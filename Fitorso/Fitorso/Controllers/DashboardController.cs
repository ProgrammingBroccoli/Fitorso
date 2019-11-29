using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Fitorso.Viewmodels;
using Logic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Fitorso.Controllers
{
    [Authorize]
    public class DashboardController : Controller
    {
        private UserLogic logic;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public DashboardController()
        {
            logic = new UserLogic();
            _httpContextAccessor = new HttpContextAccessor();
        }

        [Authorize]
        public IActionResult Index()
        {
           var userEmail = HttpContext.User.Claims.Where(i => i.Type == ClaimTypes.Email).First().Value;
           var _user = logic.GetUserByEmail(userEmail);
           var viewmodel = new DashboardViewmodel
           {
               User = _user,
               Weight = logic.GetWeightById(_user.Id),
               FatPercentage = logic.GetFatById(_user.Id),
               Bmi = logic.GetBmiById(_user.Id),
               Quote = logic.GetQuote()
           };
            return View(viewmodel);
        }
    }
}