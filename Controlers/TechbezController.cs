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
    public class TechbezController
    {
        SettingsDatabase settingsDb = new SettingsDatabase();
        public List<Techbez> GetAllTechbez()
        {
            List<Techbez> techBezs = null;

            try
            {
                using (MyContextDb db = new MyContextDb(settingsDb.GetDbContextOptions()))
                {
                    techBezs = db.Techbezs.ToList();
                }
            }
            catch (Exception ex)
            {
                return null;
            }

            return techBezs;
        }
        public bool AddNewTechbez(string _user, Techbez item)
        {
            bool result = false;

            try
            {
                using (MyContextDb db = new MyContextDb(settingsDb.GetDbContextOptions()))
                {
                    item.Id = Guid.NewGuid();
                    item.CreatedBy = _user;
                    item.CreatedDate = DateTime.Now;
                    item.UpdatedBy = _user;
                    item.UpdatedDate = DateTime.Now;

                    db.Techbezs.Add(item);
                    db.SaveChanges();
                    result = true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            return result;
        }
        public bool DeleteTechbez(Guid _guid)
        {
            bool result = false;

            try
            {
                using (MyContextDb db = new MyContextDb(settingsDb.GetDbContextOptions()))
                {
                    Techbez item = db.Techbezs.FirstOrDefault(x => x.Id == _guid);
                    if (item != null)
                    {
                        db.Techbezs.Remove(item);
                        db.SaveChanges();
                        result = true;
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }

            return result;
        }
    }
    
}
