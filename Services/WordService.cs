using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeatingCompanySystem.Controlers;
using HeatingCompanySystem.Datebase.Models;
using HeatingCompanySystem.Services.Interfaces;
using Novacode;

namespace HeatingCompanySystem.Services;

public class WordService : IDisposable
{
    EmployeeController empCtrl = null;
    TimetrackingController controller = null;

    public WordService()
    {
        controller = new TimetrackingController();
        empCtrl = new EmployeeController();
    }

    public void Dispose()
    {
    }

    private StringBuilder GetPathForFile(string _fileName)
    {
        string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        string guidCode = Guid.NewGuid().ToString();
        string shortDate = DateTime.Now.ToShortDateString();

        StringBuilder filePath = new StringBuilder();

        filePath.Append(path + "\\" + _fileName + "_" + shortDate + "_" + guidCode + ".docx");

        return filePath;
    }

    public bool CreateDocEquipmentByEmployee()
    {
        bool result = false;

        StringBuilder path = null;

        path = this.GetPathForFile("WordExport");


        try
        {
            var emps = empCtrl.GetAllEmployees();
            var empsExport = new List<EmployeeExport>();
            foreach ( var emp in emps )
            {
                var timeTrackings = controller.GetAllTimeTrackingsWithFilter();
                
                var timesExport = new List<TimeTrackingExport>();

                foreach( var item in timeTrackings)
                {
                    if(item.EmployeeId == emp.Id)
                    {
                        timesExport.Add(new TimeTrackingExport(item.TableNum, item.EntryDate, item.CurrentDate, item.HoursWorked));
                    }
                }

                empsExport.Add(new EmployeeExport(emp.PersonnelNumber, emp.LastName, emp.FirstName, emp.MiddleName, emp.BirthDate, emp.JobTitle, emp.Qual, timesExport));
            }

            using (var document = DocX.Create(path.ToString()))
            {
                foreach ( var item in empsExport)
                {
                    string empName = "ФИО сотрудника: " +
                    item.LastName + " " +
                    item.FirstName + " " +
                    item.MiddleName +
                    ", персональный номер = " + item.PersonnelNumber;

                    document.InsertParagraph(empName);
                    document.InsertParagraph("Birth: " + item.BirthDate);
                    document.InsertParagraph("JobTitle: " + item.JobTitle);
                    document.InsertParagraph("Qual: " + item.Qual);
                    document.InsertParagraph("---------------------");
                    document.InsertParagraph();

                    foreach(var time in item.TimeTrackingExport)
                    {
                        document.InsertParagraph("TableNum: " + time.TableNum);
                        document.InsertParagraph("EntryDate: " + time.EntryDate);
                        document.InsertParagraph("CurrentDate: " + time.CurrentDate.ToString());
                        document.InsertParagraph("HoursWorked: " + time.HoursWorked.ToString());
                        document.InsertParagraph();
                    }

                    document.InsertParagraph("#######################################################");
                    document.InsertParagraph("#######################################################");
                    document.InsertParagraph();
                    document.InsertParagraph();
                }

                document.Save();
                result = true;
            }
        }
        catch
        {
            return false;
        }

        return result;
    }
}

public class EmployeeExport
{
    public EmployeeExport(
        int personnelNumber,
        string lastName,
        string firstName,
        string middleName,
        string birthDate,
        string jobTitle,
        string qual,
        List<TimeTrackingExport> timeTrackingExport
        )
    {
        PersonnelNumber = personnelNumber;
        LastName = lastName;
        FirstName = firstName;
        MiddleName = middleName;
        BirthDate = birthDate;
        JobTitle = jobTitle;
        Qual = qual;
        TimeTrackingExport = timeTrackingExport;
    }

    public int PersonnelNumber { get; set; } 
    public string LastName { get; set; }
    public string FirstName { get; set; }
    public string MiddleName { get; set; }
    public string BirthDate { get; set; }
    public string JobTitle { get; set; }
    public string Qual { get; set; }

    public List<TimeTrackingExport> TimeTrackingExport { get; set; } = new List<TimeTrackingExport>();
}

public class TimeTrackingExport
{
    public TimeTrackingExport(int tableNum, string entryDate, DateTime currentDate, int hoursWorked)
    {
        TableNum = tableNum;
        EntryDate = entryDate;
        CurrentDate = currentDate;
        HoursWorked = hoursWorked;
    }

    public int TableNum { get; set; }
    public string EntryDate { get; set; }
    public DateTime CurrentDate { get; set; }
    public int HoursWorked { get; set; }
}