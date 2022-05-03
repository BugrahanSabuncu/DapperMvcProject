using AutoMapper;
using CV.Business.Interfaces;
using CV.DTO.DTOs.InterestDtos;
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
    public class InterestController : Controller
    {
        private readonly IGenericService<Interest> _genericService;
        private readonly IMapper _mapper;

        public InterestController(IMapper mapper, IGenericService<Interest> genericService)
        {
            _mapper = mapper;
            _genericService = genericService;
        }

        public IActionResult Index()
        {
            TempData["active"] = "ilgi";
            return View(_mapper.Map<List<InterestListDto>>(_genericService.GetAll()));
        }
       
        public IActionResult Add()
        {
            return View(new InterestAddDto());
        }
        [HttpPost]
        public IActionResult Add(InterestAddDto dto)
        {
            TempData["active"] = "ilgi";
            if (ModelState.IsValid)
            {
                var addedModel = _mapper.Map<Interest>(dto);
                _genericService.Insert(addedModel);
                TempData["message"] = "ekleme işlemi başarılı";
                return RedirectToAction("Index");
            }
            return View(new InterestAddDto());
        }
        public IActionResult Update(int id)
        {
            var model=_genericService.GetById(id);
            var modelDto = _mapper.Map<InterestUpdateDto>(model);
            return View(modelDto);
        }
        [HttpPost]
        public IActionResult Update(InterestUpdateDto dto)
        {
            TempData["active"] = "ilgi";
            if (ModelState.IsValid)
            {
                var updatedModel = _mapper.Map<Interest>(dto);
                _genericService.Update(updatedModel);
                TempData["message"] = "Güncelleme işlemi başarılı";
                return RedirectToAction("Index");
            }
            return View(new InterestUpdateDto());
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
