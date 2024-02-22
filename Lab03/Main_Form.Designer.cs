namespace Lab03
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox_Discipline = new System.Windows.Forms.TextBox();
            this.label_Discipline = new System.Windows.Forms.Label();
            this.label_Course = new System.Windows.Forms.Label();
            this.label_Term = new System.Windows.Forms.Label();
            this.label_Specialize = new System.Windows.Forms.Label();
            this.radioButton_Exam = new System.Windows.Forms.RadioButton();
            this.radioButton_Zachet = new System.Windows.Forms.RadioButton();
            this.label_ControlType = new System.Windows.Forms.Label();
            this.groupBox_ControlType = new System.Windows.Forms.GroupBox();
            this.groupBox_LectorInfo = new System.Windows.Forms.GroupBox();
            this.label_Phone = new System.Windows.Forms.Label();
            this.textBox_LectorPhone = new System.Windows.Forms.MaskedTextBox();
            this.comboBox_Kafedra = new System.Windows.Forms.ComboBox();
            this.label_LectorKafedra = new System.Windows.Forms.Label();
            this.textBox_LectorKabinet = new System.Windows.Forms.TextBox();
            this.label_LectorKabinet = new System.Windows.Forms.Label();
            this.textBox_LectorThirdname = new System.Windows.Forms.TextBox();
            this.textBox_LectorName = new System.Windows.Forms.TextBox();
            this.textBox_LectorSurname = new System.Windows.Forms.TextBox();
            this.label_LectorThirdname = new System.Windows.Forms.Label();
            this.label_LectorName = new System.Windows.Forms.Label();
            this.label_LectorSurname = new System.Windows.Forms.Label();
            this.button_SaveToJSON = new System.Windows.Forms.Button();
            this.button_LoadFromJSON = new System.Windows.Forms.Button();
            this.listBox_ShowList = new System.Windows.Forms.ListBox();
            this.errorProvider_Discipline = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_LectorSurname = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_LectorName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_LectorThirdname = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_LectorKabinet = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_LectorPhone = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_Specialize = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_LectorKafedra = new System.Windows.Forms.ErrorProvider(this.components);
            this.checkedListBox_Spec = new System.Windows.Forms.CheckedListBox();
            this.numericUpDown_Course = new System.Windows.Forms.NumericUpDown();
            this.groupBox_Terms = new System.Windows.Forms.GroupBox();
            this.checkBox_Term2 = new System.Windows.Forms.CheckBox();
            this.checkBox_Term1 = new System.Windows.Forms.CheckBox();
            this.trackBar_HourCounty = new System.Windows.Forms.TrackBar();
            this.label_HoursCounty = new System.Windows.Forms.Label();
            this.errorProvider_Term = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Search_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Sort_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_SortOnControlType = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_SortOnHoursCounty = new System.Windows.Forms.ToolStripMenuItem();
            this.Save_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutProgram_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.groupBox_ControlType.SuspendLayout();
            this.groupBox_LectorInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Discipline)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_LectorSurname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_LectorName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_LectorThirdname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_LectorKabinet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_LectorPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Specialize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_LectorKafedra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Course)).BeginInit();
            this.groupBox_Terms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_HourCounty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Term)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_Discipline
            // 
            this.textBox_Discipline.Location = new System.Drawing.Point(140, 80);
            this.textBox_Discipline.MaxLength = 30;
            this.textBox_Discipline.Name = "textBox_Discipline";
            this.textBox_Discipline.Size = new System.Drawing.Size(141, 20);
            this.textBox_Discipline.TabIndex = 0;
            this.textBox_Discipline.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Discipline_KeyPress);
            this.textBox_Discipline.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_Discipline_Validating);
            // 
            // label_Discipline
            // 
            this.label_Discipline.AutoSize = true;
            this.label_Discipline.Location = new System.Drawing.Point(9, 83);
            this.label_Discipline.Name = "label_Discipline";
            this.label_Discipline.Size = new System.Drawing.Size(125, 13);
            this.label_Discipline.TabIndex = 1;
            this.label_Discipline.Text = "Название дисциплины:";
            // 
            // label_Course
            // 
            this.label_Course.AutoSize = true;
            this.label_Course.Location = new System.Drawing.Point(9, 113);
            this.label_Course.Name = "label_Course";
            this.label_Course.Size = new System.Drawing.Size(34, 13);
            this.label_Course.TabIndex = 2;
            this.label_Course.Text = "Курс:";
            // 
            // label_Term
            // 
            this.label_Term.AutoSize = true;
            this.label_Term.Location = new System.Drawing.Point(9, 147);
            this.label_Term.Name = "label_Term";
            this.label_Term.Size = new System.Drawing.Size(54, 13);
            this.label_Term.TabIndex = 10;
            this.label_Term.Text = "Семестр:";
            // 
            // label_Specialize
            // 
            this.label_Specialize.AutoSize = true;
            this.label_Specialize.Location = new System.Drawing.Point(9, 230);
            this.label_Specialize.Name = "label_Specialize";
            this.label_Specialize.Size = new System.Drawing.Size(88, 13);
            this.label_Specialize.TabIndex = 11;
            this.label_Specialize.Text = "Специальность:";
            // 
            // radioButton_Exam
            // 
            this.radioButton_Exam.AutoSize = true;
            this.radioButton_Exam.Checked = true;
            this.radioButton_Exam.Location = new System.Drawing.Point(11, 14);
            this.radioButton_Exam.Name = "radioButton_Exam";
            this.radioButton_Exam.Size = new System.Drawing.Size(70, 17);
            this.radioButton_Exam.TabIndex = 13;
            this.radioButton_Exam.TabStop = true;
            this.radioButton_Exam.Text = "Экзамен";
            this.radioButton_Exam.UseVisualStyleBackColor = true;
            // 
            // radioButton_Zachet
            // 
            this.radioButton_Zachet.AutoSize = true;
            this.radioButton_Zachet.Location = new System.Drawing.Point(87, 14);
            this.radioButton_Zachet.Name = "radioButton_Zachet";
            this.radioButton_Zachet.Size = new System.Drawing.Size(54, 17);
            this.radioButton_Zachet.TabIndex = 14;
            this.radioButton_Zachet.Text = "Зачет";
            this.radioButton_Zachet.UseVisualStyleBackColor = true;
            // 
            // label_ControlType
            // 
            this.label_ControlType.AutoSize = true;
            this.label_ControlType.Location = new System.Drawing.Point(9, 186);
            this.label_ControlType.Name = "label_ControlType";
            this.label_ControlType.Size = new System.Drawing.Size(79, 13);
            this.label_ControlType.TabIndex = 15;
            this.label_ControlType.Text = "Вид контроля:";
            // 
            // groupBox_ControlType
            // 
            this.groupBox_ControlType.Controls.Add(this.radioButton_Exam);
            this.groupBox_ControlType.Controls.Add(this.radioButton_Zachet);
            this.groupBox_ControlType.Location = new System.Drawing.Point(140, 170);
            this.groupBox_ControlType.Name = "groupBox_ControlType";
            this.groupBox_ControlType.Size = new System.Drawing.Size(143, 38);
            this.groupBox_ControlType.TabIndex = 17;
            this.groupBox_ControlType.TabStop = false;
            this.groupBox_ControlType.UseCompatibleTextRendering = true;
            // 
            // groupBox_LectorInfo
            // 
            this.groupBox_LectorInfo.Controls.Add(this.label_Phone);
            this.groupBox_LectorInfo.Controls.Add(this.textBox_LectorPhone);
            this.groupBox_LectorInfo.Controls.Add(this.comboBox_Kafedra);
            this.groupBox_LectorInfo.Controls.Add(this.label_LectorKafedra);
            this.groupBox_LectorInfo.Controls.Add(this.textBox_LectorKabinet);
            this.groupBox_LectorInfo.Controls.Add(this.label_LectorKabinet);
            this.groupBox_LectorInfo.Controls.Add(this.textBox_LectorThirdname);
            this.groupBox_LectorInfo.Controls.Add(this.textBox_LectorName);
            this.groupBox_LectorInfo.Controls.Add(this.textBox_LectorSurname);
            this.groupBox_LectorInfo.Controls.Add(this.label_LectorThirdname);
            this.groupBox_LectorInfo.Controls.Add(this.label_LectorName);
            this.groupBox_LectorInfo.Controls.Add(this.label_LectorSurname);
            this.groupBox_LectorInfo.Location = new System.Drawing.Point(438, 113);
            this.groupBox_LectorInfo.Name = "groupBox_LectorInfo";
            this.groupBox_LectorInfo.Size = new System.Drawing.Size(300, 194);
            this.groupBox_LectorInfo.TabIndex = 18;
            this.groupBox_LectorInfo.TabStop = false;
            this.groupBox_LectorInfo.Text = "Информация о лекторе";
            // 
            // label_Phone
            // 
            this.label_Phone.AutoSize = true;
            this.label_Phone.Location = new System.Drawing.Point(17, 153);
            this.label_Phone.Name = "label_Phone";
            this.label_Phone.Size = new System.Drawing.Size(55, 13);
            this.label_Phone.TabIndex = 20;
            this.label_Phone.Text = "Телефон:";
            // 
            // textBox_LectorPhone
            // 
            this.textBox_LectorPhone.Location = new System.Drawing.Point(128, 153);
            this.textBox_LectorPhone.Mask = "+999(99)-99-99-999";
            this.textBox_LectorPhone.Name = "textBox_LectorPhone";
            this.textBox_LectorPhone.Size = new System.Drawing.Size(137, 20);
            this.textBox_LectorPhone.TabIndex = 21;
            this.textBox_LectorPhone.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_LectorPhone_Validating);
            // 
            // comboBox_Kafedra
            // 
            this.comboBox_Kafedra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Kafedra.FormattingEnabled = true;
            this.comboBox_Kafedra.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBox_Kafedra.Items.AddRange(new object[] {
            "Кафедра информ. и дизайна",
            "Кафедра ПИ",
            "Кафедра ИСИТ",
            "Кафедра высшей математики",
            "Кафедра физ. культуры"});
            this.comboBox_Kafedra.Location = new System.Drawing.Point(128, 123);
            this.comboBox_Kafedra.Name = "comboBox_Kafedra";
            this.comboBox_Kafedra.Size = new System.Drawing.Size(137, 21);
            this.comboBox_Kafedra.TabIndex = 19;
            this.comboBox_Kafedra.Validating += new System.ComponentModel.CancelEventHandler(this.comboBox_Kafedra_Validating);
            // 
            // label_LectorKafedra
            // 
            this.label_LectorKafedra.AutoSize = true;
            this.label_LectorKafedra.Location = new System.Drawing.Point(17, 126);
            this.label_LectorKafedra.Name = "label_LectorKafedra";
            this.label_LectorKafedra.Size = new System.Drawing.Size(55, 13);
            this.label_LectorKafedra.TabIndex = 8;
            this.label_LectorKafedra.Text = "Кафедра:";
            // 
            // textBox_LectorKabinet
            // 
            this.textBox_LectorKabinet.Location = new System.Drawing.Point(128, 97);
            this.textBox_LectorKabinet.MaxLength = 3;
            this.textBox_LectorKabinet.Name = "textBox_LectorKabinet";
            this.textBox_LectorKabinet.Size = new System.Drawing.Size(137, 20);
            this.textBox_LectorKabinet.TabIndex = 7;
            this.textBox_LectorKabinet.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_LectorKabinet_Validating);
            // 
            // label_LectorKabinet
            // 
            this.label_LectorKabinet.AutoSize = true;
            this.label_LectorKabinet.Location = new System.Drawing.Point(17, 100);
            this.label_LectorKabinet.Name = "label_LectorKabinet";
            this.label_LectorKabinet.Size = new System.Drawing.Size(52, 13);
            this.label_LectorKabinet.TabIndex = 6;
            this.label_LectorKabinet.Text = "Кабинет:";
            // 
            // textBox_LectorThirdname
            // 
            this.textBox_LectorThirdname.Location = new System.Drawing.Point(128, 71);
            this.textBox_LectorThirdname.MaxLength = 15;
            this.textBox_LectorThirdname.Name = "textBox_LectorThirdname";
            this.textBox_LectorThirdname.Size = new System.Drawing.Size(137, 20);
            this.textBox_LectorThirdname.TabIndex = 5;
            this.textBox_LectorThirdname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckRussianText_KeyPress);
            this.textBox_LectorThirdname.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_LectorThirdname_Validating);
            // 
            // textBox_LectorName
            // 
            this.textBox_LectorName.Location = new System.Drawing.Point(128, 45);
            this.textBox_LectorName.MaxLength = 10;
            this.textBox_LectorName.Name = "textBox_LectorName";
            this.textBox_LectorName.Size = new System.Drawing.Size(137, 20);
            this.textBox_LectorName.TabIndex = 4;
            this.textBox_LectorName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckRussianText_KeyPress);
            this.textBox_LectorName.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_LectorName_Validating);
            // 
            // textBox_LectorSurname
            // 
            this.textBox_LectorSurname.Location = new System.Drawing.Point(128, 19);
            this.textBox_LectorSurname.MaxLength = 10;
            this.textBox_LectorSurname.Name = "textBox_LectorSurname";
            this.textBox_LectorSurname.Size = new System.Drawing.Size(137, 20);
            this.textBox_LectorSurname.TabIndex = 3;
            this.textBox_LectorSurname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckRussianText_KeyPress);
            this.textBox_LectorSurname.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_LectorSurname_Validating);
            // 
            // label_LectorThirdname
            // 
            this.label_LectorThirdname.AutoSize = true;
            this.label_LectorThirdname.Location = new System.Drawing.Point(17, 74);
            this.label_LectorThirdname.Name = "label_LectorThirdname";
            this.label_LectorThirdname.Size = new System.Drawing.Size(57, 13);
            this.label_LectorThirdname.TabIndex = 2;
            this.label_LectorThirdname.Text = "Отчество:";
            // 
            // label_LectorName
            // 
            this.label_LectorName.AutoSize = true;
            this.label_LectorName.Location = new System.Drawing.Point(17, 48);
            this.label_LectorName.Name = "label_LectorName";
            this.label_LectorName.Size = new System.Drawing.Size(32, 13);
            this.label_LectorName.TabIndex = 1;
            this.label_LectorName.Text = "Имя:";
            // 
            // label_LectorSurname
            // 
            this.label_LectorSurname.AutoSize = true;
            this.label_LectorSurname.Location = new System.Drawing.Point(17, 22);
            this.label_LectorSurname.Name = "label_LectorSurname";
            this.label_LectorSurname.Size = new System.Drawing.Size(59, 13);
            this.label_LectorSurname.TabIndex = 0;
            this.label_LectorSurname.Text = "Фамилия:";
            // 
            // button_SaveToJSON
            // 
            this.button_SaveToJSON.Location = new System.Drawing.Point(12, 531);
            this.button_SaveToJSON.Name = "button_SaveToJSON";
            this.button_SaveToJSON.Size = new System.Drawing.Size(125, 23);
            this.button_SaveToJSON.TabIndex = 19;
            this.button_SaveToJSON.Text = "Сохранить в JSON";
            this.button_SaveToJSON.UseVisualStyleBackColor = true;
            this.button_SaveToJSON.Click += new System.EventHandler(this.button_SaveToJSON_Click);
            // 
            // button_LoadFromJSON
            // 
            this.button_LoadFromJSON.Location = new System.Drawing.Point(156, 531);
            this.button_LoadFromJSON.Name = "button_LoadFromJSON";
            this.button_LoadFromJSON.Size = new System.Drawing.Size(125, 23);
            this.button_LoadFromJSON.TabIndex = 20;
            this.button_LoadFromJSON.Text = "Загрузить из JSON";
            this.button_LoadFromJSON.UseVisualStyleBackColor = true;
            this.button_LoadFromJSON.Click += new System.EventHandler(this.button_LoadFromJSON_Click);
            // 
            // listBox_ShowList
            // 
            this.listBox_ShowList.FormattingEnabled = true;
            this.listBox_ShowList.Location = new System.Drawing.Point(12, 352);
            this.listBox_ShowList.Name = "listBox_ShowList";
            this.listBox_ShowList.Size = new System.Drawing.Size(726, 173);
            this.listBox_ShowList.TabIndex = 21;
            // 
            // errorProvider_Discipline
            // 
            this.errorProvider_Discipline.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider_Discipline.ContainerControl = this;
            // 
            // errorProvider_LectorSurname
            // 
            this.errorProvider_LectorSurname.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider_LectorSurname.ContainerControl = this;
            // 
            // errorProvider_LectorName
            // 
            this.errorProvider_LectorName.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider_LectorName.ContainerControl = this;
            // 
            // errorProvider_LectorThirdname
            // 
            this.errorProvider_LectorThirdname.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider_LectorThirdname.ContainerControl = this;
            // 
            // errorProvider_LectorKabinet
            // 
            this.errorProvider_LectorKabinet.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider_LectorKabinet.ContainerControl = this;
            // 
            // errorProvider_LectorPhone
            // 
            this.errorProvider_LectorPhone.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider_LectorPhone.ContainerControl = this;
            // 
            // errorProvider_Specialize
            // 
            this.errorProvider_Specialize.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider_Specialize.ContainerControl = this;
            // 
            // errorProvider_LectorKafedra
            // 
            this.errorProvider_LectorKafedra.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider_LectorKafedra.ContainerControl = this;
            // 
            // checkedListBox_Spec
            // 
            this.checkedListBox_Spec.FormattingEnabled = true;
            this.checkedListBox_Spec.Items.AddRange(new object[] {
            "ПОИТ",
            "ИСИТ",
            "ДЭВИ",
            "ПОИБМС"});
            this.checkedListBox_Spec.Location = new System.Drawing.Point(140, 230);
            this.checkedListBox_Spec.Name = "checkedListBox_Spec";
            this.checkedListBox_Spec.Size = new System.Drawing.Size(143, 64);
            this.checkedListBox_Spec.TabIndex = 22;
            this.checkedListBox_Spec.Validating += new System.ComponentModel.CancelEventHandler(this.checkedListBox_Spec_Validating);
            // 
            // numericUpDown_Course
            // 
            this.numericUpDown_Course.Location = new System.Drawing.Point(140, 111);
            this.numericUpDown_Course.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDown_Course.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_Course.Name = "numericUpDown_Course";
            this.numericUpDown_Course.Size = new System.Drawing.Size(37, 20);
            this.numericUpDown_Course.TabIndex = 23;
            this.numericUpDown_Course.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_Course.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numericUpDown_Course_KeyDown);
            this.numericUpDown_Course.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericUpDown_Course_KeyPress);
            // 
            // groupBox_Terms
            // 
            this.groupBox_Terms.Controls.Add(this.checkBox_Term2);
            this.groupBox_Terms.Controls.Add(this.checkBox_Term1);
            this.groupBox_Terms.Location = new System.Drawing.Point(140, 133);
            this.groupBox_Terms.Name = "groupBox_Terms";
            this.groupBox_Terms.Size = new System.Drawing.Size(81, 38);
            this.groupBox_Terms.TabIndex = 24;
            this.groupBox_Terms.TabStop = false;
            this.groupBox_Terms.Validating += new System.ComponentModel.CancelEventHandler(this.groupBox_Terms_Validating);
            // 
            // checkBox_Term2
            // 
            this.checkBox_Term2.AutoSize = true;
            this.checkBox_Term2.Location = new System.Drawing.Point(45, 12);
            this.checkBox_Term2.Name = "checkBox_Term2";
            this.checkBox_Term2.Size = new System.Drawing.Size(32, 17);
            this.checkBox_Term2.TabIndex = 25;
            this.checkBox_Term2.Text = "2";
            this.checkBox_Term2.UseVisualStyleBackColor = true;
            // 
            // checkBox_Term1
            // 
            this.checkBox_Term1.AutoSize = true;
            this.checkBox_Term1.Location = new System.Drawing.Point(7, 12);
            this.checkBox_Term1.Name = "checkBox_Term1";
            this.checkBox_Term1.Size = new System.Drawing.Size(32, 17);
            this.checkBox_Term1.TabIndex = 0;
            this.checkBox_Term1.Text = "1";
            this.checkBox_Term1.UseVisualStyleBackColor = true;
            // 
            // trackBar_HourCounty
            // 
            this.trackBar_HourCounty.LargeChange = 1;
            this.trackBar_HourCounty.Location = new System.Drawing.Point(140, 300);
            this.trackBar_HourCounty.Maximum = 40;
            this.trackBar_HourCounty.Minimum = 1;
            this.trackBar_HourCounty.Name = "trackBar_HourCounty";
            this.trackBar_HourCounty.Size = new System.Drawing.Size(143, 45);
            this.trackBar_HourCounty.TabIndex = 25;
            this.trackBar_HourCounty.Value = 1;
            this.trackBar_HourCounty.ValueChanged += new System.EventHandler(this.trackBar_HourCounty_ValueChanged);
            // 
            // label_HoursCounty
            // 
            this.label_HoursCounty.AutoSize = true;
            this.label_HoursCounty.Location = new System.Drawing.Point(9, 311);
            this.label_HoursCounty.Name = "label_HoursCounty";
            this.label_HoursCounty.Size = new System.Drawing.Size(107, 13);
            this.label_HoursCounty.TabIndex = 26;
            this.label_HoursCounty.Text = "Количество часов:1";
            // 
            // errorProvider_Term
            // 
            this.errorProvider_Term.ContainerControl = this;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Search_MenuItem,
            this.Sort_MenuItem,
            this.Save_MenuItem,
            this.aboutProgram_ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(795, 24);
            this.menuStrip1.TabIndex = 27;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Search_MenuItem
            // 
            this.Search_MenuItem.Name = "Search_MenuItem";
            this.Search_MenuItem.Size = new System.Drawing.Size(54, 20);
            this.Search_MenuItem.Text = "Поиск";
            this.Search_MenuItem.Click += new System.EventHandler(this.Search_MenuItem_Click);
            // 
            // Sort_MenuItem
            // 
            this.Sort_MenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_SortOnControlType,
            this.MenuItem_SortOnHoursCounty});
            this.Sort_MenuItem.Name = "Sort_MenuItem";
            this.Sort_MenuItem.Size = new System.Drawing.Size(85, 20);
            this.Sort_MenuItem.Text = "Сортировка";
            // 
            // MenuItem_SortOnControlType
            // 
            this.MenuItem_SortOnControlType.Name = "MenuItem_SortOnControlType";
            this.MenuItem_SortOnControlType.Size = new System.Drawing.Size(199, 22);
            this.MenuItem_SortOnControlType.Text = "По виду контроля";
            this.MenuItem_SortOnControlType.Click += new System.EventHandler(this.MenuItem_SortOnControlType_Click);
            // 
            // MenuItem_SortOnHoursCounty
            // 
            this.MenuItem_SortOnHoursCounty.Name = "MenuItem_SortOnHoursCounty";
            this.MenuItem_SortOnHoursCounty.Size = new System.Drawing.Size(199, 22);
            this.MenuItem_SortOnHoursCounty.Text = "По количеству лекций";
            this.MenuItem_SortOnHoursCounty.Click += new System.EventHandler(this.MenuItem_SortOnHoursCounty_Click);
            // 
            // Save_MenuItem
            // 
            this.Save_MenuItem.Name = "Save_MenuItem";
            this.Save_MenuItem.Size = new System.Drawing.Size(77, 20);
            this.Save_MenuItem.Text = "Сохранить";
            this.Save_MenuItem.Click += new System.EventHandler(this.Save_MenuItem_Click);
            // 
            // aboutProgram_ToolStripMenuItem
            // 
            this.aboutProgram_ToolStripMenuItem.Name = "aboutProgram_ToolStripMenuItem";
            this.aboutProgram_ToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.aboutProgram_ToolStripMenuItem.Text = "О программе";
            this.aboutProgram_ToolStripMenuItem.Click += new System.EventHandler(this.AboutProgram_ToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(795, 25);
            this.toolStrip1.TabIndex = 28;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(795, 566);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label_HoursCounty);
            this.Controls.Add(this.trackBar_HourCounty);
            this.Controls.Add(this.groupBox_Terms);
            this.Controls.Add(this.numericUpDown_Course);
            this.Controls.Add(this.checkedListBox_Spec);
            this.Controls.Add(this.listBox_ShowList);
            this.Controls.Add(this.button_LoadFromJSON);
            this.Controls.Add(this.button_SaveToJSON);
            this.Controls.Add(this.groupBox_LectorInfo);
            this.Controls.Add(this.groupBox_ControlType);
            this.Controls.Add(this.label_ControlType);
            this.Controls.Add(this.label_Specialize);
            this.Controls.Add(this.label_Term);
            this.Controls.Add(this.label_Course);
            this.Controls.Add(this.label_Discipline);
            this.Controls.Add(this.textBox_Discipline);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Учебный отдел";
            this.Load += new System.EventHandler(this.Main_Form_Load);
            this.groupBox_ControlType.ResumeLayout(false);
            this.groupBox_ControlType.PerformLayout();
            this.groupBox_LectorInfo.ResumeLayout(false);
            this.groupBox_LectorInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Discipline)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_LectorSurname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_LectorName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_LectorThirdname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_LectorKabinet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_LectorPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Specialize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_LectorKafedra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Course)).EndInit();
            this.groupBox_Terms.ResumeLayout(false);
            this.groupBox_Terms.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_HourCounty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Term)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Discipline;
        private System.Windows.Forms.Label label_Discipline;
        private System.Windows.Forms.Label label_Course;
        private System.Windows.Forms.Label label_Term;
        private System.Windows.Forms.Label label_Specialize;
        private System.Windows.Forms.RadioButton radioButton_Exam;
        private System.Windows.Forms.RadioButton radioButton_Zachet;
        private System.Windows.Forms.Label label_ControlType;
        private System.Windows.Forms.GroupBox groupBox_ControlType;
        private System.Windows.Forms.GroupBox groupBox_LectorInfo;
        private System.Windows.Forms.Label label_LectorThirdname;
        private System.Windows.Forms.Label label_LectorName;
        private System.Windows.Forms.Label label_LectorSurname;
        private System.Windows.Forms.TextBox textBox_LectorSurname;
        private System.Windows.Forms.TextBox textBox_LectorThirdname;
        private System.Windows.Forms.TextBox textBox_LectorName;
        private System.Windows.Forms.Label label_LectorKabinet;
        private System.Windows.Forms.ComboBox comboBox_Kafedra;
        private System.Windows.Forms.Label label_LectorKafedra;
        private System.Windows.Forms.TextBox textBox_LectorKabinet;
        private System.Windows.Forms.Label label_Phone;
        private System.Windows.Forms.Button button_SaveToJSON;
        private System.Windows.Forms.Button button_LoadFromJSON;
        private System.Windows.Forms.ListBox listBox_ShowList;
        private System.Windows.Forms.ErrorProvider errorProvider_Discipline;
        private System.Windows.Forms.ErrorProvider errorProvider_LectorSurname;
        private System.Windows.Forms.ErrorProvider errorProvider_LectorName;
        private System.Windows.Forms.ErrorProvider errorProvider_LectorThirdname;
        private System.Windows.Forms.ErrorProvider errorProvider_LectorKabinet;
        private System.Windows.Forms.ErrorProvider errorProvider_LectorPhone;
        private System.Windows.Forms.ErrorProvider errorProvider_Specialize;
        private System.Windows.Forms.ErrorProvider errorProvider_LectorKafedra;
        private System.Windows.Forms.NumericUpDown numericUpDown_Course;
        private System.Windows.Forms.CheckedListBox checkedListBox_Spec;
        private System.Windows.Forms.GroupBox groupBox_Terms;
        private System.Windows.Forms.CheckBox checkBox_Term2;
        private System.Windows.Forms.CheckBox checkBox_Term1;
        private System.Windows.Forms.Label label_HoursCounty;
        private System.Windows.Forms.TrackBar trackBar_HourCounty;
        private System.Windows.Forms.ErrorProvider errorProvider_Term;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Search_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem Sort_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem Save_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutProgram_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_SortOnControlType;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_SortOnHoursCounty;
        private System.Windows.Forms.MaskedTextBox textBox_LectorPhone;
        private System.Windows.Forms.ToolStrip toolStrip1;
    }
}

