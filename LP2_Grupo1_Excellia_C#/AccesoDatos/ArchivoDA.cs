using System;
using System.Collections.Generic;
using System.ComponentModel;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.Windows.Forms;
using System.Data;

namespace AccesoDatos
{
    public class ArchivoDA
    {
        public BindingList<Archivo> listarDocumentosProyecto(int idProyecto)
        {
            BindingList<Archivo> archivos = new BindingList<Archivo>();
            MySqlConnection con = new MySqlConnection(DBManager.cadena);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();

            String sql = "SELECT ID_DOCUMENTO, NOMBRE_DOCUMENTO " + 
                "FROM DOCUMENTO WHERE ID_PROYECTO = " + idProyecto + ";";
            cmd.CommandText = sql;
            cmd.Connection = con;

            MySqlDataReader lector = cmd.ExecuteReader();
            while (lector.Read())
            {
                int id = lector.GetInt32("ID_DOCUMENTO");
                String nombre = lector.GetString("NOMBRE_DOCUMENTO");
                Archivo arch = new Archivo(id, nombre);
                archivos.Add(arch);
            }
            con.Close();
            return archivos;
        }

        public int guardarDocumento(Archivo arch)
        {
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

            MySqlCommand cmd = new MySqlCommand("INSERT INTO DOCUMENTO(NOMBRE_DOCUMENTO, DOCUMENTO, ID_PROYECTO, TRABAJADOR_ID_TRABAJADOR) " +
                "VALUES (@nombre, @documento, @idProy, @idTrab);",conn);

            //String query = ;
            cmd.Parameters.Add("@nombre", MySqlDbType.VarChar).Value = arch.Nombre;
            cmd.Parameters.Add("@documento", MySqlDbType.VarBinary).Value = arch.Contenido;
            cmd.Parameters.Add("@idProy", MySqlDbType.Int32).Value = arch.IdProyecto;
            cmd.Parameters.Add("@idTrab", MySqlDbType.Int32).Value = arch.IdTrabajador;

            conn.Open();
            cmd.ExecuteNonQuery();
            int id = (int)cmd.LastInsertedId;

            conn.Close();
            return id;
        }

        public byte[] obtenerDocumento(int idArch)
        {
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

            MySqlCommand cmd = new MySqlCommand("SELECT DOCUMENTO FROM DOCUMENTO WHERE ID_DOCUMENTO = @iddoc", conn);

            //String query = ;
            cmd.Parameters.Add("@iddoc", MySqlDbType.Int32).Value = idArch;

            conn.Open();

            MySqlDataReader lector = cmd.ExecuteReader();

            while (lector.Read())
            {
                byte[] contenido = lector.GetInt32("ID_DOCUMENTO");
            }

            conn.Close();
            return ;
        }
    }
}
