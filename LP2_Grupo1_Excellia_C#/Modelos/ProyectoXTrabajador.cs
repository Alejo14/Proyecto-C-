using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ProyectoXTrabajador
    {
        private int idProyectoxTrabajador;
        private int idProyecto;
        private int idTrabajador;
        private bool retirado;

        public ProyectoXTrabajador()
        {

        }
        public ProyectoXTrabajador(int idProyectoxTrabajador, int idProyecto, int idTrabajador, bool retirado)
        {
            this.idProyectoxTrabajador = idProyectoxTrabajador;
            this.idProyecto = idProyecto;
            this.idTrabajador = idTrabajador;
            this.retirado = retirado;
        }

        public int IdProyectoxTrabajador { get => idProyectoxTrabajador; set => idProyectoxTrabajador = value; }
        public int IdProyecto { get => idProyecto; set => idProyecto = value; }
        public int IdTrabajador { get => idTrabajador; set => idTrabajador = value; }
        public bool Retirado { get => retirado; set => retirado = value; }
    }
}
