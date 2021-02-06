using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoList.Entities.DTO
{
    public class UserAddDto
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public bool IsDentist { get; set; }
        public string Color { get; set; }
    }
}
