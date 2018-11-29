using System;
using Modelo;
using LogicaNegocio;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas
{
    public partial class FormSubirArchivos : Form
    {
        private ArchivoBL logicaNegocio;
        private BindingList<Archivo> archivos;
        private BindingList<StringValue> nombresArch;
        private int idProyecto;
        private int idTrabajador;
        private int numArchivos;
        
        public FormSubirArchivos(int idProy = 1, int idTrab = 1)//entradas harcodeadas
        {
            InitializeComponent();

            idProyecto = idProy;
            idTrabajador = idTrab;

            logicaNegocio = new ArchivoBL();
            archivos = logicaNegocio.listarDocumentosProyecto(idProyecto);
            nombresArch = new BindingList<StringValue>();
            numArchivos = archivos.Count;

            nombresArch = new BindingList<StringValue>();
            for(int i=0; i<numArchivos; i++)
            {
                nombresArch.Add(new StringValue(archivos[i].Nombre));
            }
            dgvArchivos.DataSource = nombresArch;
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            
        }

        private void btnAgregarArchivo_Click(object sender, EventArgs e)
        {
            var result = ofdArchivo.ShowDialog();
            if(result != DialogResult.OK)
                return;
            {
                FileInfo fi = new FileInfo(ofdArchivo.FileName);
                Byte[] documentConten = File.ReadAllBytes(ofdArchivo.FileName);

                nombresArch.Add(new StringValue(fi.Name));

                Archivo cargado = new Archivo(0, fi.Name, documentConten, idProyecto, idTrabajador);
                archivos.Add(cargado);

            }
        }

        private void btnSubirArchivos_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("cantidad en DB: " + numArchivos + "\ncantidad en vista: " + archivos.Count);

            if (numArchivos == archivos.Count)
            {
                MessageBox.Show("No hay archivos nuevos que subir");
                return;
            }

            for(int i=numArchivos; i<archivos.Count; i++)
            {
                int idArch = logicaNegocio.guardarArchivo(archivos[i]);
                archivos[i].IdArchivo = idArch;
            }
            int numArchSubidos = archivos.Count - numArchivos;
            numArchivos = archivos.Count;
            MessageBox.Show("Se subieron " + numArchivos + " exitosamente");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (archivos.Count == 0)
            {
                MessageBox.Show("El proyecto no tiene archivos", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
            }
            if(dgvArchivos.SelectedRows.Count>1)
            {
                MessageBox.Show("Solo se puede descargar un archivo a la vez", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int indxArch = dgvArchivos.CurrentCell.RowIndex;
            var result = foldDescarga.ShowDialog();
            if (result != DialogResult.OK)
                return;
            else
            {
                String ruta = foldDescarga.SelectedPath + "\\";
                Archivo archDescargar = archivos.ElementAt(indxArch);

                if (archDescargar.Contenido == null)
                {
                    archDescargar.Contenido = logicaNegocio.obtenerDocumento(archDescargar.IdArchivo);
                }



                ruta = ruta + archDescargar.Nombre;
                if (File.Exists(@ruta))
                {
                    DialogResult dialogResult = MessageBox.Show("El archivo ya existe ¿Desea sobreescribirlo?", "Confirmación", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        File.WriteAllBytes(@ruta, archDescargar.Contenido);
                        MessageBox.Show("Se sobreescribio el archivo correctamente", "Información");
                        return;
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        return;
                    }
                }

                File.WriteAllBytes(@ruta, archDescargar.Contenido);
                MessageBox.Show("Se descargo el archivo correctamente", "Información");

            }
    
        }

        private void lblSubirArchivo_Click(object sender, EventArgs e)
        {

        }

        private void dgvArchivos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
