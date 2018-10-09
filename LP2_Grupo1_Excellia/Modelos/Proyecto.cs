using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Proyecto
    {
        private int idProyecto;
        private string nombre;
        private TipoFaseProyecto etapa;
        private float presupuesto;
        private int codigoGestorProyecto;
        private DateTime fechaInicio;
        private DateTime fechaFinEstimada;
        private DateTime fechaRealFin;
        private List<DetalleEntrega> listaDetalleEntrega;
        private JefeProyecto jefeProyecto;
        private List<Operario> listaOperario;
        private ERU eru;
        private List<SolicitudRetiro> listaSolicitudRetiro;
        public Proyecto()
        {
            this.jefeProyecto = new JefeProyecto();
            this.listaDetalleEntrega = new List<DetalleEntrega>();
            this.listaOperario = new List<Operario>();
            this.listaSolicitudRetiro = new List<SolicitudRetiro>();
            this.eru = new ERU();
        }

        public Proyecto(int idProyecto, string nombre, TipoFaseProyecto etapa,
                float presupuesto, int codigoGestorProyecto, DateTime fechaInicio,
                DateTime fechaFinEstimada, DateTime fechaRealFin)
        {
            this.idProyecto = idProyecto;
            this.etapa = etapa;
            this.presupuesto = presupuesto;
            this.codigoGestorProyecto = codigoGestorProyecto;
            this.fechaInicio = fechaInicio;
            this.fechaFinEstimada = fechaFinEstimada;
            this.fechaRealFin = fechaRealFin;
            this.jefeProyecto = new JefeProyecto();
            this.listaDetalleEntrega = new List<DetalleEntrega>();
            this.listaOperario = new List<Operario>();
            this.eru = new ERU();
            this.listaSolicitudRetiro = new List<SolicitudRetiro>();
        }
        public int IdProyecto { get => idProyecto; set => idProyecto = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public float Presupuesto { get => presupuesto; set => presupuesto = value; }
        public int CodigoGestorProyecto { get => codigoGestorProyecto; set => codigoGestorProyecto = value; }
        public DateTime FechaInicio { get => fechaInicio; set => fechaInicio = value; }
        public DateTime FechaFinEstimada { get => fechaFinEstimada; set => fechaFinEstimada = value; }
        public DateTime FechaRealFin { get => fechaRealFin; set => fechaRealFin = value; }
        internal TipoFaseProyecto Etapa { get => etapa; set => etapa = value; }
        internal List<DetalleEntrega> ListaDetalleEntrega { get => listaDetalleEntrega; set => listaDetalleEntrega = value; }
        internal JefeProyecto JefeProyecto { get => jefeProyecto; set => jefeProyecto = value; }
        internal List<Operario> ListaOperario { get => listaOperario; set => listaOperario = value; }
        internal ERU Eru { get => eru; set => eru = value; }
        internal List<SolicitudRetiro> ListaSolicitudRetiro { get => listaSolicitudRetiro; set => listaSolicitudRetiro = value; }
    }
}
