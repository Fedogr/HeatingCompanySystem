namespace HeatingCompanySystem.Views
{
    partial class ProfileWindow
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
            this.saveBtn = new System.Windows.Forms.Button();
            this.anotherUsersBtn = new System.Windows.Forms.Button();
            this.updatedDateBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.updatedByBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.createdDateBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.createdByBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.roleBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.passBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.loginBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.saveBtn.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.saveBtn.Location = new System.Drawing.Point(595, 275);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(190, 73);
            this.saveBtn.TabIndex = 14;
            this.saveBtn.Text = "Сохранить";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // anotherUsersBtn
            // 
            this.anotherUsersBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.anotherUsersBtn.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.anotherUsersBtn.Location = new System.Drawing.Point(12, 275);
            this.anotherUsersBtn.Name = "anotherUsersBtn";
            this.anotherUsersBtn.Size = new System.Drawing.Size(190, 73);
            this.anotherUsersBtn.TabIndex = 12;
            this.anotherUsersBtn.Text = "Список пользователей";
            this.anotherUsersBtn.UseVisualStyleBackColor = false;
            this.anotherUsersBtn.Click += new System.EventHandler(this.anotherUsersBtn_Click);
            // 
            // updatedDateBox
            // 
            this.updatedDateBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.updatedDateBox.Location = new System.Drawing.Point(628, 207);
            this.updatedDateBox.Name = "updatedDateBox";
            this.updatedDateBox.ReadOnly = true;
            this.updatedDateBox.Size = new System.Drawing.Size(157, 34);
            this.updatedDateBox.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(409, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(192, 24);
            this.label7.TabIndex = 5;
            this.label7.Text = "Время обновления:";
            // 
            // updatedByBox
            // 
            this.updatedByBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.updatedByBox.Location = new System.Drawing.Point(202, 207);
            this.updatedByBox.Name = "updatedByBox";
            this.updatedByBox.ReadOnly = true;
            this.updatedByBox.Size = new System.Drawing.Size(157, 34);
            this.updatedByBox.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(18, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 24);
            this.label6.TabIndex = 6;
            this.label6.Text = "Обновлен п-лем:";
            // 
            // createdDateBox
            // 
            this.createdDateBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createdDateBox.Location = new System.Drawing.Point(628, 136);
            this.createdDateBox.Name = "createdDateBox";
            this.createdDateBox.ReadOnly = true;
            this.createdDateBox.Size = new System.Drawing.Size(157, 34);
            this.createdDateBox.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(409, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Когда создан:";
            // 
            // createdByBox
            // 
            this.createdByBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createdByBox.Location = new System.Drawing.Point(202, 141);
            this.createdByBox.Name = "createdByBox";
            this.createdByBox.ReadOnly = true;
            this.createdByBox.Size = new System.Drawing.Size(157, 34);
            this.createdByBox.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(19, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Кем создан:";
            // 
            // roleBox
            // 
            this.roleBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.roleBox.Location = new System.Drawing.Point(202, 74);
            this.roleBox.Name = "roleBox";
            this.roleBox.ReadOnly = true;
            this.roleBox.Size = new System.Drawing.Size(583, 34);
            this.roleBox.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(19, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Статус:";
            // 
            // passBox
            // 
            this.passBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passBox.Location = new System.Drawing.Point(628, 14);
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(157, 34);
            this.passBox.TabIndex = 13;
            this.passBox.TextChanged += new System.EventHandler(this.passBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(413, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Пароль:";
            // 
            // loginBox
            // 
            this.loginBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loginBox.Location = new System.Drawing.Point(202, 16);
            this.loginBox.Name = "loginBox";
            this.loginBox.ReadOnly = true;
            this.loginBox.Size = new System.Drawing.Size(157, 34);
            this.loginBox.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(18, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Логин:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ProfileWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 363);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.anotherUsersBtn);
            this.Controls.Add(this.updatedDateBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.updatedByBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.createdDateBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.createdByBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.roleBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.passBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.loginBox);
            this.Controls.Add(this.label1);
            this.Name = "ProfileWindow";
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.ProfileWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button saveBtn;
        private Button anotherUsersBtn;
        private TextBox updatedDateBox;
        private Label label7;
        private TextBox updatedByBox;
        private Label label6;
        private TextBox createdDateBox;
        private Label label5;
        private TextBox createdByBox;
        private Label label4;
        private TextBox roleBox;
        private Label label3;
        private TextBox passBox;
        private Label label2;
        private TextBox loginBox;
        private Label label1;
    }
}