using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Modelo;

namespace LogicaNegocio
{
    public class EmpresaBL
    {
        public BindingList<Empresa> obtenerEmpresas()
        {
            EmpresaDA empresaDA = new EmpresaDA();
            return empresaDA.obtenerEmpresas();
        }
    }
}
