using System.Configuration;
namespace ChekOMS
{
    partial class Check
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Check));
            this.comboBoxDocType = new System.Windows.Forms.ComboBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxFam = new System.Windows.Forms.TextBox();
            this.textBoxOtch = new System.Windows.Forms.TextBox();
            this.maskedTextBoxPasNom = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxOms = new System.Windows.Forms.MaskedTextBox();
            this.groupBoxEntpacient = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerBirthDate = new System.Windows.Forms.DateTimePicker();
            this.maskedTextBoxPasSer = new System.Windows.Forms.MaskedTextBox();
            this.button_add = new System.Windows.Forms.Button();
            this.dataGridViewPacient = new System.Windows.Forms.DataGridView();
            this.NN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Otch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PasSer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PasNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ENP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inshuComp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Region = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_send = new System.Windows.Forms.Button();
            this.textBoxVipNetDir = new System.Windows.Forms.TextBox();
            this.buttonVipNetDirSel = new System.Windows.Forms.Button();
            this.folderBrowserDialogVipNet = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonRezCheck = new System.Windows.Forms.Button();
            this.textBoxRezDir = new System.Windows.Forms.TextBox();
            this.buttonRezDirSel = new System.Windows.Forms.Button();
            this.textBoxSelCheckF = new System.Windows.Forms.TextBox();
            this.buttonSelCheckF = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.openFileDialogSelCheckF = new System.Windows.Forms.OpenFileDialog();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBoxEntpacient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPacient)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxDocType
            // 
            this.comboBoxDocType.Enabled = false;
            this.comboBoxDocType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxDocType.FormattingEnabled = true;
            this.comboBoxDocType.Items.AddRange(new object[] {
            "Паспорт",
            "Загран."});
            this.comboBoxDocType.Location = new System.Drawing.Point(116, 215);
            this.comboBoxDocType.Name = "comboBoxDocType";
            this.comboBoxDocType.Size = new System.Drawing.Size(121, 24);
            this.comboBoxDocType.TabIndex = 8;
            this.comboBoxDocType.Text = "Паспорт";
            this.comboBoxDocType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFam_KeyPress);
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxName.Location = new System.Drawing.Point(116, 47);
            this.textBoxName.MaxLength = 28;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(121, 22);
            this.textBoxName.TabIndex = 2;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxFam_TextChanged);
            this.textBoxName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFam_KeyPress);
            // 
            // textBoxFam
            // 
            this.textBoxFam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFam.Location = new System.Drawing.Point(116, 19);
            this.textBoxFam.MaxLength = 28;
            this.textBoxFam.Name = "textBoxFam";
            this.textBoxFam.Size = new System.Drawing.Size(121, 22);
            this.textBoxFam.TabIndex = 1;
            this.textBoxFam.Tag = "";
            this.textBoxFam.TextChanged += new System.EventHandler(this.textBoxFam_TextChanged);
            this.textBoxFam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFam_KeyPress);
            // 
            // textBoxOtch
            // 
            this.textBoxOtch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxOtch.Location = new System.Drawing.Point(116, 75);
            this.textBoxOtch.MaxLength = 28;
            this.textBoxOtch.Name = "textBoxOtch";
            this.textBoxOtch.Size = new System.Drawing.Size(121, 22);
            this.textBoxOtch.TabIndex = 3;
            this.textBoxOtch.TextChanged += new System.EventHandler(this.textBoxFam_TextChanged);
            this.textBoxOtch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFam_KeyPress);
            // 
            // maskedTextBoxPasNom
            // 
            this.maskedTextBoxPasNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBoxPasNom.HidePromptOnLeave = true;
            this.maskedTextBoxPasNom.HideSelection = false;
            this.maskedTextBoxPasNom.Location = new System.Drawing.Point(116, 159);
            this.maskedTextBoxPasNom.Mask = "000999";
            this.maskedTextBoxPasNom.Name = "maskedTextBoxPasNom";
            this.maskedTextBoxPasNom.Size = new System.Drawing.Size(121, 22);
            this.maskedTextBoxPasNom.TabIndex = 6;
            this.maskedTextBoxPasNom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFam_KeyPress);
            // 
            // maskedTextBoxOms
            // 
            this.maskedTextBoxOms.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBoxOms.HidePromptOnLeave = true;
            this.maskedTextBoxOms.Location = new System.Drawing.Point(116, 187);
            this.maskedTextBoxOms.Mask = "0000000000000000";
            this.maskedTextBoxOms.Name = "maskedTextBoxOms";
            this.maskedTextBoxOms.Size = new System.Drawing.Size(121, 22);
            this.maskedTextBoxOms.TabIndex = 7;
            this.maskedTextBoxOms.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFam_KeyPress);
            // 
            // groupBoxEntpacient
            // 
            this.groupBoxEntpacient.Controls.Add(this.label12);
            this.groupBoxEntpacient.Controls.Add(this.label8);
            this.groupBoxEntpacient.Controls.Add(this.label7);
            this.groupBoxEntpacient.Controls.Add(this.label6);
            this.groupBoxEntpacient.Controls.Add(this.label5);
            this.groupBoxEntpacient.Controls.Add(this.label4);
            this.groupBoxEntpacient.Controls.Add(this.label3);
            this.groupBoxEntpacient.Controls.Add(this.label2);
            this.groupBoxEntpacient.Controls.Add(this.label1);
            this.groupBoxEntpacient.Controls.Add(this.dateTimePickerBirthDate);
            this.groupBoxEntpacient.Controls.Add(this.maskedTextBoxPasSer);
            this.groupBoxEntpacient.Controls.Add(this.button_add);
            this.groupBoxEntpacient.Controls.Add(this.comboBoxDocType);
            this.groupBoxEntpacient.Controls.Add(this.textBoxFam);
            this.groupBoxEntpacient.Controls.Add(this.maskedTextBoxOms);
            this.groupBoxEntpacient.Controls.Add(this.textBoxName);
            this.groupBoxEntpacient.Controls.Add(this.maskedTextBoxPasNom);
            this.groupBoxEntpacient.Controls.Add(this.textBoxOtch);
            this.groupBoxEntpacient.Location = new System.Drawing.Point(12, 243);
            this.groupBoxEntpacient.Name = "groupBoxEntpacient";
            this.groupBoxEntpacient.Size = new System.Drawing.Size(387, 247);
            this.groupBoxEntpacient.TabIndex = 12;
            this.groupBoxEntpacient.TabStop = false;
            this.groupBoxEntpacient.Text = "Внесение пациента";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(6, 218);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Тип документа";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(6, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "№ полиса *";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(6, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Дата рождения";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(6, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Сер. документа";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(6, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "№ документа";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(6, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Отчество";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(6, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Имя";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Фамилия";
            // 
            // dateTimePickerBirthDate
            // 
            this.dateTimePickerBirthDate.CustomFormat = "dd.MM.yyyy";
            this.dateTimePickerBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerBirthDate.Location = new System.Drawing.Point(116, 103);
            this.dateTimePickerBirthDate.MaxDate = new System.DateTime(2899, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerBirthDate.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerBirthDate.Name = "dateTimePickerBirthDate";
            this.dateTimePickerBirthDate.Size = new System.Drawing.Size(121, 21);
            this.dateTimePickerBirthDate.TabIndex = 4;
            this.dateTimePickerBirthDate.Value = new System.DateTime(2017, 2, 7, 0, 0, 0, 0);
            this.dateTimePickerBirthDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFam_KeyPress);
            // 
            // maskedTextBoxPasSer
            // 
            this.maskedTextBoxPasSer.AllowPromptAsInput = false;
            this.maskedTextBoxPasSer.AsciiOnly = true;
            this.maskedTextBoxPasSer.CausesValidation = false;
            this.maskedTextBoxPasSer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBoxPasSer.Location = new System.Drawing.Point(116, 131);
            this.maskedTextBoxPasSer.Mask = "aa aa";
            this.maskedTextBoxPasSer.Name = "maskedTextBoxPasSer";
            this.maskedTextBoxPasSer.Size = new System.Drawing.Size(121, 22);
            this.maskedTextBoxPasSer.TabIndex = 5;
            this.maskedTextBoxPasSer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFam_KeyPress);
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(254, 192);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(121, 47);
            this.button_add.TabIndex = 9;
            this.button_add.Text = "Добавить";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // dataGridViewPacient
            // 
            this.dataGridViewPacient.AllowUserToAddRows = false;
            this.dataGridViewPacient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPacient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NN,
            this.Fam,
            this.NameP,
            this.Otch,
            this.BirthDate,
            this.PasSer,
            this.PasNom,
            this.Status,
            this.ENP,
            this.inshuComp,
            this.Region});
            this.dataGridViewPacient.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewPacient.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewPacient.Name = "dataGridViewPacient";
            this.dataGridViewPacient.Size = new System.Drawing.Size(1115, 232);
            this.dataGridViewPacient.TabIndex = 16;
            // 
            // NN
            // 
            this.NN.DataPropertyName = "№№";
            this.NN.Frozen = true;
            this.NN.HeaderText = "№№";
            this.NN.Name = "NN";
            this.NN.ReadOnly = true;
            this.NN.Width = 60;
            // 
            // Fam
            // 
            this.Fam.DataPropertyName = "Фамилия";
            this.Fam.HeaderText = "Фамилия";
            this.Fam.MaxInputLength = 28;
            this.Fam.Name = "Fam";
            // 
            // NameP
            // 
            this.NameP.DataPropertyName = "Имя";
            this.NameP.HeaderText = "Имя";
            this.NameP.MaxInputLength = 28;
            this.NameP.Name = "NameP";
            // 
            // Otch
            // 
            this.Otch.DataPropertyName = "Отчество";
            this.Otch.HeaderText = "Отчество";
            this.Otch.MaxInputLength = 28;
            this.Otch.Name = "Otch";
            // 
            // BirthDate
            // 
            this.BirthDate.DataPropertyName = "ДатаРождения";
            dataGridViewCellStyle6.Format = "d";
            dataGridViewCellStyle6.NullValue = null;
            this.BirthDate.DefaultCellStyle = dataGridViewCellStyle6;
            this.BirthDate.HeaderText = "Дата рождения";
            this.BirthDate.MaxInputLength = 28;
            this.BirthDate.Name = "BirthDate";
            this.BirthDate.ReadOnly = true;
            // 
            // PasSer
            // 
            this.PasSer.DataPropertyName = "СерПаспорта";
            this.PasSer.HeaderText = "Серия паспорта";
            this.PasSer.MaxInputLength = 6;
            this.PasSer.Name = "PasSer";
            // 
            // PasNom
            // 
            this.PasNom.DataPropertyName = "НомПаспорта";
            this.PasNom.HeaderText = "Номер паспорта";
            this.PasNom.MaxInputLength = 8;
            this.PasNom.Name = "PasNom";
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Статус";
            this.Status.HeaderText = "Статус";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 60;
            // 
            // ENP
            // 
            this.ENP.DataPropertyName = "ЕНП";
            this.ENP.HeaderText = "ЕНП";
            this.ENP.MaxInputLength = 16;
            this.ENP.Name = "ENP";
            this.ENP.Width = 150;
            // 
            // inshuComp
            // 
            this.inshuComp.HeaderText = "Страховая комп.";
            this.inshuComp.MaxInputLength = 10;
            this.inshuComp.Name = "inshuComp";
            this.inshuComp.ReadOnly = true;
            // 
            // Region
            // 
            this.Region.HeaderText = "Регион страх.";
            this.Region.MaxInputLength = 15;
            this.Region.Name = "Region";
            this.Region.ReadOnly = true;
            // 
            // button_send
            // 
            this.button_send.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.button_send.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_send.Location = new System.Drawing.Point(972, 368);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(106, 47);
            this.button_send.TabIndex = 8;
            this.button_send.Text = "Отправить";
            this.button_send.UseVisualStyleBackColor = true;
            this.button_send.Click += new System.EventHandler(this.button_send_Click);
            // 
            // textBoxVipNetDir
            // 
            this.textBoxVipNetDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxVipNetDir.Location = new System.Drawing.Point(6, 44);
            this.textBoxVipNetDir.Name = "textBoxVipNetDir";
            this.textBoxVipNetDir.ReadOnly = true;
            this.textBoxVipNetDir.ShortcutsEnabled = false;
            this.textBoxVipNetDir.Size = new System.Drawing.Size(456, 20);
            this.textBoxVipNetDir.TabIndex = 17;
            this.textBoxVipNetDir.TabStop = false;
            this.textBoxVipNetDir.Text = "\\\\192.168.1.235\\exchange\\!VIPNET\\Автопроцессинг\\Запрос на страховую принадлежност" +
    "ь";
            // 
            // buttonVipNetDirSel
            // 
            this.buttonVipNetDirSel.Location = new System.Drawing.Point(468, 44);
            this.buttonVipNetDirSel.Name = "buttonVipNetDirSel";
            this.buttonVipNetDirSel.Size = new System.Drawing.Size(74, 22);
            this.buttonVipNetDirSel.TabIndex = 18;
            this.buttonVipNetDirSel.Text = "Обзор";
            this.buttonVipNetDirSel.UseVisualStyleBackColor = true;
            this.buttonVipNetDirSel.Click += new System.EventHandler(this.buttonOppen_Click);
            // 
            // buttonRezCheck
            // 
            this.buttonRezCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRezCheck.Location = new System.Drawing.Point(972, 427);
            this.buttonRezCheck.Name = "buttonRezCheck";
            this.buttonRezCheck.Size = new System.Drawing.Size(106, 46);
            this.buttonRezCheck.TabIndex = 19;
            this.buttonRezCheck.Text = "Проверить";
            this.buttonRezCheck.UseVisualStyleBackColor = true;
            this.buttonRezCheck.Click += new System.EventHandler(this.buttonRezCheck_Click);
            // 
            // textBoxRezDir
            // 
            this.textBoxRezDir.Location = new System.Drawing.Point(6, 90);
            this.textBoxRezDir.Name = "textBoxRezDir";
            this.textBoxRezDir.ReadOnly = true;
            this.textBoxRezDir.Size = new System.Drawing.Size(455, 20);
            this.textBoxRezDir.TabIndex = 20;
            this.textBoxRezDir.Text = "\\\\192.168.1.235\\exchange\\!VIPNET\\Автопроцессинг\\Запрос на страховую принадлежност" +
    "ь\\Входящие";
            // 
            // buttonRezDirSel
            // 
            this.buttonRezDirSel.Location = new System.Drawing.Point(468, 88);
            this.buttonRezDirSel.Name = "buttonRezDirSel";
            this.buttonRezDirSel.Size = new System.Drawing.Size(75, 23);
            this.buttonRezDirSel.TabIndex = 21;
            this.buttonRezDirSel.Text = "Обзор";
            this.buttonRezDirSel.UseVisualStyleBackColor = true;
            this.buttonRezDirSel.Click += new System.EventHandler(this.buttonRezDirSel_Click);
            // 
            // textBoxSelCheckF
            // 
            this.textBoxSelCheckF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBoxSelCheckF.Location = new System.Drawing.Point(424, 275);
            this.textBoxSelCheckF.Name = "textBoxSelCheckF";
            this.textBoxSelCheckF.ReadOnly = true;
            this.textBoxSelCheckF.Size = new System.Drawing.Size(455, 20);
            this.textBoxSelCheckF.TabIndex = 22;
            // 
            // buttonSelCheckF
            // 
            this.buttonSelCheckF.Location = new System.Drawing.Point(885, 275);
            this.buttonSelCheckF.Name = "buttonSelCheckF";
            this.buttonSelCheckF.Size = new System.Drawing.Size(75, 23);
            this.buttonSelCheckF.TabIndex = 23;
            this.buttonSelCheckF.Text = "Обзор";
            this.buttonSelCheckF.UseVisualStyleBackColor = true;
            this.buttonSelCheckF.Click += new System.EventHandler(this.buttonSelCheckF_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textBoxVipNetDir);
            this.groupBox1.Controls.Add(this.buttonVipNetDirSel);
            this.groupBox1.Controls.Add(this.textBoxRezDir);
            this.groupBox1.Controls.Add(this.buttonRezDirSel);
            this.groupBox1.Location = new System.Drawing.Point(418, 351);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(548, 139);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Пути к папкам";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Входящие";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Исходящие";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(418, 259);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Файл запроса";
            // 
            // openFileDialogSelCheckF
            // 
            this.openFileDialogSelCheckF.Filter = "XML (*.xml)|*.xml|ZipFile (*.zip)|*.zip";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(254, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 42);
            this.label12.TabIndex = 18;
            this.label12.Text = "* - Вариант если \r\nне указанны \r\nданные паспорта";
            this.label12.UseCompatibleTextRendering = true;
            // 
            // Check
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 502);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonSelCheckF);
            this.Controls.Add(this.buttonRezCheck);
            this.Controls.Add(this.button_send);
            this.Controls.Add(this.dataGridViewPacient);
            this.Controls.Add(this.groupBoxEntpacient);
            this.Controls.Add(this.textBoxSelCheckF);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Check";
            this.Text = "Проверка страховой принадлежности";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Check_FormClosing);
            this.groupBoxEntpacient.ResumeLayout(false);
            this.groupBoxEntpacient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPacient)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxFam;
        private System.Windows.Forms.TextBox textBoxOtch;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPasNom;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxOms;
        private System.Windows.Forms.GroupBox groupBoxEntpacient;
        private System.Windows.Forms.DataGridView dataGridViewPacient;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPasSer;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirthDate;
        private System.Windows.Forms.Button button_send;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxVipNetDir;
        private System.Windows.Forms.Button buttonVipNetDirSel;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogVipNet;
        private System.Windows.Forms.Button buttonRezCheck;
        private System.Windows.Forms.TextBox textBoxRezDir;
        private System.Windows.Forms.Button buttonRezDirSel;
        private System.Windows.Forms.TextBox textBoxSelCheckF;
        private System.Windows.Forms.Button buttonSelCheckF;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn NN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fam;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Otch;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirthDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PasSer;
        private System.Windows.Forms.DataGridViewTextBoxColumn PasNom;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn ENP;
        private System.Windows.Forms.DataGridViewTextBoxColumn inshuComp;
#pragma warning disable CS0108 // 'Check.Region' hides inherited member 'Control.Region'. Use the new keyword if hiding was intended.
        private System.Windows.Forms.DataGridViewTextBoxColumn Region;
        private System.Windows.Forms.ComboBox comboBoxDocType;
        private System.Windows.Forms.Label label12;
#pragma warning restore CS0108 // 'Check.Region' hides inherited member 'Control.Region'. Use the new keyword if hiding was intended.
        private System.Windows.Forms.OpenFileDialog openFileDialogSelCheckF;
    }
}

