using CV.DTO.DTOs.SkillDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;


namespace CV.Business.ValidationRules
{
    public class SkillUpdateDtoValidator : AbstractValidator<SkillUpdateDto>
    {
        public SkillUpdateDtoValidator()
        {
            RuleFor(I => I.Id).InclusiveBetween(1, int.MaxValue).WithMessage("Id alanı boş geçilemez");
        }
    }
}
