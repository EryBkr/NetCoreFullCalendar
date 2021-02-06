using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoList.Entities.DTO
{
    public class UserSignInDto
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}
