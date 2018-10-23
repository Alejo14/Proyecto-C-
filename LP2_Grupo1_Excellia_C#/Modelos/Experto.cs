using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Experto:Trabajador
    {
        private List<Estimacion> listaEstimacion;
        public Experto()
        {
            this.listaEstimacion = new List<Estimacion>();
        }

        public Experto(Dominio dominio)
        {
            this.listaEstimacion = new List<Estimacion>();
            this.Dominio = dominio;
        }
        internal List<Estimacion> ListaEstimacion { get => listaEstimacion; set => listaEstimacion = value; }
    }
}
