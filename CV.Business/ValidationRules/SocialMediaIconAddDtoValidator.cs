using CV.DTO.DTOs.SocialMediaIconDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using CV.DTO.DTOs.SocialMediaIconDtos;

namespace CV.Business.ValidationRules
{
    public class SocialMediaIconAddDtoValidator : AbstractValidator<SocialMediaIconAddDto>
    {
        public SocialMediaIconAddDtoValidator()
        {
            RuleFor(I => I.AppUserId).InclusiveBetween(1, int.MaxValue).WithMessage("AppUserId boş bırakılamaz");
            RuleFor(I => I.Icon).NotEmpty().WithMessage("İkon boş bırakılamaz");
            RuleFor(I => I.Link).NotEmpty().WithMessage("Link boş bırakılamaz");           
        }
    }
}
