using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas
{
    public partial class frmAsignarTrabajador : Form
    {
        private BindingList<Trabajador> trabajadores;
        private BindingList<Trabajador> vacio;
        public frmAsignarTrabajador()
        {
            InitializeComponent();
            trabajadores = new BindingList<Trabajador>();
            //crearTrabajadores(trabajadores);
            vacio = new BindingList<Trabajador>();
            dgvTrabajador.DataSource = vacio;
        }

        /*private static void crearTrabajadores(BindingList<Trabajador> t)
        {
            //Creación de varios trabajadores extras
            Trabajador p1 = new Trabajador("EXC145", "Roberto Paredes", "r.paredes@hotmail.com", Rol.Programador,'N',940323164);
            Trabajador p2 = new Trabajador("EXC123", "Alejandro López", "a.lopez@gmail.com", Rol.Programador,'S', 995574101);
            Trabajador p3 = new Trabajador("EXT008", "Liz Amaya", "l.amaya@hotmailcom", Rol.Programador, 'S',902345678);
            Trabajador a1 = new Trabajador("EXC220", "Rodrigo Carrillo", "r.carrillo@gmail.com", Rol.Analista, 'N',904214541);
            Trabajador a2 = new Trabajador("EXC012", "Mario Vargas", "m.vargas@hotmail.com", Rol.Analista, 'S',950354478);
            Trabajador t1 = new Trabajador("EXC100", "Lucía Palacios", "l.palacios@hotmail.com", Rol.Tester, 'N',908455661);
            Trabajador t2 = new Trabajador("EXC050", "María Córdova", "m.cordova@gmail.com", Rol.Tester, 'S',954866566);

            t.Add(p1);
            t.Add(p2);
            t.Add(p3);
            t.Add(a1);
            t.Add(a2);
            t.Add(t1);
            t.Add(t2);
        }*/

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            bool entre = false;
            foreach(DataGridViewRow r in dgvTrabajador.Rows)
            {
                if(Convert.ToBoolean(r.Cells[0].Value))
                {
                    entre = true;
                    MessageBox.Show("Correos enviados correctamente.", "Asignación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            if (!entre)
            {
                MessageBox.Show("Ningún trabajador seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }  
        }

        private void btnForm_Buscar_Click(object sender, EventArgs e)
        {
            BindingList<Trabajador> buscado = new BindingList<Trabajador>();
            if (txtBuscar.Text != "")
            {
                foreach(Trabajador t in trabajadores)
                {
                    if (t.IdTrabajador == int.Parse(txtBuscar.Text))
                    {
                        buscado.Add(t);
                        dgvTrabajador.DataSource = buscado;
                    }
                }
            }
            else
            {
                dgvTrabajador.DataSource = trabajadores;
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            bool entre = false;
            foreach (DataGridViewRow r in dgvTrabajador.Rows)
            {
                if (Convert.ToBoolean(r.Cells[0].Value))
                {
                    entre = true;
                    dgvTrabajador.Rows.RemoveAt(dgvTrabajador.CurrentRow.Index);
                }
            }
            if(entre == false)
            {
                MessageBox.Show("Ningún trabajador seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

    }
}
