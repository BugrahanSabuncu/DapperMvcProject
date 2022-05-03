using CV.Business.Concrete;
using CV.Business.Interfaces;
using CV.Business.ValidationRules;
using CV.DataAccess.Abstract;
using CV.DataAccess.Concrete.Dapper;
using CV.DTO.DTOs.AppUserDtos;
using CV.DTO.DTOs.CertificationDtos;
using CV.DTO.DTOs.EducationDtos;
using CV.DTO.DTOs.ExperienceDtos;
using CV.DTO.DTOs.InterestDtos;
using CV.DTO.DTOs.SkillDtos;
using CV.DTO.DTOs.SocialMediaIconDtos;
using FluentValidation;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace CV.Business.IOC.Microsoft
{
    public static class MicrosoftDependecies
    {
        public static void AddCustomDependencies(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddTransient<IDbConnection>(con => new SqlConnection(
                configuration.GetConnectionString("connectionMssql")));

            //herhangi bir tipten IGenericRepository görürse ilgili tipten dönüş yapacak
            services.AddScoped(typeof(IGenericRepository<>), typeof(DpGenericRepository<>));
            services.AddScoped(typeof(IGenericService<>), typeof(GenericManager<>));

            services.AddTransient<IValidator<AppUserUpdateDto>, AppUserUpdateDtoValidator>();
            services.AddTransient<IValidator<CertificationAddDto>, CertificationAddDtoValidator>();
            services.AddTransient<IValidator<CertificationUpdateDto>, CertificationUpdateDtoValidator>();
            services.AddTransient<IValidator<EducationAddDto>, EducationAddDtoValidator>();
            services.AddTransient<IValidator<EducationUpdateDto>, EducationUpdateDtoValidator>();
            services.AddTransient<IValidator<ExperienceAddDto>, ExperienceAddDtoValidator>();
            services.AddTransient<IValidator<ExperienceUpdateDto>, ExperienceUpdateDtoValidator>();
            services.AddTransient<IValidator<InterestAddDto>, InterestAddDtoValidator>();
            services.AddTransient<IValidator<InterestUpdateDto>, InterestUpdateDtoValidator>();
            services.AddTransient<IValidator<SkillAddDto>, SkillAddDtoValidator>();
            services.AddTransient<IValidator<SkillUpdateDto>, SkillUpdateDtoValidator>();
            services.AddTransient<IValidator<SocialMediaIconAddDto>, SocialMediaIconAddDtoValidator>();
            services.AddTransient<IValidator<SocialMediaIconUpdateDto>, SocialMediaIconUpdateDtoValidator>();
            services.AddTransient<IValidator<AppUserPasswordDto>, UserPasswordDtoValidator>();

            services.AddScoped<IAppUserRepository, AppUserRepository>();
            services.AddScoped<IUserService, UserManager>();
            services.AddScoped<ISocialMediaIconService, SocialMediaIconManager>();
            services.AddScoped<ISocialMediaIconRepository, SocialMediaIconRepository>();
        }
    }
}
