﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.Windows.Forms;
using System.Data;

namespace AccesoDatos
{
    public class ProyectoDA
    {
        public BindingList<Proyecto> listarProyectosOperario(int idOperario)
        {
            BindingList<Proyecto> proyectos = new BindingList<Proyecto>();
            MySqlConnection con = new MySqlConnection(DBManager.cadena);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            String sql = "select distinct P.ID_PROYECTO, P.NOMBRE, F.DESCRIPCION, P.FECHA_INICIO, P.ID_TRABAJADOR_JEFE " +
                "from PROYECTO P, PROYECTO_X_TRABAJADOR PT, TIPO_FASE_PROYECTO F " +
                "where  P.ID_PROYECTO = PT.ID_PROYECTO and F.ID_TIPO_FASE_PROYECTO = P.ID_TIPO_FASE_PROYECTO " +
                "and PT.ID_TRABAJADOR = " + idOperario + " and PT.RETIRADO = 0;";
            cmd.CommandText = sql;
            cmd.Connection = con;
            JefeProyectoDA jefeProyectoDA = new JefeProyectoDA();
            MySqlDataReader lector = cmd.ExecuteReader();
            while (lector.Read())
            {
                Proyecto pro = new Proyecto();
                pro.IdProyecto = lector.GetInt32("ID_PROYECTO");
                pro.Nombre = lector.GetString("NOMBRE");
                string etapa = lector.GetString("DESCRIPCION");
                if (etapa == "Cancelado" || etapa == "Completado") continue;
                switch (etapa)
                {
                    case "Análisis":
                        pro.Etapa = TipoFaseProyecto.ANALISIS;
                        break;
                    case "Desarrollo":
                        pro.Etapa = TipoFaseProyecto.DESARROLLO;
                        break;
                    case "Pruebas":
                        pro.Etapa = TipoFaseProyecto.PRUEBAS;
                        break;
                    case "Preparación":
                        pro.Etapa = TipoFaseProyecto.PREPARACION;
                        break;
                    case "Post-producción":
                        pro.Etapa = TipoFaseProyecto.POSTPRODUCCION;
                        break;  
                }
                pro.FechaInicio = lector.GetDateTime("FECHA_INICIO");
                int idJefeProyecto = lector.GetInt32("ID_TRABAJADOR_JEFE");
                pro.JefeProyecto = jefeProyectoDA.obtenerJefeProyecto(idJefeProyecto);
                proyectos.Add(pro);
            }
            con.Close();
            return proyectos;
        }

        public int buscarIdProyectoTrabajador(Proyecto p, Operario op)
        {
            MySqlConnection con = new MySqlConnection(DBManager.cadena);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            String sql = "SELECT ID_PROYECTO_X_TRABAJADOR FROM PROYECTO_X_TRABAJADOR WHERE ID_PROYECTO = " + p.IdProyecto + " AND ID_TRABAJADOR = " + op.IdTrabajador + ";";
            cmd.CommandText = sql;
            cmd.Connection = con;
            MySqlDataReader lector = cmd.ExecuteReader();
            lector.Read();
            int id = lector.GetInt32("ID_PROYECTO_X_TRABAJADOR");
            con.Close();
            return id;
        }

