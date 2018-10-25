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
    public class CuentaUsuarioDA
    {
        public BindingList<CuentaUsuario> obtenerCuentasUsuario() {
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
            BindingList<CuentaUsuario> cuentasUsuariosDA = new BindingList<CuentaUsuario>();

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;

            string query = "SELECT * FROM CUENTA_USUARIO C, PERSONA P, CLIENTE CLI " +
                "WHERE C.ID_CUENTA = P.ID_CUENTA AND P.ID_PERSONA = CLI.ID_PERSONA;";

            cmd.CommandText = query;

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read()) {
                CuentaUsuario cu = new CuentaUsuario();
                cu.IdCuenta = reader.GetInt32("ID_CUENTA");
                cu.NomUsuario = reader.GetString("NOMBRE_USUARIO");
                cu.Contrasena = reader.GetString("CONTRASENA");
                cu.Bloqueado = reader.GetBoolean("BLOQUEADO");
                Cliente cli = new Cliente();
                cli.IdCliente = reader.GetInt32("ID_CLIENTE");
                cli.Dni = reader.GetString("DNI");
                cli.Nombre = reader.GetString("NOMBRE");
                cli.ApellidoPaterno = reader.GetString("APELLIDO_PATERNO");
                cli.ApellidoMaterno = reader.GetString("APELLIDO_MATERNO");
                cli.Sexo = reader.GetChar("SEXO");
                cli.FechaNac = reader.GetDateTime("FECHA_NACIMIENTO");
                cli.Correo = reader.GetString("CORREO");
                cli.Telefono = reader.GetString("TELEFONO");
                cu.Persona = cli;
                cuentasUsuariosDA.Add(cu);
            }

            reader.Close();

            query = "SELECT * FROM CUENTA_USUARIO C, PERSONA P, TRABAJADOR T " +
                "WHERE C.ID_CUENTA = P.ID_CUENTA AND P.ID_PERSONA = T.ID_PERSONA;";

            cmd.CommandText = query;

            reader = cmd.ExecuteReader();
            /*IDs usados de la base de datos, darle mantenimiento*/
            while (reader.Read()) {
                CuentaUsuario cu = new CuentaUsuario();
                cu.IdCuenta = reader.GetInt32("ID_CUENTA");
                cu.NomUsuario = reader.GetString("NOMBRE_USUARIO");
                cu.Contrasena = reader.GetString("CONTRASENA");
                cu.Bloqueado = reader.GetBoolean("BLOQUEADO");
                int idTrabajador = reader.GetInt32("ID_TRABAJADOR");
                string dni = reader.GetString("DNI");
                string nombre = reader.GetString("NOMBRE");
                string apellidoPaterno = reader.GetString("APELLIDO_PATERNO");
                string apellidoMaterno = reader.GetString("APELLIDO_MATERNO");
                char sexo = reader.GetChar("SEXO");
                DateTime fechaNacimiento = reader.GetDateTime("FECHA_NACIMIENTO");
                string correo = reader.GetString("CORREO");
                string telefono = reader.GetString("TELEFONO");
                int idTipo = reader.GetInt32("ID_TIPO");

                if (idTipo == 0)
                {
                    Administrador admin = new Administrador();
                    admin.IdTrabajador = idTrabajador;
                    admin.Dni = dni;
                    admin.Nombre = nombre;
                    admin.ApellidoPaterno = apellidoPaterno;
                    admin.ApellidoMaterno = apellidoMaterno;
                    admin.Sexo = sexo;
                    admin.FechaNac = fechaNacimiento;
                    admin.Correo = correo;
                    admin.Telefono = telefono;
                    cu.Persona = admin;
                }
                if (idTipo == 1)
                {
                    Operario op = new Operario();
                    op.Cargo = TipoCargo.ANALISTA_DESARROLLO;
                    op.IdTrabajador = idTrabajador;
                    op.Dni = dni;
                    op.Nombre = nombre;
                    op.ApellidoPaterno = apellidoPaterno;
                    op.ApellidoMaterno = apellidoMaterno;
                    op.Sexo = sexo;
                    op.FechaNac = fechaNacimiento;
                    op.Correo = correo;
                    op.Telefono = telefono;
                    cu.Persona = op;
                }
                else if (idTipo == 2)
                {
                    KAM kam = new KAM();
                    kam.IdTrabajador = idTrabajador;
                    kam.Dni = dni;
                    kam.Nombre = nombre;
                    kam.ApellidoPaterno = apellidoPaterno;
                    kam.ApellidoMaterno = apellidoMaterno;
                    kam.Sexo = sexo;
                    kam.FechaNac = fechaNacimiento;
                    kam.Correo = correo;
                    kam.Telefono = telefono;
                    cu.Persona = kam;
                }
                else if (idTipo == 3)
                {
                    Experto experto = new Experto();
                    experto.IdTrabajador = idTrabajador;
                    experto.Dni = dni;
                    experto.Nombre = nombre;
                    experto.ApellidoPaterno = apellidoPaterno;
                    experto.ApellidoMaterno = apellidoMaterno;
                    experto.Sexo = sexo;
                    experto.FechaNac = fechaNacimiento;
                    experto.Correo = correo;
                    experto.Telefono = telefono;
                    cu.Persona = experto;
                }
                else if (idTipo == 4)
                {
                    JefeProyecto jefe = new JefeProyecto();
                    jefe.IdTrabajador = idTrabajador;
                    jefe.Dni = dni;
                    jefe.Nombre = nombre;
                    jefe.ApellidoPaterno = apellidoPaterno;
                    jefe.ApellidoMaterno = apellidoMaterno;
                    jefe.Sexo = sexo;
                    jefe.FechaNac = fechaNacimiento;
                    jefe.Correo = correo;
                    jefe.Telefono = telefono;
                    cu.Persona = jefe;
                }
                else if (idTipo == 5)
                {
                    Operario op = new Operario();
                    op.Cargo = TipoCargo.TESTER;
                    op.IdTrabajador = idTrabajador;
                    op.Dni = dni;
                    op.Nombre = nombre;
                    op.ApellidoPaterno = apellidoPaterno;
                    op.ApellidoMaterno = apellidoMaterno;
                    op.Sexo = sexo;
                    op.FechaNac = fechaNacimiento;
                    op.Correo = correo;
                    op.Telefono = telefono;
                    cu.Persona = op;
                }
                else if (idTipo == 6)
                {
                    Operario op = new Operario();
                    op.Cargo = TipoCargo.PROGRAMADOR;
                    op.IdTrabajador = idTrabajador;
                    op.Dni = dni;
                    op.Nombre = nombre;
                    op.ApellidoPaterno = apellidoPaterno;
                    op.ApellidoMaterno = apellidoMaterno;
                    op.Sexo = sexo;
                    op.FechaNac = fechaNacimiento;
                    op.Correo = correo;
                    op.Telefono = telefono;
                    cu.Persona = op;
                }
                cuentasUsuariosDA.Add(cu);
            }
            reader.Close();
            conn.Close();
            return cuentasUsuariosDA;
        }

        public int insertarCuentaUsuario(CuentaUsuario usuario) {
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

            string insert = "INSERT INTO CUENTA_USUARIO(NOMBRE_USUARIO, CONTRASENA, BLOQUEADO) VALUES ('" + usuario.NomUsuario + "', '" + usuario.Contrasena + "', " + usuario.Bloqueado+ ");";

            cmd.CommandText = insert;

            cmd.ExecuteNonQuery();

            int id = (int)cmd.LastInsertedId;

            return id;
        }
    }
}
