
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Administrador:Trabajador
    {
        private int idAdmin;
        private CuentaUsuario cuentaUsuario;

        public Administrador() {
            //this.CuentaUsuario = new CuentaUsuario();
        }
        public Administrador(int idAdmin)
        {
            this.idAdmin = idAdmin;
            this.CuentaUsuario = new CuentaUsuario();
        }

        public int IdAdmin { get => idAdmin; set => idAdmin = value; }
        internal CuentaUsuario CuentaUsuario { get => cuentaUsuario; set => cuentaUsuario = value; }
    }
}
