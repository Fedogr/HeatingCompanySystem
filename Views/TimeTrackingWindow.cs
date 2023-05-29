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
    public partial class TimeTrackingWindow : Form
    {
        User mUser = null;
        MainWindow mainWindow = null;
        TimetrackingController controller = null;
        List<TimeTracking> structuresList = null;
        List<Employee> employees = null;
        EmployeeController empCtrl= null;
        public TimeTrackingWindow(User _user, MainWindow _form)
        {
            mainWindow = _form;
            mUser = _user;
            controller = new TimetrackingController();
            empCtrl = new EmployeeController();
            InitializeComponent();
        }

        private void TimeTrackingWindow_Load(object sender, EventArgs e)
        {
            UpdateForm();
            //UpdateFormTwo();
            switch (mUser.Role)
            {
                case "user":
                    dataStructureGV.Columns[11].Visible = false;
                    dataStructureGV.Columns[12].Visible = false;
                    groupBox3.Visible = false;
                    break;
            }

        }
        private void UpdateForm(string search = "", string field = "")
        {
            employees = empCtrl.GetAllEmployees(search);
            if (comboBox1.Items.Count > 0) { comboBox1.Items.Clear(); }
            if (employees != null)
            {
                foreach (var type in employees)
                {
                    comboBox1.Items.Add(type.LastName);
                }
                comboBox1.SelectedIndex = 0;
            }

            structuresList = controller.GetAllTimeTrackingsWithFilter(search, field);
            if (structuresList != null)
            {
                dataStructureGV.Rows.Clear();
                Employee pStat = null;
                for (int i = 0; i < structuresList.Count; i++)
                {
                    dataStructureGV.Rows.Add();
                    dataStructureGV[0, i].Value = structuresList[i].Id;
                    dataStructureGV[1, i].Value = i + 1;
                    dataStructureGV[2, i].Value = structuresList[i].TableNum;
                    dataStructureGV[3, i].Value = structuresList[i].EmployeeId;
                    dataStructureGV[4, i].Value = structuresList[i].EntryDate;
                    dataStructureGV[5, i].Value = structuresList[i].CurrentDate;
                    dataStructureGV[6, i].Value = structuresList[i].HoursWorked;
                    dataStructureGV[7, i].Value = structuresList[i].CreatedBy;
                    dataStructureGV[8, i].Value = structuresList[i].CreatedDate;
                    dataStructureGV[9, i].Value = structuresList[i].UpdatedBy;
                    dataStructureGV[10, i].Value = structuresList[i].UpdatedDate;
                    dataStructureGV[11, i].Value = "Сохранить";
                    dataStructureGV[12, i].Value = "Удалить";
                }
            }
        }

        private void ClearFilters()
        {
            commonSearchBox.Text = string.Empty;
            nameSearchBox.Text = string.Empty;
            squareSearchBox.Text = string.Empty;
        }

        private void clearFiltersBtn_Click(object sender, EventArgs e)
        {
            ClearFilters();

        }
        private void ValidateInputSymbols(KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == (char)ConsoleKey.Backspace || e.KeyChar == ','))
            {
                e.KeyChar = '\0';
            }
        }

        private void squareSearchBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateInputSymbols(e);
        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateInputSymbols(e);
        }
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            //ValidateInputSymbols(e);
        }
        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            ///ValidateInputSymbols(e);
        }
        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            //ValidateInputSymbols(e);
        }
        private void commonSearchBox_TextChanged(object sender, EventArgs e)
        {
            nameSearchBox.Text = string.Empty;
            squareSearchBox.Text = string.Empty;
            UpdateForm(commonSearchBox.Text, "common");
        }
        private void nameSearchBox_TextChanged(object sender, EventArgs e)
        {
            commonSearchBox.Text = string.Empty;
            squareSearchBox.Text = string.Empty;
            UpdateForm(nameSearchBox.Text, "TableNum");
        }
        private void squareSearchBox_TextChanged(object sender, EventArgs e)
        {
            commonSearchBox.Text = string.Empty;
            nameSearchBox.Text = string.Empty;
            UpdateForm(squareSearchBox.Text, "HoursWorked");
        }
        private bool SaveSingleStructure(DataGridViewCellEventArgs e)
        {
            bool result = false;

            Guid guid = (Guid)dataStructureGV[0, e.RowIndex].Value;
            int TableNum = Convert.ToInt32(dataStructureGV[2, e.RowIndex].Value);
            Guid EmployeeId = (Guid)dataStructureGV[3, e.RowIndex].Value;
            string EntryDate = dataStructureGV[4, e.RowIndex].Value.ToString();
            DateTime CurrentDate = Convert.ToDateTime(dataStructureGV[5, e.RowIndex].Value);
            int HoursWorked = Convert.ToInt32(dataStructureGV[6, e.RowIndex].Value);
            decimal square = Convert.ToDecimal(dataStructureGV[3, e.RowIndex].Value);

            if(controller.SaveSingleStructure(mUser.Login, guid, TableNum, EmployeeId, EntryDate, CurrentDate, HoursWorked ))
            {
                ClearFilters();
                UpdateForm();
                result = true;
            }

            return result;
        }
        private bool DeleteStructure(DataGridViewCellEventArgs e)
        {
            bool delete = false;

            Guid guid = (Guid)dataStructureGV[0, e.RowIndex].Value;

            if (controller.DeleteSingleStructure(guid))
            {
                ClearFilters();
                UpdateForm();
                delete = true;
            }

            return delete;
        }
        private void dataStructureGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 11)
            {
                if (SaveSingleStructure(e))
                {
                    MessageBox.Show("Данные успешно изменены!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Произошла ошибка при записи данных!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (e.ColumnIndex == 12)
            {
                string message = "Вы действительно хотите удалить Табель?";
                if (MessageBox.Show(message, "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (DeleteStructure(e))
                    {
                        MessageBox.Show("Табель был успешно удален.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Произошла ошибка при удалении данных!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void addStructureBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == String.Empty)
                {
                    throw new Exception("Необходимо заполнить поле \"Табельный номер\"!!");
                }

                if (comboBox1.Text == String.Empty)
                {
                    throw new Exception("Необходимо заполнить поле \"Номер сотрудника\"!!");
                }
                if (textBox3.Text == String.Empty)
                {
                    throw new Exception("Необходимо заполнить поле \"Начало работы\"!!");
                }
                if (textBox4.Text == String.Empty)
                {
                    throw new Exception("Необходимо заполнить поле \"Текущая дата\"!!");
                }
                if (textBox5.Text == String.Empty)
                {
                    throw new Exception("Необходимо заполнить поле \"Отработано часов\"!!");
                }

                Guid guid = Guid.Empty;
                foreach (var type in employees)
                {
                    if (type.LastName == comboBox1.SelectedItem.ToString())
                    {
                        guid = type.Id;
                    }
                }

                if (controller.AddNewStructure(mUser.Login, Convert.ToInt32(textBox1.Text), guid, textBox3.Text, Convert.ToDateTime(textBox4.Text), Convert.ToInt32(textBox5.Text)))
                {
                    ClearFilters();
                    UpdateForm();
                    textBox1.Text = String.Empty;
                    comboBox1.Text = String.Empty;
                    textBox3.Text = String.Empty;
                    textBox4.Text = String.Empty;
                    textBox5.Text = String.Empty;
                    MessageBox.Show("Новый табель успешно добавлен!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    throw new Exception("Не получилось добавить данные!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
