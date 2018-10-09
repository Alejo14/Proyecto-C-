using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class DetalleEntrega
    {
        private int idDetalle;
        private DateTime fechaEntrega;
        private bool evaluacion;
        private DateTime fechaEvaluacion;
        private Entregable entregable;
        private Proyecto proyecto;
        private Cliente cliente;

        public DetalleEntrega()
        {
            this.entregable = new Entregable();
            this.proyecto = new Proyecto();
            this.cliente = new Cliente();
        }

        public DetalleEntrega(int idDetalle, DateTime fechaEntrega, bool evaluacion,
                DateTime fechaEvaluacion)
        {
            this.idDetalle = idDetalle;
            this.fechaEntrega = fechaEntrega;
            this.evaluacion = evaluacion;
            this.fechaEvaluacion = fechaEvaluacion;
            this.entregable = new Entregable();
            this.proyecto = new Proyecto();
            this.cliente = new Cliente();
        }
        public int IdDetalle { get => idDetalle; set => idDetalle = value; }
        public DateTime FechaEntrega { get => fechaEntrega; set => fechaEntrega = value; }
        public bool Evaluacion { get => evaluacion; set => evaluacion = value; }
        public DateTime FechaEvaluacion { get => fechaEvaluacion; set => fechaEvaluacion = value; }
        internal Entregable Entregable { get => entregable; set => entregable = value; }
        internal Proyecto Proyecto { get => proyecto; set => proyecto = value; }
        internal Cliente Cliente { get => cliente; set => cliente = value; }
    }
}
