//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProveedorTuTienditaPS4.Models.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProveedorVentaEstado
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProveedorVentaEstado()
        {
            this.ProveedorVenta = new HashSet<ProveedorVenta>();
        }
    
        public int idProveedorVentaEstado { get; set; }
        public string nombreEstado { get; set; }
        public Nullable<bool> vigente { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProveedorVenta> ProveedorVenta { get; set; }
    }
}
