using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Modelo;
using System.ComponentModel;

namespace LogicaNegocio
{
    public class EruBL
    {
        private EruDA eruDA;
        public EruBL()
        {
            eruDA = new EruDA();
        }
        public BindingList<ERU> listarErusPendientes()
        {
            return eruDA.listarErusPendientes();
        }

    }
}
