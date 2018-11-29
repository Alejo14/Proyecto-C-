using Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class RolDA
    {
        public BindingList<TipoTrabajador> listarRoles(int seleccionador)
        {
            BindingList<TipoTrabajador> roles = new BindingList<TipoTrabajador>();
            MySqlConnection con = new MySqlConnection(DBManager.cadena);
            con.Open();
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "SELECT * FROM TIPO_TRABAJADOR WHERE ID_TIPO = 1 OR ID_TIPO >= 4"; 
            comando.Connection = con;
            MySqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                TipoTrabajador rol = new TipoTrabajador();
                rol.IdTipoTrabajador = lector.GetInt32("ID_TIPO");
                rol.Descripcion = lector.GetString("DESCRIPCION");
                if((seleccionador == 1 && rol.IdTipoTrabajador != 4) || seleccionador == 0) roles.Add(rol);
            }
            con.Close();
            return roles;
        }
    }
}
