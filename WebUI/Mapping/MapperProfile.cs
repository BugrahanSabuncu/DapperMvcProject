using AutoMapper;
using CV.DTO.DTOs.AppUserDtos;
using CV.DTO.DTOs.CertificationDtos;
using CV.DTO.DTOs.EducationDtos;
using CV.DTO.DTOs.ExperienceDtos;
using CV.DTO.DTOs.InterestDtos;
using CV.DTO.DTOs.SkillDtos;
using CV.DTO.DTOs.SocialMediaIconDtos;
using CV.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Mapping
{
    public class MapperProfile:Profile
    {
        public MapperProfile()
        {
            CreateMap<User, AppUserListDto>();
            CreateMap<AppUserListDto, User>();

            CreateMap<Certification, CertificationListDto>();
            CreateMap<CertificationListDto, Certification>();

            CreateMap<CertificationAddDto, Certification>();
            CreateMap<Certification, CertificationAddDto>();

            CreateMap<Certification, CertificationUpdateDto>();
            CreateMap<CertificationUpdateDto, Certification>();

            CreateMap<Education, EducationListDto>();
            CreateMap<EducationListDto, Education>();

            CreateMap<Education, EducationUpdateDto>();
            CreateMap<EducationUpdateDto, Education>();

            CreateMap<Education, EducationAddDto>();
            CreateMap<EducationAddDto, Education>();

            CreateMap<Experience, ExperienceListDto>();
            CreateMap<ExperienceListDto, Experience>();

            CreateMap<Experience, ExperienceAddDto>();
            CreateMap<ExperienceAddDto, Experience>();

            CreateMap<Interest, InterestUpdateDto>();
            CreateMap<InterestUpdateDto, Interest>();

            CreateMap<Interest, InterestListDto>();
            CreateMap<InterestListDto, Interest>();

            CreateMap<Interest, InterestAddDto>();
            CreateMap<InterestAddDto, Interest>();

            CreateMap<Skill, SkillUpdateDto>();
            CreateMap<SkillUpdateDto, Skill>();

            CreateMap<Skill, SkillListDto>();
            CreateMap<SkillListDto, Skill>();

            CreateMap<Skill, SkillAddDto>();
            CreateMap<SkillAddDto, Skill>();

            CreateMap<SocialMediaIcon, SocialMediaIconListDto>();
            CreateMap<SocialMediaIconListDto, SocialMediaIcon>();

            CreateMap<SocialMediaIcon, SocialMediaIconAddDto>();
            CreateMap<SocialMediaIconAddDto, SocialMediaIcon>();

            CreateMap<SocialMediaIcon, SocialMediaIconUpdateDto>();
            CreateMap<SocialMediaIconUpdateDto, SocialMediaIcon>();


        }
    }
}
