using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Modelo;
using MySql.Data.MySqlClient;

namespace AccesoDatos
{
    public class SolicitudCambioDA
    {
        public BindingList<SolicitudCambio> obtenerSolicitudesDeCambio(int idJefe) {

            MySqlConnection conn;
            string cadena = DBManager.cadena;

            try
            {
                conn = new MySqlConnection(cadena);
            }
            catch
            {
                return null;
            }
            conn.Open();
            BindingList<SolicitudCambio> solicitudesCambioDA = new BindingList<SolicitudCambio>();

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;

            string query = "SELECT S.ID_SOLICITUD, S.DESCRIPCION AS DESCRIPCION_SOLICITUD, S.FECHA_SOLICITUD, R.ID_REQUERIMIENTO, " +
                            "R.DESCRIPCION AS DESCRIPCION_REQUERIMIENTO, R.FECHA_REQUERIMIENTO, R.ID_TIPO_REQUERIMIENTO, R.FECHA_ESTIMADA, " +
                            "E.ID_EMPRESA, E.RUC, E.RAZON_SOCIAL, E.DIRECCION, P.ID_PROYECTO, P.NOMBRE AS NOMBRE_PROYECTO, " +
                            "P.PRESUPUESTO, P.PRIORIDAD, P.FECHA_INICIO, P.FECHA_FIN_ESTIMADA, P.FECHA_FIN_REAL, " +
                            "C.ID_CLIENTE, PER.NOMBRE AS NOMBRE_PERSONA, PER.APELLIDO_PATERNO, PER.APELLIDO_MATERNO " +
                            "FROM SOLICITUD_CAMBIO S, REQUERIMIENTO R, EMPRESA E, ERU ER, PROYECTO P, CLIENTE C, PERSONA PER " +
                            "WHERE S.ID_SOLICITUD = R.ID_SOLICITUD AND R.ID_ERU = ER.ID_ERU AND ER.ID_CLIENTE = C.ID_CLIENTE AND " +
                            "C.ID_EMPRESA = E.ID_EMPRESA AND C.ID_PERSONA = PER.ID_PERSONA AND " +
                            "ER.ID_ERU = P.ID_ERU AND S.ID_TIPO_ESTADO_SOLICITUD = 2 AND P.ID_TRABAJADOR_JEFE = " + idJefe + "; ";

            cmd.CommandText = query;

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read()) {
                SolicitudCambio solCambio = new SolicitudCambio();
                solCambio.IdSolicitud = reader.GetInt32("ID_SOLICITUD");
                solCambio.Descripcion = reader.GetString("DESCRIPCION_SOLICITUD");
                solCambio.FechaSolicitud = reader.GetDateTime("FECHA_SOLICITUD");
                int idEstado = reader.GetInt32("ID_TIPO_ESTADO_SOLICITUD");
                solCambio.setEstado(idEstado);
                Requerimiento req = new Requerimiento();
                req.IdRequerimiento = reader.GetInt32("ID_REQUERIMIENTO");
                req.Descripcion = reader.GetString("DESCRIPCION_REQUERIMIENTO");
                req.FechaRequerimiento = reader.GetDateTime("FECHA_REQUERIMIENTO");
                req.TipoInt = reader.GetInt32("ID_TIPO_REQUERIMIENTO");
                solCambio.Requerimiento = req;

                Proyecto proyecto = new Proyecto();
                proyecto.IdProyecto = reader.GetInt32("ID_PROYECTO");
                proyecto.Nombre = reader.GetString("NOMBRE_PROYECTO");
                proyecto.Presupuesto = reader.GetFloat("PRESUPUESTO");
                proyecto.PrioridadInt = reader.GetInt32("PRIORIDAD");
                proyecto.FechaInicio = reader.GetDateTime("FECHA_INICIO");
                proyecto.FechaFinEstimada = reader.GetDateTime("FECHA_FIN_ESTIMADA");
                solCambio.Proyecto = proyecto;

                Cliente cliente = new Cliente();
                cliente.IdCliente = reader.GetInt32("ID_CLIENTE");
                cliente.Nombre = reader.GetString("NOMBRE_PERSONA");
                cliente.ApellidoPaterno = reader.GetString("APELLIDO_PATERNO");
                cliente.ApellidoMaterno = reader.GetString("APELLIDO_MATERNO");
                Empresa empresa = new Empresa();
                empresa.IdEmpresa = reader.GetInt32("ID_EMPRESA");
                empresa.Ruc = reader.GetString("RUC");
                empresa.RazonSocial = reader.GetString("RAZON_SOCIAL");
                empresa.Direccion = reader.GetString("DIRECCION");
                cliente.Empresa = empresa;
                solCambio.Cliente = cliente;

                solicitudesCambioDA.Add(solCambio);
            }

            reader.Close();

            conn.Close();

            return solicitudesCambioDA;
        }
    }
}
