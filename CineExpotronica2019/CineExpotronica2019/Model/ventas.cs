//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CineExpotronica2019.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class ventas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ventas()
        {
            this.boletoVendido = new HashSet<boletoVendido>();
        }
    
        public int idVenta { get; set; }
        public Nullable<int> cantidad_boletos { get; set; }
        public Nullable<decimal> importe { get; set; }
        public Nullable<int> idTaquillero { get; set; }
        public Nullable<int> fk_idTaquillero { get; set; }
        public Nullable<int> tarifa { get; set; }
        public Nullable<int> idPelicula { get; set; }
        public string fechaFuncion { get; set; }
        public string horaFuncion { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<boletoVendido> boletoVendido { get; set; }
        public virtual funcion funcion { get; set; }
        public virtual usuario usuario { get; set; }
    }
}
