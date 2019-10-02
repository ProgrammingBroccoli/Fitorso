using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Mvc;
using System.Xml;
using DAL;
using Fitorso.Models;
using Models;

namespace Fitorso.Controllers
{
    public class LoginController : Controller
    {

        public LoginController()
        {
           
        }
        // GET: Login
        public ActionResult Index()
        {
            var viewmodel = new LoginViewModel();
            var model = new User();
            return View(model);
        }

        public ActionResult Register()
        {
            var model = new User();
            return View(model);
        }

        [HttpPost]
        public ActionResult Register(User user)
        {
            var _context = new UserMemoryContext();
            _context.RegisterNewAccount(user.Email, user.Password);
            return Content(user.Email);
        }
    }
}