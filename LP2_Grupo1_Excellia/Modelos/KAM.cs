using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class KAM: Trabajador
    {
        private List<ERU> listaERU;
        private List<SolicitudCambio> listaSolicitudCambio;
        public KAM()
        {
            this.listaERU = new List<ERU>();
            this.listaSolicitudCambio = new List<SolicitudCambio>();
        }
        internal List<ERU> ListaERU { get => listaERU; set => listaERU = value; }
        internal List<SolicitudCambio> ListaSolicitudCambio { get => listaSolicitudCambio; set => listaSolicitudCambio = value; }
    }
}
