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
    
    public partial class ventas
    {
        public int idVenta { get; set; }
        public Nullable<int> cantidad { get; set; }
        public string hora { get; set; }
        public Nullable<decimal> importe { get; set; }
        public Nullable<int> fk_idTaquillero { get; set; }
        public string idFuncion { get; set; }
        public Nullable<decimal> precio { get; set; }
    
        public virtual funcion funcion { get; set; }
        public virtual usuario usuario { get; set; }
    }
}
