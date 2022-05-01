using CV.DTO.DTOs.CertificationDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;


namespace CV.Business.ValidationRules
{
    public class CertificationAddDtoValidator :AbstractValidator<CertificationAddDto>
    {
        public CertificationAddDtoValidator()
        {
            RuleFor(I => I.Description).NotEmpty().WithMessage("Sertifika alanı boş geçilemez");
        }
    }
}
