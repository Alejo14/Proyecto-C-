using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using MySql.Data.MySqlClient;

namespace AccesoDatos
{
    public class DominioDA
    {
        public BindingList<Dominio> obtenerDominios()
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
            conn.Open();
            BindingList<Dominio> dominiosDA = new BindingList<Dominio>();

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;

            string query = "SELECT * FROM DOMINIO;";

            cmd.CommandText = query;

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Dominio dominio = new Dominio();
                dominio.IdDominio = reader.GetInt32("ID_DOMINIO");
                dominio.Denominacion = reader.GetString("DENOMINACION");

                dominiosDA.Add(dominio);
            }

            reader.Close();

            conn.Close();

            return dominiosDA;
        }
    }
}
