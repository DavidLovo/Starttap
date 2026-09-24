using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Dtos
{
    public class ClienteDto
    {
        public int Id_Cliente { get; set; }
        public string Codigo_Cliente { get; set; }
        public string Nombre_Cliente { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Identificacion { get; set; }
        public string Correo { get; set; }
        public string Estado { get; set; }
        public DateTime Fecha_Ingreso { get; set; }
    }
}
