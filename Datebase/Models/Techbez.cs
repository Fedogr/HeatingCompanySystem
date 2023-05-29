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
    [Table("Techbez")]
    public class Techbez: BaseEntity
    {
        [Column("employee_id", Order = 1)]
        public Guid EmployeeId { get; set; }
        public Employee Employee { get; set; }

        [Column("check_date", Order = 2)]
        public string CheckDate { get; set; }

        [Column("check_result", Order = 3)]
        public string CheckResult { get; set; }

        [Column("next_check_date", Order = 4)]
        public string NextCheckDate { get; set; }

    }
}
