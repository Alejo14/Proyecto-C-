using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class TipoTrabajador
    {
        private int idTipoTrabajador;
        private string descripcion;

        public TipoTrabajador()
        {
        }
        public TipoTrabajador(int idTipoTrabajador, string descripcion)
        {
            this.idTipoTrabajador = idTipoTrabajador;
            this.descripcion = descripcion;
        }

        public int IdTipoTrabajador { get => idTipoTrabajador; set => idTipoTrabajador = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
    }
}
