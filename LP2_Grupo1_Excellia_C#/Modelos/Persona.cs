using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Persona
    {
        private string dni;
        private string nombre;
        private string apellidoPaterno;
        private string apellidoMaterno;
        private char sexo;
        private DateTime fechaNac;
        private string correo;
        private string telefono;
        public Persona() {}

        public Persona(string dni, string nombre, string apellidoPaterno,
                string apellidoMaterno, char sexo, DateTime fechaNac, string correo,
                string telefono)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.apellidoMaterno = apellidoMaterno;
            this.apellidoMaterno = apellidoMaterno;
            this.sexo = sexo;
            this.correo = correo;
            this.telefono = telefono;
        }
        public string Dni { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string ApellidoPaterno { get => apellidoPaterno; set => apellidoPaterno = value; }
        public string ApellidoMaterno { get => apellidoMaterno; set => apellidoMaterno = value; }
        public char Sexo { get => sexo; set => sexo = value; }
        public DateTime FechaNac { get => fechaNac; set => fechaNac = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Telefono { get => telefono; set => telefono = value; }
    }
}
