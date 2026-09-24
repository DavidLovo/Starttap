using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Detalle_Ingreso
    {
        public int Id_Detalle { get; set; }
        public int Id_Ingreso { get; set; }
        public int Id_Producto { get; set; }
        public string Nombre_Producto { get; set; }
        public int Cantidad { get; set; }
        public decimal Costo_Unitario { get; set; }
        public decimal Sub_Total { get; set; }
    }
}
