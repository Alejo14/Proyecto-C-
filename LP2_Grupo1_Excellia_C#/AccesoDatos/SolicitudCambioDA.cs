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

            string query = "SELECT * FROM SOLICITUD_CAMBIO S, REQUERIMIENTO R, ERU E, PROYECTO P " +
                            "WHERE S.ID_REQUERIMIENTO = R.ID_REQUERIMIENTO AND R.ID_ERU = E.ID_ERU AND " +
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
