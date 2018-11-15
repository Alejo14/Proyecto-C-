using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Estimacion
    {
        private int idEstimacion;
        private string descripcion;
        private DateTime fechaEstimacion;
        private double total;
        private ERU eru;
        private List<LineaEstimacion> listaLineaEstimacion;
        private SolicitudCambio solicitudCambio;
        private Experto experto;
        private Evaluacion evaluacion;
        public Estimacion()
        {
            //this.eru = new ERU();
            this.evaluacion = new Evaluacion();
            this.experto = new Experto();
            this.evaluacion = new Evaluacion();
            this.solicitudCambio = new SolicitudCambio();
            this.listaLineaEstimacion = new List<LineaEstimacion>();
        }

        public Estimacion(int idEstimacion, string descripcion, DateTime fechaEstimacion,
                double total)
        {
            this.eru = new ERU();
            this.evaluacion = new Evaluacion();
            this.experto = new Experto();
            this.evaluacion = new Evaluacion();
            this.solicitudCambio = new SolicitudCambio();
            this.listaLineaEstimacion = new List<LineaEstimacion>();
            this.idEstimacion = idEstimacion;
            this.descripcion = descripcion;
            this.fechaEstimacion = fechaEstimacion;
            this.total = total;
        }
        public int IdEstimacion { get => idEstimacion; set => idEstimacion = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public DateTime FechaEstimacion { get => fechaEstimacion; set => fechaEstimacion = value; }
        public double Total { get => total; set => total = value; }
        internal ERU Eru { get => eru; set => eru = value; }
        internal List<LineaEstimacion> ListaLineaEstimacion { get => listaLineaEstimacion; set => listaLineaEstimacion = value; }
        internal SolicitudCambio SolicitudCambio { get => solicitudCambio; set => solicitudCambio = value; }
        internal Experto Experto { get => experto; set => experto = value; }
        internal Evaluacion Evaluacion { get => evaluacion; set => evaluacion = value; }
    }
}
