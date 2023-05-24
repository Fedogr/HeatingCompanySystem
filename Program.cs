using HeatingCompanySystem.Datebase;
using HeatingCompanySystem.Services;

namespace HeatingCompanySystem
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SettingsDatabase settingsDb = new SettingsDatabase();
            // Начальная инициализация БД
            using (MyContextDb db = new MyContextDb(settingsDb.GetDbContextOptions()))
            {
                DatabaseInitializer dbIni = new DatabaseInitializer(db);
                dbIni.MySeed();
            }

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new authForm());
        }
    }
}