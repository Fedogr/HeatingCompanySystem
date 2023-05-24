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
    public partial class TimatabelWindow : Form
    {

        User mUser = null;
        MainWindow mainWindows = null;
        TimatabelController psTypeCtrl;
        List<Timatabel> listTypes = null;
        public TimatabelWindow(User _user, MainWindow _form)
        {
            mUser = _user;
            mainWindows = _form;
            psTypeCtrl = new TimatabelController();
            InitializeComponent();
        }
        private void UpdateForm(string search = "", string field = "")
        {
            typeDataGV.Rows.Clear(); // Очистить таблицу

            this.listTypes = psTypeCtrl.GetAllTypes(search, field);
            if (this.listTypes != null)
            {
                for (int i = 0; i < this.listTypes.Count; i++)
                {
                    typeDataGV.Rows.Add();
                    typeDataGV[0, i].Value = i + 1;
                    typeDataGV[1, i].Value = this.listTypes[i].TimetableType;
                    typeDataGV[2, i].Value = this.listTypes[i].CreatedBy;
                    typeDataGV[3, i].Value = this.listTypes[i].CreatedDate.ToString();
                    typeDataGV[4, i].Value = this.listTypes[i].UpdatedBy;
                    typeDataGV[5, i].Value = this.listTypes[i].UpdatedDate.ToString();
                    typeDataGV[6, i].Value = this.listTypes[i].Id;
                    typeDataGV[7, i].Value = "Сохранить";
                    typeDataGV[8, i].Value = "Удалить";
                }
            }
        }

        private void TimatabelWindow_Load(object sender, EventArgs e)
        {
            UpdateForm();
        }
        private void ClearsFilters()
        {
            commonSearchBox.Text = "";
            typeNameSearchBox.Text = "";
            changeByBox.Text = "";
        }
        private void clearFiltersBtn_Click(object sender, EventArgs e)
        {
            ClearsFilters();
        }

        private void commonSearchBox_TextChanged(object sender, EventArgs e)
        {
            typeNameSearchBox.Text = "";
            changeByBox.Text = "";
            UpdateForm(commonSearchBox.Text, "common");
        }

        private void typeNameSearchBox_TextChanged(object sender, EventArgs e)
        {
            commonSearchBox.Text = "";
            changeByBox.Text = "";
            UpdateForm(typeNameSearchBox.Text, "typename");
        }

        private void changeByBox_TextChanged(object sender, EventArgs e)
        {
            commonSearchBox.Text = "";
            typeNameSearchBox.Text = "";
            UpdateForm(changeByBox.Text, "userBy");
        }

        private bool SaveDataGVChanges(DataGridViewCellEventArgs e)
        {
            bool result = false;

            Guid _guid = (Guid)typeDataGV[6, e.RowIndex].Value;
            string _typeName = (string)typeDataGV[1, e.RowIndex].Value;
            string _user = mUser.Login;

            if (psTypeCtrl.SaveChangesSingleType(_guid, _typeName, _user))
            {
                ClearsFilters();
                UpdateForm();
                result = true;
            }

            return result;
        }

        private bool DeleteSingleType(DataGridViewCellEventArgs e)
        {
            bool delete = false;

            Guid _guid = (Guid)typeDataGV[6, e.RowIndex].Value;
            if (psTypeCtrl.DeleteSingleType(_guid))
            {
                ClearsFilters();
                UpdateForm();
                delete = true;
            }

            return delete;
        }

        private void typeDataGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7)
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
            else if (e.ColumnIndex == 8)
            {
                string message = "Вы действительно хотите удалить тип?";
                if (MessageBox.Show(message, "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (DeleteSingleType(e))
                    {
                        MessageBox.Show("Тип графика успешно удален!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Произошла ошибка при удалении данных!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void addNewTypeBtn_Click(object sender, EventArgs e)
        {
            if (psTypeCtrl.AddSingleType(addTypeBox.Text, mUser.Login))
            {
                MessageBox.Show("Новый тип успешно добавлен!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearsFilters();
                UpdateForm();
                addTypeBox.Text = "";
            }
            else
            {
                MessageBox.Show("Произошла ошибка при добавлении новых данных!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
