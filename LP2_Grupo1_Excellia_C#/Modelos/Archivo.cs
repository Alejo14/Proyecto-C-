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
        private int idProyecto;
        private int idTrabajador;

        public Archivo(int idArchivo, string nombre)
        {
            this.idArchivo = idArchivo;
            this.nombre = nombre;
            this.contenido = null;
        }


        public Archivo(int idArchivo, string nombre, byte[] contenido, int idProy, int idTrab)
        {
            this.idArchivo = idArchivo;
            this.nombre = nombre;
            this.contenido = contenido;
            this.idProyecto = idProy;
            this.idTrabajador = idTrab;
        }

        public Archivo(int idArchivo, string nombre, int idProy, int idTrab)
        {
            this.idArchivo = idArchivo;
            this.nombre = nombre;
            this.contenido = null;
            this.idProyecto = idProy;
            this.idTrabajador = idTrab;
        }

        public int IdArchivo { get => idArchivo; set => idArchivo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public byte[] Contenido { get => contenido; set => contenido = value; }
        public int IdProyecto { get => idProyecto; set => idProyecto = value; }
        public int IdTrabajador { get => idTrabajador; set => idTrabajador = value; }
    }
}
