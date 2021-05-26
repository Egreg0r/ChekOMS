using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;
using System.Xml.Serialization;
using System.Globalization;
using System.Xml;
using Ionic.Zip;
using System.Configuration;

namespace ChekOMS
{
    //подключение app.config
    public partial class Check : Form
    {
        string k; // переменная хранит значение из файла Номер.txt
        string Fname; // переменная хранит Имя файла
        string TempDir = Application.StartupPath + "\\Temp";  // Полный путь к папке Temp
        public string inFolder, outFolder;
        public Check()
        {
            InitializeComponent();
            Logger.Log.Info("Начало работы.");
            appSetOut();
            appSetIn();

        }
        #region void
        //Добавление записей в xml класса "List<ZP>"  
        //in: xml - имя List<ZP>, in: crow - кол-во добавляемых записей 
        //out: заполненный List<ZP>
        private void addStrtoZpList(List<ZP> xml, int crow)
        {
            for (int i = 0; i < crow; i++)
            {
                // Если серия паспорта не заполнена удаляем пробелы создаваемые маской формы. 
                string ser = dataGridViewPacient[5, i].Value.ToString();
                if (ser.Contains("  ")) ser = "";

                xml.Add(new ZP
                {
                    N_REC = dataGridViewPacient[0, i].Value.ToString(),
                    PERSON = new PERSON
                    {
                        ENP = "",//dataGridViewPacient[8, i].Value.ToString(),
                        FAM = dataGridViewPacient[1, i].Value.ToString(),
                        IM = dataGridViewPacient[2, i].Value.ToString(),
                        OT = dataGridViewPacient[3, i].Value.ToString(),
                        DR = DateTime.Parse(dataGridViewPacient[4, i].Value.ToString()),
                        W = 2,
                        SS = ""
                    },
                    DOC = new DOC
                    {
                        DOCTYPE = (dataGridViewPacient[6, i].Value.ToString().Length == 6) ? "14" : "X",
                        //DOCTYPE = (comboBoxDocType.SelectedIndex == 1) ? "14": "",
                        MR = "", // место рождения
                        DOCSER = ser,
                        DOCNUM = dataGridViewPacient[6, i].Value.ToString()
                    },
                    POLIS = new POLIS
                    {
                        TPOL = 3,
                        SPOL = "",
                        NPOL = dataGridViewPacient[8, i].Value.ToString()
                    }
                });
            }
        }

        private void appSetIn() // Подтягиваем папку исходящих запросов из AppConfig
        {
            AppSettingsReader reader = new AppSettingsReader();
            inFolder = reader.GetValue("inFolder", typeof(string)).ToString();
            this.textBoxVipNetDir.Text = inFolder;
        }
        private void appSetOut() // Подтягиваем папку полученных ответов  из AppConfig

        {
            AppSettingsReader reader = new AppSettingsReader();
            outFolder = reader.GetValue("outFolder", typeof(string)).ToString();
            this.textBoxRezDir.Text = outFolder;
        }

        // Распаковка и сверка файла ответа RZPM с данными в datagrid
        private void checkResponse(string name)
        {
            using (var RZPMZip = Ionic.Zip.ZipFile.Read((name + ".zip")))
            {
                RZPMZip.ExtractAll(textBoxRezDir.Text, ExtractExistingFileAction.OverwriteSilently); // распаковка архива
                var RXml = XDocument.Load(name + (".xml"));            // загружаем файл HM
                IEnumerable<XElement> Rzp = RXml.Root.Descendants("RZP").ToList();
                foreach (XElement x in Rzp) // обработка каждого x элеманта
                {
                    for (int i = 0; i < dataGridViewPacient.Rows.Count; i++)
                    {
                        if (dataGridViewPacient[0, i].Value.ToString() == x.Attribute("N_REC").Value.ToString())
                        {
                            if (x.Element("INSUR").Attribute("TPOL").Value != "")
                            {
                                dataGridViewPacient["Status", i].Value = true;
                                dataGridViewPacient[8, i].Value = x.Element("INSUR").Attribute("ENP").Value;
                                dataGridViewPacient[9, i].Value = x.Element("INSUR").Attribute("Q").Value;
                                dataGridViewPacient[10, i].Value = x.Element("INSUR").Attribute("OKATO").Value;
                                dataGridViewPacient["Status", i].Style.BackColor = Color.LimeGreen;
                            }
                            else
                            {
                                dataGridViewPacient["inshuComp", i].Value = "Не застрахован";
                                dataGridViewPacient.Rows[i].DefaultCellStyle.BackColor = Color.Tomato;
                                dataGridViewPacient["Status", i].Value = true;
                            }
                        }
                    }
                }
                Logger.Log.InfoFormat("Файл {0} успешно распакован.", name);
                File.Delete(name + (".xml"));
            }
        }
        #endregion
        //Добавление строк в таблицу
        private void button_add_Click(object sender, EventArgs e)
        {

            int i = 0;

            dataGridViewPacient.Rows.Add();
            i = dataGridViewPacient.Rows.Count - 1;
            dataGridViewPacient[0, i].Value = i + 1;
            dataGridViewPacient[1, i].Value = textBoxFam.Text;
            dataGridViewPacient[2, i].Value = textBoxName.Text;
            dataGridViewPacient[3, i].Value = textBoxOtch.Text;
            dataGridViewPacient[4, i].Value = dateTimePickerBirthDate.Value;
            dataGridViewPacient[5, i].Value = maskedTextBoxPasSer.Text;
            dataGridViewPacient[6, i].Value = maskedTextBoxPasNom.Text;
            dataGridViewPacient[8, i].Value = maskedTextBoxOms.Text;

            textBoxFam.ResetText(); textBoxName.ResetText(); textBoxOtch.ResetText(); maskedTextBoxOms.ResetText(); maskedTextBoxPasNom.ResetText(); maskedTextBoxPasSer.ResetText(); dateTimePickerBirthDate.ResetText();
            textBoxFam.Focus();
            Console.WriteLine(DateTime.Parse(dataGridViewPacient[4, i].Value.ToString()));
        }

