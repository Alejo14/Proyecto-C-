using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Requerimiento
    {
        private int idRequerimiento;
        private string descripcion;
        private DateTime fechaRequerimiento;
        private TipoRequerimiento tipo;
        private ERU eru;
        private Estimacion estimacion;
        public Requerimiento()
        {
            this.eru = new ERU();
            this.estimacion = new Estimacion();
        }

        public Requerimiento(int idRequerimiento, string descripcion, DateTime fechaRequerimiento,
                TipoRequerimiento tipo)
        {
            this.idRequerimiento = idRequerimiento;
            this.descripcion = descripcion;
            this.fechaRequerimiento = fechaRequerimiento;
            this.tipo = tipo;
        }
        public int IdRequerimiento { get => idRequerimiento; set => idRequerimiento = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public DateTime FechaRequerimiento { get => fechaRequerimiento; set => fechaRequerimiento = value; }
        internal TipoRequerimiento Tipo { get => tipo; set => tipo = value; }
        internal ERU Eru { get => eru; set => eru = value; }
        internal Estimacion Estimacion { get => estimacion; set => estimacion = value; }
    }
}
