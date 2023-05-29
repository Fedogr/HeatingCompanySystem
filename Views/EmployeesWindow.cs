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
using System.Net;

namespace HeatingCompanySystem.Views
{
    public partial class EmployeesWindow : Form
    {
        User mUser = null;
        MainWindow mainWindow = null;
        EmployeeController controller = null;
        TimatabelController psCtrl = null;
        List<Employee> employees = null;
        List<Timatabel> psItems = null;
        string strDefaultUrl = "https://secure.gravatar.com/avatar/833c2d4165b70f183a27744cfc123396?s=100&d=mm&r=g";

        public EmployeesWindow(User _user, MainWindow _form)
        {
            mUser = _user;
            mainWindow = _form;
            controller = new EmployeeController();
            psCtrl = new TimatabelController();
            InitializeComponent();
        }

        private void EmployeesWindow_Load(object sender, EventArgs e)
        {
        }
        private void UpdateForm(string search = "", string field = "")
        {
            switch (mUser.Role)
            {
                case "user":
                    dataEmployeesGV.Columns[11].Visible = false;
                    dataEmployeesGV.Columns[12].Visible = false;
                    break;
            }
            dataEmployeesGV.Rows.Clear();

            this.employees = controller.GetAllEmployees(search, field);
            if (this.employees != null)
            {
                Timatabel ps = null;
                for (int i = 0; i < this.employees.Count; i++)
                {
                    dataEmployeesGV.Rows.Add();
                    dataEmployeesGV[0, i].Value = i + 1;
                    dataEmployeesGV[1, i].Value = employees[i].PersonnelNumber;
                    dataEmployeesGV[2, i].Value = employees[i].LastName;
                    dataEmployeesGV[3, i].Value = employees[i].FirstName;
                    dataEmployeesGV[4, i].Value = employees[i].MiddleName;
                    dataEmployeesGV[5, i].Value = employees[i].BirthDate;
                    dataEmployeesGV[6, i].Value = GetImageFromUrl(employees[i].PhotoUrl);
                    dataEmployeesGV[7, i].Value = employees[i].BrigadeId;

                    ps = psCtrl.GetSingleTimatabel(employees[i].TimatabelId);
                    dataEmployeesGV[8, i].Value = ps.TimetableType;
                    dataEmployeesGV[9, i].Value = employees[i].JobTitle;
                    dataEmployeesGV[10, i].Value = employees[i].Qual;

                    //dataEmployeesGV[6, i].Value = employees[i].PetrolStationId;
                    dataEmployeesGV[11, i].Value = employees[i].CreatedBy;
                    dataEmployeesGV[12, i].Value = employees[i].CreatedDate.ToString();
                    dataEmployeesGV[13, i].Value = employees[i].UpdatedBy;
                    dataEmployeesGV[14, i].Value = employees[i].UpdatedDate.ToString();
                    dataEmployeesGV[15, i].Value = "Сохранить";
                    dataEmployeesGV[16, i].Value = "Удалить";
                    dataEmployeesGV[17, i].Value = employees[i].Id;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearFilters();

        }
        private void ClearFilters()
        {
            commonSearchBox.Text = String.Empty;
            lastNameSearchBox.Text = String.Empty;
            firstNameSearchBox.Text = String.Empty;
            middleNameSearchBox.Text = String.Empty;
        }

        private Image GetImageFromUrl(string url)
        {
            try
            {
                HttpWebRequest httpWebRequest = (HttpWebRequest)HttpWebRequest.Create(url);
                using (HttpWebResponse httpWebReponse = (HttpWebResponse)httpWebRequest.GetResponse())
                {
                    using (Stream stream = httpWebReponse.GetResponseStream())
                    {
                        return Image.FromStream(stream);
                    }
                }
            }
            catch
            {
                return null;
            }
        }

        private void commonSearchBox_TextChanged(object sender, EventArgs e)
        {
            lastNameSearchBox.Text = string.Empty;
            firstNameSearchBox.Text = string.Empty;
            middleNameSearchBox.Text = string.Empty;
            UpdateForm(commonSearchBox.Text, "common");
        }

        private void lastNameSearchBox_TextChanged(object sender, EventArgs e)
        {
            commonSearchBox.Text = string.Empty;
            firstNameSearchBox.Text = string.Empty;
            middleNameSearchBox.Text = string.Empty;
            UpdateForm(lastNameSearchBox.Text, "lastname");
        }

        private void firstNameSearchBox_TextChanged(object sender, EventArgs e)
        {
            commonSearchBox.Text = string.Empty;
            lastNameSearchBox.Text = string.Empty;
            middleNameSearchBox.Text = string.Empty;
            UpdateForm(firstNameSearchBox.Text, "firstname");
        }

        private void middleNameSearchBox_TextChanged(object sender, EventArgs e)
        {
            commonSearchBox.Text = string.Empty;
            lastNameSearchBox.Text = string.Empty;
            firstNameSearchBox.Text = string.Empty;
            UpdateForm(middleNameSearchBox.Text, "middlename");
        }
        
        private bool SaveDataGVChanges(DataGridViewCellEventArgs e)
        {
            bool result = false;

            Guid guid = (Guid)dataEmployeesGV[17, e.RowIndex].Value;
            string lName = (string)dataEmployeesGV[2, e.RowIndex].Value;
            string fName = (string)dataEmployeesGV[3, e.RowIndex].Value;
            string mName = (string)dataEmployeesGV[4, e.RowIndex].Value;

            if (controller.SaveChangesSingleEmployee(guid, mUser.Login, lName, fName, mName))
            {
                ClearFilters();
                UpdateForm();
                result = true;
            }

            return result;
        }
        private bool DeleteDataGVChanges(DataGridViewCellEventArgs e)
        {
            bool result = false;

            Guid _guid = (Guid)dataEmployeesGV[17, e.RowIndex].Value;
            if (controller.DeleteSingleEmployee(_guid))
            {
                ClearFilters();
                UpdateForm();
                result = true;
            }

            return result;
        }
        //private void dataEmployeesGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
            
        //}
        private void urlDefaultRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (urlDefaultRadioBtn.Checked)
            {
                inputPhotoUrlBox.Enabled = false;
            }
            else
            {
                inputPhotoUrlBox.Enabled = true;
            }
        }
        private void UpdateFormTwo()
        {
            numEmployeeBox.Text = (controller.GetMaxNumEmployees() + 1).ToString();
            inputLNameBox.Text = String.Empty;
            inputFNameBox.Text = String.Empty;
            inputMNameBox.Text = String.Empty;
            inputPhotoUrlBox.Text = String.Empty;
            inputBdateBox.Text = String.Empty;
            inputBrBox.Text = String.Empty;
            inputJtBox.Text = String.Empty;
            inputQualBox.Text = String.Empty;


            psItems = psCtrl.GetAllTimatabels();

            if (psItems.Count > 0)
            {
                PetrolStationCmbBox.Items.Clear();
                var listSorted = psItems.OrderBy(p => p.TimetableType);
                foreach (var item in listSorted)
                {
                    PetrolStationCmbBox.Items.Add(item.TimetableType);
                }
                PetrolStationCmbBox.SelectedIndex = 0;
            }
        }

        private void addNewEmployeeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (inputLNameBox.Text == String.Empty)
                {
                    throw new Exception("Необходимо заполнить поле \"Фамилия\"!!");
                }

                if (inputFNameBox.Text == String.Empty)
                {
                    throw new Exception("Необходимо заполнить поле \"Имя\"!!");
                }

                if (inputMNameBox.Text == String.Empty)
                {
                    throw new Exception("Необходимо заполнить поле \"Отчество\"!!");
                }

                if (inputBdateBox.Text == String.Empty)
                {
                    throw new Exception("Необходимо заполнить поле \"Дата рождения\"!!");
                }
                if (inputBrBox.Text == String.Empty)
                {
                    throw new Exception("Необходимо заполнить поле \"Бригада\"!!");
                }
                if (inputJtBox.Text == String.Empty)
                {
                    throw new Exception("Необходимо заполнить поле \"Должность\"!!");
                }
                if (inputQualBox.Text == String.Empty)
                {
                    throw new Exception("Необходимо заполнить поле \"Квалификация\"!!");
                }



                Employee emp = new Employee();
                emp.PersonnelNumber = Convert.ToInt32(numEmployeeBox.Text);
                emp.LastName = inputLNameBox.Text;
                emp.FirstName = inputFNameBox.Text;
                emp.MiddleName = inputMNameBox.Text;
                emp.BirthDate = inputBdateBox.Text;
                emp.BrigadeId = inputBrBox.Text;
                emp.JobTitle = inputJtBox.Text;
                emp.Qual = inputQualBox.Text;

                if (urlDefaultRadioBtn.Checked)
                {
                    emp.PhotoUrl = strDefaultUrl;
                }
                else
                {
                    emp.PhotoUrl = inputPhotoUrlBox.Text;
                }

                string[] numStat = PetrolStationCmbBox.SelectedItem.ToString().Split(';');
                foreach (var item in psItems)
                {
                    if (item.TimetableType == (numStat[0]))
                    {
                        emp.TimatabelId = item.Id;
                    }
                }

                if (controller.AddSingleEmployee(mUser.Login, emp))
                {
                    MessageBox.Show("Новый сотрудник добавлен!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdateForm();
                    UpdateFormTwo();
                }
                else
                {
                    MessageBox.Show("Новый сотрудник не был добавлен!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }

        private void dataEmployeesGV_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 15)
            {
                if (SaveDataGVChanges(e))
                {
                    MessageBox.Show("Данные успешно изменены!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Произошла ошибка при записи данных!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (e.ColumnIndex == 16)
            {
                string message = "Вы действительно хотите удалить сотрудника?";
                if (MessageBox.Show(message, "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (DeleteDataGVChanges(e))
                    {
                        MessageBox.Show("Сотрудник был успешно удалён.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Произошла ошибка при удалении данных!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void EmployeesWindow_Load_1(object sender, EventArgs e)
        {
            UpdateForm();
            UpdateFormTwo();
            switch (mUser.Role)
            {
                case "user":
                    tabControl1.TabPages.Remove(tabControl1.TabPages[1]);
                    break;
            }

        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void inputBdateBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
