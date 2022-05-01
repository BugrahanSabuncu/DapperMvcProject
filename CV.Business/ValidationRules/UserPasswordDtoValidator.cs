using CV.DTO.DTOs.AppUserDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace CV.Business.ValidationRules
{
    class UserPasswordDtoValidator:AbstractValidator<AppUserPasswordDto>
    {
        public UserPasswordDtoValidator()
        {
            RuleFor(p => p.Password).NotEmpty().WithMessage("Parola boş geçilemez");
            RuleFor(P => P.ConfirmPassword).NotEmpty().WithMessage("Parola tekrarı zorunludur.");
            RuleFor(cp => cp.ConfirmPassword).Equal(p => p.Password).WithMessage("Parolalar uyuşmuyor");
        }
    }
}
