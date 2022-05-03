using AutoMapper;
using CV.Business.Interfaces;
using CV.DTO.DTOs.ExperienceDtos;
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
    [Authorize(Roles = "Admin")]
    public class ExperienceController : Controller
    {
        private readonly IGenericService<Experience> _genericService;
        private readonly IMapper _mapper;

        public ExperienceController(IMapper mapper, IGenericService<Experience> genericService)
        {
            _mapper = mapper;
            _genericService = genericService;
        }

        public IActionResult Index()
        {
            TempData["active"] = "deneyim";
            return View(_mapper.Map<List<ExperienceListDto>>(_genericService.GetAll()));
        }
        public IActionResult Delete(int id)
        {
            TempData["active"] = "deneyim";
            var deletedModel = _genericService.GetById(id);
            _genericService.Delete(deletedModel);
            TempData["message"] = "Silme işlemi başarıyla gerçekleşti";
            return RedirectToAction("Index");
        }
        public IActionResult Add()
        {
            return View(new ExperienceAddDto());
        }

        [HttpPost]
        public IActionResult Add(ExperienceAddDto dto)
        {
            TempData["active"] = "deneyim";
            var addedModel = _mapper.Map<Experience>(dto);
            _genericService.Insert(addedModel);
            TempData["message"] = "Ekleme işlemi başarıyla gerçekleşti";
            return RedirectToAction("Index");
        }
        public IActionResult Update(int id)
        {
            TempData["active"] = "deneyim";
            var model = _genericService.GetById(id);
            var dto = _mapper.Map<ExperienceUpdateDto>(model);
            return View(dto);
        }
        [HttpPost]
        public IActionResult Update(ExperienceUpdateDto dto)
        {
            TempData["active"] = "deneyim";
            if (ModelState.IsValid)
            {
                var updatedModel = _mapper.Map<Experience>(dto);
                _genericService.Update(updatedModel);
                TempData["message"] = "Güncelleme işlemi başarıyla gerçekleşti";
                return RedirectToAction("Index");
            }
            return View(dto);
        }
    }
}
