using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Productos
    {
        public int Id_Producto { get; set; }
        public string Codigo_Producto { get; set; }
        public string Nombre_Producto { get; set; }
        public string Descripcion { get; set; }
        public string Presentacion { get; set; }
        public string Lote { get; set; }
        public DateTime Fecha_Caducidad { get; set; }
        public decimal Costo_Unitario { get; set; }
        public decimal Precio_Venta { get; set; }
        public string Estado { get; set; }
        public string Categoria { get; set; }
        public int Id_Proveedor { get; set; }
        public DateTime Fecha_Ingreso { get; set; }
    }
}
