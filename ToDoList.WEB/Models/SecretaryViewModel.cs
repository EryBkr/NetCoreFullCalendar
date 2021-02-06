using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoList.Entities.Concrete.IdentityLibraryEntites;

namespace ToDoList.WEB.Models
{
    public class SecretaryViewModel
    {
        public AppUser AppUser { get; set; }
        public List<AppUser> Dentists { get; set; }
        public IEnumerable<SelectListItem> CollapseDentist { get; set; }
    }
}
