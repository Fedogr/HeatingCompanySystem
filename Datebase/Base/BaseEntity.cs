using Novacode;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeatingCompanySystem.Datebase.Base
{
    public class BaseEntity: AuditableEntity
    {
        [Column("id", Order = 0)]
        [Key]
        public Guid Id { get; set; }
    }
}
