using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using ToDoList.Entities.DTO;

namespace ToDoList.Bussiness.ValidationRules.FluentValidation.AppUser
{
    public class UserSignInValidator : AbstractValidator<UserSignInDto>
    {
        public UserSignInValidator()
        {
            RuleFor(i => i.UserName).NotNull().WithMessage("Kullanıcı adı boş olamaz");
            RuleFor(i => i.Password).NotNull().WithMessage("Parola boş olamaz");
        }
    }
}
