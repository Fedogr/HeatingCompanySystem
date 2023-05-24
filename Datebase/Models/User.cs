using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HeatingCompanySystem.Datebase.Base;

namespace HeatingCompanySystem.Datebase.Models;

public class User: BaseEntity
{
    [Column("login", Order = 1)]
    [MaxLength(255)]
    [Required]
    public string Login { get; set; }

    [Column("password", Order = 2)]
    [MaxLength(255)]
    [Required]
    public string Password { get; set; }

    [Column("role", Order = 3)]
    [MaxLength(50)]
    [Required]
    public string Role { get; set; }
}
