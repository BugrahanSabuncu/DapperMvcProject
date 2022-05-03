using AutoMapper;
using CV.Business.Interfaces;
using CV.DTO.DTOs.SocialMediaIconDtos;
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
    public class SocialMediaIconController : Controller
    {
        private readonly ISocialMediaIconService _socialMediaIconService;
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public SocialMediaIconController(ISocialMediaIconService socialMediaIconService, IUserService userService, IMapper mapper)
        {
            _socialMediaIconService = socialMediaIconService;
            _userService = userService;
            _mapper = mapper;
        }
        [Area("Admin")]
        [Authorize(Roles = "Admin")]
        public IActionResult Index()
        {
            TempData["active"] = "ikon";
            var user = _userService.FindByName(User.Identity.Name);
            var icon = _socialMediaIconService.GetByUserId(user.Id);
            var dto = _mapper.Map<List<SocialMediaIconListDto>>(icon);
            return View(dto);
        }
        public IActionResult Delete(int id)
        {
            var deletedEntity = _socialMediaIconService.GetById(id);
            _socialMediaIconService.Delete(deletedEntity);
            TempData["message"] = "ikon Silindi";
            return RedirectToAction("Index");
        }
        public IActionResult Add()
        {
            TempData["active"] = "ikon";
            return View(new SocialMediaIconAddDto());
        }
        [HttpPost]
        public IActionResult Add(SocialMediaIconAddDto dto)
        {
            TempData["active"] = "ikon";
            if (ModelState.IsValid)
            {
                var user = _userService.FindByName(User.Identity.Name);
                dto.AppUserId = user.Id;
                _socialMediaIconService.Insert(_mapper.Map<SocialMediaIcon>(dto));
                TempData["message"] = "İkon Ekleme İşlemi Başarılı";
                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult Update(int id)
        {
            TempData["active"] = "ikon";
            return View(_mapper.Map<SocialMediaIconUpdateDto>(_socialMediaIconService.GetById(id)));
        }
        [HttpPost]
        public IActionResult Update(SocialMediaIconUpdateDto dto)
        {
            TempData["active"] = "ikon";
            if (ModelState.IsValid)
            {
                var user = _userService.FindByName(User.Identity.Name);
                dto.AppUserId = user.Id;
                var socialMedia = _mapper.Map<SocialMediaIcon>(dto);
                _socialMediaIconService.Update(socialMedia);
                TempData["message"] = "Güncelleme Başarılı";
                return RedirectToAction("Index");
            }
            return View(dto);
        }
    }
}
