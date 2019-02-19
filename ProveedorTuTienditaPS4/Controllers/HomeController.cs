using ProveedorTuTienditaPS4.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProveedorTuTienditaPS4.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            LoginViewModels login = new LoginViewModels();
            return View(login);
        }

        [HttpPost]
        public ActionResult Login(LoginViewModels model)
        {
            return View("Index");
        }

        [HttpPost]
        public ActionResult GuardarPack(PackViewModels model)
        {
            return View(model);
        }
    }
}
