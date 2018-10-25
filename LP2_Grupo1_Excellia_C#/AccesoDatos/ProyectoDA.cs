using System;
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
        public BindingList<Proyecto> listarProyectos()
        {
            BindingList<Proyecto> proyectos = new BindingList<Proyecto>();
            MySqlConnection con = new MySqlConnection(DBManager.cadena);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            String sql = "select ID_PROYECTO,NOMBRE from PROYECTO";
            cmd.CommandText = sql;
            cmd.Connection = con;
            MySqlDataReader lector = cmd.ExecuteReader();
            while (lector.Read())
            {
                Proyecto pro = new Proyecto();
                pro.IdProyecto = lector.GetInt32("ID_PROYECTO");
                pro.Nombre = lector.GetString("NOMBRE");
                //MessageBox.Show(pro.Nombre);
                proyectos.Add(pro);
            }
            con.Close();
            return proyectos;
        }

        public void retirarOperario(Proyecto p, Trabajador t)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(DBManager.cadena);
                con.Open();
                MySqlCommand cmd = new MySqlCommand();
                String sql = " update PROYECTO_X_TRABAJADOR set retirado = 0 where ID_PROYECTO ="+ p.IdProyecto +
                    " and ID_TRABAJADOR ="+t.IdTrabajador;
                cmd.CommandText = sql;
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                con.Close();

            }
            catch
            {
                MessageBox.Show("ERROR");
            }
        }

        public BindingList<Proyecto> listarProyectosEnCurso(int e, DateTime mifecha)
        {
            BindingList<Proyecto> proyectos = new BindingList<Proyecto>();
            MySqlConnection con = new MySqlConnection(DBManager.cadena);
            con.Open();
            //MessageBox.Show(e);
            //int etapaSelecc = int.Parse(e);
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
                //MessageBox.Show(pro.Nombre);
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
            //MySqlDataAdapter da1 = new MySqlDataAdapter(cmd);
            //DataTable dt = new DataTable();
            //da1.Fill(dt);
            while (lector.Read())
            {
            Etapa et = new Etapa();
            et.IdEtapa = lector.GetInt32("ID_TIPO_FASE_PROYECTO");
            et.NombreEtapa = lector.GetString("DESCRIPCION");
            etapas.Add(et);
            }
            con.Close();
            //return dt;
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
                MessageBox.Show("Error al realizar la actualización del proyecto "+id.ToString()+" con prioridad "+pri.ToString()+" y etapa "+et.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

    }
}
