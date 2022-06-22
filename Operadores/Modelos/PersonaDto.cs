using System;

namespace Operadores.Modelos
{
    public class PersonaDto
    {
        public int Id { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public string Profesion { get; set; }
    }
}
