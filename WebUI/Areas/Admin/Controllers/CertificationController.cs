using AutoMapper;
using CV.Business.Interfaces;
using CV.DTO.DTOs.CertificationDtos;
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
    public class CertificationController : Controller
    {
        private readonly IGenericService<Certification> _genericService;
        private readonly IMapper _mapper;

        public CertificationController(IGenericService<Certification> genericService, IMapper mapper)
        {
            _genericService = genericService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            TempData["active"] = "sertifikalar";
            return View(_mapper.Map<List<CertificationListDto>>(_genericService.GetAll()));
        }

        public IActionResult Delete(int id)
        {
            var deletedEntity = _genericService.GetById(id);
            _genericService.Delete(deletedEntity);
            TempData["message"] = "Sertifika Silindi";
            return RedirectToAction("Index");
        }
        public IActionResult Add()
        {
            TempData["active"] = "sertifikalar";
            return View(new CertificationAddDto());
        }
        [HttpPost]
        public IActionResult Add(CertificationAddDto certificationAddDto)
        {
            TempData["active"] = "sertifikalar";
            if (ModelState.IsValid)
            {
                _genericService.Insert(_mapper.Map<Certification>(certificationAddDto));
                TempData["message"] = "Sertifika Ekleme İşlemi Başarılı";
                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult Update(int id)
        {
            TempData["active"] = "sertifikalar";
            return View(_mapper.Map<CertificationUpdateDto>(_genericService.GetById(id)));
        }
        [HttpPost]
        public IActionResult Update(CertificationUpdateDto dto)
        {
            TempData["active"] = "sertifikalar";
            if (ModelState.IsValid)
            {
                var certification = _genericService.GetById(dto.Id);
                certification.Description = dto.Description;
                _genericService.Update(certification);
                TempData["message"] = "Güncelleme Başarılı";
                return RedirectToAction("Index");
            }
            return View(dto);
        }
    }
}
