using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class JefeProyecto:Trabajador
    {
        private List<Proyecto> listaProyecto;
        private List<SolicitudRetiro> listaSolicitudRetiro;
        public JefeProyecto()
        {
            this.listaProyecto = new List<Proyecto>();
            this.listaSolicitudRetiro = new List<SolicitudRetiro>();
        }
        internal List<Proyecto> ListaProyecto { get => listaProyecto; set => listaProyecto = value; }
        internal List<SolicitudRetiro> ListaSolicitudRetiro { get => listaSolicitudRetiro; set => listaSolicitudRetiro = value; }
    }
}
