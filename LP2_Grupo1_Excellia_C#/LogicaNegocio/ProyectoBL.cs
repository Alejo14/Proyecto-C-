using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using AccesoDatos;
using System.ComponentModel;
using System.Data;

namespace LogicaNegocio
{
    public class ProyectoBL
    {
        private ProyectoDA proyectoDA;
        public ProyectoBL()
        {
            proyectoDA = new ProyectoDA();
        }

        public BindingList<Proyecto> listarProyectos()
        {
            return proyectoDA.listarProyectos();
        }

        public void retirarOperario(Proyecto p, Trabajador t)
        {
            proyectoDA.retirarOperario(p,t);
        }
        public BindingList<Proyecto> listarProyectosEnCurso(int e, DateTime mifecha)
        {
            return proyectoDA.listarProyectosEnCurso(e, mifecha);
        }

        public BindingList<Etapa> listarEtapas()
        {
            return proyectoDA.listarEtapas();
        }

        public void ActualizarDatos(int id, int pri, int et)
        {
            proyectoDA.ActualizarDatos(id, pri, et);
        }
        public void CancelarProyecto(int id)
        {
            proyectoDA.CancelarProyecto(id);
        }

        public void CrearProyecto(Proyecto p)
        {
            proyectoDA.CrearProyecto(p);
        }
    }
}
