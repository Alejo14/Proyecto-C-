using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Objetivo
    {
        private int idObjetivo;
        private string descripcion;
        private List<AlineamientoObjetivo> listaAlineamientoObjetivo;
        public Objetivo() { this.listaAlineamientoObjetivo = new List<AlineamientoObjetivo>(); }

        public Objetivo(int idObjetivo, string descripcion)
        {
            this.idObjetivo = idObjetivo;
            this.descripcion = descripcion;
            this.listaAlineamientoObjetivo = new List<AlineamientoObjetivo>();
        }
        public int IdObjetivo { get => idObjetivo; set => idObjetivo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        internal List<AlineamientoObjetivo> ListaAlineamientoObjetivo { get => listaAlineamientoObjetivo; set => listaAlineamientoObjetivo = value; }
    }
}
