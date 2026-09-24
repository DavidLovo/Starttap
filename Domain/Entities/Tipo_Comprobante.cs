using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Tipo_Comprobante
    {
        public int Id_Comprobante { get; set; }
        public string Nombre_Comprobante { get; set; }
        public string TipoComprobante { get; set; }
        public int Correlativo { get; set; }
    }
}
