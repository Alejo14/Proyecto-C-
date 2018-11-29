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
        public BindingList<Trabajador> listarTrabajadores(Operario op,string rol)
        {
            BindingList<Trabajador> trabajadores = new BindingList<Trabajador>();
            MySqlConnection con = new MySqlConnection(DBManager.cadena);
            con.Open();
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "SELECT * FROM TIPO_TRABAJADOR TT, PERSONA P, TRABAJADOR T WHERE P.ID_PERSONA = T.ID_PERSONA" +
                " AND P.DNI LIKE CONCAT ('%" + op.Dni + "%') AND P.NOMBRE LIKE CONCAT('%" + op.Nombre + "%') AND P.APELLIDO_PATERNO LIKE CONCAT('%" + op.ApellidoPaterno +
                "%') AND P.APELLIDO_MATERNO LIKE CONCAT('%" + op.ApellidoMaterno + "%') AND P.CORREO LIKE ('%" + op.Correo +
                "%') AND P.TELEFONO LIKE CONCAT ('%" + op.Telefono + "%') AND TT.DESCRIPCION LIKE CONCAT ('%" + rol + "%')" +
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
                "WHERE PXT.RETIRADO = 0 AND P.ID_PERSONA = T.ID_PERSONA AND TT.ID_TIPO = T.ID_TIPO " +
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
                operarios.Add(tra);
            }
            con.Close();
            return operarios;

        }
        public string obtenerDominio(int id)
        {
            MySqlConnection con = new MySqlConnection(DBManager.cadena);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            String sql = "select D.DENOMINACION from DOMINIO D, TRABAJADOR T where D.ID_DOMINIO = T.ID_DOMINIO AND T.ID_TRABAJADOR = " + id;

            cmd.CommandText = sql;
            cmd.Connection = con;
            MySqlDataReader lector = cmd.ExecuteReader();
            string dominio = "";
            if (lector.Read())
            {
                dominio = lector.GetString("DENOMINACION"); 
            }
            con.Close();
            return dominio;
        }
        public bool actualizarPerfil(CuentaUsuario cu)
        {
            MySqlConnection con = new MySqlConnection(DBManager.cadena);
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand();
                String sql = "UPDATE PERSONA P INNER JOIN CUENTA_USUARIO CU ON P.ID_CUENTA = CU.ID_CUENTA SET P.CORREO = '" + cu.Persona.Correo + "', CU.CONTRASENA = '" + cu.Contrasena +
                    "', CU.NOMBRE_USUARIO = '" + cu.NomUsuario + "' WHERE P.ID_CUENTA = " + cu.IdCuenta;
                cmd.CommandText = sql;
                cmd.Connection = con;
                cmd.ExecuteNonQuery();

                con.Close();
                return true;
            }
            catch
            {
                con.Close();
                return false;
            }
        }
        public BindingList<Trabajador> listarTrabajadoresDisponibles(Proyecto p, Operario op, string rol)
        {
            BindingList<Trabajador> trabajadores = new BindingList<Trabajador>();
            MySqlConnection con = new MySqlConnection(DBManager.cadena);
            con.Open();
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "SELECT * FROM TIPO_TRABAJADOR TT, PERSONA P, TRABAJADOR T WHERE P.ID_PERSONA = T.ID_PERSONA" +
                " AND P.DNI LIKE CONCAT ('%" + op.Dni + "%') AND P.NOMBRE LIKE CONCAT('%" + op.Nombre + "%') AND P.APELLIDO_PATERNO LIKE CONCAT('%" + op.ApellidoPaterno +
                "%') AND P.APELLIDO_MATERNO LIKE CONCAT('%" + op.ApellidoMaterno + "%') AND P.CORREO LIKE ('%" + op.Correo +
                "%') AND P.TELEFONO LIKE CONCAT ('%" + op.Telefono + "%') AND TT.DESCRIPCION LIKE CONCAT ('%" + rol + "%')" +
                " AND (TT.ID_TIPO = 1 OR TT.ID_TIPO > 4) AND T.ID_TIPO = TT.ID_TIPO" +
                " AND T.ID_TRABAJADOR NOT IN (SELECT ID_TRABAJADOR FROM PROYECTO_X_TRABAJADOR WHERE ID_PROYECTO = " + p.IdProyecto + ");";
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
    }
}