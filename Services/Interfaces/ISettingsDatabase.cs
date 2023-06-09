﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using HeatingCompanySystem.Datebase;

namespace HeatingCompanySystem.Services.Interfaces
{
    public interface ISettingsDatabase : IDisposable
    {
        DbContextOptions<MyContextDb> GetDbContextOptions();
        string GetDbPathTofile();
    }
}
