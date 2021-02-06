using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using ToDoList.Core.Entites.Abstract;

namespace ToDoList.Entities.Concrete.IdentityLibraryEntites
{
    public class AppRole:IdentityRole<int>,IEntity
    {
    }
}
