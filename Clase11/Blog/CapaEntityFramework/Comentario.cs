//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaEntityFramework
{
    using System;
    using System.Collections.Generic;
    
    public partial class Comentario
    {
        public int Id { get; set; }
        public string Autor { get; set; }
        public string Comentario1 { get; set; }
        public Nullable<int> IdPost { get; set; }
    
        public virtual Post Post { get; set; }
    }
}
