using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using ToDoList.Entities.Concrete.IdentityLibraryEntites;

namespace ToDoList.DataAccess.Concrete.EntityFramework.Mapping
{
    public class AppUserMap : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.Property(i => i.Name).HasMaxLength(100);
            builder.Property(i => i.Surname).HasMaxLength(100);

            builder.HasMany(i => i.Appointments).WithOne(i => i.AppUser).HasForeignKey(i => i.AppUserId).OnDelete(DeleteBehavior.SetNull);

        }
    }
}
