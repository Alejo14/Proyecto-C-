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
        private TipoPrioridad prioridad;
        public Proyecto()
        {
            //this.jefeProyecto = new JefeProyecto();
            //this.listaDetalleEntrega = new List<DetalleEntrega>();
            //this.listaOperario = new List<Operario>();
            //this.listaSolicitudRetiro = new List<SolicitudRetiro>();
            //this.eru = new ERU();
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
            //this.jefeProyecto = new JefeProyecto();
            //this.listaDetalleEntrega = new List<DetalleEntrega>();
            //this.listaOperario = new List<Operario>();
            //this.eru = new ERU();
            //this.listaSolicitudRetiro = new List<SolicitudRetiro>();
        }
        public int IdProyecto { get => idProyecto; set => idProyecto = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public float Presupuesto { get => presupuesto; set => presupuesto = value; }
        public int CodigoGestorProyecto { get => codigoGestorProyecto; set => codigoGestorProyecto = value; }
        public DateTime FechaInicio { get => fechaInicio; set => fechaInicio = value; }
        public DateTime FechaFinEstimada { get => fechaFinEstimada; set => fechaFinEstimada = value; }
        public DateTime FechaRealFin { get => fechaRealFin; set => fechaRealFin = value; }
        public TipoFaseProyecto Etapa { get => etapa; set => etapa = value; }
        public List<DetalleEntrega> ListaDetalleEntrega { get => listaDetalleEntrega; set => listaDetalleEntrega = value; }
        public JefeProyecto JefeProyecto { get => jefeProyecto; set => jefeProyecto = value; }
        public List<Operario> ListaOperario { get => listaOperario; set => listaOperario = value; }
        public ERU Eru { get => eru; set => eru = value; }
        public List<SolicitudRetiro> ListaSolicitudRetiro { get => listaSolicitudRetiro; set => listaSolicitudRetiro = value; }

        public string EtapaString
        {
            get
            {
                switch (etapa)
                {
                    case TipoFaseProyecto.ANALISIS:
                        return "Analisis";
                    case TipoFaseProyecto.COMPLETADO:
                        return "Completado";
                }
                return "";
            }
        }

        public int EtapaInt
        {
            get
            {
                switch (etapa)
                {
                    case TipoFaseProyecto.ANALISIS:
                        return 1;
                    case TipoFaseProyecto.DESARROLLO:
                        return 2;
                    case TipoFaseProyecto.POSTPRODUCCION:
                        return 5;
                    case TipoFaseProyecto.PREPARACION:
                        return 4;
                    case TipoFaseProyecto.PRUEBAS:
                        return 3;
                    case TipoFaseProyecto.COMPLETADO:
                        return 6;
                    case TipoFaseProyecto.CANCELADO:
                        return 6;
                }
                return 0;
            }
        }
        public TipoPrioridad Prioridad { get => prioridad; set => prioridad = value; }

        public int PrioridadInt
        {
            get
            {
                switch (prioridad)
                {
                    case TipoPrioridad.ALTA:
                        return 1;
                    case TipoPrioridad.MEDIA:
                        return 2;
                    case TipoPrioridad.BAJA:
                        return 3;
                }
                return 0;
            }
        }
    }
}
