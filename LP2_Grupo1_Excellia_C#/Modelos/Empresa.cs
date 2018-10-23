using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
     public class Empresa
    {
        private int idEmpresa;
        private string ruc;
        private string razonSocial;
        private string direccion;
        private List<Cliente> listaCliente;
        private List<Dominio> listaDominio;

        public Empresa()
        {
            //this.listaCliente = new List<Cliente>();
            //this.listaDominio = new List<Dominio>();
        }

        public Empresa(int idEmpresa, string ruc, string razonSocial,
                string direccion)
        {
            this.idEmpresa = idEmpresa;
            this.ruc = ruc;
            this.direccion = direccion;
            this.razonSocial = razonSocial;
            //this.listaCliente = new List<Cliente>();
            //this.listaDominio = new List<Dominio>();
        }
        public int IdEmpresa { get => idEmpresa; set => idEmpresa = value; }
        public string Ruc { get => ruc; set => ruc = value; }
        public string RazonSocial { get => razonSocial; set => razonSocial = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        internal List<Cliente> ListaCliente { get => listaCliente; set => listaCliente = value; }
        internal List<Dominio> ListaDominio { get => listaDominio; set => listaDominio = value; }
    }
}
