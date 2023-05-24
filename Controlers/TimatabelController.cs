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
    public class TimatabelController
    {
        SettingsDatabase settingsDb = new SettingsDatabase();
        public List<Timatabel> GetAllTypes(string search = "", string field = "")
        {
            List<Timatabel> result = null;

            try
            {
                using (MyContextDb db = new MyContextDb(settingsDb.GetDbContextOptions()))
                {
                    if (search == "")
                    {
                        result = db.Timatabels.ToList();
                    }
                    else
                    {
                        var listLocal = db.Timatabels.ToList();
                        switch (field)
                        {
                            case "common":
                                result = listLocal
                                    .Where(
                                        psType => psType.TimetableType.ToLower().Contains(search.ToLower())
                                        || psType.CreatedBy.ToLower().Contains(search.ToLower())
                                        || psType.UpdatedBy.ToLower().Contains(search.ToLower())
                                        || psType.CreatedDate.ToString().ToLower().Contains(search.ToLower())
                                        || psType.UpdatedDate.ToString().ToLower().Contains(search.ToLower())
                                    ).ToList();
                                break;

                            case "typename":
                                result = listLocal.Where(psType => psType.TimetableType.ToLower().Contains(search.ToLower())).ToList();
                                break;

                            case "userBy":
                                result = listLocal
                                    .Where(psType => psType.CreatedBy.ToLower().Contains(search.ToLower()) || psType.UpdatedBy.ToLower().Contains(search.ToLower())).ToList();
                                break;

                            case "date":
                                result = listLocal
                                    .Where(psType => psType.CreatedDate.ToString().ToLower().Contains(search.ToLower()) || psType.UpdatedDate.ToString().ToLower().Contains(search.ToLower())).ToList();
                                break;

                            default:
                                result = db.Timatabels.ToList();
                                break;
                        }
                    }
                }
            }
            catch
            {
                return null;
            }

            return result;
        }

        public bool SaveChangesSingleType(Guid _id, string _typeName, string _user)
        {
            bool result = false;
            Timatabel psType = null;

            try
            {
                using (MyContextDb db = new MyContextDb(settingsDb.GetDbContextOptions()))
                {
                    psType = db.Timatabels.FirstOrDefault(ps => ps.Id == _id);
                    if (psType != null)
                    {
                        psType.TimetableType = _typeName;
                        psType.UpdatedBy = _user;
                        psType.UpdatedDate = DateTime.Now;
                        db.Timatabels.Update(psType);
                        db.SaveChanges();

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

        public bool DeleteSingleType(Guid _id)
        {
            bool result = false;
            Timatabel psType = null;

            try
            {
                using (MyContextDb db = new MyContextDb(settingsDb.GetDbContextOptions()))
                {
                    psType = db.Timatabels.FirstOrDefault(ps => ps.Id == _id);
                    if (psType != null)
                    {
                        db.Timatabels.Remove(psType);
                        db.SaveChanges();
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

        public bool AddSingleType(string _typename, string _user)
        {
            bool isAdd = false;
            Guid guid;

            try
            {
                using (MyContextDb db = new MyContextDb(settingsDb.GetDbContextOptions()))
                {
                    Timatabel psType = new Timatabel
                    {
                        Id = Guid.NewGuid(),
                        TimetableType = _typename,
                        CreatedBy = _user,
                        CreatedDate = DateTime.Now,
                        UpdatedBy = _user,
                        UpdatedDate = DateTime.Now
                    };

                    guid = psType.Id;

                    db.Timatabels.Add(psType);
                    db.SaveChanges();
                }

                using (var db = new MyContextDb(settingsDb.GetDbContextOptions()))
                {
                    if (db.Timatabels.Any(ps => ps.Id == guid)) { isAdd = true; }
                }
            }
            catch
            {
                return false;
            }

            return isAdd;
        }
    }
}
