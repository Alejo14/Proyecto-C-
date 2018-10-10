using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Operario: Trabajador
    {
        private TipoCargo cargo;
        private List<Proyecto> listaProyecto;
        private List<SolicitudRetiro> listaSolicitudRetiro;
        public Operario()
        {
            this.listaProyecto = new List<Proyecto>();
            this.listaSolicitudRetiro = new List<SolicitudRetiro>();
        }

        public Operario(TipoCargo cargo)
        {
            this.cargo = cargo;
            this.listaProyecto = new List<Proyecto>();
            this.listaSolicitudRetiro = new List<SolicitudRetiro>();
        }
        internal TipoCargo Cargo { get => cargo; set => cargo = value; }
        internal List<Proyecto> ListaProyecto { get => listaProyecto; set => listaProyecto = value; }
        internal List<SolicitudRetiro> ListaSolicitudRetiro { get => listaSolicitudRetiro; set => listaSolicitudRetiro = value; }
    }
}
