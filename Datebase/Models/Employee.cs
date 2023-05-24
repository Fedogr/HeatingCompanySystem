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
    [Table("employee")]
    public class Employee : BaseEntity
    {
        [Column("personnel_number", Order = 1)]
        public int PersonnelNumber { get; set; }

        [Column("last_name", Order = 2)]
        public string LastName { get; set; }

        [Column("first_name", Order = 3)]
        public string FirstName { get; set; }

        [Column("middle_name", Order = 4)]
        public string MiddleName { get; set; }

        [Column("birth_date", Order = 5)]
        public string BirthDate { get; set; }

        [Column("job_title", Order = 6)]
        public string JobTitle { get; set; }

        [Column("qual", Order = 7)]
        public string Qual { get; set; }

        [Column("photo_url", Order = 8)]
        public string PhotoUrl { get; set; }

        [Column("brigade_id", Order = 9)]
        public string BrigadeId { get; set; }

        [Column("timatabel_id", Order = 10)]
        public Guid TimatabelId { get; set; }
        public Timatabel Timatabel { get; set; }
    }
}
