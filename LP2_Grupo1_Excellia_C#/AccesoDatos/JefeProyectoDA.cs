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
    public class JefeProyectoDA
    {
        public int insertarJefeProyecto(JefeProyecto jefeProyecto, int idPersona) {
            MySqlConnection conn;
            string cadena = DBManager.cadena;

            try
            {
                conn = new MySqlConnection(cadena);
            }
            catch
            {
                return -1;
            }
            conn.Open();

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            /*El Id del tipo JefeProyecto en la base de datos es 4*/
            string insert = "INSERT INTO TRABAJADOR(ID_PERSONA, ID_TIPO, ID_DOMINIO) VALUES (" + idPersona + ", " + 4 + ", " + jefeProyecto.Dominio.IdDominio + ");";

            cmd.CommandText = insert;

            cmd.ExecuteNonQuery();

            int id = (int)cmd.LastInsertedId;

            return id;
        }

        public JefeProyecto obtenerJefeProyecto(int idJefeProyecto) {
            MySqlConnection con = new MySqlConnection(DBManager.cadena);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            String sql = "SELECT * FROM TRABAJADOR, PERSONA WHERE ID_TRABAJADOR = " + idJefeProyecto + ";";
            cmd.CommandText = sql;
            cmd.Connection = con;
            MySqlDataReader lector = cmd.ExecuteReader();
            lector.Read();

            JefeProyecto jefeProyecto = new JefeProyecto();

            jefeProyecto.IdTrabajador = lector.GetInt32("ID_TRABAJADOR");
            jefeProyecto.Dni = lector.GetString("DNI");
            jefeProyecto.Nombre = lector.GetString("NOMBRE");
            jefeProyecto.ApellidoPaterno = lector.GetString("APELLIDO_PATERNO");
            jefeProyecto.ApellidoMaterno = lector.GetString("APELLIDO_MATERNO");
            jefeProyecto.Sexo = lector.GetChar("SEXO");
            jefeProyecto.FechaNac = lector.GetDateTime("FECHA_NACIMIENTO");
            jefeProyecto.Correo = lector.GetString("CORREO");
            jefeProyecto.Telefono = lector.GetString("TELEFONO");

            lector.Close();
            con.Close();

            return jefeProyecto;
        }
    }
}
