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
    public class TimetrackingController
    {
        SettingsDatabase settingsDb = new SettingsDatabase();
        public List<TimeTracking> GetAllTimeTrackingsWithFilter(string search = "", string field = "")
        {
            List<TimeTracking> structuresList = null;

            try
            {
                using (MyContextDb db = new MyContextDb(settingsDb.GetDbContextOptions()))
                {
                    if (search == "")
                    {
                        structuresList = db.TimeTrackings.ToList();
                    }
                    else
                    {
                        var listLocal = db.TimeTrackings.ToList();
                        switch (field)
                        {
                            case "common":
                                structuresList = listLocal
                                    .Where(
                                        s => s.TableNum.ToString().Contains(search.ToLower())
                                        || s.EmployeeId.ToString().ToLower().Contains(search.ToLower())
                                        || s.EntryDate.ToString().ToLower().Contains(search.ToLower())
                                        || s.CurrentDate.ToString().ToLower().Contains(search.ToLower())
                                        || s.HoursWorked.ToString().Contains(search.ToLower())
                                        || s.CreatedBy.ToLower().Contains(search.ToLower())
                                        || s.UpdatedBy.ToLower().Contains(search.ToLower())
                                    ).ToList();
                                break;

                            case "TableNum":
                                structuresList = listLocal
                                    .Where(
                                        s => s.TableNum.ToString().Contains(search.ToLower())
                                    ).ToList();
                                break;

                            case "HoursWorked":
                                structuresList = listLocal
                                    .Where(
                                        s => s.HoursWorked.ToString().Contains(search.ToLower())
                                    ).ToList();
                                break;

                            default:
                                structuresList = db.TimeTrackings.ToList();
                                break;

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return null;
            }
            return structuresList;
        }
        public bool SaveSingleStructure(string _user, Guid _guid, int _tablenum,
            Guid _emguid, string _entdate, DateTime _curdate, int _hrswrkd)
        {
            bool result = false;

            try
            {
                using (MyContextDb db = new MyContextDb(settingsDb.GetDbContextOptions()))
                {
                    TimeTracking item = db.TimeTrackings.FirstOrDefault(st => st.Id == _guid);
                    if (item != null)
                    {
                        item.TableNum = _tablenum;
                        item.EmployeeId = _emguid;
                        item.EntryDate = _entdate;
                        item.CurrentDate = DateTime.Now;
                        item.HoursWorked = _hrswrkd;
                        item.UpdatedBy = _user;
                        item.UpdatedDate = DateTime.Now;

                        db.TimeTrackings.Update(item);
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
        public bool DeleteSingleStructure(Guid _guid)
        {
            bool delete = false;

            try
            {
                using (MyContextDb db = new MyContextDb(settingsDb.GetDbContextOptions()))
                {
                    TimeTracking item = db.TimeTrackings.FirstOrDefault(st => st.Id == _guid);

                    if (item != null)
                    {
                        db.TimeTrackings.Remove(item);
                        db.SaveChanges();
                        delete = true;
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }

            return delete;
        }
        public bool AddNewStructure(string _user,  int _tablenum,
            Guid _emguid, string _entdate, DateTime _curdate, int _hrswrkd)
        {
            bool result = false;

            try
            {
                using (MyContextDb db = new MyContextDb(settingsDb.GetDbContextOptions()))
                {
                    Guid _guid = Guid.NewGuid();
                    TimeTracking item = new TimeTracking
                    {
                        Id = _guid,
                        TableNum = _tablenum,
                        EmployeeId = _emguid,
                        EntryDate = _entdate,
                        CurrentDate = _curdate,
                        HoursWorked = _hrswrkd,
                        CreatedBy = _user,
                        CreatedDate = DateTime.Now,
                        UpdatedBy = _user,
                        UpdatedDate = DateTime.Now
                    };

                    db.TimeTrackings.Add(item);
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
        public TimeTracking GetSingleStructure(Guid _guid)
        {
            TimeTracking structure = null;

            try
            {
                using (MyContextDb db = new MyContextDb(settingsDb.GetDbContextOptions()))
                {
                    structure = db.TimeTrackings.FirstOrDefault(x => x.Id == _guid);
                    return structure;
                }
            }
            catch (Exception ex)
            {
                return null;
            }

            return structure;
        }
        public List<Guid> GetTimeTrackingIdByEmployeeId(Guid _employeeId)
        {
            List<Guid> result = new List<Guid>();

            try
            {
                using (MyContextDb db = new MyContextDb(settingsDb.GetDbContextOptions()))
                {
                    var list = db.TimeTrackings.Where(x => x.EmployeeId == _employeeId).ToList();
                    if (list != null && list.Count > 0)
                    {
                        foreach (var types in list)
                        {
                            result.Add(new Guid(types.TableNum.ToString()));
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
    }
}
