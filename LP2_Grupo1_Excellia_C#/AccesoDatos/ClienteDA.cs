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

        public Cliente obtenerCliente(int idProyecto) {
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

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;

            string query = "SELECT C.*, PE.* " +
                        "FROM PROYECTO P, ERU E, CLIENTE C, PERSONA PE " +
                        "WHERE P.ID_ERU = E.ID_ERU AND E.ID_CLIENTE = C.ID_CLIENTE AND C.ID_PERSONA = PE.ID_PERSONA AND P.ID_PROYECTO = " + idProyecto + "; ";

            cmd.CommandText = query;

            MySqlDataReader reader = cmd.ExecuteReader();

            Cliente clienteProyecto = new Cliente();

            bool leido = reader.Read();

            if (leido) {
                clienteProyecto.IdCliente = reader.GetInt32("ID_CLIENTE");
                clienteProyecto.Dni = reader.GetString("DNI");
                clienteProyecto.Nombre = reader.GetString("NOMBRE");
                clienteProyecto.ApellidoPaterno = reader.GetString("APELLIDO_PATERNO");
                clienteProyecto.ApellidoPaterno = reader.GetString("APELLIDO_MATERNO");
                clienteProyecto.Sexo = reader.GetChar("SEXO");
                clienteProyecto.FechaNac = reader.GetDateTime("FECHA_NACIMIENTO");
                clienteProyecto.Correo = reader.GetString("CORREO");
                clienteProyecto.Telefono = reader.GetString("TELEFONO");
            }

            reader.Close();
            conn.Close();

            if (leido)
                return clienteProyecto;
            else
                return null;
        }
    }
}
