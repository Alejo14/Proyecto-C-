using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.ComponentModel;
using MySql.Data.MySqlClient;

namespace AccesoDatos
{
    public class EruDA
    {
        public BindingList<ERU> listarErusPendientes()
        {
            BindingList<ERU> erus = new BindingList<ERU>();
            MySqlConnection con = new MySqlConnection(DBManager.cadena);
            con.Open();
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "SELECT e.*, r.RAZON_SOCIAL FROM ERU e, EMPRESA r WHERE e.ESTADO= 1 and r.ID_EMPRESA=e.ID_CLIENTE";
            comando.Connection = con;
            MySqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                ERU eru = new ERU();
                eru.IdERU = lector.GetInt32("ID_ERU");
                eru.Descripcion = lector.GetString("DESCRIPCION");
                eru.FechaSolicitud = lector.GetDateTime("FECHA_SOLICITUD");
                Cliente cli = new Cliente();
                cli.IdCliente = lector.GetInt32("ID_CLIENTE");
                cli.NomEmpresa = lector.GetString("RAZON_SOCIAL");
                eru.Cliente = cli;
                erus.Add(eru);
            }
            con.Close();
            return erus;
        }
    }
}