        public void registrarSolicitud(int id, string descripcion)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(DBManager.cadena);
                con.Open();
                MySqlCommand cmd = new MySqlCommand();
                String sql = "INSERT INTO SOLICITUD_RETIRO (ID_PROYECTO_X_TRABAJADOR,DESCRIPCION,FECHA_SOLICITUD) VALUES (" + id + ", '" + descripcion + "', sysdate());";
                cmd.CommandText = sql;
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch
            {
                MessageBox.Show("No se pudo registrar la solicitud de retiro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        public void retirarOperario(Proyecto p, Trabajador t)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(DBManager.cadena);
                con.Open();
                MySqlCommand cmd = new MySqlCommand();
                String sql = "UPDATE PROYECTO_X_TRABAJADOR set retirado = 1 WHERE ID_PROYECTO ="+ p.IdProyecto +
                    " AND ID_TRABAJADOR ="+t.IdTrabajador;
                cmd.CommandText = sql;
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                con.Close();

            }
            catch
            {
                MessageBox.Show("No se pudo realizar el retiro.", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        public BindingList<Proyecto> listarProyectosEnCurso(int e, DateTime mifecha)
        {
            BindingList<Proyecto> proyectos = new BindingList<Proyecto>();
            MySqlConnection con = new MySqlConnection(DBManager.cadena);
            con.Open();
            int dia = mifecha.Day;
            int mes = mifecha.Month;
            int anio = mifecha.Year;
            string fecha = anio + "-" + mes + "-" + dia;
            MySqlCommand cmd = new MySqlCommand();
            String sql = " select P.ID_PROYECTO, P.NOMBRE, P.ID_TIPO_FASE_PROYECTO, P.PRIORIDAD, P.FECHA_INICIO, P.FECHA_FIN_ESTIMADA, P.PRESUPUESTO " +
                " from PROYECTO P, TIPO_FASE_PROYECTO TFP " +
                " WHERE TFP.ID_TIPO_FASE_PROYECTO = P.ID_TIPO_FASE_PROYECTO ";
            if(e != 0)
                sql = sql + " AND TFP.ID_TIPO_FASE_PROYECTO=" + e;
            sql = sql + " AND P.FECHA_INICIO >='" + fecha+"'";
            cmd.CommandText = sql;
            cmd.Connection = con;
            MySqlDataReader lector = cmd.ExecuteReader();
            while (lector.Read())
            {
                Proyecto pro = new Proyecto();
                pro.IdProyecto = lector.GetInt32("ID_PROYECTO");
                pro.Nombre = lector.GetString("NOMBRE");
                int idEtapa = lector.GetInt32("ID_TIPO_FASE_PROYECTO");
                if (idEtapa == 1)
                {
                    pro.Etapa = TipoFaseProyecto.ANALISIS;
                }else if (idEtapa == 2)
                {
                    pro.Etapa = TipoFaseProyecto.DESARROLLO;
                }
                else if (idEtapa == 3)
                {
                    pro.Etapa = TipoFaseProyecto.PRUEBAS;
                }
                else if (idEtapa == 4)
                {
                    pro.Etapa = TipoFaseProyecto.PREPARACION;
                }
                else if (idEtapa == 5)
                {
                    pro.Etapa = TipoFaseProyecto.POSTPRODUCCION;
                }
                else if (idEtapa == 6)
                {
                    pro.Etapa = TipoFaseProyecto.COMPLETADO;
                }
                else if (idEtapa == 7)
                {
                    pro.Etapa = TipoFaseProyecto.CANCELADO;
                }
                int idPri = lector.GetInt32("PRIORIDAD");
                if (idPri == 1)
                {
                    pro.Prioridad = TipoPrioridad.ALTA;
                }
                else if (idPri == 2)
                {
                    pro.Prioridad = TipoPrioridad.MEDIA;
                }
                else if (idPri == 3)
                {
                    pro.Prioridad = TipoPrioridad.BAJA;
                }
                pro.FechaInicio = lector.GetDateTime("FECHA_INICIO");
                pro.FechaFinEstimada = lector.GetDateTime("FECHA_FIN_ESTIMADA");
                pro.Presupuesto = lector.GetFloat("PRESUPUESTO");
                proyectos.Add(pro);
            }
            con.Close();
            return proyectos;
        }

        public BindingList<Etapa> listarEtapas()
        {
            BindingList<Etapa> etapas = new BindingList<Etapa>();
            MySqlConnection con = new MySqlConnection(DBManager.cadena);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            String sql = "SELECT ID_TIPO_FASE_PROYECTO, DESCRIPCION FROM  TIPO_FASE_PROYECTO ";
            cmd.CommandText = sql;
            cmd.Connection = con;
            MySqlDataReader lector = cmd.ExecuteReader();
            while (lector.Read())
            {
            Etapa et = new Etapa();
            et.IdEtapa = lector.GetInt32("ID_TIPO_FASE_PROYECTO");
            et.NombreEtapa = lector.GetString("DESCRIPCION");
            etapas.Add(et);
            }
            Etapa e = new Etapa();
            e.IdEtapa = 0;
            e.NombreEtapa = "---Seleccionar---";
            etapas.Insert(0,e);
            con.Close();
            return etapas;
        }

        public void ActualizarDatos(int id, int pri, int et)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(DBManager.cadena);
                con.Open();
                MySqlCommand cmd = new MySqlCommand();
                String sql = " update PROYECTO set PRIORIDAD =" + pri +
                    ", ID_TIPO_FASE_PROYECTO =" + et +
                    " where ID_PROYECTO =" + id;
                cmd.CommandText = sql;
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                con.Close();

            }
            catch
            {
                MessageBox.Show("Error al realizar la actualización del proyecto "+id.ToString()+" con prioridad "+pri.ToString()+" y etapa "+et.ToString(), 
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CancelarProyecto(int id)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(DBManager.cadena);
                con.Open();
                MySqlCommand cmd = new MySqlCommand();
                String sql = " update PROYECTO set  ID_TIPO_FASE_PROYECTO=7 where ID_PROYECTO=" + id;
                cmd.CommandText = sql;
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                con.Close();

            }
            catch
            {
                MessageBox.Show("Error al cancelar el proyecto N° " + id.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CrearProyecto(Proyecto p)
        {
            try
            {
                int pri=0;
                if(p.Prioridad == TipoPrioridad.ALTA)
                {
                    pri = 1;
                }else if (p.Prioridad == TipoPrioridad.MEDIA)
                {
                    pri = 2;
                }
                else if (p.Prioridad == TipoPrioridad.BAJA)
                {
                    pri = 3;
                }

                MySqlConnection con = new MySqlConnection(DBManager.cadena);
                con.Open();
                MySqlCommand cmd = new MySqlCommand();
                String cadenaI = p.FechaInicio.Year.ToString() + "-" + p.FechaInicio.Month.ToString() + "-" + p.FechaInicio.Day.ToString();
                String cadenaF = p.FechaFinEstimada.Year.ToString() + "-" + p.FechaFinEstimada.Month.ToString() + "-" + p.FechaFinEstimada.Day.ToString();
                String cadenaFR = p.FechaRealFin.Year.ToString() + "-" + p.FechaRealFin.Month.ToString() + "-" + p.FechaRealFin.Day.ToString();
                
                String sql = " INSERT INTO PROYECTO (ID_ERU, ID_TRABAJADOR_JEFE, NOMBRE, PRESUPUESTO, PRIORIDAD, ID_TIPO_FASE_PROYECTO, FECHA_INICIO, FECHA_FIN_ESTIMADA, FECHA_FIN_REAL)"+
                    " VALUES ("+p.Eru.IdERU+", "+p.JefeProyecto.IdTrabajador+", '"+p.Nombre+"', "+p.Presupuesto+", "+pri+", 1, '"+ cadenaI +"', '"+ cadenaF +"', '"+ cadenaFR + "')";
                cmd.CommandText = sql;
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                con.Close();

            }
            catch
            {
                MessageBox.Show("Error al crear el proyecto. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void ActualizarERU(Proyecto p)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(DBManager.cadena);
                con.Open();
                MySqlCommand cmd = new MySqlCommand();
                String sql = " update ERU set  ESTADO=3 where ID_ERU=" + p.Eru.IdERU;
                cmd.CommandText = sql;
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                con.Close();

            }
            catch
            {
                MessageBox.Show("Error al actualizar la ERU. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void AsignarTrabajador(Proyecto p, Trabajador t)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(DBManager.cadena);
                con.Open();
                MySqlCommand cmd = new MySqlCommand();
                String sql = " insert into PROYECTO_X_TRABAJADOR(id_proyecto, id_trabajador, retirado) " +
                                " values(" + p.IdProyecto + "," + t.IdTrabajador + ",0)";

                cmd.CommandText = sql;
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                con.Close();

            }
            catch
            {
                MessageBox.Show("Error al asignar trabajador al proyeco ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //
        public BindingList<Cliente> listarEmpresasClientes()
        {
            BindingList<Cliente> clientes = new BindingList<Cliente>();
            MySqlConnection con = new MySqlConnection(DBManager.cadena);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            String sql = "SELECT C.*, E.RAZON_SOCIAL from CLIENTE C, EMPRESA E WHERE C.ID_EMPRESA=E.ID_EMPRESA ";
            cmd.CommandText = sql;
            cmd.Connection = con;
            MySqlDataReader lector = cmd.ExecuteReader();
            while (lector.Read())
            {
                Cliente cli = new Cliente();
                cli.IdCliente = lector.GetInt32("ID_CLIENTE");
                Empresa emp = new Empresa();
                emp.IdEmpresa = lector.GetInt32("ID_EMPRESA");
                emp.RazonSocial = lector.GetString("RAZON_SOCIAL");
                cli.Empresa = emp;
                clientes.Add(cli);
            }
            Cliente c = new Cliente();
            c.IdCliente = 0;
            c.Empresa.IdEmpresa = 0;
            c.Empresa.RazonSocial = "---Seleccionar---";
            clientes.Insert(0, c);
            con.Close();
            return clientes;
        }

        public void CancelarERU(int id)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(DBManager.cadena);
                con.Open();
                MySqlCommand cmd = new MySqlCommand();
                String sql = " update ERU set  ESTADO=4 where ID_ERU=" + id;
                cmd.CommandText = sql;
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                con.Close();

            }
            catch
            {
                MessageBox.Show("Error al actualizar el estado de la ERU. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public int EruDeProyecto(int p)
        {
            BindingList<Etapa> etapas = new BindingList<Etapa>();
            MySqlConnection con = new MySqlConnection(DBManager.cadena);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            String sql = "select ID_ERU FROM PROYECTO WHERE ID_PROYECTO="+p;
            cmd.CommandText = sql;
            cmd.Connection = con;
            MySqlDataReader lector = cmd.ExecuteReader();
            int eru = 0;
            while (lector.Read())
            {
                eru = lector.GetInt32("ID_ERU");
            }

            return eru;
        }

        public BindingList<Proyecto> listarReportes()
        {
            BindingList<Proyecto> proyectos = new BindingList<Proyecto>();
            MySqlConnection con = new MySqlConnection(DBManager.cadena);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            String sql = "SELECT ID_TIPO_FASE_PROYECTO, DESCRIPCION FROM  TIPO_FASE_PROYECTO ";
            cmd.CommandText = sql;
            cmd.Connection = con;
            MySqlDataReader lector = cmd.ExecuteReader();
            while (lector.Read())
            {
                Proyecto pro = new Proyecto();
                proyectos.Add(pro);
            }
            con.Close();
            return proyectos;
        }

        public string obtenerPresupuesto(ERU e)
        {
            MySqlConnection con = new MySqlConnection(DBManager.cadena);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            String sql = "SELECT TOTAL_COSTO FROM ESTIMACION WHERE ERU_ID_ERU = " + e.IdERU + ";";
            cmd.CommandText = sql;
            cmd.Connection = con;
            MySqlDataReader lector = cmd.ExecuteReader();
            string presupuesto = "";
            if (lector.Read()) presupuesto = lector.GetDouble("TOTAL_COSTO").ToString();
            con.Close();
            return presupuesto;
        }

        public string obtenerFFEstimado(ERU e)
        {
            MySqlConnection con = new MySqlConnection(DBManager.cadena);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            String sql = "SELECT DISTINCT FECHA_ESTIMADA FROM REQUERIMIENTO WHERE ID_ERU = " + e.IdERU + ";";
            cmd.CommandText = sql;
            cmd.Connection = con;
            MySqlDataReader lector = cmd.ExecuteReader();
            string fecha = "";
            if (lector.Read()) fecha = lector.GetDateTime("FECHA_ESTIMADA").ToString();
            con.Close();
            return fecha;
        }


        public BindingList<Etapa> listarEtapasxProyecto(int id)
        {
            BindingList<Etapa> etapas = new BindingList<Etapa>();
            MySqlConnection con = new MySqlConnection(DBManager.cadena);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            String sql = "SELECT ID_TIPO_FASE_PROYECTO, DESCRIPCION FROM  TIPO_FASE_PROYECTO WHERE ID_TIPO_FASE_PROYECTO >="+id;
            cmd.CommandText = sql;
            cmd.Connection = con;
            MySqlDataReader lector = cmd.ExecuteReader();
            while (lector.Read())
            {
                Etapa et = new Etapa();
                et.IdEtapa = lector.GetInt32("ID_TIPO_FASE_PROYECTO");
                et.NombreEtapa = lector.GetString("DESCRIPCION");
                if(id!= 1 && et.IdEtapa !=7)
                    etapas.Add(et);
                if(id == 1 || id==7)
                    etapas.Add(et);
            }
            Etapa e = new Etapa();
            con.Close();
            return etapas;
        }
    }
}
