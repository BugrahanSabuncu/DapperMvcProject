using AutoMapper;
using CV.Business.Interfaces;
using CV.DTO.DTOs.SkillDtos;
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
    public class SkillController : Controller
    {
        private readonly IGenericService<Skill> _genericService;
        private readonly IMapper _mapper;

        public SkillController(IMapper mapper, IGenericService<Skill> genericService)
        {
            _mapper = mapper;
            _genericService = genericService;
        }

        public IActionResult Index()
        {
            TempData["active"] = "yetenek";
            return View(_mapper.Map<List<SkillListDto>>(_genericService.GetAll()));
        }
        public IActionResult Add()
        {
            return View(new SkillAddDto());
        }
        [HttpPost]
        public IActionResult Add(SkillAddDto dto)
        {
            TempData["active"] = "yetenek";
            if (ModelState.IsValid)
            {
                var addedModel = _mapper.Map<Skill>(dto);
                _genericService.Insert(addedModel);
                TempData["message"] = "ekleme işlemi başarılı";
                return RedirectToAction("Index");
            }
            return View(new SkillAddDto());
        }
        public IActionResult Update(int id)
        {
            TempData["active"] = "yetenek";
            var model = _genericService.GetById(id);
            var modelDto = _mapper.Map<SkillUpdateDto>(model);
            return View(modelDto);
        }
        [HttpPost]
        public IActionResult Update(SkillUpdateDto dto)
        {
            TempData["active"] = "yetenek";
            if (ModelState.IsValid)
            {
                var updatedModel = _mapper.Map<Skill>(dto);
                _genericService.Update(updatedModel);
                TempData["message"] = "Güncelleme işlemi başarılı";
                return RedirectToAction("Index");
            }
            return View(new SkillUpdateDto());
        }
        public IActionResult Delete(int id)
        {           
            var deletedModel = _genericService.GetById(id);
            _genericService.Delete(deletedModel);
            TempData["message"] = "Silme işlemi başarılı";
            return RedirectToAction("Index");
        }
    }
}
