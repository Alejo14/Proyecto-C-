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
    public class DominioBL
    {
        public BindingList<Dominio> obtenerDominios()
        {
            DominioDA dominioDA = new DominioDA();
            return dominioDA.obtenerDominios();
        }
    }
}
