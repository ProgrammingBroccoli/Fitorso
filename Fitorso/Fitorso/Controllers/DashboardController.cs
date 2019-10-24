using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Logic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Fitorso.Controllers
{
    public class DashboardController : Controller
    {
        private UserLogic logic;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public DashboardController()
        {
            logic = new UserLogic();
            _httpContextAccessor = new HttpContextAccessor();
        }
        public IActionResult Index()
        {
            var userEmail = HttpContext.User.Claims.Where(i => i.Type == ClaimTypes.Email).First().Value;
            var _user = logic.GetUserByEmail(userEmail);
            return View();
        }
    }
}