using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Dtos
{
    public class VentaDto
    {
        public int Id_Venta { get; set; }
        public int Id_Cliente { get; set; }
        public string No_Factura { get; set; }
        public DateTime Fecha_Venta { get; set; }
        public DateTime Fecha_Validez { get; set; }
        public string Comprobante { get; set; }
        public decimal Sub_Total { get; set; }
        public decimal Descuento { get; set; }
        public decimal Iva { get; set; }
        public decimal Monto_Total { get; set; }
        public string Estado { get; set; }
        public int Id_Usuario { get; set; }
    }
}
