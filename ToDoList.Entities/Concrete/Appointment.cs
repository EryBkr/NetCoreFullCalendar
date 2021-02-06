using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using ToDoList.Core.Entites.Abstract;
using ToDoList.Entities.Concrete.IdentityLibraryEntites;

namespace ToDoList.Entities.Concrete
{
    public class Appointment:IEntity
    {
        public int Id { get; set; }
        public int? AppUserId { get; set; }
        public AppUser AppUser { get; set; }
        public DateTime CreatedName { get; set; }
        public DateTime UpdatedDate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string PatientName { get; set; }
        public string PatientSurname { get; set; }
        public string Description { get; set; }
    }
}
