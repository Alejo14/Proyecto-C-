using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Archivo
    {
        private int idArchivo;
        private String nombre;
        private Byte[] contenido;

        public Archivo(int idArchivo, string nombre, byte[] contenido)
        {
            this.idArchivo = idArchivo;
            this.nombre = nombre;
            this.contenido = contenido;
        }

        public Archivo(int idArchivo, string nombre)
        {
            this.idArchivo = idArchivo;
            this.nombre = nombre;
            this.contenido = null;
        }

        public int IdArchivo { get => idArchivo; set => idArchivo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public byte[] Contenido { get => contenido; set => contenido = value; }
    }
}
