using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProveedorTuTienditaPS4.Models.ViewModels
{
    public class LoginViewModels
    {
        [Required(ErrorMessage = "El campo Username es requerido")]
        [MaxLength(50,ErrorMessageResourceName = "El campo Username tiene un máximo de 50 caracteres")]
        public string Username { get; set; }
        [Required(ErrorMessage ="El campo Password es requerido")]
        [MaxLength(20,ErrorMessageResourceName ="El campo Password tiene un máximo de 20 caracteres")]
        public string Password { get; set; }
    }
}