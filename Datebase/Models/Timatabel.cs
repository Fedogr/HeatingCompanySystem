using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeatingCompanySystem.Datebase.Base;

namespace HeatingCompanySystem.Datebase.Models;

public class Timatabel: AuditableEntity
{
    public Timatabel()
    {
    }

    public Timatabel(string timetableType)
    {
        TimetableType = timetableType;
    }

    [Column("timetable_type", Order = 1)]
    public string TimetableType { get; set; }
}
