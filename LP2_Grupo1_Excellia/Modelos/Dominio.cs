using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Dominio
    {
        private Empresa empresa;
        private int idDominio;
        private string denominacion;
        private List<Trabajador> listaTrabajador;

        public Dominio()
        {
            this.listaTrabajador = new List<Trabajador>();
            this.empresa = new Empresa();
        }

        public Dominio(int idDominio, string denominacion)
        {
            this.idDominio = idDominio;
            this.denominacion = denominacion;
            this.listaTrabajador = new List<Trabajador>();
            this.empresa = new Empresa();
        }
        public int IdDominio { get => idDominio; set => idDominio = value; }
        public string Denominacion { get => denominacion; set => denominacion = value; }
        internal Empresa Empresa { get => empresa; set => empresa = value; }
        internal List<Trabajador> ListaTrabajador { get => listaTrabajador; set => listaTrabajador = value; }
    }
}
