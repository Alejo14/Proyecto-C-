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
    public partial class FormSubirArchivos : Form
    {
        private BindingList<StringValue> archivos;

        public FormSubirArchivos()
        {
            InitializeComponent();
            archivos = new BindingList<StringValue>();
            dgvArchivos.DataSource = archivos;
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            
        }

        private void btnAgregarArchivo_Click(object sender, EventArgs e)
        {
            ofdArchivo.ShowDialog();
            archivos.Add(new StringValue(ofdArchivo.FileName));
            
        }

        private void btnSubirArchivos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Archivos subidos con éxito");

            Dispose();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }

    class StringValue {
        string nombreArchivo;

        public StringValue(string nombreArchivo)
        {
            NombreArchivo = nombreArchivo;
        }

        public string NombreArchivo { get => nombreArchivo; set => nombreArchivo = value; }
    }
}
