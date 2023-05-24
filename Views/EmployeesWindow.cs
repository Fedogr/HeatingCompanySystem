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

        //private void EmployeesWindow_Load(object sender, EventArgs e)
        //{
        //    UpdateForm();
        //    UpdateFormTwo();
        //    switch (mUser.Role)
        //    {
        //        case "user":
        //            tabControl1.TabPages.Remove(tabControl1.TabPages[1]);
        //            break;
        //    }
        //}
        //private void UpdateForm(string search = "", string field = "")
        //{
        //    switch (mUser.Role)
        //    {
        //        case "user":
        //            dataEmployeesGV.Columns[11].Visible = false;
        //            dataEmployeesGV.Columns[12].Visible = false;
        //            break;
        //    }
        //    dataEmployeesGV.Rows.Clear();

        //    this.employees = controller.GetEmployees(search, field);
        //    if (this.employees != null)
        //    {
        //        Timatabel ps = null;
        //        for (int i = 0; i < this.employees.Count; i++)
        //        {
        //            dataEmployeesGV.Rows.Add();
        //            dataEmployeesGV[0, i].Value = i + 1;
        //            dataEmployeesGV[1, i].Value = employees[i].PersonnelNumber;
        //            dataEmployeesGV[2, i].Value = employees[i].LastName;
        //            dataEmployeesGV[3, i].Value = employees[i].FirstName;
        //            dataEmployeesGV[4, i].Value = employees[i].MiddleName;

        //            dataEmployeesGV[5, i].Value = GetImageFromUrl(employees[i].PhotoUrl);

        //            ps = psCtrl.GetSingleTimatabel(employees[i].PetrolStationId);

        //            //dataEmployeesGV[6, i].Value = employees[i].PetrolStationId;
        //            dataEmployeesGV[6, i].Value = "Номер АЗС: " + ps.NumberStation + "\n, " + ps.Location;
        //            dataEmployeesGV[7, i].Value = employees[i].CreatedBy;
        //            dataEmployeesGV[8, i].Value = employees[i].CreatedDate.ToString();
        //            dataEmployeesGV[9, i].Value = employees[i].UpdatedBy;
        //            dataEmployeesGV[10, i].Value = employees[i].UpdatedDate.ToString();
        //            dataEmployeesGV[11, i].Value = "Сохранить";
        //            dataEmployeesGV[12, i].Value = "Удалить";
        //            dataEmployeesGV[13, i].Value = employees[i].Id;
        //        }
        //    }
        //}

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

        //private void UpdateForm(string search = "", string field = "")
        //{
        //    switch (mUser.Role)
        //    {
        //        case "user":
        //            dataEmployeesGV.Columns[11].Visible = false;
        //            dataEmployeesGV.Columns[12].Visible = false;
        //            break;
        //    }
        //    dataEmployeesGV.Rows.Clear();

        //    this.employees = controller.GetEmployees(search, field);
        //    if (this.employees != null)
        //    {
        //        PetrolStation ps = null;
        //        for (int i = 0; i < this.employees.Count; i++)
        //        {
        //            dataEmployeesGV.Rows.Add();
        //            dataEmployeesGV[0, i].Value = i + 1;
        //            dataEmployeesGV[1, i].Value = employees[i].PersonnelNumber;
        //            dataEmployeesGV[2, i].Value = employees[i].LastName;
        //            dataEmployeesGV[3, i].Value = employees[i].FirstName;
        //            dataEmployeesGV[4, i].Value = employees[i].MiddleName;

        //            dataEmployeesGV[5, i].Value = GetImageFromUrl(employees[i].PhotoUrl);

        //            ps = psCtrl.GetSinglePStation(employees[i].BrigadeId);

        //            //dataEmployeesGV[6, i].Value = employees[i].PetrolStationId;
        //            dataEmployeesGV[6, i].Value = "Номер АЗС: " + ps.NumberStation + "\n, " + ps.Location;
        //            dataEmployeesGV[7, i].Value = employees[i].CreatedBy;
        //            dataEmployeesGV[8, i].Value = employees[i].CreatedDate.ToString();
        //            dataEmployeesGV[9, i].Value = employees[i].UpdatedBy;
        //            dataEmployeesGV[10, i].Value = employees[i].UpdatedDate.ToString();
        //            dataEmployeesGV[11, i].Value = "Сохранить";
        //            dataEmployeesGV[12, i].Value = "Удалить";
        //            dataEmployeesGV[13, i].Value = employees[i].Id;
        //        }
        //    }
        //}

    }
}
