using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using MySql.Data.MySqlClient;
using Modelo;

namespace AccesoDatos
{
    public class EmpresaDA
    {
        public BindingList<Empresa> obtenerEmpresas() {
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
            BindingList<Empresa> empresasDA = new BindingList<Empresa>();

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;

            string query = "SELECT * FROM EMPRESA;";

            cmd.CommandText = query;

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read()) {
                Empresa emp = new Empresa();
                emp.IdEmpresa = reader.GetInt32("ID_EMPRESA");
                emp.Ruc = reader.GetString("RUC");
                emp.RazonSocial = reader.GetString("RAZON_SOCIAL");
                emp.Direccion = reader.GetString("DIRECCION");

                empresasDA.Add(emp);
            }

            reader.Close();

            conn.Close();

            return empresasDA;
        }
    }
}
