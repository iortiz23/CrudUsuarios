using System;

namespace Entities
{
    public class Usuario
    {

        public int Id { get; set; }

        public decimal Identificacion { get; set; }

        public string NombreUsuario { get; set; }

        public string Genero { get; set; } 

        public decimal NumeroTelefono { get; set; }

        public string Correo { get; set; }
    }
}
