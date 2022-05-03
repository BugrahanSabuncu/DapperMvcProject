using AutoMapper;
using CV.Business.Interfaces;
using CV.DTO.DTOs.EducationDtos;
using CV.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.ViewComponents
{
    public class EducationComponent : ViewComponent
    {
        private readonly IGenericService<Education> _genericService;
        private readonly IMapper _mapper;

        public EducationComponent(IMapper mapper, IGenericService<Education> genericService)
        {
            _mapper = mapper;
            _genericService = genericService;
        }

        public IViewComponentResult Invoke()
        {
            return View(_mapper.Map<List<EducationListDto>>(_genericService.GetAll()));
        }
    }
}
