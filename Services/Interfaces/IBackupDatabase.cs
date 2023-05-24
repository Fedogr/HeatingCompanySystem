﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeatingCompanySystem.Services.Interfaces
{
    public interface IBackupDatabase: IDisposable
    {
        bool BackupSQLiteDbToDesktop();
    }
}