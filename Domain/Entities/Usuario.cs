using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Usuario
    {
        public int Id_Usuario { get; set; }
        public string Codigo_Usuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Usuarios { get; set; }
        public string Contraseña { get; set; }
        public string Estado { get; set; }
        public string Roll { get; set; }
        public DateTime Fecha_Ingresa { get; set; }
    }
}
