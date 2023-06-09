﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeatingCompanySystem.Datebase.Interfaces;
using HeatingCompanySystem.Datebase;
using HeatingCompanySystem.Services.Interfaces;

namespace HeatingCompanySystem.Services
{
    public class BackupDatabase : IBackupDatabase
    {
        public bool BackupSQLiteDbToDesktop()
        {

            bool result = false;

            try
            {
                StringBuilder pathToFileDb = new StringBuilder();

                using (SettingsDatabase settingsDatabase = new SettingsDatabase())
                {
                    pathToFileDb.Append(settingsDatabase.GetDbPathTofile().ToString().Split('=')[1]);
                }

                string pathDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string guidCode = Guid.NewGuid().ToString();
                string shortDate = DateTime.Now.ToShortDateString();

                StringBuilder folderPath = new StringBuilder();
                folderPath.Append(pathDesktop + "\\" + "sqlite_heating_company_system" + "_" + shortDate.Replace('.', '-') + "_" + guidCode);

                if (!Directory.Exists(folderPath.ToString()))
                {
                    Directory.CreateDirectory(folderPath.ToString());
                    // Пути
                    string oldPathFiles = pathToFileDb.ToString();
                    string newPathFile = folderPath.ToString();

                    FileInfo fileInfo = new FileInfo(oldPathFiles);
                    if (fileInfo.Exists)
                    {
                        fileInfo.CopyTo(newPathFile + "\\" + "sqlite_heating_company_system.db");
                    }

                    result = true;
                }
            }
            catch
            {
                return false;
            }

            return result;
        }

        public void Dispose()
        {
        }
    }
}
