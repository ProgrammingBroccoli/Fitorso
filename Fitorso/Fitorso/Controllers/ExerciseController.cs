using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Fitorso.Viewmodels;
using Logic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Fitorso.Controllers
{
    [Authorize]
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
                FavoriteExercises = logic.GetFavExercisesById(_user.Id),
                Musclegroups = logic.GetMusclegroups()
            };
            return View(viewmodel);
        }

        [HttpGet]
        public void RemoveFavorite(int exerciseId, int userId)
        {
            logic.RemoveFavorite(exerciseId, userId);
            //return RedirectToAction("Index", "Exercise");
        }

        public IActionResult AddExerciseIndex()
        {
            var userEmail = HttpContext.User.Claims.Where(i => i.Type == ClaimTypes.Email).First().Value;
            var _user = logic.GetUserByEmail(userEmail);
            var musclegroups = logic.GetMusclegroups();
            var viewmodel = new ExerciseViewmodel
            {
                User = _user,
                Exercises = logic.GetExercises(),
                Musclegroups = logic.GetMusclegroups()
            };
            return View(viewmodel);
        }

        [HttpGet]
        public ActionResult AddFavorite(int exerciseId, int userId)
        {
            logic.AddFavorite(userId, exerciseId);
            return RedirectToAction("Index", "Exercise");
        }

        public IActionResult GenerateTrainingIndex()
        {
            var userEmail = HttpContext.User.Claims.Where(i => i.Type == ClaimTypes.Email).First().Value;
            var _user = logic.GetUserByEmail(userEmail);
            var exercises = logic.GenerateTraining(_user);
            var viewmodel = new ExerciseViewmodel
            {
                Exercises = exercises,
                Musclegroups = logic.GetMusclegroups()
            };
            return View(viewmodel);
        }
    }
}