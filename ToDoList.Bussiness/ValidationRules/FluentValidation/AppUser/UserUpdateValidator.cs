using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using ToDoList.Entities.DTO;

namespace ToDoList.Bussiness.ValidationRules.FluentValidation.AppUser
{
    public class UserUpdateValidator : AbstractValidator<UserUpdateDto>
    {
        public UserUpdateValidator()
        {
            RuleFor(i => i.Email).NotNull().WithMessage("Email boş olamaz").EmailAddress().WithMessage("Geçersiz email adresi");
            RuleFor(i => i.Name).NotNull().WithMessage("İsim boş olamaz");
            RuleFor(i => i.Surname).NotNull().WithMessage("Soyadı boş olamaz");
        }
    }
}
