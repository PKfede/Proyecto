//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VistasCineWPF.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class funcion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public funcion()
        {
            this.ventas = new HashSet<ventas>();
        }
    
        public string idFuncion { get; set; }
        public string fechaFuncion { get; set; }
        public string horaFuncion { get; set; }
        public Nullable<int> asientosDisponibles { get; set; }
        public Nullable<int> asientosOcupados { get; set; }
        public string asientoAsignado { get; set; }
        public string diagrama { get; set; }
        public decimal fk_precio { get; set; }
        public Nullable<int> fk_idPelicula { get; set; }
    
        public virtual pelicula pelicula { get; set; }
        public virtual tarifa tarifa { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ventas> ventas { get; set; }
    }
}