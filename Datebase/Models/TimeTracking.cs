using HeatingCompanySystem.Datebase.Base;
using Novacode;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeatingCompanySystem.Datebase.Models
{
    public class TimeTracking: BaseEntity
    {
        [Column("table_num", Order = 1)]
        public int TableNum { get; set; }
        
        [Column("employee_id", Order = 2)]
        public Guid EmployeeId { get; set; }
        public Employee Employee { get; set; }

        [Column("entry_date", Order = 3)]
        public string EntryDate { get; set; }

        [Column("current_date", Order = 4)]
        public DateTime CurrentDate { get; set; }

        [Column("hours_worked", Order = 5)]
        public int HoursWorked { get; set; }
    }
}
