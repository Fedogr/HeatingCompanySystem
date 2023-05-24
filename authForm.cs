using HeatingCompanySystem.Controlers;
using HeatingCompanySystem.Datebase.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeatingCompanySystem
{
    public partial class authForm : Form
    {
        AuthorizationController authCtrl;
        public authForm()
        {
            authCtrl = new AuthorizationController();
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (loginBox.Text != "")
            {
                if (passBox.Text != "")
                {
                    User myUser = authCtrl.AuthToApp(loginBox.Text, passBox.Text);
                    if (myUser != null)
                    {
                        myUser.Password = passBox.Text;
                        this.Hide();
                        MainWindow mainWindow = new MainWindow(myUser, this);
                        mainWindow.Show();
                    }
                    else
                    {
                        MessageBox.Show("Ошибка!! Неверные данные!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Пароль не может быть пустым!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Логин не может быть пустым!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
