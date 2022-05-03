using AutoMapper;
using CV.Business.Interfaces;
using CV.DTO.DTOs.CertificationDtos;
using CV.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.ViewComponents
{
    public class CertificationComponent:ViewComponent
    {
        private readonly IGenericService<Certification> _genericService;
        private readonly IMapper _mapper;

        public CertificationComponent(IMapper mapper, IGenericService<Certification> genericService)
        {
            _mapper = mapper;
            _genericService = genericService;
        }
        public IViewComponentResult Invoke()
        {
            return View(_mapper.Map<List<CertificationListDto>>(_genericService.GetAll()));
        }
    }
}
