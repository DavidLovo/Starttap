using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Detalle_Venta
    {
        public int Id_Detalle { get; set; }
        public int Id_Venta { get; set; }
        public int Id_Producto { get; set; }
        public string Presentacion { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio_Venta { get; set; }
        public decimal Sub_Total { get; set; }
        public decimal Descuento { get; set; }
        public decimal Iva { get; set; }
        public decimal Monto_Total { get; set; }
    }
}
