using ProveedorTuTienditaPS4.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProveedorTuTienditaPS4.Models.Entity;
using System.Text;
using System.Security.Cryptography;
using System.IO;
using Newtonsoft.Json;

namespace ProveedorTuTienditaPS4.Controllers
{
    //[Authorize]
    public class HomeController : Controller
    {
        tutienditaps4_Entities modelo = new tutienditaps4_Entities();

        public ActionResult Index(Usuario usuario)
        {
            ViewBag.Title = "Home Page";
            ViewBag.NombreUsuario = usuario.nombreUsuario;
            //var encrip = Encripta("prueba");
            ProveedorVentaViewModels proveedorVenta = new ProveedorVentaViewModels();
            return View("Index", proveedorVenta);
        }

        [HttpGet]
        [AllowAnonymous]
        public ActionResult Login()
        {
            LoginViewModels login = new LoginViewModels();
            return View(login);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginViewModels model)
        {
            try
            {
                var respuesta = modelo.Usuario.Where(c => c.emailUsuario == model.Username && c.password == model.Password).FirstOrDefault();
                if (respuesta != null)
                {
                    Usuario usuario = new Usuario()
                    {
                        nombreUsuario = respuesta.nombreUsuario,
                        apellidoUsuario = respuesta.apellidoUsuario,
                        emailUsuario = respuesta.emailUsuario,
                        idUsuarioPerfil = respuesta.idUsuarioPerfil
                    };

                    return Index(usuario);
                }
                else
                {
                    ViewBag.MensajeError = "Datos son incorrectos";
                    return View();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpPost]
        public ActionResult GuardarPack(ProveedorVentaViewModels model)
        {
            try
            {
                ProveedorVenta proveedorVenta = new ProveedorVenta()
                {
                    idUsuario = 2,
                    descripcion = model.Descripcion,
                    USD = model.Usd,
                    FechaCreacion = DateTime.Now,
                    idProveedorVentaEstado = 1,
                    email = model.Email
                };

                modelo.ProveedorVenta.Add(proveedorVenta);
                modelo.SaveChanges();

                return View("Index");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public string ListarPack()
        {
            var lista = modelo.sp_ListarPackProveedor();
            return JsonConvert.SerializeObject(lista).ToString();
            //return Json(lista, JsonRequestBehavior.AllowGet);
        }



        public byte[] Clave = Encoding.ASCII.GetBytes("Tu Clave");
        public byte[] IV = Encoding.ASCII.GetBytes("Devjoker7.37hAES");

        public string Encripta(string Cadena)
        {

            byte[] inputBytes = Encoding.ASCII.GetBytes(Cadena);
            byte[] encripted;
            RijndaelManaged cripto = new RijndaelManaged();
            using (MemoryStream ms = new MemoryStream(inputBytes.Length))
            {
                using (CryptoStream objCryptoStream = new CryptoStream(ms, cripto.CreateEncryptor(Clave, IV), CryptoStreamMode.Write))
                {
                    objCryptoStream.Write(inputBytes, 0, inputBytes.Length);
                    objCryptoStream.FlushFinalBlock();
                    objCryptoStream.Close();
                }
                encripted = ms.ToArray();
            }
            return Convert.ToBase64String(encripted);
        }

        public string Desencripta(string Cadena)
        {
            byte[] inputBytes = Convert.FromBase64String(Cadena);
            byte[] resultBytes = new byte[inputBytes.Length];
            string textoLimpio = String.Empty;
            RijndaelManaged cripto = new RijndaelManaged();
            using (MemoryStream ms = new MemoryStream(inputBytes))
            {
                using (CryptoStream objCryptoStream = new CryptoStream(ms, cripto.CreateDecryptor(Clave, IV), CryptoStreamMode.Read))
                {
                    using (StreamReader sr = new StreamReader(objCryptoStream, true))
                    {
                        textoLimpio = sr.ReadToEnd();
                    }
                }
            }
            return textoLimpio;
        }
    }
}
