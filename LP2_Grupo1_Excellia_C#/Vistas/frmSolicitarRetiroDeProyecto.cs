using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;
using LogicaNegocio;

namespace Vistas
{
    public partial class frmSolicitarRetiroDeProyecto : Form
    {
        private Operario operario;
        private ProyectoBL proyectoBL;
        private Proyecto proyecto;
        public frmSolicitarRetiroDeProyecto(Operario operario)
        {
            InitializeComponent();
            this.operario = operario;
            proyectoBL = new ProyectoBL();
            dgvProyectos.AutoGenerateColumns = false;
            dgvProyectos.DataSource = proyectoBL.listarProyectosOperario(operario.IdTrabajador);           
        }
        private void btnSolicitarRetiro_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMotivo.Text))
            {
                MessageBox.Show("Debe de ingresar el motivo de la solicitud de retiro");
                return;
            }
            if(txtMotivo.Text.Length > 4000)
            {
                MessageBox.Show("La cantidad de caracteres ingresados supera el límite permitido (4000 caracteres)");
                return;
            }
            if(txtMotivo.Text.Length < 100)
            {
                MessageBox.Show("La cantidad de caracteres ingresados es menor al mínimo límite permitido (100 caracteres)");
                return;
            }
            List<int> caracteres = buscarCantidadNumeros(txtMotivo.Text);
            if(caracteres[0] == txtMotivo.Text.Length || 
                caracteres[1] == txtMotivo.Text.Length || 
                caracteres[0] + caracteres[1] == txtMotivo.Text.Length)
            {
                MessageBox.Show("La cadena no puede tener sólo números y/o caracteres especiales.");
                return;
            }
            if(dgvProyectos.CurrentRow != null)
            {
                proyecto = (Proyecto)dgvProyectos.CurrentRow.DataBoundItem;
            }
            else
            {
                MessageBox.Show("Seleccione el proyecto del que desea retirarse.");
                return;
            }
            proyectoBL.registrarSolicitud(proyecto, operario, txtMotivo.Text);
            MessageBox.Show("Se ha registrado la solicitud de retiro y se ha enviado un correo al Jefe de Proyecto");
            
        }

        private List<int> buscarCantidadNumeros(string cadena)
        {
            List<int> contadores = new List<int>();
            int numeros = 0;
            int caracters_no_alfnumericos = 0;
            foreach(char c in cadena)
            {
                if (Char.IsDigit(c)) numeros++;
                if (Char.IsSymbol(c) || Char.IsPunctuation(c) || Char.IsSeparator(c)) caracters_no_alfnumericos++; 
            }
            contadores.Add(numeros);
            contadores.Add(caracters_no_alfnumericos);
            return contadores;
        }
    }
}