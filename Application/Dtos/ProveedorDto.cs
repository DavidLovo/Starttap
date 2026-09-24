using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Dtos
{
    public class ProveedorDto
    {
        public int Id_Proveedor { get; set; }
        public string? Codigo_Proveedor { get; set; }
        public string? Nombre_Proveedor { get; set; }
        public string? Telefono { get; set; }
        public string? Direccion { get; set; }
        public string? Identificacion { get; set; }
        public string? Correo { get; set; }
        public string? Estado { get; set; }
        public DateTime Fecha_Ingreso { get; set; }
    }
}
