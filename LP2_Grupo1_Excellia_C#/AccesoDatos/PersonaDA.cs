using Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class PersonaDA
    {
        public int insertarPersona(Persona per, int idUsuario) {
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

            string dia = per.FechaNac.Day.ToString();
            string mes = per.FechaNac.Month.ToString();
            string ano = per.FechaNac.Year.ToString();

            string insert = "INSERT INTO PERSONA(ID_CUENTA, DNI, NOMBRE, APELLIDO_PATERNO, APELLIDO_MATERNO, " +
                "SEXO, FECHA_NACIMIENTO, CORREO, TELEFONO) VALUES (" + idUsuario + ", '" + per.Dni+ "', '" + per.Nombre +
                "', '"+ per.ApellidoPaterno + "', '" + per.ApellidoMaterno + "', '" + per.Sexo +
                "', '" + ano + "/" + mes + "/" + dia + "', '" + per.Correo + "', '" + per.Telefono + "');";

            cmd.CommandText = insert;

            cmd.ExecuteNonQuery();

            int id = (int)cmd.LastInsertedId;

            return id;
        }
    }
}
