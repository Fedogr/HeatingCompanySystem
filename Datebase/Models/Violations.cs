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
    public class Violations: BaseEntity
    {
        [Column("employee_id", Order = 1)]
        public Guid EmployeeId { get; set; }
        [Column("last_name", Order = 2)]
        public string LastName { get; set; }
        public Employee Employee { get; set; }

        [Column("vio_date", Order = 2)]
        public string VioDate { get; set; }

        [Column("vio_reason", Order = 3)]
        public string VioReason { get; set; }
    }
}
