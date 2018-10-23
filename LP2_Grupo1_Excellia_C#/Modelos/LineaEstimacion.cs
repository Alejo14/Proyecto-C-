using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class LineaEstimacion
    {
        private int idLinea;
        private TipoCargo rol;
        private float tiempoEstimadoPlaneacion;
        private float tiempoEstimadoAnalisis;
        private float tiempoEstimadoDesarrollo;
        private float tiempoEstimadoPruebas;
        private float tiempoEstimadoPreparacion;
        private float tiempoEstimadoPostProduccion;
        private float subTotal;
        private Estimacion estimacion;
        public LineaEstimacion() { this.estimacion = new Estimacion(); }

        public LineaEstimacion(int idLinea, TipoCargo rol, float tiempoEstimadoPlaneacion,
                float tiempoEstimadoAnalisis, float tiempoEstimadoDesarrollo,
                float tiempoEstimadoPruebas, float tiempoEstimadoPreparacion,
                float tiempoEstimadoPostProduccion, float subTotal)
        {
            this.idLinea = idLinea;
            this.rol = rol;
            this.tiempoEstimadoAnalisis = tiempoEstimadoAnalisis;
            this.tiempoEstimadoDesarrollo = tiempoEstimadoDesarrollo;
            this.tiempoEstimadoPlaneacion = tiempoEstimadoPlaneacion;
            this.tiempoEstimadoPostProduccion = tiempoEstimadoPostProduccion;
            this.tiempoEstimadoPreparacion = tiempoEstimadoPreparacion;
            this.tiempoEstimadoPruebas = tiempoEstimadoPruebas;
            this.estimacion = new Estimacion();
        }
        public int IdLinea { get => idLinea; set => idLinea = value; }
        public float TiempoEstimadoPlaneacion { get => tiempoEstimadoPlaneacion; set => tiempoEstimadoPlaneacion = value; }
        public float TiempoEstimadoAnalisis { get => tiempoEstimadoAnalisis; set => tiempoEstimadoAnalisis = value; }
        public float TiempoEstimadoDesarrollo { get => tiempoEstimadoDesarrollo; set => tiempoEstimadoDesarrollo = value; }
        public float TiempoEstimadoPruebas { get => tiempoEstimadoPruebas; set => tiempoEstimadoPruebas = value; }
        public float TiempoEstimadoPreparacion { get => tiempoEstimadoPreparacion; set => tiempoEstimadoPreparacion = value; }
        public float TiempoEstimadoPostProduccion { get => tiempoEstimadoPostProduccion; set => tiempoEstimadoPostProduccion = value; }
        public float SubTotal { get => subTotal; set => subTotal = value; }
        internal TipoCargo Rol { get => rol; set => rol = value; }
        internal Estimacion Estimacion { get => estimacion; set => estimacion = value; }
    }
}
