using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HeatingCompanySystem.Services;
using HeatingCompanySystem.Datebase;
using HeatingCompanySystem.Datebase.Models;
using HeatingCompanySystem.Controlers;
using HeatingCompanySystem.Views;
// 

namespace HeatingCompanySystem
{
    public partial class MainWindow : Form
    {
        User mUser = null;
        authForm aForm = null;


        public MainWindow(User _user, authForm _from)
        {
            mUser = _user;
            aForm = _from;
            InitializeComponent();
            switch (_user.Role)
            {
                case "user":
                    //видимость определенных кнопок
                    break;
            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void profileBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ProfileWindow profWindow = new ProfileWindow(mUser);
                profWindow.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void timetableBtn_Click(object sender, EventArgs e)
        {
            try
            {
                TimatabelWindow psTypeWindow = new TimatabelWindow(mUser, this);
                psTypeWindow.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
