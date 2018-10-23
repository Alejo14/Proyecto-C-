using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Modelo;
using System.ComponentModel;

namespace LogicaNegocio
{
    public class TrabajadorBL
    {
        private TrabajadorDA trabajadorDA;
        public TrabajadorBL()
        {
            trabajadorDA = new TrabajadorDA();
        }
        public BindingList<Trabajador> listarTrabajadores(string dni, string nombre, string apellidoP, string apellidoM, 
            string correo, string telefono, string rol)
        {
            return trabajadorDA.listarTrabajadores(dni,nombre,apellidoP,apellidoM,correo,telefono,rol);
        }
        public BindingList<Trabajador> listarOperarios(Proyecto p)
        {
            return trabajadorDA.listarOperarios(p);
        }
    }
}
