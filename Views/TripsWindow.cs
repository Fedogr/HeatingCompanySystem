using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HeatingCompanySystem.Datebase;
using HeatingCompanySystem.Datebase.Models;
using HeatingCompanySystem.Controlers;

namespace HeatingCompanySystem.Views
{
    public partial class TripsWindow : Form
    {
        User mUser = null;
        MainWindow mainWindow = null;
        TripsController tripCtrl = null;
        EmployeeController empCtrl = null;

        List<Trips> mainItems = null;
        List<Employee> empItems = null;
        public TripsWindow(User _user, MainWindow _form)
        {
            mUser = _user;
            mainWindow = _form;
            tripCtrl = new TripsController();
            empCtrl = new EmployeeController();
            InitializeComponent();
        }
        private void UpdateForm()
        {
            mainItems = tripCtrl.GetAllTrips();
            if (mainItems != null)
            {
                dataMatLiabGV.Rows.Clear();
                for (int i = 0; i < mainItems.Count; i++)
                {
                    dataMatLiabGV.Rows.Add();
                    dataMatLiabGV[0, i].Value = mainItems[i].Id;
                    dataMatLiabGV[1, i].Value = i + 1;

                    Employee emp;
                    if ((emp = empCtrl.GetSingleEmployeeById(mainItems[i].EmployeeId)) != null)
                    {
                        dataMatLiabGV[2, i].Value = emp.PersonnelNumber + " -- " + emp.LastName + " " + emp.FirstName[0] + "." + emp.MiddleName[0] + ".";
                    }
                    else
                    {
                        dataMatLiabGV[2, i].Value = "Не найдено";
                    }

                    dataMatLiabGV[3, i].Value = mainItems[i].VisitDate;
                    dataMatLiabGV[4, i].Value = mainItems[i].RepairType;
                    dataMatLiabGV[5, i].Value = mainItems[i].Result;
                    dataMatLiabGV[6, i].Value = mainItems[i].CreatedBy;
                    dataMatLiabGV[7, i].Value = mainItems[i].CreatedDate.ToString();
                    dataMatLiabGV[8, i].Value = mainItems[i].UpdatedBy;
                    dataMatLiabGV[9, i].Value = mainItems[i].UpdatedDate.ToString();
                    dataMatLiabGV[10, i].Value = "Удалить";
                }
            }
        }
        private void UpdateEmployeeCmbBox()
        {
            empItems = empCtrl.GetAllEmployees();
            if (empItems != null)
            {
                chooseEmployeeCmbBox.Items.Clear();
                foreach (var item in empItems)
                {
                    chooseEmployeeCmbBox.Items.Add(item.PersonnelNumber + "; " + item.LastName + " " + item.FirstName[0] + "." + item.MiddleName[0] + ".");
                }
                chooseEmployeeCmbBox.SelectedIndex = 0;
            }
        }

        private void TripsWindow_Load(object sender, EventArgs e)
        {
            UpdateForm();
            UpdateEmployeeCmbBox();
            switch (mUser.Role)
            {
                case "user":
                    groupBox2.Visible = false;
                    dataMatLiabGV.Columns[9].Visible = false;
                    break;
            }
        }

        private void addNewTripBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Trips _matLiab = new Trips();
                _matLiab.VisitDate = TextBox1.Text;
                _matLiab.RepairType = TextBox2.Text;

                if (string.IsNullOrEmpty(TextBox3.Text))
                {
                    throw new Exception("Необходимо заполнить поле \"Исход\"!!");
                }

                // Преобразовываем значение из строки в тип bool

                bool resultValue;
                if (!bool.TryParse(TextBox3.Text, out resultValue))
                {
                    throw new Exception("Некорректное значение для \"Исход\"!!");
                }

                _matLiab.Result = resultValue;
                string[] arrEmp = chooseEmployeeCmbBox.SelectedItem.ToString().Split(';');
                foreach (var item in empItems)
                {
                    if (item.PersonnelNumber.ToString() == arrEmp[0])
                    {
                        _matLiab.EmployeeId = item.Id;
                        break;
                    }
                }

                if (TextBox1.Text == String.Empty)
                {
                    throw new Exception("Необходимо заполнить поле \"Дата выезда\"!!");
                }
                if (TextBox2.Text == String.Empty)
                {
                    throw new Exception("Необходимо заполнить поле \"Тип ремонта\"!!");
                }
                

                if (tripCtrl.AddNewTrips(mUser.Login, _matLiab))
                {
                    MessageBox.Show("Новые данные успешно добавлены!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdateForm();
                }
                else
                {
                    MessageBox.Show("Не удалось добавить данные!!", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool DeleteTrips(DataGridViewCellEventArgs e)
        {
            bool result = false;

            Guid _guid = (Guid)dataMatLiabGV[0, e.RowIndex].Value;
            if (tripCtrl.DeleteTrips(_guid))
            {
                UpdateForm();
                UpdateEmployeeCmbBox();
                result = true;
            }

            return result;
        }
        private void dataMatLiabGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 10)
            {
                string message = "Вы действительно хотите удалить строку?";
                if (MessageBox.Show(message, "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (DeleteTrips(e))
                    {
                        MessageBox.Show("Строка была успешно удалена.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Произошла ошибка при удалении данных!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

       
    }
}
