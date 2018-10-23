using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class AlineamientoObjetivo
    {
        private bool estadoProyecto;
        private TipoEstadoMeta estadoMeta;
        private string formaMedir;
        private DateTime fechaPlazo;
        private Objetivo objetivo;
        private ERU eru;

        public AlineamientoObjetivo()
        {
            this.objetivo = new Objetivo();
            this.eru = new ERU();
        }

        public AlineamientoObjetivo(bool estadoProyecto,
                TipoEstadoMeta estadometa, string formaMedir, DateTime fechaPlazo)
        {
            this.estadoMeta = estadometa;
            this.estadoProyecto = estadoProyecto;
            this.formaMedir = formaMedir;
            this.fechaPlazo = fechaPlazo;
            this.objetivo = new Objetivo();
            this.eru = new ERU();
        }

        public bool EstadoProyecto { get => estadoProyecto; set => estadoProyecto = value; }
        public string FormaMedir { get => formaMedir; set => formaMedir = value; }
        public DateTime FechaPlazo { get => fechaPlazo; set => fechaPlazo = value; }
        internal TipoEstadoMeta EstadoMeta { get => estadoMeta; set => estadoMeta = value; }
        internal Objetivo Objetivo { get => objetivo; set => objetivo = value; }
        internal ERU Eru { get => eru; set => eru = value; }
    }
}
