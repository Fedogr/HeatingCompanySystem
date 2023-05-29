namespace HeatingCompanySystem.Views
{
    partial class EmployeesWindow
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeesWindow));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataEmployeesGV = new System.Windows.Forms.DataGridView();
            this.numCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personnelNumCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middleNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthDateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photoCol = new System.Windows.Forms.DataGridViewImageColumn();
            this.numPStationCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timaTabelCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobTitleCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qualCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdByCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdDateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatedByCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatedDateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveBtnCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.deleteBtnCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.guidCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.middleNameSearchBox = new System.Windows.Forms.TextBox();
            this.firstNameSearchBox = new System.Windows.Forms.TextBox();
            this.lastNameSearchBox = new System.Windows.Forms.TextBox();
            this.commonSearchBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.inputQualBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.inputJtBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.inputBrBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.inputBdateBox = new System.Windows.Forms.TextBox();
            this.addNewEmployeeBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.PetrolStationCmbBox = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.inputPhotoUrlBox = new System.Windows.Forms.TextBox();
            this.urlCustomRadioBtn = new System.Windows.Forms.RadioButton();
            this.urlDefaultRadioBtn = new System.Windows.Forms.RadioButton();
            this.inputMNameBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.inputFNameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.inputLNameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numEmployeeBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataEmployeesGV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1126, 631);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1118, 594);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Список";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FloralWhite;
            this.groupBox2.Controls.Add(this.dataEmployeesGV);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(3, 121);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1112, 470);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Список";
            // 
            // dataEmployeesGV
            // 
            this.dataEmployeesGV.AllowUserToAddRows = false;
            this.dataEmployeesGV.AllowUserToDeleteRows = false;
            this.dataEmployeesGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataEmployeesGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataEmployeesGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numCol,
            this.personnelNumCol,
            this.lastNameCol,
            this.firstNameCol,
            this.middleNameCol,
            this.birthDateCol,
            this.photoCol,
            this.numPStationCol,
            this.timaTabelCol,
            this.jobTitleCol,
            this.qualCol,
            this.createdByCol,
            this.createdDateCol,
            this.updatedByCol,
            this.updatedDateCol,
            this.saveBtnCol,
            this.deleteBtnCol,
            this.guidCol});
            this.dataEmployeesGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataEmployeesGV.Location = new System.Drawing.Point(3, 26);
            this.dataEmployeesGV.Name = "dataEmployeesGV";
            this.dataEmployeesGV.RowHeadersWidth = 51;
            this.dataEmployeesGV.RowTemplate.Height = 29;
            this.dataEmployeesGV.Size = new System.Drawing.Size(1106, 441);
            this.dataEmployeesGV.TabIndex = 0;
            this.dataEmployeesGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataEmployeesGV_CellContentClick_1);
            // 
            // numCol
            // 
            this.numCol.HeaderText = "#";
            this.numCol.MinimumWidth = 6;
            this.numCol.Name = "numCol";
            this.numCol.ReadOnly = true;
            this.numCol.Width = 125;
            // 
            // personnelNumCol
            // 
            this.personnelNumCol.HeaderText = "Табельный номер";
            this.personnelNumCol.MinimumWidth = 6;
            this.personnelNumCol.Name = "personnelNumCol";
            this.personnelNumCol.ReadOnly = true;
            this.personnelNumCol.Width = 125;
            // 
            // lastNameCol
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            this.lastNameCol.DefaultCellStyle = dataGridViewCellStyle1;
            this.lastNameCol.HeaderText = "Фамилия";
            this.lastNameCol.MinimumWidth = 6;
            this.lastNameCol.Name = "lastNameCol";
            this.lastNameCol.Width = 200;
            // 
            // firstNameCol
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
            this.firstNameCol.DefaultCellStyle = dataGridViewCellStyle2;
            this.firstNameCol.HeaderText = "Имя";
            this.firstNameCol.MinimumWidth = 6;
            this.firstNameCol.Name = "firstNameCol";
            this.firstNameCol.Width = 200;
            // 
            // middleNameCol
            // 
            this.middleNameCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Silver;
            this.middleNameCol.DefaultCellStyle = dataGridViewCellStyle3;
            this.middleNameCol.HeaderText = "Отчество";
            this.middleNameCol.MinimumWidth = 6;
            this.middleNameCol.Name = "middleNameCol";
            this.middleNameCol.Width = 123;
            // 
            // birthDateCol
            // 
            this.birthDateCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.birthDateCol.HeaderText = "Дата рождения";
            this.birthDateCol.MinimumWidth = 6;
            this.birthDateCol.Name = "birthDateCol";
            this.birthDateCol.Width = 165;
            // 
            // photoCol
            // 
            this.photoCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle4.NullValue")));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.photoCol.DefaultCellStyle = dataGridViewCellStyle4;
            this.photoCol.HeaderText = "Фото";
            this.photoCol.MinimumWidth = 6;
            this.photoCol.Name = "photoCol";
            this.photoCol.Width = 63;
            // 
            // numPStationCol
            // 
            this.numPStationCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.numPStationCol.HeaderText = "Номер бригады";
            this.numPStationCol.MinimumWidth = 6;
            this.numPStationCol.Name = "numPStationCol";
            this.numPStationCol.ReadOnly = true;
            this.numPStationCol.Width = 169;
            // 
            // timaTabelCol
            // 
            this.timaTabelCol.HeaderText = "Рабочий день";
            this.timaTabelCol.MinimumWidth = 6;
            this.timaTabelCol.Name = "timaTabelCol";
            this.timaTabelCol.Width = 125;
            // 
            // jobTitleCol
            // 
            this.jobTitleCol.HeaderText = "Должность";
            this.jobTitleCol.MinimumWidth = 6;
            this.jobTitleCol.Name = "jobTitleCol";
            this.jobTitleCol.Width = 125;
            // 
            // qualCol
            // 
            this.qualCol.HeaderText = "Квалификация";
            this.qualCol.MinimumWidth = 6;
            this.qualCol.Name = "qualCol";
            this.qualCol.Width = 125;
            // 
            // createdByCol
            // 
            this.createdByCol.HeaderText = "Кем создан";
            this.createdByCol.MinimumWidth = 6;
            this.createdByCol.Name = "createdByCol";
            this.createdByCol.ReadOnly = true;
            this.createdByCol.Width = 125;
            // 
            // createdDateCol
            // 
            this.createdDateCol.HeaderText = "Создан";
            this.createdDateCol.MinimumWidth = 6;
            this.createdDateCol.Name = "createdDateCol";
            this.createdDateCol.ReadOnly = true;
            this.createdDateCol.Width = 125;
            // 
            // updatedByCol
            // 
            this.updatedByCol.HeaderText = "Кем обновлён";
            this.updatedByCol.MinimumWidth = 6;
            this.updatedByCol.Name = "updatedByCol";
            this.updatedByCol.ReadOnly = true;
            this.updatedByCol.Width = 125;
            // 
            // updatedDateCol
            // 
            this.updatedDateCol.HeaderText = "Обновлён";
            this.updatedDateCol.MinimumWidth = 6;
            this.updatedDateCol.Name = "updatedDateCol";
            this.updatedDateCol.ReadOnly = true;
            this.updatedDateCol.Width = 125;
            // 
            // saveBtnCol
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DarkOrange;
            this.saveBtnCol.DefaultCellStyle = dataGridViewCellStyle5;
            this.saveBtnCol.HeaderText = "Изменить";
            this.saveBtnCol.MinimumWidth = 6;
            this.saveBtnCol.Name = "saveBtnCol";
            this.saveBtnCol.Width = 125;
            // 
            // deleteBtnCol
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Red;
            this.deleteBtnCol.DefaultCellStyle = dataGridViewCellStyle6;
            this.deleteBtnCol.HeaderText = "Удалить";
            this.deleteBtnCol.MinimumWidth = 6;
            this.deleteBtnCol.Name = "deleteBtnCol";
            this.deleteBtnCol.Width = 125;
            // 
            // guidCol
            // 
            this.guidCol.HeaderText = "GUID";
            this.guidCol.MinimumWidth = 6;
            this.guidCol.Name = "guidCol";
            this.guidCol.ReadOnly = true;
            this.guidCol.Visible = false;
            this.guidCol.Width = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.middleNameSearchBox);
            this.groupBox1.Controls.Add(this.firstNameSearchBox);
            this.groupBox1.Controls.Add(this.lastNameSearchBox);
            this.groupBox1.Controls.Add(this.commonSearchBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1112, 118);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Tomato;
            this.button1.Location = new System.Drawing.Point(1111, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(343, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "Очистить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // middleNameSearchBox
            // 
            this.middleNameSearchBox.Location = new System.Drawing.Point(766, 71);
            this.middleNameSearchBox.Name = "middleNameSearchBox";
            this.middleNameSearchBox.PlaceholderText = "Поиск по отчеству...";
            this.middleNameSearchBox.Size = new System.Drawing.Size(339, 28);
            this.middleNameSearchBox.TabIndex = 1;
            this.middleNameSearchBox.TextChanged += new System.EventHandler(this.middleNameSearchBox_TextChanged);
            // 
            // firstNameSearchBox
            // 
            this.firstNameSearchBox.Location = new System.Drawing.Point(395, 70);
            this.firstNameSearchBox.Name = "firstNameSearchBox";
            this.firstNameSearchBox.PlaceholderText = "Поиск по имени...";
            this.firstNameSearchBox.Size = new System.Drawing.Size(365, 28);
            this.firstNameSearchBox.TabIndex = 1;
            this.firstNameSearchBox.TextChanged += new System.EventHandler(this.firstNameSearchBox_TextChanged);
            // 
            // lastNameSearchBox
            // 
            this.lastNameSearchBox.Location = new System.Drawing.Point(3, 70);
            this.lastNameSearchBox.Name = "lastNameSearchBox";
            this.lastNameSearchBox.PlaceholderText = "Поиск по фамилии...";
            this.lastNameSearchBox.Size = new System.Drawing.Size(386, 28);
            this.lastNameSearchBox.TabIndex = 1;
            this.lastNameSearchBox.TextChanged += new System.EventHandler(this.lastNameSearchBox_TextChanged);
            // 
            // commonSearchBox
            // 
            this.commonSearchBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.commonSearchBox.Location = new System.Drawing.Point(3, 24);
            this.commonSearchBox.Name = "commonSearchBox";
            this.commonSearchBox.PlaceholderText = "Общий поиск...";
            this.commonSearchBox.Size = new System.Drawing.Size(1106, 28);
            this.commonSearchBox.TabIndex = 0;
            this.commonSearchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.commonSearchBox.TextChanged += new System.EventHandler(this.commonSearchBox_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1118, 594);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Добавить";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.LightGray;
            this.groupBox3.Controls.Add(this.inputQualBox);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.inputJtBox);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.inputBrBox);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.inputBdateBox);
            this.groupBox3.Controls.Add(this.addNewEmployeeBtn);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.PetrolStationCmbBox);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.inputMNameBox);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.inputFNameBox);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.inputLNameBox);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.numEmployeeBox);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1112, 495);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ввод данных";
            // 
            // inputQualBox
            // 
            this.inputQualBox.Location = new System.Drawing.Point(215, 210);
            this.inputQualBox.Name = "inputQualBox";
            this.inputQualBox.Size = new System.Drawing.Size(326, 30);
            this.inputQualBox.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 233);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 24);
            this.label10.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 213);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 24);
            this.label9.TabIndex = 13;
            this.label9.Text = "Квалификация:";
            // 
            // inputJtBox
            // 
            this.inputJtBox.Location = new System.Drawing.Point(557, 154);
            this.inputJtBox.Name = "inputJtBox";
            this.inputJtBox.Size = new System.Drawing.Size(206, 30);
            this.inputJtBox.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(421, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 24);
            this.label8.TabIndex = 11;
            this.label8.Text = "Должность:";
            // 
            // inputBrBox
            // 
            this.inputBrBox.Location = new System.Drawing.Point(215, 158);
            this.inputBrBox.Name = "inputBrBox";
            this.inputBrBox.Size = new System.Drawing.Size(189, 30);
            this.inputBrBox.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 24);
            this.label7.TabIndex = 9;
            this.label7.Text = "Бригада:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(421, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 24);
            this.label6.TabIndex = 3;
            this.label6.Text = "Дата рожд-я:";
            // 
            // inputBdateBox
            // 
            this.inputBdateBox.Location = new System.Drawing.Point(557, 99);
            this.inputBdateBox.Name = "inputBdateBox";
            this.inputBdateBox.Size = new System.Drawing.Size(206, 30);
            this.inputBdateBox.TabIndex = 5;
            this.inputBdateBox.TextChanged += new System.EventHandler(this.inputBdateBox_TextChanged);
            // 
            // addNewEmployeeBtn
            // 
            this.addNewEmployeeBtn.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addNewEmployeeBtn.ForeColor = System.Drawing.Color.LimeGreen;
            this.addNewEmployeeBtn.Location = new System.Drawing.Point(855, 242);
            this.addNewEmployeeBtn.Name = "addNewEmployeeBtn";
            this.addNewEmployeeBtn.Size = new System.Drawing.Size(225, 86);
            this.addNewEmployeeBtn.TabIndex = 8;
            this.addNewEmployeeBtn.Text = "Добавить нового сотрудника";
            this.addNewEmployeeBtn.UseVisualStyleBackColor = true;
            this.addNewEmployeeBtn.Click += new System.EventHandler(this.addNewEmployeeBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(783, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "График работы:";
            // 
            // PetrolStationCmbBox
            // 
            this.PetrolStationCmbBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PetrolStationCmbBox.FormattingEnabled = true;
            this.PetrolStationCmbBox.Location = new System.Drawing.Point(952, 98);
            this.PetrolStationCmbBox.Name = "PetrolStationCmbBox";
            this.PetrolStationCmbBox.Size = new System.Drawing.Size(128, 32);
            this.PetrolStationCmbBox.TabIndex = 7;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.inputPhotoUrlBox);
            this.groupBox4.Controls.Add(this.urlCustomRadioBtn);
            this.groupBox4.Controls.Add(this.urlDefaultRadioBtn);
            this.groupBox4.Location = new System.Drawing.Point(18, 271);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(325, 164);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Фото URL";
            // 
            // inputPhotoUrlBox
            // 
            this.inputPhotoUrlBox.Enabled = false;
            this.inputPhotoUrlBox.Location = new System.Drawing.Point(6, 116);
            this.inputPhotoUrlBox.Name = "inputPhotoUrlBox";
            this.inputPhotoUrlBox.Size = new System.Drawing.Size(599, 30);
            this.inputPhotoUrlBox.TabIndex = 2;
            // 
            // urlCustomRadioBtn
            // 
            this.urlCustomRadioBtn.AutoSize = true;
            this.urlCustomRadioBtn.Location = new System.Drawing.Point(16, 79);
            this.urlCustomRadioBtn.Name = "urlCustomRadioBtn";
            this.urlCustomRadioBtn.Size = new System.Drawing.Size(215, 28);
            this.urlCustomRadioBtn.TabIndex = 6;
            this.urlCustomRadioBtn.Text = "Добавить своё фото";
            this.urlCustomRadioBtn.UseVisualStyleBackColor = true;
            // 
            // urlDefaultRadioBtn
            // 
            this.urlDefaultRadioBtn.AutoSize = true;
            this.urlDefaultRadioBtn.Checked = true;
            this.urlDefaultRadioBtn.Location = new System.Drawing.Point(16, 33);
            this.urlDefaultRadioBtn.Name = "urlDefaultRadioBtn";
            this.urlDefaultRadioBtn.Size = new System.Drawing.Size(240, 28);
            this.urlDefaultRadioBtn.TabIndex = 5;
            this.urlDefaultRadioBtn.TabStop = true;
            this.urlDefaultRadioBtn.Text = "Стандартная картинка";
            this.urlDefaultRadioBtn.UseVisualStyleBackColor = true;
            // 
            // inputMNameBox
            // 
            this.inputMNameBox.Location = new System.Drawing.Point(215, 99);
            this.inputMNameBox.Name = "inputMNameBox";
            this.inputMNameBox.Size = new System.Drawing.Size(189, 30);
            this.inputMNameBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Отчество:";
            // 
            // inputFNameBox
            // 
            this.inputFNameBox.Location = new System.Drawing.Point(850, 41);
            this.inputFNameBox.Name = "inputFNameBox";
            this.inputFNameBox.Size = new System.Drawing.Size(230, 30);
            this.inputFNameBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(786, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Имя:";
            // 
            // inputLNameBox
            // 
            this.inputLNameBox.Location = new System.Drawing.Point(533, 41);
            this.inputLNameBox.Name = "inputLNameBox";
            this.inputLNameBox.Size = new System.Drawing.Size(230, 30);
            this.inputLNameBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(421, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Фамилия:";
            // 
            // numEmployeeBox
            // 
            this.numEmployeeBox.Enabled = false;
            this.numEmployeeBox.Location = new System.Drawing.Point(215, 41);
            this.numEmployeeBox.Name = "numEmployeeBox";
            this.numEmployeeBox.Size = new System.Drawing.Size(189, 30);
            this.numEmployeeBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Табельный номер:\r\n";
            // 
            // EmployeesWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1126, 631);
            this.Controls.Add(this.tabControl1);
            this.Name = "EmployeesWindow";
            this.Text = "EmployeesWindow";
            this.Load += new System.EventHandler(this.EmployeesWindow_Load_1);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataEmployeesGV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private GroupBox groupBox2;
        private DataGridView dataEmployeesGV;
        private GroupBox groupBox1;
        private Button button1;
        private TextBox middleNameSearchBox;
        private TextBox firstNameSearchBox;
        private TextBox lastNameSearchBox;
        private TextBox commonSearchBox;
        private TabPage tabPage2;
        private GroupBox groupBox3;
        private Button addNewEmployeeBtn;
        private Label label5;
        private ComboBox PetrolStationCmbBox;
        private GroupBox groupBox4;
        private TextBox inputPhotoUrlBox;
        private RadioButton urlCustomRadioBtn;
        private RadioButton urlDefaultRadioBtn;
        private TextBox inputMNameBox;
        private Label label4;
        private TextBox inputFNameBox;
        private Label label3;
        private TextBox inputLNameBox;
        private Label label2;
        private TextBox numEmployeeBox;
        private Label label1;
        private DataGridViewTextBoxColumn numCol;
        private DataGridViewTextBoxColumn personnelNumCol;
        private DataGridViewTextBoxColumn lastNameCol;
        private DataGridViewTextBoxColumn firstNameCol;
        private DataGridViewTextBoxColumn middleNameCol;
        private DataGridViewTextBoxColumn birthDateCol;
        private DataGridViewImageColumn photoCol;
        private DataGridViewTextBoxColumn numPStationCol;
        private DataGridViewTextBoxColumn timaTabelCol;
        private DataGridViewTextBoxColumn jobTitleCol;
        private DataGridViewTextBoxColumn qualCol;
        private DataGridViewTextBoxColumn createdByCol;
        private DataGridViewTextBoxColumn createdDateCol;
        private DataGridViewTextBoxColumn updatedByCol;
        private DataGridViewTextBoxColumn updatedDateCol;
        private DataGridViewButtonColumn saveBtnCol;
        private DataGridViewButtonColumn deleteBtnCol;
        private DataGridViewTextBoxColumn guidCol;
        private Label label6;
        private TextBox inputBdateBox;
        private Label label7;
        private TextBox inputBrBox;
        private Label label10;
        private Label label9;
        private TextBox inputJtBox;
        private Label label8;
        private TextBox inputQualBox;
    }
}