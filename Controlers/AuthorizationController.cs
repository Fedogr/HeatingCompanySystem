using HeatingCompanySystem.Datebase;
using HeatingCompanySystem.Datebase.Models;
using HeatingCompanySystem.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeatingCompanySystem.Controlers
{
    public class AuthorizationController
    {
        SettingsDatabase settingsDb = new SettingsDatabase();
        public User AuthToApp(string _login, string _pass)
        {
            User user = null;
            EncryptionText et = new EncryptionText();

            try
            {
                using (MyContextDb db = new MyContextDb(settingsDb.GetDbContextOptions()))
                {
                    var res = db.Users.FirstOrDefault(x => x.Login == _login && x.Password == et.ComputeSha256Hash(_pass));
                    if (res != null) user = res;
                }
            }
            catch
            {
                return null;
            }

            return user;
        }
    }
}
