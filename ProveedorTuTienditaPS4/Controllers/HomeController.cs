using ProveedorTuTienditaPS4.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProveedorTuTienditaPS4.Models.Entity;

namespace ProveedorTuTienditaPS4.Controllers
{
    public class HomeController : Controller
    {
        tutienditaps4_Entities modelo = new tutienditaps4_Entities();

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
            try
            {
                var respuesta = modelo.Usuario.Where(c => c.emailUsuario == model.Username && c.password == model.Password).FirstOrDefault();
                if (respuesta != null)
                {
                    return View("Index");
                }
                else
                {
                    return View();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpPost]
        public ActionResult GuardarPack(PackViewModels model)
        {
            return View(model);
        }
    }
}
