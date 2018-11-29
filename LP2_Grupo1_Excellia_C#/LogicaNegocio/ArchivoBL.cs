using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Modelo;

using Modelo;
using AccesoDatos;

namespace LogicaNegocio
{
    public class ArchivoBL
    {
        public BindingList<Archivo> listarDocumentosProyecto(int idProyecto)
        {
            ArchivoDA accesoDatos = new ArchivoDA();
            return accesoDatos.listarDocumentosProyecto(idProyecto);
        }

        public int guardarArchivo(Archivo arch)
        {
            ArchivoDA accesoDatos = new ArchivoDA();
            return accesoDatos.guardarDocumento(arch);
        }

        public byte[] obtenerDocumento(int idArch)
        {
            ArchivoDA accesoDatos = new ArchivoDA();
            return accesoDatos.obtenerDocumento(idArch);
        }
    }
}
