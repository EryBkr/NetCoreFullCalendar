using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using ToDoList.DataAccess.Concrete.EntityFramework.Mapping;
using ToDoList.Entities.Concrete;
using ToDoList.Entities.Concrete.IdentityLibraryEntites;

namespace ToDoList.DataAccess.Concrete.EntityFramework.Context
{
   public class MyDataContext : IdentityDbContext<AppUser, AppRole, int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @"Server=(localdb)\MSSQLLocalDB;Database=FullCalendarDB;Trusted_Connection=true;"); 
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AppUserMap());
            modelBuilder.ApplyConfiguration(new AppointmentMap());
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Appointment> Appointments { get; set; }
    }
}
