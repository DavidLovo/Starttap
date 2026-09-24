using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Dtos
{
    public class UsuarioDto
    {
        public int Id_Usuario { get; set; }
        public string Codigo_Usuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Usuario { get; set; }
        public string Contraseña { get; set; }
        public string Estado { get; set; }
        public string Roll { get; set; }
        public DateTime Fecha_Ingresa { get; set; }
    }
}
