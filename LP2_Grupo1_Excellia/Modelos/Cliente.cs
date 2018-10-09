using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Cliente: Persona
    {
        private int idCliente;
        private string nomEmpresa;
        private Empresa empresa;
        private List<ERU> listaEru;
        private List<DetalleEntrega> listaDetalleEntrega;

        public Cliente()
        {
            this.empresa = new Empresa();
            this.listaEru = new List<ERU>();
            this.listaDetalleEntrega = new List<DetalleEntrega>();
        }

        public Cliente(int idCliente, string nomEmpresa)
        {
            this.idCliente = idCliente;
            this.nomEmpresa = nomEmpresa;
            this.empresa = new Empresa();
            this.listaEru = new List<ERU>();
            this.listaDetalleEntrega = new List<DetalleEntrega>();
        }

        public int IdCliente { get => idCliente; set => idCliente = value; }
        public string NomEmpresa { get => nomEmpresa; set => nomEmpresa = value; }
        internal Empresa Empresa { get => empresa; set => empresa = value; }
        internal List<ERU> ListaEru { get => listaEru; set => listaEru = value; }
        internal List<DetalleEntrega> ListaDetalleEntrega { get => listaDetalleEntrega; set => listaDetalleEntrega = value; }
    }
}
