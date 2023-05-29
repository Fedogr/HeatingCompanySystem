namespace HeatingCompanySystem
{
    partial class MainWindow
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
            this.profileBtn = new System.Windows.Forms.Button();
            this.timetableBtn = new System.Windows.Forms.Button();
            this.EmployeesBtn = new System.Windows.Forms.Button();
            this.TimeTrBtn = new System.Windows.Forms.Button();
            this.VioBtn = new System.Windows.Forms.Button();
            this.TripsBtn = new System.Windows.Forms.Button();
            this.TechbezBtn = new System.Windows.Forms.Button();
            this.exportToWordBtn = new System.Windows.Forms.Button();
            this.backupDbBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // profileBtn
            // 
            this.profileBtn.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.profileBtn.Location = new System.Drawing.Point(12, 12);
            this.profileBtn.Name = "profileBtn";
            this.profileBtn.Size = new System.Drawing.Size(200, 60);
            this.profileBtn.TabIndex = 0;
            this.profileBtn.Text = "Профиль";
            this.profileBtn.UseVisualStyleBackColor = true;
            this.profileBtn.Click += new System.EventHandler(this.profileBtn_Click);
            // 
            // timetableBtn
            // 
            this.timetableBtn.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timetableBtn.Location = new System.Drawing.Point(12, 78);
            this.timetableBtn.Name = "timetableBtn";
            this.timetableBtn.Size = new System.Drawing.Size(200, 60);
            this.timetableBtn.TabIndex = 1;
            this.timetableBtn.Text = "Графики работы";
            this.timetableBtn.UseVisualStyleBackColor = true;
            this.timetableBtn.Click += new System.EventHandler(this.timetableBtn_Click);
            // 
            // EmployeesBtn
            // 
            this.EmployeesBtn.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmployeesBtn.Location = new System.Drawing.Point(12, 144);
            this.EmployeesBtn.Name = "EmployeesBtn";
            this.EmployeesBtn.Size = new System.Drawing.Size(200, 60);
            this.EmployeesBtn.TabIndex = 2;
            this.EmployeesBtn.Text = "Сотрудники";
            this.EmployeesBtn.UseVisualStyleBackColor = true;
            this.EmployeesBtn.Click += new System.EventHandler(this.EmployeesBtn_Click);
            // 
            // TimeTrBtn
            // 
            this.TimeTrBtn.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TimeTrBtn.Location = new System.Drawing.Point(111, 210);
            this.TimeTrBtn.Name = "TimeTrBtn";
            this.TimeTrBtn.Size = new System.Drawing.Size(200, 60);
            this.TimeTrBtn.TabIndex = 3;
            this.TimeTrBtn.Text = "Учет рабочего времени";
            this.TimeTrBtn.UseVisualStyleBackColor = true;
            this.TimeTrBtn.Click += new System.EventHandler(this.TimeTrBtn_Click);
            // 
            // VioBtn
            // 
            this.VioBtn.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VioBtn.Location = new System.Drawing.Point(218, 12);
            this.VioBtn.Name = "VioBtn";
            this.VioBtn.Size = new System.Drawing.Size(200, 60);
            this.VioBtn.TabIndex = 4;
            this.VioBtn.Text = "Нарушения";
            this.VioBtn.UseVisualStyleBackColor = true;
            this.VioBtn.Click += new System.EventHandler(this.VioBtn_Click);
            // 
            // TripsBtn
            // 
            this.TripsBtn.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TripsBtn.Location = new System.Drawing.Point(218, 78);
            this.TripsBtn.Name = "TripsBtn";
            this.TripsBtn.Size = new System.Drawing.Size(200, 60);
            this.TripsBtn.TabIndex = 5;
            this.TripsBtn.Text = "Выезды";
            this.TripsBtn.UseVisualStyleBackColor = true;
            this.TripsBtn.Click += new System.EventHandler(this.TripsBtn_Click);
            // 
            // TechbezBtn
            // 
            this.TechbezBtn.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TechbezBtn.Location = new System.Drawing.Point(218, 144);
            this.TechbezBtn.Name = "TechbezBtn";
            this.TechbezBtn.Size = new System.Drawing.Size(200, 60);
            this.TechbezBtn.TabIndex = 6;
            this.TechbezBtn.Text = "Контроль ТБ";
            this.TechbezBtn.UseVisualStyleBackColor = true;
            this.TechbezBtn.Click += new System.EventHandler(this.TechbezBtn_Click);
            // 
            // exportToWordBtn
            // 
            this.exportToWordBtn.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exportToWordBtn.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.exportToWordBtn.Location = new System.Drawing.Point(12, 329);
            this.exportToWordBtn.Name = "exportToWordBtn";
            this.exportToWordBtn.Size = new System.Drawing.Size(200, 94);
            this.exportToWordBtn.TabIndex = 7;
            this.exportToWordBtn.Text = "Экспорт в MSWord";
            this.exportToWordBtn.UseVisualStyleBackColor = true;
            this.exportToWordBtn.Click += new System.EventHandler(this.exportToWordBtn_Click);
            // 
            // backupDbBtn
            // 
            this.backupDbBtn.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backupDbBtn.ForeColor = System.Drawing.Color.OrangeRed;
            this.backupDbBtn.Location = new System.Drawing.Point(218, 329);
            this.backupDbBtn.Name = "backupDbBtn";
            this.backupDbBtn.Size = new System.Drawing.Size(200, 94);
            this.backupDbBtn.TabIndex = 8;
            this.backupDbBtn.Text = "Резервное копирование базы данных";
            this.backupDbBtn.UseVisualStyleBackColor = true;
            this.backupDbBtn.Click += new System.EventHandler(this.backupDbBtn_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 470);
            this.Controls.Add(this.backupDbBtn);
            this.Controls.Add(this.exportToWordBtn);
            this.Controls.Add(this.TechbezBtn);
            this.Controls.Add(this.TripsBtn);
            this.Controls.Add(this.VioBtn);
            this.Controls.Add(this.TimeTrBtn);
            this.Controls.Add(this.EmployeesBtn);
            this.Controls.Add(this.timetableBtn);
            this.Controls.Add(this.profileBtn);
            this.Name = "MainWindow";
            this.Text = "Главная";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private Button profileBtn;
        private Button timetableBtn;
        private Button EmployeesBtn;
        private Button TimeTrBtn;
        private Button VioBtn;
        private Button TripsBtn;
        private Button TechbezBtn;
        private Button exportToWordBtn;
        private Button backupDbBtn;
    }
}