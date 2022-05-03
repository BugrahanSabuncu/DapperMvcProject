using AutoMapper;
using CV.Business.Interfaces;
using CV.DTO.DTOs.SkillDtos;
using CV.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.ViewComponents
{
    public class SkillComponent:ViewComponent
    {
        private readonly IGenericService<Skill> _genericService;
        private readonly IMapper _mapper;

        public SkillComponent(IMapper mapper, IGenericService<Skill> genericService)
        {
            _mapper = mapper;
            _genericService = genericService;
        }        

        public IViewComponentResult Invoke()
        {
            return View(_mapper.Map<List<SkillListDto>>(_genericService.GetAll()));
        }
    }
}