        private void textBoxFam_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Enter дублирует кнопку TAB
            if (e.KeyChar == (char)Keys.Enter)// Keys.return
            {
                e.Handled = true;
                System.Windows.Forms.SendKeys.Send("{TAB}");
            }
            else base.OnKeyPress(e);
        }

        //Cоздания файла передачи реестров
        private void button_send_Click(object sender, EventArgs e)

        // Проверка на пустые поля
        {
            if (dataGridViewPacient.RowCount == 0)
            {
                MessageBox.Show("Внесите данные", "Пусто", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (textBoxVipNetDir.Text == "")
            {
                MessageBox.Show("Укажите папку исходящих файлов", "XML", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                buttonVipNetDirSel.PerformClick();
            }

            int n = CreateFile.LastNomber(TempDir);
            if (n % 100 >= 99)
            {
                MessageBox.Show("Достигнут предел поверки файлов в текущем месяце", "Проблема", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                Logger.Log.Warn("Достигнут предел номера в текущем месяце");
                return;
            }
            else n= n + 1;
            k = n.ToString();
            Fname = "ZPM25200" + k;

            //Создаем файл XML с данными из datagrid
            try
            {
                var listZp = new List<ZP>();
                int colRow = dataGridViewPacient.Rows.Count;
                addStrtoZpList(listZp, colRow);
                    Console.WriteLine("i= " + colRow);
                Logger.Log.Info("Добавленно " + colRow + "строк");
                
                // создаем 
                var Pacient = new ZPLIST()
                {
                    FILENAME = Fname,
                    OTPR = "LPU",
                    DZP = DateTime.Today,
                    NRECORDS = dataGridViewPacient.Rows.Count,
                    OTPRCOD = 25200,
                    ZP = listZp.ToArray()
                };
                //создаем файл xml и записываем данные через поток
                var pathfile = Path.ChangeExtension(TempDir + "\\Исходящие\\" + Fname, "xml"); // full file name
                using (var fs = new StreamWriter(new FileStream(pathfile, FileMode.Create), Encoding.GetEncoding("Windows-1251")))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(ZPLIST));
                    serializer.Serialize(fs, Pacient);
                    fs.Close();
                }
                Logger.Log.InfoFormat("Файл {0} успешно создан.", pathfile.ToString());
                File.WriteAllText(TempDir + "\\Номер.txt", k);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Ошибка при создании XML", "XML", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logger.Log.ErrorFormat("При создании {0}.xml возникла ошибка {1}", Fname, ex);
                return;
            }

            //архивация .xml
            try
            {
                using (var ZpmZip = new Ionic.Zip.ZipFile())
                {
                    ZpmZip.AddFile(Path.ChangeExtension(TempDir + "\\Исходящие\\" + Fname, "xml"), "");
                    if (textBoxVipNetDir.Text == "")
                    {
                        buttonVipNetDirSel.PerformClick();
                    }
                    Console.WriteLine(textBoxVipNetDir.Text + "\\" + Fname);
                    ZpmZip.Save(Path.ChangeExtension((textBoxVipNetDir.Text + "\\" + Fname), "zip"));
                    string str = string.Format("Архив {0} успешно создан", ZpmZip);
                    MessageBox.Show(str, "Zip", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    //File.Delete(Path.ChangeExtension("Temp\\" + Fname, "xml"));
                    Logger.Log.Info(str);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при создании архива .zip", "Ошибка ZIP", MessageBoxButtons.OK, MessageBoxIcon.Error); Console.WriteLine(ex.Message);
                Logger.Log.ErrorFormat("Не удалось создать ZIP. {0}", ex);
                return;
            }


        }

        private void buttonOppen_Click(object sender, EventArgs e) //Папка для отправки запроса
        {
            if (folderBrowserDialogVipNet.ShowDialog() == DialogResult.OK)
            {
                textBoxVipNetDir.Text = folderBrowserDialogVipNet.SelectedPath;

                //Прописываем указанный путь в файле конфига
                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.AppSettings.Settings["inFolder"].Value = folderBrowserDialogVipNet.SelectedPath;
                config.Save();
                ConfigurationManager.RefreshSection("appSettings");
            }
        }

        private void buttonRezCheck_Click(object sender, EventArgs e)  // проверка полученных данных.
        {
            int n = 0; // флаг определитель пришел ли ответ по файлам.
            if (textBoxRezDir.Text == "")
            {
                MessageBox.Show("Укажите папку для полученных ответов", "XML_Rezul", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                buttonVipNetDirSel.PerformClick();
            }
            //Проверка входящих файлов
            string RFname = textBoxRezDir.Text + "\\R" + Fname + "_r";
            if (File.Exists(RFname + ".zip"))
            {
                checkResponse(RFname);
                n = 1;
            }

            RFname = textBoxRezDir.Text + "\\R" + Fname + "_c";
            if (File.Exists(RFname + ".zip"))
            {
                checkResponse(RFname);
                n = 1;
            }
            if (n == 0) MessageBox.Show("Ответ на файл: " + Fname + " Еще не получен", "Ответ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonRezDirSel_Click(object sender, EventArgs e) // путь к папке рузультатов запроса
        {
            if (folderBrowserDialogVipNet.ShowDialog() == DialogResult.OK)
            {
                textBoxRezDir.Text = folderBrowserDialogVipNet.SelectedPath;

                //Прописываем указанный путь в файле конфига
                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.AppSettings.Settings["outFolder"].Value = textBoxRezDir.Text;
                config.Save();
                ConfigurationManager.RefreshSection("appSettings");
            }
        }

        private void textBoxFam_TextChanged(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text.Length == 1)
                ((TextBox)sender).Text = ((TextBox)sender).Text.ToUpper();
            ((TextBox)sender).Select(((TextBox)sender).Text.Length, 0);
        }

        private void Check_FormClosing(object sender, FormClosingEventArgs e)
        {
            Logger.Log.Info("Завершение работы приложения");
        }

        private void buttonSelCheckF_Click(object sender, EventArgs e) // Путь к исходящему файлу xml
        {
            /*
            if (textBoxRezDir.Text == "")
            {
                MessageBox.Show("Укажите дирректории файлов ответов", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            */
            if (openFileDialogSelCheckF.ShowDialog() == DialogResult.OK)
            {
                textBoxSelCheckF.Text = openFileDialogSelCheckF.FileName;
                dataGridViewPacient.Rows.Clear();

                //загрузка исходящих данных в датагрид из созданного файла

                string pathToFile = Path.GetFileNameWithoutExtension(textBoxSelCheckF.Text); // Имя открываемого исходящего файла ( вырезать имя запрашиваемого файла из строки.)
                Fname = pathToFile;
                int f = 0;
                try
                {
                    using (var ZPMZip = Ionic.Zip.ZipFile.Read((textBoxSelCheckF.Text)))
                    {
                        ZPMZip.ExtractAll(TempDir + "\\Исходящие", Ionic.Zip.ExtractExistingFileAction.OverwriteSilently);
                    }
                    f = 1;
                }
                catch { }
                try
                {
                    switch (f)
                    {
                        case 1:
                    using (var fs = new FileStream(TempDir + "\\Исходящие\\" + Path.ChangeExtension(pathToFile, "xml"), FileMode.Open))
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(ZPLIST));
                        ZPLIST Zplist = (ZPLIST)serializer.Deserialize(fs);
                        fs.Close();

                        var listZp = new List<ZP>();
                        listZp = Zplist.ZP.ToList();
                        foreach (var x in listZp)
                        {
                            dataGridViewPacient.Rows.Add(x.N_REC, x.PERSON.FAM, x.PERSON.IM, x.PERSON.OT, x.PERSON.DR, x.DOC.DOCSER, x.DOC.DOCNUM, false, x.POLIS.NPOL, "", "");
                        }
                        //textBoxSelCheckF.Clear();
                    }
                            break;
                        case 0:
                            using (var fs = new FileStream(textBoxSelCheckF.Text, FileMode.Open))
                            {
                                XmlSerializer serializer = new XmlSerializer(typeof(ZPLIST));
                                ZPLIST Zplist = (ZPLIST)serializer.Deserialize(fs);
                                fs.Close();

                                var listZp = new List<ZP>();
                                listZp = Zplist.ZP.ToList();
                                foreach (var x in listZp)
                                {
                                    dataGridViewPacient.Rows.Add(x.N_REC, x.PERSON.FAM, x.PERSON.IM, x.PERSON.OT, x.PERSON.DR, x.DOC.DOCSER, x.DOC.DOCNUM, false, x.POLIS.NPOL, "", "");
                                }
                               // textBoxSelCheckF.Clear();
                            }
                            break;
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Не удалось загрузить файл", "Ошибка загрузки", MessageBoxButtons.OK, MessageBoxIcon.Error); Console.WriteLine(ex.Message);
                    Logger.Log.ErrorFormat("Ошибка загрузки файла запроса. {0}", ex);
                }


            }
        }
    }
}

