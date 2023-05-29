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
                    TechbezBtn.Visible = false;
                    TimeTrBtn.Visible = false;
                    VioBtn.Visible = false;
                    backupDbBtn.Visible = false;
                    break;
            }
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            string message = "Вы уверены, что хотите выйти?";
            if (MessageBox.Show(message, "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                if (aForm != null)
                {
                    aForm.Show();
                }
                this.Dispose();
            }
            else
            {
                e.Cancel = true;
            }
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

        private void EmployeesBtn_Click(object sender, EventArgs e)
        {
            try
            {
                EmployeesWindow employeesWindow = new EmployeesWindow(mUser, this);
                employeesWindow.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TimeTrBtn_Click(object sender, EventArgs e)
        {
            try
            {
                TimeTrackingWindow timetrWindow = new TimeTrackingWindow(mUser, this);
                timetrWindow.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void VioBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ViolationsWindow violationsWindow = new ViolationsWindow(mUser, this);
                violationsWindow.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TechbezBtn_Click(object sender, EventArgs e)
        {
            try
            {
                TechbezWindow techbezWindow = new TechbezWindow(mUser, this);
                techbezWindow.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TripsBtn_Click(object sender, EventArgs e)
        {
            try
            {
                TripsWindow tripsWindow = new TripsWindow(mUser, this);
                tripsWindow.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void backupDbBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (BackupDatabase backupMySqlDatabase = new BackupDatabase())
                {

                    if (backupMySqlDatabase.BackupSQLiteDbToDesktop())
                    {
                        MessageBox.Show("Бэкап БД успешно сделан. Файл на рабочем столе.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Не получилось создать бэкап!!", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void exportToWordBtn_Click(object sender, EventArgs e)
        {
            using(WordService wordService = new WordService())
            {
                if(wordService.CreateDocEquipmentByEmployee())
                {
                    MessageBox.Show("Success!");
                } else
                {
                    MessageBox.Show("Error!");
                }
            }
        }
    }
}
