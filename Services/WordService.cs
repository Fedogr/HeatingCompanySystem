using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeatingCompanySystem.Datebase.Models;
using HeatingCompanySystem.Services.Interfaces;
using Novacode;

namespace HeatingCompanySystem.Services
{


    public class WordService : IDisposable
    {
        private StringBuilder GetPathForFile(string _fileName)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string guidCode = Guid.NewGuid().ToString();
            string shortDate = DateTime.Now.ToShortDateString();

            StringBuilder filePath = new StringBuilder();

            filePath.Append(path + "\\" + _fileName + "_" + shortDate + "_" + guidCode + ".docx");

            return filePath;
        }
        //public bool CreateDocEquipmentByTimeTracking(List<TimeTracking> _dict, string _nameEmployee = "")
        //{

        //    bool result = false;

        //    StringBuilder path = null;

        //    if (_nameEmployee == "")
        //    {
        //        path = this.GetPathForFile("Оборудование_по_сотруднику");
        //    }
        //    else
        //    {
        //        path = this.GetPathForFile(_nameEmployee + "_Оборудование");
        //    }

        //    try
        //    {
        //        if (_dict == null)
        //        {
        //            throw new Exception();
        //        }

        //        using (var document = DocX.Create(path.ToString()))
        //        {
        //            Employee employee = _dict.Keys.First();
        //            string empName = "ФИО сотрудника: " +
        //                employee.LastName + " " +
        //                employee.FirstName + " " +
        //                employee.MiddleName +
        //                ", персональный номер = " + employee.PersonnelNumber;

        //            document.InsertParagraph(empName);
        //            document.InsertParagraph("Список оборудования:");
        //            document.InsertParagraph();

        //            if (_dict.Values.Count > 0)
        //            {
        //                int idx = 0;

        //                var list = _dict.First().Value.ToList();
        //                foreach (var item in list)
        //                {
        //                    string strValue =
        //                        (idx + 1).ToString() + ". " + item.Name +
        //                        " (цена: " + Math.Round(item.Price, 2) +
        //                        "; инв. номер: " + item.InventoryNumber +
        //                        "; дата выпуска: " + item.DateOfRelease.ToShortDateString() + ").";
        //                    document.InsertParagraph(strValue);
        //                    document.InsertParagraph();
        //                    idx++;
        //                }
        //            }
        //            document.Save();
        //            result = true;
        //        }
        //    }
        //    catch
        //    {
        //        return false;
        //    }

        //    return result;
        //}


        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
    
}
