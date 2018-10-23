using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Etapa
    {
        private int idEtapa;
        private string nombreEtapa;

        public Etapa()
        {

        }
        public Etapa(int idEtapa, string nombreEtapa)
        {
            this.idEtapa = idEtapa;
            this.nombreEtapa = nombreEtapa;
        }

        public int IdEtapa { get => idEtapa; set => idEtapa = value; }
        public string NombreEtapa { get => nombreEtapa; set => nombreEtapa = value; }
    }
}
