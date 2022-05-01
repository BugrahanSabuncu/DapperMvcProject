using CV.Business.Interfaces;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using WebUI.Models;

namespace WebUI.Controllers
{
    public class AuthController : Controller
    {
        private readonly IUserService _userService;

        public AuthController(IUserService userService)
        {
            _userService = userService;
        }

        public IActionResult Login()
        {
            UserLoginModel loginModel = new UserLoginModel();
            return View(loginModel);
        }

        [HttpPost]
        public async Task<IActionResult> Login(UserLoginModel loginModel)
        {
            if (ModelState.IsValid)
            {
                if (_userService.CheckUser(loginModel.UserName, loginModel.Password))
                {
                    var claims = new List<Claim>
                        {
                            new Claim(ClaimTypes.Name, loginModel.UserName),

                            new Claim(ClaimTypes.Role, "Admin"),
                        };

                    var claimsIdentity = new ClaimsIdentity(
                        claims, CookieAuthenticationDefaults.AuthenticationScheme);

                    var authProperties = new AuthenticationProperties
                    {
                        IsPersistent = loginModel.RememberMe
                    };

                    await HttpContext.SignInAsync(
    CookieAuthenticationDefaults.AuthenticationScheme,
    new ClaimsPrincipal(claimsIdentity),
    authProperties);
                    return RedirectToAction("Index", "Home", new { @area = "Admin" });
                }
                ModelState.AddModelError("", "Kullanıcı adı veya parola hatalı");
            }
            return View(loginModel);
        }
    }
}
