using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeatingCompanySystem.Datebase;
using HeatingCompanySystem.Datebase.Models;
using HeatingCompanySystem.Services;
using Microsoft.EntityFrameworkCore;

namespace HeatingCompanySystem.Controlers
{
    public class ProfileController
    {
        SettingsDatabase settingsDb = new SettingsDatabase();
        public bool ChangePassword(ref User _user, string newPass)
        {
            bool result = false;

            Guid guid = _user.Id;

            User user = null;
            EncryptionText et = new EncryptionText();

            try
            {
                using (MyContextDb db = new MyContextDb(settingsDb.GetDbContextOptions()))
                {
                    user = db.Users.FirstOrDefault(u => u.Id == guid);
                    if (user != null)
                    {
                        user.Password = et.ComputeSha256Hash(newPass);
                        user.UpdatedBy = user.Login;
                        user.UpdatedDate = DateTime.Now;
                        db.Users.Update(user);
                        db.SaveChanges();

                        _user = db.Users.FirstOrDefault(u => u.Id == guid);
                        _user.Password = newPass;

                        result = true;
                    }
                }
            }
            catch
            {
                return false;
            }

            return result;
        }

        public List<User> ViewAllUsers()
        {
            List<User> users = null;

            try
            {
                using (MyContextDb db = new MyContextDb(settingsDb.GetDbContextOptions()))
                {
                    users = db.Users.ToList();
                }
            }
            catch
            {
                return null;
            }

            return users;
        }

    }
}
