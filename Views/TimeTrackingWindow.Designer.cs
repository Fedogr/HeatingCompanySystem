namespace HeatingCompanySystem.Views
{
    partial class TimeTrackingWindow
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clearFiltersBtn = new System.Windows.Forms.Button();
            this.squareSearchBox = new System.Windows.Forms.TextBox();
            this.nameSearchBox = new System.Windows.Forms.TextBox();
            this.commonSearchBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataStructureGV = new System.Windows.Forms.DataGridView();
            this.idCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TableNumCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeIdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EntryDateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrentDateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoursWorkedCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdByCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdDateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatedByCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatedDateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.changeBtnCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.deleteBtnCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.addStructureBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataStructureGV)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.groupBox1.Controls.Add(this.clearFiltersBtn);
            this.groupBox1.Controls.Add(this.squareSearchBox);
            this.groupBox1.Controls.Add(this.nameSearchBox);
            this.groupBox1.Controls.Add(this.commonSearchBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Georgia", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1082, 119);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск";
            // 
            // clearFiltersBtn
            // 
            this.clearFiltersBtn.ForeColor = System.Drawing.Color.Tomato;
            this.clearFiltersBtn.Location = new System.Drawing.Point(871, 67);
            this.clearFiltersBtn.Name = "clearFiltersBtn";
            this.clearFiltersBtn.Size = new System.Drawing.Size(208, 37);
            this.clearFiltersBtn.TabIndex = 1;
            this.clearFiltersBtn.Text = "Очистить";
            this.clearFiltersBtn.UseVisualStyleBackColor = true;
            this.clearFiltersBtn.Click += new System.EventHandler(this.clearFiltersBtn_Click);
            // 
            // squareSearchBox
            // 
            this.squareSearchBox.Location = new System.Drawing.Point(437, 70);
            this.squareSearchBox.Name = "squareSearchBox";
            this.squareSearchBox.PlaceholderText = "Поиск по кол-ву часов...";
            this.squareSearchBox.Size = new System.Drawing.Size(428, 32);
            this.squareSearchBox.TabIndex = 4;
            this.squareSearchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.squareSearchBox.TextChanged += new System.EventHandler(this.squareSearchBox_TextChanged);
            this.squareSearchBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.squareSearchBox_KeyPress);
            // 
            // nameSearchBox
            // 
            this.nameSearchBox.Location = new System.Drawing.Point(3, 70);
            this.nameSearchBox.Name = "nameSearchBox";
            this.nameSearchBox.PlaceholderText = "Поиск по номеру...";
            this.nameSearchBox.Size = new System.Drawing.Size(428, 32);
            this.nameSearchBox.TabIndex = 3;
            this.nameSearchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nameSearchBox.TextChanged += new System.EventHandler(this.nameSearchBox_TextChanged);
            // 
            // commonSearchBox
            // 
            this.commonSearchBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.commonSearchBox.Location = new System.Drawing.Point(3, 28);
            this.commonSearchBox.Name = "commonSearchBox";
            this.commonSearchBox.PlaceholderText = "Общий поиск...";
            this.commonSearchBox.Size = new System.Drawing.Size(1076, 32);
            this.commonSearchBox.TabIndex = 2;
            this.commonSearchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.commonSearchBox.TextChanged += new System.EventHandler(this.commonSearchBox_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightYellow;
            this.groupBox2.Controls.Add(this.dataStructureGV);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(0, 119);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1082, 339);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Список табелей учета рабочего времени";
            // 
            // dataStructureGV
            // 
            this.dataStructureGV.AllowUserToAddRows = false;
            this.dataStructureGV.AllowUserToDeleteRows = false;
            this.dataStructureGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataStructureGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCol,
            this.numCol,
            this.TableNumCol,
            this.EmployeeIdCol,
            this.EntryDateCol,
            this.CurrentDateCol,
            this.HoursWorkedCol,
            this.createdByCol,
            this.createdDateCol,
            this.updatedByCol,
            this.updatedDateCol,
            this.changeBtnCol,
            this.deleteBtnCol});
            this.dataStructureGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataStructureGV.Location = new System.Drawing.Point(3, 26);
            this.dataStructureGV.Name = "dataStructureGV";
            this.dataStructureGV.RowHeadersWidth = 51;
            this.dataStructureGV.RowTemplate.Height = 29;
            this.dataStructureGV.Size = new System.Drawing.Size(1076, 310);
            this.dataStructureGV.TabIndex = 0;
            this.dataStructureGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataStructureGV_CellContentClick);
            // 
            // idCol
            // 
            this.idCol.HeaderText = "GUID";
            this.idCol.MinimumWidth = 6;
            this.idCol.Name = "idCol";
            this.idCol.ReadOnly = true;
            this.idCol.Visible = false;
            this.idCol.Width = 125;
            // 
            // numCol
            // 
            this.numCol.HeaderText = "#";
            this.numCol.MinimumWidth = 6;
            this.numCol.Name = "numCol";
            this.numCol.ReadOnly = true;
            this.numCol.Width = 125;
            // 
            // TableNumCol
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            this.TableNumCol.DefaultCellStyle = dataGridViewCellStyle1;
            this.TableNumCol.HeaderText = "Табельный номер";
            this.TableNumCol.MinimumWidth = 6;
            this.TableNumCol.Name = "TableNumCol";
            this.TableNumCol.Width = 250;
            // 
            // EmployeeIdCol
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
            this.EmployeeIdCol.DefaultCellStyle = dataGridViewCellStyle2;
            this.EmployeeIdCol.HeaderText = "Номер сотрудника";
            this.EmployeeIdCol.MinimumWidth = 6;
            this.EmployeeIdCol.Name = "EmployeeIdCol";
            this.EmployeeIdCol.Width = 125;
            // 
            // EntryDateCol
            // 
            this.EntryDateCol.HeaderText = "Начало работы";
            this.EntryDateCol.MinimumWidth = 6;
            this.EntryDateCol.Name = "EntryDateCol";
            this.EntryDateCol.ReadOnly = true;
            this.EntryDateCol.Width = 300;
            // 
            // CurrentDateCol
            // 
            this.CurrentDateCol.HeaderText = "Текущая дата";
            this.CurrentDateCol.MinimumWidth = 6;
            this.CurrentDateCol.Name = "CurrentDateCol";
            this.CurrentDateCol.ReadOnly = true;
            this.CurrentDateCol.Width = 170;
            // 
            // HoursWorkedCol
            // 
            this.HoursWorkedCol.HeaderText = "Отработано часов";
            this.HoursWorkedCol.MinimumWidth = 6;
            this.HoursWorkedCol.Name = "HoursWorkedCol";
            this.HoursWorkedCol.Width = 125;
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
            // changeBtnCol
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkOrange;
            this.changeBtnCol.DefaultCellStyle = dataGridViewCellStyle3;
            this.changeBtnCol.HeaderText = "Изменить";
            this.changeBtnCol.MinimumWidth = 6;
            this.changeBtnCol.Name = "changeBtnCol";
            this.changeBtnCol.Width = 125;
            // 
            // deleteBtnCol
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.OrangeRed;
            this.deleteBtnCol.DefaultCellStyle = dataGridViewCellStyle4;
            this.deleteBtnCol.HeaderText = "Удалить";
            this.deleteBtnCol.MinimumWidth = 6;
            this.deleteBtnCol.Name = "deleteBtnCol";
            this.deleteBtnCol.Width = 125;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Silver;
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(this.textBox5);
            this.groupBox3.Controls.Add(this.textBox4);
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.addStructureBtn);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(0, 458);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1082, 117);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Добавить табель сотрудника";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(137, 69);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(143, 29);
            this.comboBox1.TabIndex = 15;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(755, 54);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(143, 28);
            this.textBox5.TabIndex = 14;
            this.textBox5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox5_KeyPress);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(430, 74);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(143, 28);
            this.textBox4.TabIndex = 13;
            this.textBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(430, 35);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(143, 28);
            this.textBox3.TabIndex = 12;
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(590, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "Отработано часов:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(286, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Текущая дата:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(286, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Начало работы:";
            // 
            // addStructureBtn
            // 
            this.addStructureBtn.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addStructureBtn.ForeColor = System.Drawing.Color.Green;
            this.addStructureBtn.Location = new System.Drawing.Point(922, 34);
            this.addStructureBtn.Name = "addStructureBtn";
            this.addStructureBtn.Size = new System.Drawing.Size(148, 63);
            this.addStructureBtn.TabIndex = 8;
            this.addStructureBtn.Text = "Добавить";
            this.addStructureBtn.UseVisualStyleBackColor = true;
            this.addStructureBtn.Click += new System.EventHandler(this.addStructureBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(137, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(143, 28);
            this.textBox1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ном. сотр-ка:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Таб. номер:";
            // 
            // TimeTrackingWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 575);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "TimeTrackingWindow";
            this.Text = "Учет рабочего времени";
            this.Load += new System.EventHandler(this.TimeTrackingWindow_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataStructureGV)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button clearFiltersBtn;
        private TextBox squareSearchBox;
        private TextBox nameSearchBox;
        private TextBox commonSearchBox;
        private GroupBox groupBox2;
        private DataGridView dataStructureGV;
        private GroupBox groupBox3;
        private Button addStructureBtn;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private DataGridViewTextBoxColumn idCol;
        private DataGridViewTextBoxColumn numCol;
        private DataGridViewTextBoxColumn TableNumCol;
        private DataGridViewTextBoxColumn EmployeeIdCol;
        private DataGridViewTextBoxColumn EntryDateCol;
        private DataGridViewTextBoxColumn CurrentDateCol;
        private DataGridViewTextBoxColumn HoursWorkedCol;
        private DataGridViewTextBoxColumn createdByCol;
        private DataGridViewTextBoxColumn createdDateCol;
        private DataGridViewTextBoxColumn updatedByCol;
        private DataGridViewTextBoxColumn updatedDateCol;
        private DataGridViewButtonColumn changeBtnCol;
        private DataGridViewButtonColumn deleteBtnCol;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private Label label6;
        private Label label5;
        private Label label4;
        private ComboBox comboBox1;
    }
}