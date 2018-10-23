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
    public class ClienteDA
    {
        public int insertarCliente(Cliente cli, int idPersona) {
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

            string insert = "INSERT INTO CLIENTE(ID_PERSONA, ID_EMPRESA) VALUES (" + idPersona + ", " + cli.Empresa.IdEmpresa + ");";

            cmd.CommandText = insert;

            cmd.ExecuteNonQuery();

            int id = (int)cmd.LastInsertedId;

            return id;
        }
    }
}
