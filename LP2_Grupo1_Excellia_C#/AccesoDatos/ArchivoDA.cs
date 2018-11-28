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
            return 1;
        }
    }
}
