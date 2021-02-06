using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using ToDoList.Entities.Concrete;

namespace ToDoList.DataAccess.Concrete.EntityFramework.Mapping
{
    public class AppointmentMap : IEntityTypeConfiguration<Appointment>
    {
        public void Configure(EntityTypeBuilder<Appointment> builder)
        {
            builder.HasKey(i => i.Id);
            builder.Property(i => i.Id).UseIdentityColumn();

            builder.HasOne(i => i.AppUser).WithMany(i => i.Appointments).HasForeignKey(i => i.AppUserId);
        }
    }
}
