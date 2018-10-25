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
    public class TrabajadorDA
    {
        public BindingList<Trabajador> listarTrabajadores(string dni, string nombre, string apellidoP, string apellidoM, 
            string correo, string tel,string rol)
        {
            BindingList<Trabajador> trabajadores = new BindingList<Trabajador>();
            MySqlConnection con = new MySqlConnection(DBManager.cadena);
            con.Open();
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "SELECT * FROM TIPO_TRABAJADOR TT, PERSONA P, TRABAJADOR T WHERE P.ID_PERSONA = T.ID_PERSONA" +
                " AND P.DNI LIKE CONCAT ('%" + dni + "%') AND P.NOMBRE LIKE CONCAT('%" + nombre + "%') AND P.APELLIDO_PATERNO LIKE CONCAT('%" + apellidoP +
                "%') AND P.APELLIDO_MATERNO LIKE CONCAT('%" + apellidoM + "%') AND P.CORREO LIKE ('%" + correo +
                "%') AND P.TELEFONO LIKE CONCAT ('%" + tel + "%') AND TT.DESCRIPCION LIKE CONCAT ('%" + rol + "%')" +
                " AND (TT.ID_TIPO = 1 OR TT.ID_TIPO >= 4) AND T.ID_TIPO = TT.ID_TIPO;";
            comando.Connection = con;
            MySqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                Trabajador t = new Trabajador();
                t.IdTrabajador = lector.GetInt32("ID_TRABAJADOR");
                t.Dni = lector.GetString("DNI");
                t.Nombre = lector.GetString("NOMBRE");
                t.ApellidoPaterno = lector.GetString("APELLIDO_PATERNO");
                t.ApellidoMaterno = lector.GetString("APELLIDO_MATERNO");
                t.Correo = lector.GetString("CORREO");
                t.Telefono = lector.GetString("TELEFONO");
                TipoTrabajador r = new TipoTrabajador();
                r.IdTipoTrabajador = lector.GetInt32("ID_TIPO");
                r.Descripcion = rol;
                t.CargoTrabajador = r;
                trabajadores.Add(t);
            }
            con.Close();
            return trabajadores;
        }
        public BindingList<Trabajador> listarOperarios(Proyecto p)
        {
            BindingList<Trabajador> operarios = new BindingList<Trabajador>();
            MySqlConnection con = new MySqlConnection(DBManager.cadena);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            String sql = "SELECT T.ID_TRABAJADOR, P.NOMBRE, P.APELLIDO_PATERNO, P.APELLIDO_MATERNO, TT.ID_TIPO, TT.DESCRIPCION " +
                "FROM PERSONA P, TRABAJADOR T,TIPO_TRABAJADOR TT, PROYECTO_X_TRABAJADOR PXT, PROYECTO PR " +
                "WHERE PXT.RETIRADO=1 AND P.ID_PERSONA = T.ID_PERSONA AND TT.ID_TIPO = T.ID_TIPO " +
                "AND PXT.ID_PROYECTO = PR.ID_PROYECTO AND PXT.ID_TRABAJADOR = T.ID_TRABAJADOR " +
                "AND PR.ID_PROYECTO = " + p.IdProyecto;


            cmd.CommandText = sql;
            cmd.Connection = con;
            MySqlDataReader lector = cmd.ExecuteReader();
            while (lector.Read())
            {
                Trabajador tra = new Trabajador();
                tra.IdTrabajador = lector.GetInt32("ID_TRABAJADOR");
                tra.Nombre = lector.GetString("NOMBRE");
                tra.ApellidoPaterno = lector.GetString("APELLIDO_PATERNO");
                tra.ApellidoMaterno = lector.GetString("APELLIDO_MATERNO");
                TipoTrabajador tc = new TipoTrabajador();
                tc.IdTipoTrabajador = lector.GetInt32("ID_TIPO");
                tc.Descripcion = lector.GetString("DESCRIPCION");
                
                tra.CargoTrabajador = tc;
                //MessageBox.Show(tra.Nombre+" "+ tc.Descripcion);
                operarios.Add(tra);
            }
            con.Close();
            return operarios;

        }
    }
}