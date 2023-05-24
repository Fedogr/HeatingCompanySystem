using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeatingCompanySystem.Datebase.Models;

namespace HeatingCompanySystem.Services.Interfaces
{
    public interface IWordService : IDisposable
    {
        bool CreateDocEquipmentByTimeTracking(List<TimeTracking> _dict, string _nameEmployee = "");
    }
}
