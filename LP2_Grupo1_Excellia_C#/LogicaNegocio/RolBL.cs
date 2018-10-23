using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Modelo;

namespace LogicaNegocio
{
    public class RolBL
    {
        private RolDA rolDA;
        public RolBL()
        {
            rolDA = new RolDA();
        }
        public BindingList<TipoTrabajador> listarRoles()
        {
            return rolDA.listarRoles();
        }

    }
}
