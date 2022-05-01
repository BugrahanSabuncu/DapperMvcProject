using CV.Business.Interfaces;
using CV.DTO.DTOs.AppUserDtos;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Models;

namespace WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles ="Admin,Member")]
    public class HomeController : Controller
    {
        IUserService _userService;

        public HomeController(IUserService userService)
        {
            _userService = userService;
        }

        public IActionResult Index()
        {
            TempData["active"]= "bilgilerim";
            var user = _userService.FindByName(User.Identity.Name);
            var appUserListDto = new UserUpdateModel()
            {
                Email = user.EMail,
                FirstName = user.FirstName,
                LastName = user.LastName,                
                Id = user.Id,
                PhoneNumber = user.PhoneNumber,
                ShortDescription = user.ShortDescription,
                Address = user.Address,
                ImageUrl = user.ImageUrl
            };
            
            return View(appUserListDto);
        }
        [HttpPost]
        public IActionResult Index(UserUpdateModel model)
        {
            TempData["active"] = "bilgilerim";
            if (ModelState.IsValid)
            {
                var updatedUser = _userService.GetById(model.Id);
                if (model.Picture!=null)
                {
                    var imgName = Guid.NewGuid() + Path.GetExtension(model.Picture.FileName);
                    var path = Directory.GetCurrentDirectory() + "/wwwroot/img/" +imgName;

                    var stream = new FileStream(path, FileMode.Create);
                    model.Picture.CopyTo(stream);
                    updatedUser.ImageUrl = imgName;
                }
                updatedUser.FirstName = model.FirstName;
                updatedUser.LastName = model.LastName;
                updatedUser.PhoneNumber = model.PhoneNumber;
                updatedUser.ShortDescription = model.ShortDescription;
                updatedUser.Address = model.Address;
                updatedUser.EMail = model.Email;
                _userService.Update(updatedUser);
                TempData["Message"] = "işleminiz başarı ile gerçekleşti";
                return RedirectToAction("Index");
            }
            return View(model);
        }
        public IActionResult ChangePassword()
        {
            var user = _userService.FindByName(User.Identity.Name);
            TempData["active"] = "sifre";
            return View(new AppUserPasswordDto 
            {
                Id=user.Id
            });
        }

        [HttpPost]
        public IActionResult ChangePassword(AppUserPasswordDto model)
        {
            TempData["active"] = "sifre";
            if (ModelState.IsValid)
            {
                var updatedUser = _userService.FindByName(User.Identity.Name);
                updatedUser.Password = model.Password;
                _userService.Update(updatedUser);
                HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
                
                if (true)
                {

                }

            }
            return View();
        }
    }
    
}
