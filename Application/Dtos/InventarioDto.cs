using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Dtos
{
    public class InventarioDto
    {
        public int Id_Inventario { get; set; }
        public int Id_Proveedor { get; set; }
        public string Nombre_Proveedor { get; set; }
        public int Id_Producto { get; set; }
        public string Nombre_Producto { get; set; }
        public int Cantidad { get; set; }
    }
}
