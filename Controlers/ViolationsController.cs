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
    public class ViolationsController
    {
        SettingsDatabase settingsDb = new SettingsDatabase();
        public List<Violations> GetViolations()
        {
            List<Violations> materialLiabilities = null;

            try
            {
                using (MyContextDb db = new MyContextDb(settingsDb.GetDbContextOptions()))
                {
                    materialLiabilities = db.Violationss.ToList();
                }
            }
            catch (Exception ex)
            {
                return null;
            }

            return materialLiabilities;
        }
        public bool AddNewViolation(string _user, Violations item)
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

                    db.Violationss.Add(item);
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
        public bool DeleteViolation(Guid _guid)
        {
            bool result = false;

            try
            {
                using (MyContextDb db = new MyContextDb(settingsDb.GetDbContextOptions()))
                {
                    Violations item = db.Violationss.FirstOrDefault(x => x.Id == _guid);
                    if (item != null)
                    {
                        db.Violationss.Remove(item);
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
        //public List<Guid> GetEquipmentsIdByEmployeeId(Guid _employeeId)
        //{
        //    List<Guid> result = new List<Guid>();

        //    try
        //    {
        //        using (_ContextDb db = new _ContextDb(settingsDb.GetDbContextOptions()))
        //        {
        //            var list = db.MaterialLiabilitys.Where(x => x.EmployeeId == _employeeId).ToList();
        //            if (list != null && list.Count > 0)
        //            {
        //                foreach (var item in list)
        //                {
        //                    result.Add(item.EquipmentId);
        //                }
        //            }
        //        }
        //    }
        //    catch
        //    {
        //        return null;
        //    }

        //    return result;
        //}
    }
}
