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
        public TipoRequerimiento Tipo { get => tipo; set => tipo = value; }
        public ERU Eru { get => eru; set => eru = value; }
        public Estimacion Estimacion { get => estimacion; set => estimacion = value; }

        public int TipoInt {
            set {
                int idTipo = value;
                switch (idTipo) {
                    case 1:
                        tipo = TipoRequerimiento.FUNCIONAL;
                        break;
                    case 2:
                        tipo = TipoRequerimiento.NO_FUNCIONAL;
                        break;
                }
            }
        }

        public string TipoStr {
            get {
                string tipoStr = "";

                switch (tipo) {
                    case TipoRequerimiento.FUNCIONAL:
                        tipoStr = "Funcional";
                        break;
                    case TipoRequerimiento.NO_FUNCIONAL:
                        tipoStr = "No funcional";
                        break;
                }

                return tipoStr;
            }
        }
    }
}
