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
        public int idVenta { get; set; }
        public Nullable<int> cantidad { get; set; }
        public string hora { get; set; }
        public Nullable<decimal> importe { get; set; }
        public Nullable<int> fk_idTaquillero { get; set; }
        public Nullable<int> fk_idPelicula { get; set; }
        public string fechaFuncion { get; set; }
        public string horaFuncion { get; set; }
    
        public virtual funcion funcion { get; set; }
        public virtual usuario usuario { get; set; }
    }
}
