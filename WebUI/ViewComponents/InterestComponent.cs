using AutoMapper;
using CV.Business.Interfaces;
using CV.DTO.DTOs.InterestDtos;
using CV.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.ViewComponents
{
    public class InterestComponent:ViewComponent
    {
        private readonly IGenericService<Interest> _genericService;
        private readonly IMapper _mapper;

        public InterestComponent(IMapper mapper, IGenericService<Interest> genericService)
        {
            _mapper = mapper;
            _genericService = genericService;
        }

        public IViewComponentResult Invoke()
        {
            return View(_mapper.Map<List<InterestListDto>>(_genericService.GetAll()));
        }
    }
}
