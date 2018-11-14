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
        private TipoTrabajador cargo;
        
        public Trabajador() { this.dominio = new Dominio(); }

        public Trabajador(int idTrabajador)
        {
            this.idTrabajador = idTrabajador;
            //this.dominio = new Dominio();
        }
        public int IdTrabajador { get => idTrabajador; set => idTrabajador = value; }
        public Dominio Dominio { get => dominio; set => dominio = value; }
        public TipoTrabajador CargoTrabajador { get => cargo; set => cargo = value; }
        public string Descripcion { get => cargo.Descripcion; set => cargo.Descripcion = value; }
        public int TipoTrabajador {
            get {
                int idTipo = 0;

                if (this is KAM)
                    idTipo = 2;
                else if (this is Experto)
                    idTipo = 3;
                else if (this is JefeProyecto)
                    idTipo = 4;
                else {
                    Operario operario = (Operario)this;
                    idTipo = operario.IdTipo;
                }

                return idTipo;
            }
        }
    }
}
