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
    
    public partial class Pack
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pack()
        {
            this.AnunciarPago = new HashSet<AnunciarPago>();
            this.PackJuego = new HashSet<PackJuego>();
            this.PackOferta = new HashSet<PackOferta>();
            this.Venta = new HashSet<Venta>();
        }
    
        public int idPack { get; set; }
        public string nombrePack { get; set; }
        public Nullable<int> precio { get; set; }
        public Nullable<System.DateTime> fechaCreacion { get; set; }
        public Nullable<bool> vigente { get; set; }
        public string email { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AnunciarPago> AnunciarPago { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PackJuego> PackJuego { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PackOferta> PackOferta { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Venta> Venta { get; set; }
    }
}
