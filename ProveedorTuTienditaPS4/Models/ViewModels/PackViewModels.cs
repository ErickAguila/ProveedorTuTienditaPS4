using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProveedorTuTienditaPS4.Models.ViewModels
{
    public class PackViewModels
    {
        public int IdPack { get; set; }
        public string Email { get; set; }
        public double price { get; set; }
        public string description { get; set; }
    }
}