using HeatingCompanySystem.Datebase;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeatingCompanySystem.Services;

public class SettingsDatabase: IDisposable
{
    public void Dispose()
    {
    }

    public DbContextOptions<MyContextDb> GetDbContextOptions()
    {
        var builder = new ConfigurationBuilder();
        // установка пути к текущему каталогу
        builder.SetBasePath(Directory.GetCurrentDirectory());
        // получаем конфигурацию из файла appsettings.json
        builder.AddJsonFile("Config\\appsettings.json");
        // создаем конфигурацию
        var config = builder.Build();
        // получаем строку подключения
        string connectionString = config.GetConnectionString("DefaultConnection");

        var optionsBuilder = new DbContextOptionsBuilder<MyContextDb>();
        var options = optionsBuilder.UseSqlite(connectionString).Options;
        return options;
    }

    public string GetDbPathTofile()
    {
        var builder = new ConfigurationBuilder();
        // установка пути к текущему каталогу
        builder.SetBasePath(Directory.GetCurrentDirectory());
        // получаем конфигурацию из файла appsettings.json
        builder.AddJsonFile("Config\\appsettings.json");
        // создаем конфигурацию
        var config = builder.Build();
        // получаем строку подключения
        string connectionString = config.GetConnectionString("DefaultConnection");
        //MessageBox.Show(connectionString);
        return connectionString;
    }
}
