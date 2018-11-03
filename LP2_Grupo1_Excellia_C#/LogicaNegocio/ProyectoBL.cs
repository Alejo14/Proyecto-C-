﻿using System;
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

        public BindingList<Proyecto> listarProyectosOperario(int id)
        {
            return proyectoDA.listarProyectosOperario(id);
        }

        public void retirarOperario(Proyecto p, Trabajador t)
        {
            proyectoDA.retirarOperario(p,t);
        }

        public void registrarSolicitud(Proyecto p, Operario op, string justificacion)
        {
            int id = proyectoDA.buscarIdProyectoTrabajador(p, op);
            proyectoDA.registrarSolicitud(id, justificacion);
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

        public void ActualizarERU(Proyecto p)
        {
            proyectoDA.ActualizarERU(p);
        }

        public void AsignarTrabajador(Proyecto p, Trabajador t)
        {
            proyectoDA.AsignarTrabajador(p, t);

        }

        public BindingList<Cliente> listarEmpresasClientes()
        {
            return proyectoDA.listarEmpresasClientes();

        }
    }
}
