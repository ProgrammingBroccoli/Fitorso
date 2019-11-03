    using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
    using System.Threading;
    using System.Threading.Tasks;
using Fitorso.Viewmodels;
using Microsoft.AspNetCore.Mvc;
using Logic;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Hosting.Internal;

namespace Fitorso.Controllers
{
    public class AccountController : Controller
    {
        public UserLogic _UserLogic;

        public AccountController()
        {
            _UserLogic = new UserLogic();
        }
        //Login Page
        public IActionResult Index()
        {
            var viewmodel = new AccountViewmodel();
            return View(viewmodel);
        }

        [HttpPost]
        public async Task<ActionResult> Login(AccountViewmodel viewmodel)
        {
            var user = viewmodel.User;
            var result = _UserLogic.ValidateUser(user.Email, user.Password);
            if (result != null)
            {
                //ValidatedUser
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Email, result.Email)
                };
                var claimsIdentity = new ClaimsIdentity(
                    claims, CookieAuthenticationDefaults.AuthenticationScheme);

                var authProperties = new AuthenticationProperties
                {

                };
                
                await HttpContext.SignInAsync(
                    CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(claimsIdentity),
                    authProperties);
                return RedirectToAction("Index", "Dashboard");

            }
            return View("Index" ,viewmodel);
        }

        public IActionResult Register()
        {
            var viewmodel = new AccountViewmodel();
            return View(viewmodel);
        }

        [HttpPost]
        public async Task<ActionResult> Register(AccountViewmodel viewmodel)
        {
            var user = viewmodel.User;
            _UserLogic.RegisterUser(user.Email, user.Password);
            return View("Index", viewmodel);
        }
    }
}