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
    [Table("Trips")]
    public class Trips: BaseEntity
    {
        [Column("employee_id", Order = 1)]
        public Guid EmployeeId { get; set; }
        public Employee Employee { get; set; }

        //[Column("last_name", Order = 2)]
        //public string LastName { get; set; }

        [Column("visit_date", Order = 2)]
        public string VisitDate { get; set; }

        [Column("repair_type", Order = 3)]
        public string RepairType { get; set; }

        [Column("result", Order = 4)]
        public Boolean Result { get; set; }
    }
}
