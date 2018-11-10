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
                "E.ID_ERU, E.DESCRIPCION AS DESCRIPCION_ERU, E.FECHA_SOLICITUD AS FECHA_SOLICITUD_ERU, E.ESTADO, P.ID_PROYECTO, P.NOMBRE, " +
                "P.PRESUPUESTO, P.PRIORIDAD, P.FECHA_INICIO, P.FECHA_FIN_ESTIMADA, P.FECHA_FIN_REAL, P.ID_TRABAJADOR_JEFE " +
                "FROM SOLICITUD_CAMBIO S, REQUERIMIENTO R, ERU E, PROYECTO P " +
                "WHERE S.ID_SOLICITUD = R.ID_SOLICITUD AND R.ID_ERU = E.ID_ERU AND " +
                "E.ID_ERU = P.ID_ERU AND S.ID_TIPO_ESTADO_SOLICITUD = 2 AND P.ID_TRABAJADOR_JEFE = " + idJefe + "; ";

            cmd.CommandText = query;

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read()) {
                SolicitudCambio solCambio = new SolicitudCambio();
                solCambio.IdSolicitud = reader.GetInt32("ID_SOLICITUD");
                solCambio.Descripcion = reader.GetString("DESCRIPCION");
                solCambio.FechaSolicitud = reader.GetDateTime("FECHA_SOLICITUD");
                int idEstado = reader.GetInt32("ID_TIPO_ESTADO_SOLICITUD");
                solCambio.setEstado(idEstado);
                Requerimiento req = new Requerimiento();
                req.IdRequerimiento = reader.GetInt32("ID_REQUERIMIENTO");
                req.Descripcion = reader.GetString("DESCRIPCION");

                solCambio.Requerimiento = req;

            }

            return solicitudesCambioDA;
        }
    }
}
