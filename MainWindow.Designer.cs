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
            this.SuspendLayout();
            // 
            // profileBtn
            // 
            this.profileBtn.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.profileBtn.Location = new System.Drawing.Point(12, 12);
            this.profileBtn.Name = "profileBtn";
            this.profileBtn.Size = new System.Drawing.Size(200, 45);
            this.profileBtn.TabIndex = 0;
            this.profileBtn.Text = "Профиль";
            this.profileBtn.UseVisualStyleBackColor = true;
            this.profileBtn.Click += new System.EventHandler(this.profileBtn_Click);
            // 
            // timetableBtn
            // 
            this.timetableBtn.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timetableBtn.Location = new System.Drawing.Point(12, 63);
            this.timetableBtn.Name = "timetableBtn";
            this.timetableBtn.Size = new System.Drawing.Size(200, 45);
            this.timetableBtn.TabIndex = 1;
            this.timetableBtn.Text = "Графики работы";
            this.timetableBtn.UseVisualStyleBackColor = true;
            this.timetableBtn.Click += new System.EventHandler(this.timetableBtn_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 597);
            this.Controls.Add(this.timetableBtn);
            this.Controls.Add(this.profileBtn);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button profileBtn;
        private Button timetableBtn;
    }
}