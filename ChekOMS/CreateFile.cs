using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Threading.Tasks;



namespace ChekOMS
{
    public class CreateFile
    {

        public static string CreateTxt() // устаревшая функция
        {
            string line = File.ReadAllText("Temp\\Номер.txt");
            string p = line.Substring(4, 2);
            int month = Convert.ToInt32(line.Substring(2, 2), 10);
            int year =2000 + Convert.ToInt32(line.Substring(0, 2), 10);
            int n = Convert.ToInt32(p, 10);
            if (month == DateTime.Today.Month)//Convert.ToInt32(DateTime.Today.Month.ToString(), 10));
                n = n + 1;
                else if (month < DateTime.Today.Month)
                {
                    n = 1;
                }
                    else if (year < DateTime.Today.Year)
                    {
                        MessageBox.Show("C Новым Годом!!!!", DateTime.Today.Year.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        n = 1;
                    }
                    else
                        MessageBox.Show("Время системы не верное", "Неверная дата", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (n < 100)
            {
                string d = DateTime.Today.ToString("yyMM") + n.ToString("D2");
                return d;
            }
            else
            {
                MessageBox.Show("Достигнут предел отправи файлов за этот месяц", "Закройте программу", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }
            
        }

        public static int LastNomber(string tempdir)
            // Файл с максимальным номером в имени после 8го знака.
        {
            int maxNom = 0; // maximum nomber of file name in dir "Исходящие" 
            FileInfo fileInf = new FileInfo("Temp");
            DirectoryInfo dir = new DirectoryInfo(tempdir+@"\Исходящие");
            int n = 0; // служебная переменная
            foreach (var file in dir.GetFiles("*.xml"))
            {
                try
                {
                    var str = file.Name.Replace(file.Extension, "");
                    str = str.Substring(8);
                    n = Int32.Parse(str);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка конвертации", "Ошибка конвертаци. Обратитесь к разработчику", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Logger.Log.Fatal(ex);
                    return 0;
                }
                if (maxNom < n) maxNom = n;
            }

            // Определяем формат номера по дате
            int defNom; // nomber of file name  on this date 
            defNom = Int32.Parse(DateTime.Today.ToString("yMM") + "00");
            // Определить какой номер больше. 

            if (maxNom > defNom)
                return maxNom;
            else return defNom;
        }
    }
}
