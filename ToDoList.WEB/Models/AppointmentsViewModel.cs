using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoList.WEB.Models
{
    public class AppointmentsViewModel
    {
        public int Id { get; set; }
        public int? AppUserId { get; set; }
        public string Title { get; set; }
        public string Color { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string PatientName { get; set; }
        public string PatientSurname { get; set; }
        public string Description { get; set; }
    }
}
