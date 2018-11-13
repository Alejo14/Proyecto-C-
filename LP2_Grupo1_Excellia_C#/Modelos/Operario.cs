using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Operario:Trabajador
    {
        private TipoCargo cargo;
        private List<Proyecto> listaProyecto;
        private List<SolicitudRetiro> listaSolicitudRetiro;
        public Operario()
        {
            this.listaProyecto = new List<Proyecto>();
            this.listaSolicitudRetiro = new List<SolicitudRetiro>();
        }

        public Operario(TipoCargo cargo)
        {
            this.cargo = cargo;
            this.listaProyecto = new List<Proyecto>();
            this.listaSolicitudRetiro = new List<SolicitudRetiro>();
        }

        public Operario(TipoCargo cargo, Dominio dominio)
        {
            this.cargo = cargo;
            this.Dominio = dominio;
            this.listaProyecto = new List<Proyecto>();
            this.listaSolicitudRetiro = new List<SolicitudRetiro>();
        }
        public TipoCargo Cargo { get => cargo; set => cargo = value; }
        public List<Proyecto> ListaProyecto { get => listaProyecto; set => listaProyecto = value; }
        public List<SolicitudRetiro> ListaSolicitudRetiro { get => listaSolicitudRetiro; set => listaSolicitudRetiro = value; }
        public int IdTipo {
            get {
                int idTipo = 0;

                switch (cargo) {
                    case TipoCargo.ANALISTA_DESARROLLO:
                        idTipo = 1;
                        break;
                    case TipoCargo.PROGRAMADOR:
                        idTipo = 6;
                        break;
                    case TipoCargo.TESTER:
                        idTipo = 5;
                        break;
                }

                return idTipo;
            }
        }

        public string CargoOperarioStr {
            get {
                string cargoStr = "";
                switch (cargo)
                {
                    case TipoCargo.ANALISTA_DESARROLLO:
                        cargoStr = "Analista desarrollo";
                        break;
                    case TipoCargo.PROGRAMADOR:
                        cargoStr = "Programador";
                        break;
                    case TipoCargo.TESTER:
                        cargoStr = "Tester";
                        break;
                }

                return cargoStr;
            }
        }
    }
}
