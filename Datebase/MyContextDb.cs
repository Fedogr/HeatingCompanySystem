 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HeatingCompanySystem.Datebase.Models;

namespace HeatingCompanySystem.Datebase;

public class MyContextDb : DbContext
{

    public DbSet<Brigade> Brigades { get; set; }

    public DbSet<Timatabel> Timatabels { get; set; }

    public DbSet<User> Users { get; set; }

    public DbSet<Employee> Employees { get; set; }

    public DbSet<Techbez> Techbezs { get; set; }

    public DbSet<Trips> Tripss { get; set; }

    public DbSet<Violations> Violationss { get; set; }

    public DbSet<TimeTracking> TimeTrackings { get; set; }


    public MyContextDb(DbContextOptions<MyContextDb> options) : base(options)
    {
        //Проверка существования БД
        //Database.EnsureDeleted();
        Database.EnsureCreated();
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().HasAlternateKey(u => u.Login);
        modelBuilder.Entity<Timatabel>().HasAlternateKey(ps => ps.TimetableType);
        modelBuilder.Entity<Employee>().HasAlternateKey(u => u.PersonnelNumber);
        modelBuilder.Entity<TimeTracking>().HasAlternateKey(o => o.TableNum);
    }

}


