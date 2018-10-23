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
    public class ExpertoDA
    {
        public int insertarExperto(Experto experto, int idPersona) {
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
            /*El Id del tipo Experto en la base de datos es 3*/
            string insert = "INSERT INTO TRABAJADOR(ID_PERSONA, ID_TIPO, ID_DOMINIO) VALUES (" + idPersona + ", " + 3 + ", "+ experto.Dominio.IdDominio + ");";

            cmd.CommandText = insert;

            cmd.ExecuteNonQuery();

            int id = (int)cmd.LastInsertedId;

            return id;
        }
    }
}
