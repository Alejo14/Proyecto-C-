using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class SolicitudRetiro
    {
        private int idSolicitud;
        private string descripcion;
        private DateTime fechaSolicitud;
        private TipoEstadoSolicitud estado;
        private Proyecto proyecto;
        private JefeProyecto jefeProyecto;
        private Operario operario;
        public SolicitudRetiro()
        {
            this.proyecto = new Proyecto();
            this.jefeProyecto = new JefeProyecto();
            this.operario = new Operario();
        }

        public SolicitudRetiro(int idSolicitud, string descripcion,
                DateTime fechaSolicitud, TipoEstadoSolicitud estado)
        {
            this.descripcion = descripcion;
            this.estado = estado;
            this.fechaSolicitud = fechaSolicitud;
            this.proyecto = new Proyecto();
            this.jefeProyecto = new JefeProyecto();
            this.operario = new Operario();
        }
        public int IdSolicitud { get => idSolicitud; set => idSolicitud = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public DateTime FechaSolicitud { get => fechaSolicitud; set => fechaSolicitud = value; }
        internal TipoEstadoSolicitud Estado { get => estado; set => estado = value; }
        internal Proyecto Proyecto { get => proyecto; set => proyecto = value; }
        internal JefeProyecto JefeProyecto { get => jefeProyecto; set => jefeProyecto = value; }
        internal Operario Operario { get => operario; set => operario = value; }
    }
}
