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
        public BindingList<Trabajador> listarTrabajadores(Operario op, string rol)
        {
            return trabajadorDA.listarTrabajadores(op,rol);           
        }
        public BindingList<Trabajador> listarTrabajadoresDisponibles(Proyecto p, Operario op, string rol)
        {
            return trabajadorDA.listarTrabajadoresDisponibles(p, op, rol);
        }
        public BindingList<Trabajador> listarOperarios(Proyecto p)
        {
            return trabajadorDA.listarOperarios(p);
        }
        public string obtenerDominio(int id)
        {
            return trabajadorDA.obtenerDominio(id);
        }
        public bool actualizarPerfil(CuentaUsuario cu)
        {
            return trabajadorDA.actualizarPerfil(cu);
        }
    }
}
