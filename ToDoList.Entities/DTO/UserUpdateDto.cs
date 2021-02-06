using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoList.Entities.DTO
{
    public class UserUpdateDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
    }
}
