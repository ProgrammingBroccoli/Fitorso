using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Fitorso.Viewmodels;
using Logic;
using Microsoft.AspNetCore.Mvc;

namespace Fitorso.Controllers
{
    public class ExerciseController : Controller
    {
        private UserLogic logic;
        public ExerciseController()
        {
            logic = new UserLogic();
        }
        public IActionResult Index()
        {
            var userEmail = HttpContext.User.Claims.Where(i => i.Type == ClaimTypes.Email).First().Value;
            var _user = logic.GetUserByEmail(userEmail);
            var viewmodel = new ExerciseViewmodel
            {
                User = _user,
                FavoritExercises = logic.GetFavExercisesById(_user.Id)
            };
            //implement fav exercises view
            return View(viewmodel);
        }
    }
}