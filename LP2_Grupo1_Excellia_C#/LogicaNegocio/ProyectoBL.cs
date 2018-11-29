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

            string mensajeRetiro = obtenerMensajeCorreoRetiroProyecto(p, op);

            EmailSender.enviarEmail(p.JefeProyecto.Correo, "Solicitud de retiro de operario de proyecto " + p.Nombre, mensajeRetiro);
        }

        public BindingList<Proyecto> listarProyectosEnCurso(int e, DateTime mifecha)
        {
            return proyectoDA.listarProyectosEnCurso(e, mifecha);
        }

        public BindingList<Etapa> listarEtapas()
        {
            return proyectoDA.listarEtapas();
        }

        public void ActualizarDatos(Proyecto proyectoActualizar, int pri, int et)
        {
            if (et == 4 || et == 6) {
                enviarCorreoActualizacionEtapa(proyectoActualizar, et);
            }
            proyectoDA.ActualizarDatos(proyectoActualizar.IdProyecto, pri, et);
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
            string mensajeCorreo = obtenerMensajeAsignacionTrabajador(p);
            EmailSender.enviarEmail(t.Correo, "Asignacion a proyecto", mensajeCorreo);
            proyectoDA.AsignarTrabajador(p, t);

        }

        public BindingList<Cliente> listarEmpresasClientes()
        {
            return proyectoDA.listarEmpresasClientes();

        }

        public void CancelarERU(int id)
        {
            proyectoDA.CancelarERU(id);
        }

        public int EruDeProyecto(int p)
        {
            return proyectoDA.EruDeProyecto(p);
        }

        public BindingList<Proyecto> listarReportes()
        {
            return proyectoDA.listarReportes();
        }

        public string obtenerMensajeCorreoRetiroProyecto(Proyecto proyectoOperarioRetiro, Operario operarioRetiro) {
            string mensajeCorreo = "El presente correo es para notificar que el siguiente operario ha solicitado retirarse de un proyecto que usted lidera:\r\n" +
                                  "Nombre del proyecto: " + proyectoOperarioRetiro.Nombre +
                                    "\r\nNombre del operario: " + operarioRetiro.Nombre + " " +
                                    operarioRetiro.ApellidoPaterno + " " + operarioRetiro.ApellidoMaterno +
                                    "\r\nCargo: " + operarioRetiro.CargoOperarioStr +
                                    "\r\n\r\nDeberá comunicarse con el operario y acordar si procede su retiro para registrarlo en el sistema." +
                                    "\r\n\r\nAtentamente,\r\n\r\nSistema de apoyo a la gestión de proyectos de Excellia.";

            return mensajeCorreo;
        }

        private string obtenerMensajeAsignacionTrabajador(Proyecto proyectoAsignar) {
            string mensajeCorreo = "Estimado Operario,\r\n\r\n"+
                            "El presente correo es para notificarle que ha sido asignado a un proyecto. Los detalles del proyecto son los siguientes:" +
                            "\r\n\r\nNombre del proyecto: " + proyectoAsignar.Nombre +
                            "\r\nJefe de Proyecto: " + proyectoAsignar.JefeProyecto.Nombre + " " + proyectoAsignar.JefeProyecto.ApellidoPaterno +
                            "\r\n\r\nCualquier Consulta, comuniquese con el jefe de proyecto." +
                            "\r\n\r\nAtentamente," +
                            "\r\nEl equipo de Excellia";

            return mensajeCorreo;
        }

        private void enviarCorreoActualizacionEtapa(Proyecto proyectoActualizar, int idEtapa) {
            string etapa = "";

            if (idEtapa == 4)
            {
                etapa = "Preparación";
            }
            else if (idEtapa == 6)
            {
                etapa = "Finalizado";
            }

            Cliente clienteProyecto = obtenerCliente(proyectoActualizar.IdProyecto);

            string mensajeCorreo = "";

            if (idEtapa == 4)

                mensajeCorreo = obtenerMensajePasoEtapaProyectoPostProduccion(proyectoActualizar, clienteProyecto, etapa);

            else if (idEtapa == 6)

                mensajeCorreo = obtenerMensajePasoEtapaProyectoCompletado(proyectoActualizar, clienteProyecto, etapa);

            EmailSender.enviarEmail(clienteProyecto.Correo, "Paso de etapa de proyecto a " + etapa, mensajeCorreo);
        }

        private Cliente obtenerCliente(int idProyecto) {
            ClienteDA clienteDA = new ClienteDA();
            return clienteDA.obtenerCliente(idProyecto);
        }

        private string obtenerMensajePasoEtapaProyectoPostProduccion(Proyecto proyectoActualizar, Cliente clienteProyecto, string etapaActualizar) {
            string mensajeCorreo = "Estimado " + clienteProyecto.Nombre + ",\r\n\r\n" +
                            "El presente mensaje es para notificarle que uno de los proyectos que ha solicitado ha pasado a la etapa de " + etapaActualizar + ":" +
                            "\r\n\r\nNombre del Proyecto: " + proyectoActualizar.Nombre +
                            "\r\nJefe de Proyecto: " + proyectoActualizar.JefeProyecto.Nombre + " " + proyectoActualizar.JefeProyecto.ApellidoPaterno +
                            "\r\n\r\nDeberá aprobar su paso a post-producción de haber conformidad con el estado del proyecto." +
                            "\r\n\r\nCualquier consulta, comunicarse con el KAM o el jefe del proyecto." +
                            "\r\n\r\nAtentamente," +
                            "\r\n\r\nEl equipo de Excellia";

            return mensajeCorreo;
        }

        private string obtenerMensajePasoEtapaProyectoCompletado(Proyecto proyectoActualizar, Cliente clienteProyecto, string etapaActualizar)
        {
            string mensajeCorreo = "Estimado " + clienteProyecto.Nombre + ",\r\n\r\n" +
                            "El presente mensaje es para notificarle que uno de los proyectos que ha solicitado ha pasado a la etapa de " + etapaActualizar + ":" +
                            "\r\n\r\nNombre del Proyecto: " + proyectoActualizar.Nombre +
                            "\r\nJefe de Proyecto: " + proyectoActualizar.JefeProyecto.Nombre + " " + proyectoActualizar.JefeProyecto.ApellidoPaterno +
                            "\r\n\r\nCualquier consulta, comunicarse con el KAM o el jefe del proyecto." +
                            "\r\n\r\nAtentamente," +
                            "\r\n\r\nEl equipo de Excellia";

            return mensajeCorreo;
        }

        public string obtenerPresupuesto(ERU e)
        {
            return proyectoDA.obtenerPresupuesto(e);
        }

        public string obtenerFFEstimado(ERU e)
        {
            return proyectoDA.obtenerFFEstimado(e); ;
        }

        public BindingList<Etapa> listarEtapasxProyecto(int id)
        {
            return proyectoDA.listarEtapasxProyecto(id);
        }
    }
}
