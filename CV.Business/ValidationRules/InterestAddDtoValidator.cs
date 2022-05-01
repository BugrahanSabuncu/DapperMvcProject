using CV.DTO.DTOs.InterestDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;


namespace CV.Business.ValidationRules
{
    public class InterestAddDtoValidator : AbstractValidator<InterestAddDto>
    {
        public InterestAddDtoValidator()
        {
            RuleFor(I => I.Description).NotEmpty().WithMessage("Açıklama alanı boş geçilemez");
        }
    }
}
