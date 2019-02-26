using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProveedorTuTienditaPS4.Models.ViewModels
{
    public class ProveedorVentaViewModels
    {        
        [Required(ErrorMessageResourceName = "El campo Email es requerido")]
        [MaxLength(50, ErrorMessageResourceName ="El campo Email no debe ser mas de 50 caracteres")]
        public string Email { get; set; }
        [Required(ErrorMessageResourceName ="El campo USD es requerido")]
        public double Usd { get; set; }
        [Required(ErrorMessageResourceName ="El campo Descripcion es querido")]
        [MaxLength(250, ErrorMessageResourceName = "El campo Descripción no debe ser más de 250 caracteres")]
        public string Descripcion { get; set; }
    }
}