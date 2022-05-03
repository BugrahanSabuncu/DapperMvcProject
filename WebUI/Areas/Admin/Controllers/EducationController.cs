using AutoMapper;
using CV.Business.Interfaces;
using CV.DTO.DTOs.EducationDtos;
using CV.Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles ="Admin")]
    public class EducationController : Controller
    {
        private readonly IGenericService<Education> _genericService;
        private readonly IMapper _mapper;

        public EducationController(IMapper mapper, IGenericService<Education> genericService)
        {
            _mapper = mapper;
            _genericService = genericService;
        }

        public IActionResult Index()
        {
            TempData["active"] = "eğitim";
            return View(_mapper.Map<List<EducationListDto>>(_genericService.GetAll()));
        }
        public IActionResult Delete(int id)
        {            
            var model = _genericService.GetById(id);
            _genericService.Delete(model);
            TempData["message"] = "Silme İşlemi Başarılı";
            return RedirectToAction("Index");
        }
        public IActionResult Add()
        {
            TempData["active"] = "eğitim";
            return View(new EducationAddDto());
        }
        [HttpPost]
        public IActionResult Add(EducationAddDto dto)
        {
            TempData["active"] = "eğitim";
            if (ModelState.IsValid)
            {
                _genericService.Insert(_mapper.Map<Education>(dto));
                TempData["message"] = "Ekleme İşlemi Başarılı";
                return RedirectToAction("Index");
            }
            return View(dto);
        }
        public IActionResult Update(int id)
        {
            TempData["active"] = "eğitim";
            return View(_mapper.Map<EducationUpdateDto>(_genericService.GetById(id)));
        }
        [HttpPost]
        public IActionResult Update(EducationUpdateDto dto)
        {
            if (ModelState.IsValid)
            {
                var model = _mapper.Map<Education>(dto);
                _genericService.Update(model);
                TempData["message"] = "Güncelleme İşlemi Başarılı";
                return RedirectToAction("Index");
            }

            return View(dto);
        }
    }
}
