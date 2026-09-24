using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Dtos
{
    public class IngresoProductoDto
    {
        public int Id_Ingreso { get; set; }
        public string No_Ingreso { get; set; }
        public int Id_Proveedor { get; set; }
        public DateTime Fecha_Ingreso { get; set; }
        public string Comprobante { get; set; }
        public decimal Monto_Total { get; set; }
        public string Estado { get; set; }
    }
}
