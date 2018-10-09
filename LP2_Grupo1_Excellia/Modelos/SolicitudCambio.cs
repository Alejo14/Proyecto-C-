using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class SolicitudCambio
    {
        private int idSolicitud;
        private string descripcion;
        private DateTime fechaSolicitud;
        private bool aprobada;
        private bool seAgregaRequerimiento;
        private Estimacion estimacion;
        private Requerimiento requerimiento;
        private KAM kam;
        private Cliente cliente;
        public SolicitudCambio()
        {
            this.estimacion = new Estimacion();
            this.requerimiento = new Requerimiento();
            this.kam = new KAM();
            this.cliente = new Cliente();
        }

        public SolicitudCambio(int idSolicitud, string descripcion, DateTime fechaSolicitud,
                bool aprobada, bool seAgregaRequerimiento)
        {
            this.idSolicitud = idSolicitud;
            this.descripcion = descripcion;
            this.fechaSolicitud = fechaSolicitud;
            this.aprobada = aprobada;
            this.seAgregaRequerimiento = seAgregaRequerimiento;
            this.estimacion = new Estimacion();
            this.requerimiento = new Requerimiento();
            this.kam = new KAM();
            this.cliente = new Cliente();
        }
        public int IdSolicitud { get => idSolicitud; set => idSolicitud = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public DateTime FechaSolicitud { get => fechaSolicitud; set => fechaSolicitud = value; }
        public bool Aprobada { get => aprobada; set => aprobada = value; }
        public bool SeAgregaRequerimiento { get => seAgregaRequerimiento; set => seAgregaRequerimiento = value; }
        internal Estimacion Estimacion { get => estimacion; set => estimacion = value; }
        internal Requerimiento Requerimiento { get => requerimiento; set => requerimiento = value; }
        internal KAM Kam { get => kam; set => kam = value; }
        internal Cliente Cliente { get => cliente; set => cliente = value; }
    }
}
