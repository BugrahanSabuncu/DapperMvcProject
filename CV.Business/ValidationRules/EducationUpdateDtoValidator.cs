using CV.DTO.DTOs.EducationDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;


namespace CV.Business.ValidationRules
{
    public class EducationUpdateDtoValidator : AbstractValidator<EducationUpdateDto>
    {
        public EducationUpdateDtoValidator()
        {
            RuleFor(I => I.Id).InclusiveBetween(1, int.MaxValue).WithMessage("Id alanı gereklidir");
            //RuleFor(I=>I.Title).NotEmpty().WithMessage("")
        }
    }
}
