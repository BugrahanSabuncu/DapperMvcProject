using AutoMapper;
using CV.Business.Interfaces;
using CV.DTO.DTOs.ExperienceDtos;
using CV.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.ViewComponents
{
    public class ExperienceComponent:ViewComponent
    {
        private readonly IGenericService<Experience> _genericService;
        private readonly IMapper _mapper;

        public ExperienceComponent(IMapper mapper, IGenericService<Experience> genericService)
        {
            _mapper = mapper;
            _genericService = genericService;
        }

        public IViewComponentResult Invoke()
        {
            return View(_mapper.Map<List<ExperienceListDto>>(_genericService.GetAll()));
        }
    }
}
