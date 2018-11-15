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
        private TipoEstadoSolicitud estado;
        private bool seAgregaRequerimiento;
        private Estimacion estimacion;
        private Requerimiento requerimiento;
        private KAM kam;
        private Cliente cliente;
        private Proyecto proyecto;
        public SolicitudCambio()
        {
            //this.estimacion = new Estimacion();
            this.requerimiento = new Requerimiento();
            this.kam = new KAM();
            this.cliente = new Cliente();
        }

        public SolicitudCambio(int idSolicitud, string descripcion, DateTime fechaSolicitud,
                 TipoEstadoSolicitud estado, bool seAgregaRequerimiento)
        {
            this.idSolicitud = idSolicitud;
            this.descripcion = descripcion;
            this.fechaSolicitud = fechaSolicitud;
            this.estado = estado;
            this.seAgregaRequerimiento = seAgregaRequerimiento;
            this.estimacion = new Estimacion();
            this.requerimiento = new Requerimiento();
            this.kam = new KAM();
            this.cliente = new Cliente();
        }
        public int IdSolicitud { get => idSolicitud; set => idSolicitud = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public DateTime FechaSolicitud { get => fechaSolicitud; set => fechaSolicitud = value; }
        public bool SeAgregaRequerimiento { get => seAgregaRequerimiento; set => seAgregaRequerimiento = value; }
        public TipoEstadoSolicitud Estado { get => estado; set => estado = value; }
        public Estimacion Estimacion { get => estimacion; set => estimacion = value; }
        public Requerimiento Requerimiento { get => requerimiento; set => requerimiento = value; }
        public KAM Kam { get => kam; set => kam = value; }
        public Cliente Cliente { get => cliente; set => cliente = value; }
        public Proyecto Proyecto { get => proyecto; set => proyecto = value; }

        public void setEstado(int idEstado) {
            switch (idEstado) {
                case 0:
                    estado = TipoEstadoSolicitud.APROBADA;
                    break;
                case 1:
                    estado = TipoEstadoSolicitud.DESAPROBADA;
                    break;
                case 2:
                    estado = TipoEstadoSolicitud.ENVIADA;
                    break;
                case 3:
                    estado = TipoEstadoSolicitud.COMPLETADA;
                    break;
            }
        }
    }
}
