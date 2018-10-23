using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Entregable
    {
        private int idEntregable;
        private string descripcion;
        private bool esFinal;
        private List<DetalleEntrega> listaDetalleEntrega;
        public Entregable() { this.listaDetalleEntrega = new List<DetalleEntrega>(); }

        public Entregable(int idEntregable, string descripcion, bool esFinal)
        {
            this.idEntregable = idEntregable;
            this.descripcion = descripcion;
            this.esFinal = esFinal;
            this.listaDetalleEntrega = new List<DetalleEntrega>();
        }
        public int IdEntregable { get => idEntregable; set => idEntregable = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public bool EsFinal { get => esFinal; set => esFinal = value; }
        internal List<DetalleEntrega> ListaDetalleEntrega { get => listaDetalleEntrega; set => listaDetalleEntrega = value; }
    }
}
