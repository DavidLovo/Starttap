using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Inventario
    {
        public int Id_Inventario { get; set; }
        public int Id_Proveedor { get; set; }
        public string Nombre_Proveedor { get; set; }
        public int Id_Producto { get; set; }
        public string Nombre_Producto { get; set; }
        public int Cantidad { get; set; }
    }
}
