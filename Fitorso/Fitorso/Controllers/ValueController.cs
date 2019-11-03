using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Fitorso.Viewmodels;
using Logic;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Query;

namespace Fitorso.Controllers
{
    public class ValueController : Controller
    {
        private UserLogic logic;
        public ValueController()
        {
            logic = new UserLogic();
        }
        public IActionResult AddWeight()
        {
            var userEmail = HttpContext.User.Claims.Where(i => i.Type == ClaimTypes.Email).First().Value;
            var _user = logic.GetUserByEmail(userEmail);
            var viewmodel = new DashboardViewmodel
            {
                User = _user,
                Weight = logic.GetWeightById(_user.Id)
            };
            return View(viewmodel);
        }

        [HttpPost]
        public async Task<ActionResult> AddWeight(DashboardViewmodel viewmodel)
        {
            logic.AddWeight(viewmodel.Weight, viewmodel.User.Id);
            return RedirectToAction("index", "Dashboard");
        }

        public IActionResult AddFatpercentage()
        {
            var userEmail = HttpContext.User.Claims.Where(i => i.Type == ClaimTypes.Email).First().Value;
            var _user = logic.GetUserByEmail(userEmail);
            var viewmodel = new DashboardViewmodel
            {
                User = _user,
                FatPercentage = logic.GetFatById(_user.Id)
            };
            return View(viewmodel);
        }

        [HttpPost]
        public async Task<ActionResult> AddFatpercentage(DashboardViewmodel viewmodel)
        {
            logic.AddFatpercentage(viewmodel.FatPercentage, viewmodel.User.Id);
            return RedirectToAction("index", "Dashboard");
        }

        public async Task<ActionResult> CalcBmi(DashboardViewmodel viewmodel)
        {
            var userEmail = HttpContext.User.Claims.Where(i => i.Type == ClaimTypes.Email).First().Value;
            var _user = logic.GetUserByEmail(userEmail);
            var _viewmodel = new DashboardViewmodel
            {
                User = _user,
                Weight = logic.GetWeightById(_user.Id),
                Height = logic.GetHeightById(_user.Id)
            };

            var bmi = logic.CalcBmi(_viewmodel.Weight, _viewmodel.Height, _user.Id);
            return RedirectToAction("index", "Dashboard");
        }
    }
}