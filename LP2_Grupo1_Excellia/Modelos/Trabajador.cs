using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Trabajador: Persona
    {
        private int idTrabajador;
        private Dominio dominio;
        public Trabajador() { this.dominio = new Dominio(); }

        public Trabajador(int idTrabajador)
        {
            this.idTrabajador = idTrabajador;
            this.dominio = new Dominio();
        }
        public int IdTrabajador { get => idTrabajador; set => idTrabajador = value; }
        internal Dominio Dominio { get => dominio; set => dominio = value; }
    }
}
