using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Dtos
{
    public class ComprobanteDto
    {
        public int Id_Comprobante { get; set; }
        public string Nombre_Comprobante { get; set; }
        public string Tipo_Comprobante { get; set; }
        public int Correlativo { get; set; }
    }
}
