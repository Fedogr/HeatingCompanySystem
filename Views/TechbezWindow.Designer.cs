namespace HeatingCompanySystem.Views
{
    partial class TechbezWindow
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataMatLiabGV = new System.Windows.Forms.DataGridView();
            this.guidCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChekDateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckResCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NextChDateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdByCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdDateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatedByCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatedDateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteBtnCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TextBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.addNewTbBtn = new System.Windows.Forms.Button();
            this.chooseEmployeeCmbBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataMatLiabGV)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MistyRose;
            this.groupBox1.Controls.Add(this.dataMatLiabGV);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1124, 377);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Контроль";
            // 
            // dataMatLiabGV
            // 
            this.dataMatLiabGV.AllowUserToAddRows = false;
            this.dataMatLiabGV.AllowUserToDeleteRows = false;
            this.dataMatLiabGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMatLiabGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.guidCol,
            this.numCol,
            this.employeeCol,
            this.ChekDateCol,
            this.CheckResCol,
            this.NextChDateCol,
            this.createdByCol,
            this.createdDateCol,
            this.updatedByCol,
            this.updatedDateCol,
            this.deleteBtnCol});
            this.dataMatLiabGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataMatLiabGV.Location = new System.Drawing.Point(3, 26);
            this.dataMatLiabGV.Name = "dataMatLiabGV";
            this.dataMatLiabGV.RowHeadersWidth = 51;
            this.dataMatLiabGV.RowTemplate.Height = 29;
            this.dataMatLiabGV.Size = new System.Drawing.Size(1118, 348);
            this.dataMatLiabGV.TabIndex = 0;
            this.dataMatLiabGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataMatLiabGV_CellContentClick);
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
            // numCol
            // 
            this.numCol.HeaderText = "#";
            this.numCol.MinimumWidth = 6;
            this.numCol.Name = "numCol";
            this.numCol.ReadOnly = true;
            this.numCol.Width = 70;
            // 
            // employeeCol
            // 
            this.employeeCol.HeaderText = "Сотрудник";
            this.employeeCol.MinimumWidth = 6;
            this.employeeCol.Name = "employeeCol";
            this.employeeCol.ReadOnly = true;
            this.employeeCol.Width = 200;
            // 
            // ChekDateCol
            // 
            this.ChekDateCol.HeaderText = "Дата прохождения";
            this.ChekDateCol.MinimumWidth = 6;
            this.ChekDateCol.Name = "ChekDateCol";
            this.ChekDateCol.ReadOnly = true;
            this.ChekDateCol.Width = 250;
            // 
            // CheckResCol
            // 
            this.CheckResCol.HeaderText = "Результат ";
            this.CheckResCol.MinimumWidth = 6;
            this.CheckResCol.Name = "CheckResCol";
            this.CheckResCol.ReadOnly = true;
            this.CheckResCol.Width = 250;
            // 
            // NextChDateCol
            // 
            this.NextChDateCol.HeaderText = "Следующая проверка";
            this.NextChDateCol.MinimumWidth = 6;
            this.NextChDateCol.Name = "NextChDateCol";
            this.NextChDateCol.Width = 125;
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
            this.createdDateCol.HeaderText = "Создано";
            this.createdDateCol.MinimumWidth = 6;
            this.createdDateCol.Name = "createdDateCol";
            this.createdDateCol.ReadOnly = true;
            this.createdDateCol.Width = 125;
            // 
            // updatedByCol
            // 
            this.updatedByCol.HeaderText = "Кем обновлено";
            this.updatedByCol.MinimumWidth = 6;
            this.updatedByCol.Name = "updatedByCol";
            this.updatedByCol.ReadOnly = true;
            this.updatedByCol.Width = 125;
            // 
            // updatedDateCol
            // 
            this.updatedDateCol.HeaderText = "Обновлено";
            this.updatedDateCol.MinimumWidth = 6;
            this.updatedDateCol.Name = "updatedDateCol";
            this.updatedDateCol.ReadOnly = true;
            this.updatedDateCol.Width = 125;
            // 
            // deleteBtnCol
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Red;
            this.deleteBtnCol.DefaultCellStyle = dataGridViewCellStyle1;
            this.deleteBtnCol.HeaderText = "Удалить";
            this.deleteBtnCol.MinimumWidth = 6;
            this.deleteBtnCol.Name = "deleteBtnCol";
            this.deleteBtnCol.ReadOnly = true;
            this.deleteBtnCol.Width = 125;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Azure;
            this.groupBox2.Controls.Add(this.TextBox3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.TextBox2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.TextBox1);
            this.groupBox2.Controls.Add(this.addNewTbBtn);
            this.groupBox2.Controls.Add(this.chooseEmployeeCmbBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(0, 377);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1124, 122);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Добавить результат проверки";
            // 
            // TextBox3
            // 
            this.TextBox3.Location = new System.Drawing.Point(688, 73);
            this.TextBox3.Name = "TextBox3";
            this.TextBox3.Size = new System.Drawing.Size(185, 30);
            this.TextBox3.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(688, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "След. проверка\r\n";
            // 
            // TextBox2
            // 
            this.TextBox2.Location = new System.Drawing.Point(486, 73);
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.Size = new System.Drawing.Size(185, 30);
            this.TextBox2.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(486, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Результат";
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(257, 73);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(213, 30);
            this.TextBox1.TabIndex = 5;
            // 
            // addNewTbBtn
            // 
            this.addNewTbBtn.ForeColor = System.Drawing.Color.ForestGreen;
            this.addNewTbBtn.Location = new System.Drawing.Point(904, 34);
            this.addNewTbBtn.Name = "addNewTbBtn";
            this.addNewTbBtn.Size = new System.Drawing.Size(198, 69);
            this.addNewTbBtn.TabIndex = 4;
            this.addNewTbBtn.Text = "Добавить";
            this.addNewTbBtn.UseVisualStyleBackColor = true;
            this.addNewTbBtn.Click += new System.EventHandler(this.addNewTbBtn_Click);
            // 
            // chooseEmployeeCmbBox
            // 
            this.chooseEmployeeCmbBox.FormattingEnabled = true;
            this.chooseEmployeeCmbBox.Location = new System.Drawing.Point(6, 73);
            this.chooseEmployeeCmbBox.Name = "chooseEmployeeCmbBox";
            this.chooseEmployeeCmbBox.Size = new System.Drawing.Size(233, 32);
            this.chooseEmployeeCmbBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(257, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Выбрать дату";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выбрать сотрудника";
            // 
            // TechbezWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 499);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "TechbezWindow";
            this.Text = "Прохождение техники безопасности";
            this.Load += new System.EventHandler(this.TechbezWindow_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataMatLiabGV)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dataMatLiabGV;
        private GroupBox groupBox2;
        private TextBox TextBox2;
        private Label label3;
        private TextBox TextBox1;
        private Button addNewTbBtn;
        private ComboBox chooseEmployeeCmbBox;
        private Label label2;
        private Label label1;
        private DataGridViewTextBoxColumn guidCol;
        private DataGridViewTextBoxColumn numCol;
        private DataGridViewTextBoxColumn employeeCol;
        private DataGridViewTextBoxColumn ChekDateCol;
        private DataGridViewTextBoxColumn CheckResCol;
        private DataGridViewTextBoxColumn NextChDateCol;
        private DataGridViewTextBoxColumn createdByCol;
        private DataGridViewTextBoxColumn createdDateCol;
        private DataGridViewTextBoxColumn updatedByCol;
        private DataGridViewTextBoxColumn updatedDateCol;
        private DataGridViewButtonColumn deleteBtnCol;
        private TextBox TextBox3;
        private Label label4;
    }
}