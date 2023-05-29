using HeatingCompanySystem.Datebase.Models;
using HeatingCompanySystem.Datebase;
using HeatingCompanySystem.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeatingCompanySystem.Controlers
{
    public class TripsController
    {
        SettingsDatabase settingsDb = new SettingsDatabase();
        public List<Trips> GetAllTrips()
        {
            List<Trips> trips = null;

            try
            {
                using (MyContextDb db = new MyContextDb(settingsDb.GetDbContextOptions()))
                {
                    trips = db.Tripss.ToList();
                }
            }
            catch (Exception ex)
            {
                return null;
            }

            return trips;
        }
        public bool AddNewTrips(string _user, Trips item)
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

                    db.Tripss.Add(item);
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
        public bool DeleteTrips(Guid _guid)
        {
            bool result = false;

            try
            {
                using (MyContextDb db = new MyContextDb(settingsDb.GetDbContextOptions()))
                {
                    Trips item = db.Tripss.FirstOrDefault(x => x.Id == _guid);
                    if (item != null)
                    {
                        db.Tripss.Remove(item);
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
