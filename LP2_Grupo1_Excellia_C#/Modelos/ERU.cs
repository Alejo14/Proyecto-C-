using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ERU
    {
        private int idERU;
        private string descripcion;
        private bool estado;
        private DateTime fechaSolicitud;
        private Cliente cliente;
        private KAM kam;
        private Estimacion estimacion;
        private Evaluacion evaluacion;
        private Proyecto proyecto;
        private List<AlineamientoObjetivo> listaAlienamientoObjtivo;
        private Requerimiento requerimiento;
        public ERU()
        {
            this.kam = new KAM();
            //this.estimacion = new Estimacion();
            //this.evaluacion = new Evaluacion();
            //this.proyecto = new Proyecto();
            //this.listaAlienamientoObjtivo = new List<AlineamientoObjetivo>();
            //this.requerimiento = new Requerimiento();
        }

        public ERU(int idERU, string descripcion, bool estado, DateTime fechaSolicitud)
        {
            this.idERU = idERU;
            this.descripcion = descripcion;
            this.estado = estado;
            this.fechaSolicitud = fechaSolicitud;
            this.kam = new KAM();
            this.estimacion = new Estimacion();
            this.evaluacion = new Evaluacion();
            this.proyecto = new Proyecto();
            this.listaAlienamientoObjtivo = new List<AlineamientoObjetivo>();
            this.requerimiento = new Requerimiento();
        }
        public int IdERU { get => idERU; set => idERU = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public bool Estado { get => estado; set => estado = value; }
        public DateTime FechaSolicitud { get => fechaSolicitud; set => fechaSolicitud = value; }
        public Cliente Cliente { get => cliente; set => cliente = value; }
        internal KAM Kam { get => kam; set => kam = value; }
        internal Estimacion Estimacion { get => estimacion; set => estimacion = value; }
        internal Evaluacion Evaluacion { get => evaluacion; set => evaluacion = value; }
        internal Proyecto Proyecto { get => proyecto; set => proyecto = value; }
        internal List<AlineamientoObjetivo> ListaAlienamientoObjtivo { get => listaAlienamientoObjtivo; set => listaAlienamientoObjtivo = value; }
        internal Requerimiento Requerimiento { get => requerimiento; set => requerimiento = value; }

        public string NombreCliente { get => cliente.NomEmpresa; }
    }
}
