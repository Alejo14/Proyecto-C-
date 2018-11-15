using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Evaluacion
    {
        private bool resultado;
        private DateTime fecha;
        private string descripcion;
        private ERU eru;
        private Estimacion estimacion;
        public Evaluacion()
        {
            this.eru = new ERU();
            //this.estimacion = new Estimacion();
        }

        public Evaluacion(bool resultado, DateTime fecha, string descripcion)
        {
            this.resultado = resultado;
            this.fecha = fecha;
            this.descripcion = descripcion;
            this.eru = new ERU();
            this.estimacion = new Estimacion();
        }
        public bool Resultado { get => resultado; set => resultado = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        internal ERU Eru { get => eru; set => eru = value; }
        internal Estimacion Estimacion { get => estimacion; set => estimacion = value; }
    }
}
