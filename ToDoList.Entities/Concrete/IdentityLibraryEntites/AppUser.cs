using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using ToDoList.Core.Entites.Abstract;

namespace ToDoList.Entities.Concrete.IdentityLibraryEntites
{
    public class AppUser:IdentityUser<int>, IEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public bool IsDentist { get; set; }
        public string Color { get; set; }
        public List<Appointment> Appointments { get; set; }
    }
}
