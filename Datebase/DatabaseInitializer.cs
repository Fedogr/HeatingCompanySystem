using HeatingCompanySystem.Datebase.Models;
using HeatingCompanySystem.Services;


namespace HeatingCompanySystem.Datebase;
public interface IDatabaseInitializer
{
    void MySeed();
}

public class DatabaseInitializer
{

    private readonly MyContextDb _context;

    public DatabaseInitializer(MyContextDb context)
    {
        _context = context;
    }

    public void MySeed()
    {
        string str_ini_by = "Initializer";
        EncryptionText et = new EncryptionText();


        if (!_context.Timatabels.Any())
        {
            var items = new Timatabel[]
            {
                new Timatabel
                {
                    Id = Guid.NewGuid(),
                    TimetableType = "4h",
                    CreatedBy = str_ini_by,
                    UpdatedBy = str_ini_by,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now
                },
                new Timatabel
                {
                    Id = Guid.NewGuid(),
                    TimetableType = "8h",
                    CreatedBy = str_ini_by,
                    UpdatedBy = str_ini_by,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now
                },
                new Timatabel
                {
                    Id = Guid.NewGuid(),
                    TimetableType = "12h",
                    CreatedBy = str_ini_by,
                    UpdatedBy = str_ini_by,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now
                }
            };

            _context.Timatabels.AddRange(items);
            _context.SaveChanges();

        }
        if (!_context.Users.Any())
        {
            var items = new User[]
            {
                    new User {
                        Id = Guid.NewGuid(),
                        Login = "root",
                        Password = et.ComputeSha256Hash("root"),
                        Role = "root",
                        CreatedBy = str_ini_by,
                        UpdatedBy = str_ini_by,
                        CreatedDate = DateTime.Now,
                        UpdatedDate = DateTime.Now
                    },
                    new User
                    {
                        Id = Guid.NewGuid(),
                        Login = "admin",
                        Password = et.ComputeSha256Hash("admin"),
                        Role = "admin",
                        CreatedBy = str_ini_by,
                        UpdatedBy = str_ini_by,
                        CreatedDate = DateTime.Now,
                        UpdatedDate = DateTime.Now
                    },
                    new User
                    {
                        Id= Guid.NewGuid(),
                        Login = "user",
                        Password = et.ComputeSha256Hash("user"),
                        Role = "user",
                        CreatedBy = str_ini_by,
                        UpdatedBy = str_ini_by,
                        CreatedDate = DateTime.Now,
                        UpdatedDate = DateTime.Now
                    }
            };

            _context.Users.AddRange(items);
            _context.SaveChanges();
        }
        if (!_context.Employees.Any())
        {
            var ps = _context.Timatabels.ToList();
            string defaultUrl = "https://secure.gravatar.com/avatar/833c2d4165b70f183a27744cfc12023396?s=100&d=mm&r=g";
            var items = new Employee[]
            {
                new Employee
                {
                    Id = Guid.NewGuid(),
                    PersonnelNumber = 1,
                    LastName = "Александрова",
                    FirstName = "Екатерина",
                    MiddleName = "Витальевна",
                    BirthDate = "21.08.1978",
                    JobTitle= "Бригадир",
                    Qual= "Высшая квалификация",
                    PhotoUrl = defaultUrl,
                    BrigadeId= "1",
                    TimatabelId = ps.Find(p => p.TimetableType == "4h").Id,
                    CreatedBy = str_ini_by,
                    CreatedDate = DateTime.Now,
                    UpdatedBy = str_ini_by,
                    UpdatedDate = DateTime.Now
                },
                 new Employee
                {
                    Id = Guid.NewGuid(),
                    PersonnelNumber = 2,
                    LastName = "Смирнов",
                    FirstName = "Алексей",
                    MiddleName = "Игоревич",
                    BirthDate = "15.05.1978",
                    JobTitle= "Бригадир",
                    Qual= "Высшая квалификация",
                    PhotoUrl = defaultUrl,
                    BrigadeId= "2",
                    TimatabelId = ps.Find(p => p.TimetableType == "8h").Id,
                    CreatedBy = str_ini_by,
                    CreatedDate = DateTime.Now,
                    UpdatedBy = str_ini_by,
                    UpdatedDate = DateTime.Now
                },
                 new Employee
                 {
                    Id = Guid.NewGuid(),
                    PersonnelNumber = 3,
                    LastName = "Петрова",
                    FirstName = "Екатерина",
                    MiddleName = "Александровна",
                    BirthDate = "03.09.1990",
                    JobTitle= "Бригадир",
                    Qual= "Высшая квалификация",
                    PhotoUrl = defaultUrl,
                    BrigadeId= "3",
                    TimatabelId = ps.Find(p => p.TimetableType == "12h").Id,
                    CreatedBy = str_ini_by,
                    CreatedDate = DateTime.Now,
                    UpdatedBy = str_ini_by,
                    UpdatedDate = DateTime.Now
                 },
                 new Employee
                 {
                    Id = Guid.NewGuid(),
                    PersonnelNumber = 4,
                    LastName = "Козлов",
                    FirstName = "Андрей",
                    MiddleName = "Михайлович",
                    BirthDate = "12.11.1982",
                    JobTitle= "Водитель",
                    Qual= "Квалификация 1 класса",
                    PhotoUrl = defaultUrl,
                    BrigadeId= "1",
                    TimatabelId = ps.Find(p => p.TimetableType == "4h").Id,
                    CreatedBy = str_ini_by,
                    CreatedDate = DateTime.Now,
                    UpdatedBy = str_ini_by,
                    UpdatedDate = DateTime.Now
                 },
                 new Employee
                 {
                    Id = Guid.NewGuid(),
                    PersonnelNumber = 5,
                    LastName = "Сергеев",
                    FirstName = "Владимир",
                    MiddleName = "Владимирович",
                    BirthDate = "25.06.1975",
                    JobTitle= "Водитель",
                    Qual= "Квалификация 1 класса",
                    PhotoUrl = defaultUrl,
                    BrigadeId= "2",
                    TimatabelId = ps.Find(p => p.TimetableType == "8h").Id,
                    CreatedBy = str_ini_by,
                    CreatedDate = DateTime.Now,
                    UpdatedBy = str_ini_by,
                    UpdatedDate = DateTime.Now
                 },
                 new Employee
                 {
                    Id = Guid.NewGuid(),
                    PersonnelNumber = 6,
                    LastName = "Михайлова",
                    FirstName = "Оксана",
                    MiddleName = "Анатольевна",
                    BirthDate = "09.03.1992",
                    JobTitle= "Водитель",
                    Qual= "Квалификация 1 класса",
                    PhotoUrl = defaultUrl,
                    BrigadeId= "3",
                    TimatabelId = ps.Find(p => p.TimetableType == "12h").Id,
                    CreatedBy = str_ini_by,
                    CreatedDate = DateTime.Now,
                    UpdatedBy = str_ini_by,
                    UpdatedDate = DateTime.Now
                 },
                 new Employee
                 {
                    Id = Guid.NewGuid(),
                    PersonnelNumber = 7,
                    LastName = "Николаев",
                    FirstName = "Сергей",
                    MiddleName = "Александрович",
                    BirthDate = "18.08.1988",
                    JobTitle= "Аварийный инженер",
                    Qual= "Инженер 1 категории",
                    PhotoUrl = defaultUrl,
                    BrigadeId= "1",
                    TimatabelId = ps.Find(p => p.TimetableType == "4h").Id,
                    CreatedBy = str_ini_by,
                    CreatedDate = DateTime.Now,
                    UpdatedBy = str_ini_by,
                    UpdatedDate = DateTime.Now
                 },
                 new Employee
                 {
                    Id = Guid.NewGuid(),
                    PersonnelNumber = 8,
                    LastName = "Лебедева",
                    FirstName = "Мария",
                    MiddleName = "Дмитриевна",
                    BirthDate = "27.12.1994",
                    JobTitle= "Аварийный инженер",
                    Qual= "Инженер 1 категории",
                    PhotoUrl = defaultUrl,
                    BrigadeId= "2",
                    TimatabelId = ps.Find(p => p.TimetableType == "8h").Id,
                    CreatedBy = str_ini_by,
                    CreatedDate = DateTime.Now,
                    UpdatedBy = str_ini_by,
                    UpdatedDate = DateTime.Now
                 },
                 new Employee
                 {
                    Id = Guid.NewGuid(),
                    PersonnelNumber = 9,
                    LastName = "Григорьев",
                    FirstName = "Дмитрий",
                    MiddleName = "Игоревич",
                    BirthDate = "07.06.1980",
                    JobTitle= "Аварийный инженер",
                    Qual= "Инженер 1 категории",
                    PhotoUrl = defaultUrl,
                    BrigadeId= "3",
                    TimatabelId = ps.Find(p => p.TimetableType == "12h").Id,
                    CreatedBy = str_ini_by,
                    CreatedDate = DateTime.Now,
                    UpdatedBy = str_ini_by,
                    UpdatedDate = DateTime.Now
                 }

            };
            _context.Employees.AddRange(items);
            _context.SaveChanges();

        }
        if (!_context.Techbezs.Any())
        {
            var emps = _context.Employees.ToList();
            var items = new Techbez[]
              {
                    new Techbez
                    {
                        Id = Guid.NewGuid(),
                        EmployeeId = emps.Find(p => p.LastName == "Александрова").Id,
                        CheckDate = "26.03.2023",
                        CheckResult = "Сдал",
                        NextCheckDate = "26.03.2024",
                        CreatedBy = str_ini_by,
                        CreatedDate = DateTime.Now,
                        UpdatedBy = str_ini_by,
                        UpdatedDate = DateTime.Now
                    },
                    new Techbez
                    {
                        Id = Guid.NewGuid(),
                        EmployeeId = emps.Find(p => p.LastName == "Смирнов").Id,
                        CheckDate = "26.03.2023",
                        CheckResult = "Сдал",
                        NextCheckDate = "26.03.2024",
                        CreatedBy = str_ini_by,
                        CreatedDate = DateTime.Now,
                        UpdatedBy = str_ini_by,
                        UpdatedDate = DateTime.Now
                    },
                    new Techbez
                    {
                        Id = Guid.NewGuid(),
                        EmployeeId = emps.Find(p => p.LastName == "Петрова").Id,
                        CheckDate = "26.03.2023",
                        CheckResult = "Сдал",
                        NextCheckDate = "26.03.2024",
                        CreatedBy = str_ini_by,
                        CreatedDate = DateTime.Now,
                        UpdatedBy = str_ini_by,
                        UpdatedDate = DateTime.Now
                    },
                    new Techbez
                    {
                        Id = Guid.NewGuid(),
                        EmployeeId = emps.Find(p => p.LastName == "Козлов").Id,
                        CheckDate = "20.03.2023",
                        CheckResult = "Сдал",
                        NextCheckDate = "20.03.2024",
                        CreatedBy = str_ini_by,
                        CreatedDate = DateTime.Now,
                        UpdatedBy = str_ini_by,
                        UpdatedDate = DateTime.Now
                    },
                    new Techbez
                    {
                        Id = Guid.NewGuid(),
                        EmployeeId = emps.Find(p => p.LastName == "Сергеев").Id,
                        CheckDate = "20.03.2023",
                        CheckResult = "Сдал",
                        NextCheckDate = "20.03.2024",
                        CreatedBy = str_ini_by,
                        CreatedDate = DateTime.Now,
                        UpdatedBy = str_ini_by,
                        UpdatedDate = DateTime.Now
                    },
                    new Techbez
                    {
                        Id = Guid.NewGuid(),
                        EmployeeId = emps.Find(p => p.LastName == "Михайлова").Id,
                        CheckDate = "20.03.2023",
                        CheckResult = "Сдал",
                        NextCheckDate = "20.03.2024",
                        CreatedBy = str_ini_by,
                        CreatedDate = DateTime.Now,
                        UpdatedBy = str_ini_by,
                        UpdatedDate = DateTime.Now
                    },
                    new Techbez
                    {
                        Id = Guid.NewGuid(),
                        EmployeeId = emps.Find(p => p.LastName == "Николаев").Id,
                        CheckDate = "03.03.2023",
                        CheckResult = "Сдал",
                        NextCheckDate = "03.03.2024",
                        CreatedBy = str_ini_by,
                        CreatedDate = DateTime.Now,
                        UpdatedBy = str_ini_by,
                        UpdatedDate = DateTime.Now
                    },
                    new Techbez
                    {
                        Id = Guid.NewGuid(),
                        EmployeeId = emps.Find(p => p.LastName == "Лебедева").Id,
                        CheckDate = "03.03.2023",
                        CheckResult = "Сдал",
                        NextCheckDate = "03.03.2024",
                        CreatedBy = str_ini_by,
                        CreatedDate = DateTime.Now,
                        UpdatedBy = str_ini_by,
                        UpdatedDate = DateTime.Now
                    },
                    new Techbez
                    {
                        Id = Guid.NewGuid(),
                        EmployeeId = emps.Find(p => p.LastName == "Григорьев").Id,
                        CheckDate = "03.03.2023",
                        CheckResult = "Сдал",
                        NextCheckDate = "03.03.2024",
                        CreatedBy = str_ini_by,
                        CreatedDate = DateTime.Now,
                        UpdatedBy = str_ini_by,
                        UpdatedDate = DateTime.Now
                    },
              };
            _context.Techbezs.AddRange(items);
            _context.SaveChanges();

        }
        if (!_context.Violationss.Any())
        {
            var emps = _context.Employees.ToList();
            var items = new Violations[]
            {
                    new Violations
                    {
                        Id = Guid.NewGuid(),
                        EmployeeId = emps.Find(p => p.LastName == "Александрова").Id,
                        VioDate = "10.06.2022",
                        VioReason = "Уважительная причина",
                        CreatedBy = str_ini_by,
                        CreatedDate = DateTime.Now,
                        UpdatedBy = str_ini_by,
                        UpdatedDate = DateTime.Now
                    },
                    new Violations
                    {
                        Id = Guid.NewGuid(),
                        EmployeeId = emps.Find(p => p.LastName == "Сергеев").Id,
                        VioDate = "10.06.2022",
                        VioReason = "Уважительная причина",
                        CreatedBy = str_ini_by,
                        CreatedDate = DateTime.Now,
                        UpdatedBy = str_ini_by,
                        UpdatedDate = DateTime.Now
                    },
                    new Violations
                    {
                        Id = Guid.NewGuid(),
                        EmployeeId = emps.Find(p => p.LastName == "Михайлова").Id,
                        VioDate = "10.01.2023",
                        VioReason = "Неуважительная причина",
                        CreatedBy = str_ini_by,
                        CreatedDate = DateTime.Now,
                        UpdatedBy = str_ini_by,
                        UpdatedDate = DateTime.Now
                    },
                    new Violations
                    {
                        Id = Guid.NewGuid(),
                        EmployeeId = emps.Find(p => p.LastName == "Михайлова").Id,
                        VioDate = "15.01.2023",
                        VioReason = "Уважительная причина",
                        CreatedBy = str_ini_by,
                        CreatedDate = DateTime.Now,
                        UpdatedBy = str_ini_by,
                        UpdatedDate = DateTime.Now
                    },
                    new Violations
                    {
                        Id = Guid.NewGuid(),
                        EmployeeId = emps.Find(p => p.LastName == "Михайлова").Id,
                        VioDate = "20.01.2023",
                        VioReason = "Уважительная причина",
                        CreatedBy = str_ini_by,
                        CreatedDate = DateTime.Now,
                        UpdatedBy = str_ini_by,
                        UpdatedDate = DateTime.Now
                    },
                    new Violations
                    {
                        Id = Guid.NewGuid(),
                        EmployeeId = emps.Find(p => p.LastName == "Михайлова").Id,
                        VioDate = "25.01.2023",
                        VioReason = "Неуважительная причина",
                        CreatedBy = str_ini_by,
                        CreatedDate = DateTime.Now,
                        UpdatedBy = str_ini_by,
                        UpdatedDate = DateTime.Now
                    },
                    new Violations
                    {
                        Id = Guid.NewGuid(),
                        EmployeeId = emps.Find(p => p.LastName == "Николаев").Id,
                        VioDate = "10.01.2023",
                        VioReason = "Уважительная причина",
                        CreatedBy = str_ini_by,
                        CreatedDate = DateTime.Now,
                        UpdatedBy = str_ini_by,
                        UpdatedDate = DateTime.Now
                    },
                    new Violations
                    {
                        Id = Guid.NewGuid(),
                        EmployeeId = emps.Find(p => p.LastName == "Николаев").Id,
                        VioDate = "20.01.2023",
                        VioReason = "Неуважительная причина",
                        CreatedBy = str_ini_by,
                        CreatedDate = DateTime.Now,
                        UpdatedBy = str_ini_by,
                        UpdatedDate = DateTime.Now
                    },
                    new Violations
                    {
                        Id = Guid.NewGuid(),
                        EmployeeId = emps.Find(p => p.LastName == "Лебедева").Id,
                        VioDate = "10.02.2022",
                        VioReason = "Уважительная причина",
                        CreatedBy = str_ini_by,
                        CreatedDate = DateTime.Now,
                        UpdatedBy = str_ini_by,
                        UpdatedDate = DateTime.Now
                    },
                    new Violations
                    {
                        Id = Guid.NewGuid(),
                        EmployeeId = emps.Find(p => p.LastName == "Лебедева").Id,
                        VioDate = "15.02.2022",
                        VioReason = "Уважительная причина",
                        CreatedBy = str_ini_by,
                        CreatedDate = DateTime.Now,
                        UpdatedBy = str_ini_by,
                        UpdatedDate = DateTime.Now
                    },
                    new Violations
                    {
                        Id = Guid.NewGuid(),
                        EmployeeId = emps.Find(p => p.LastName == "Лебедева").Id,
                        VioDate = "20.02.2022",
                        VioReason = "Неуважительная причина",
                        CreatedBy = str_ini_by,
                        CreatedDate = DateTime.Now,
                        UpdatedBy = str_ini_by,
                        UpdatedDate = DateTime.Now
                    },
                    new Violations
                    {
                        Id = Guid.NewGuid(),
                        EmployeeId = emps.Find(p => p.LastName == "Григорьев").Id,
                        VioDate = "17.03.2023",
                        VioReason = "Уважительная причина",
                        CreatedBy = str_ini_by,
                        CreatedDate = DateTime.Now,
                        UpdatedBy = str_ini_by,
                        UpdatedDate = DateTime.Now
                    },
            };
            _context.Violationss.AddRange(items);
            _context.SaveChanges();
        }
        if (!_context.TimeTrackings.Any())
        {
            var emps = _context.Employees.ToList();
            var items = new TimeTracking[]
            {
                    new TimeTracking
                    {
                        Id = Guid.NewGuid(),
                        EmployeeId = emps.Find(p => p.LastName == "Александрова").Id,
                        TableNum = 1,
                        EntryDate = "01.05.2022",
                        CurrentDate = DateTime.Now,
                        HoursWorked = 800,
                        CreatedBy = str_ini_by,
                        CreatedDate = DateTime.Now,
                        UpdatedBy = str_ini_by,
                        UpdatedDate = DateTime.Now
                    },
                    new TimeTracking
                    {
                        Id = Guid.NewGuid(),
                        EmployeeId = emps.Find(p => p.LastName == "Смирнов").Id,
                        TableNum = 2,
                        EntryDate = "01.03.2022",
                        CurrentDate = DateTime.Now,
                        HoursWorked = 1000,
                        CreatedBy = str_ini_by,
                        CreatedDate = DateTime.Now,
                        UpdatedBy = str_ini_by,
                        UpdatedDate = DateTime.Now
                    },
                    new TimeTracking
                    {
                        Id = Guid.NewGuid(),
                        EmployeeId = emps.Find(p => p.LastName == "Петрова").Id,
                        TableNum = 3,
                        EntryDate = "01.01.2022",
                        CurrentDate = DateTime.Now,
                        HoursWorked = 1200,
                        CreatedBy = str_ini_by,
                        CreatedDate = DateTime.Now,
                        UpdatedBy = str_ini_by,
                        UpdatedDate = DateTime.Now
                    },
                    new TimeTracking
                    {
                        Id = Guid.NewGuid(),
                        EmployeeId = emps.Find(p => p.LastName == "Козлов").Id,
                        TableNum = 4,
                        EntryDate = "01.01.2023",
                        CurrentDate = DateTime.Now,
                        HoursWorked = 300,
                        CreatedBy = str_ini_by,
                        CreatedDate = DateTime.Now,
                        UpdatedBy = str_ini_by,
                        UpdatedDate = DateTime.Now
                    },
                    new TimeTracking
                    {
                        Id = Guid.NewGuid(),
                        EmployeeId = emps.Find(p => p.LastName == "Сергеев").Id,
                        TableNum = 5,
                        EntryDate = "01.12.2022",
                        CurrentDate = DateTime.Now,
                        HoursWorked = 400,
                        CreatedBy = str_ini_by,
                        CreatedDate = DateTime.Now,
                        UpdatedBy = str_ini_by,
                        UpdatedDate = DateTime.Now
                    },
                    new TimeTracking
                    {
                        Id = Guid.NewGuid(),
                        EmployeeId = emps.Find(p => p.LastName == "Михайлова").Id,
                        TableNum = 6,
                        EntryDate = "01.11.2022",
                        CurrentDate = DateTime.Now,
                        HoursWorked = 500,
                        CreatedBy = str_ini_by,
                        CreatedDate = DateTime.Now,
                        UpdatedBy = str_ini_by,
                        UpdatedDate = DateTime.Now
                    },
                    new TimeTracking
                    {
                        Id = Guid.NewGuid(),
                        EmployeeId = emps.Find(p => p.LastName == "Николаев").Id,
                        TableNum = 7,
                        EntryDate = "01.01.2020",
                        CurrentDate = DateTime.Now,
                        HoursWorked = 1500,
                        CreatedBy = str_ini_by,
                        CreatedDate = DateTime.Now,
                        UpdatedBy = str_ini_by,
                        UpdatedDate = DateTime.Now
                    },
                    new TimeTracking
                    {
                        Id = Guid.NewGuid(),
                        EmployeeId = emps.Find(p => p.LastName == "Лебедева").Id,
                        TableNum = 8,
                        EntryDate = "01.01.2020",
                        CurrentDate = DateTime.Now,
                        HoursWorked = 1500,
                        CreatedBy = str_ini_by,
                        CreatedDate = DateTime.Now,
                        UpdatedBy = str_ini_by,
                        UpdatedDate = DateTime.Now
                    },
                    new TimeTracking
                    {
                        Id = Guid.NewGuid(),
                        EmployeeId = emps.Find(p => p.LastName == "Григорьев").Id,
                        TableNum = 9,
                        EntryDate = "01.12.2019",
                        CurrentDate = DateTime.Now,
                        HoursWorked = 1700,
                        CreatedBy = str_ini_by,
                        CreatedDate = DateTime.Now,
                        UpdatedBy = str_ini_by,
                        UpdatedDate = DateTime.Now
                    },


            };
            _context.TimeTrackings.AddRange(items);
            _context.SaveChanges();

        }
        if (!_context.Tripss.Any())
        {
            var emps = _context.Employees.ToList();
            var items = new Trips[]
            {
                    new Trips
                    {
                        Id = Guid.NewGuid(),
                        EmployeeId = emps.Find(p => p.LastName == "Александрова").Id,
                        VisitDate = "26.03.2023",
                        RepairType = "Поломка трубопровода",
                        Result = true,
                        CreatedBy = str_ini_by,
                        CreatedDate = DateTime.Now,
                        UpdatedBy = str_ini_by,
                        UpdatedDate = DateTime.Now
                    },
                    new Trips
                    {
                        Id = Guid.NewGuid(),
                        EmployeeId = emps.Find(p => p.LastName == "Смирнов").Id,
                        VisitDate = "26.03.2023",
                        RepairType = "Поломка трубопровода",
                        Result = true,
                        CreatedBy = str_ini_by,
                        CreatedDate = DateTime.Now,
                        UpdatedBy = str_ini_by,
                        UpdatedDate = DateTime.Now
                    },
                    new Trips
                    {
                        Id = Guid.NewGuid(),
                        EmployeeId = emps.Find(p => p.LastName == "Петрова").Id,
                        VisitDate = "26.03.2023",
                        RepairType = "Поломка трубопровода",
                        Result = true,
                        CreatedBy = str_ini_by,
                        CreatedDate = DateTime.Now,
                        UpdatedBy = str_ini_by,
                        UpdatedDate = DateTime.Now
                    },
                    new Trips
                    {
                        Id = Guid.NewGuid(),
                        EmployeeId = emps.Find(p => p.LastName == "Козлов").Id,
                        VisitDate = "01.03.2023",
                        RepairType = "Аварийное отключение электричества",
                        Result = false,
                        CreatedBy = str_ini_by,
                        CreatedDate = DateTime.Now,
                        UpdatedBy = str_ini_by,
                        UpdatedDate = DateTime.Now
                    },
                    new Trips
                    {
                        Id = Guid.NewGuid(),
                        EmployeeId = emps.Find(p => p.LastName == "Сергеев").Id,
                        VisitDate = "01.03.2023",
                        RepairType = "Аварийное отключение электричества",
                        Result = false,
                        CreatedBy = str_ini_by,
                        CreatedDate = DateTime.Now,
                        UpdatedBy = str_ini_by,
                        UpdatedDate = DateTime.Now
                    },
                    new Trips
                    {
                        Id = Guid.NewGuid(),
                        EmployeeId = emps.Find(p => p.LastName == "Михайлова").Id,
                        VisitDate = "01.03.2023",
                        RepairType = "Аварийное отключение электричества",
                        Result = false,
                        CreatedBy = str_ini_by,
                        CreatedDate = DateTime.Now,
                        UpdatedBy = str_ini_by,
                        UpdatedDate = DateTime.Now
                    },
                    new Trips
                    {
                        Id = Guid.NewGuid(),
                        EmployeeId = emps.Find(p => p.LastName == "Николаев").Id,
                        VisitDate = "17.03.2023",
                        RepairType = "Пожар в производственном отсеке",
                        Result = true,
                        CreatedBy = str_ini_by,
                        CreatedDate = DateTime.Now,
                        UpdatedBy = str_ini_by,
                        UpdatedDate = DateTime.Now
                    },
                    new Trips
                    {
                        Id = Guid.NewGuid(),
                        EmployeeId = emps.Find(p => p.LastName == "Лебедева").Id,
                        VisitDate = "17.03.2023",
                        RepairType = "Пожар в производственном отсеке",
                        Result = true,
                        CreatedBy = str_ini_by,
                        CreatedDate = DateTime.Now,
                        UpdatedBy = str_ini_by,
                        UpdatedDate = DateTime.Now
                    },
                    new Trips
                    {
                        Id = Guid.NewGuid(),
                        EmployeeId = emps.Find(p => p.LastName == "Григорьев").Id,
                        VisitDate = "17.03.2023",
                        RepairType = "Пожар в производственном отсеке",
                        Result = true,
                        CreatedBy = str_ini_by,
                        CreatedDate = DateTime.Now,
                        UpdatedBy = str_ini_by,
                        UpdatedDate = DateTime.Now
                    },

            };
            _context.Tripss.AddRange(items);
            _context.SaveChanges();
        }
    }

}
