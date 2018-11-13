using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Modelo;
using AccesoDatos;

namespace LogicaNegocio
{
    public class SolicitudCambioBL
    {
        public BindingList<SolicitudCambio> obtenerSolicitudesCambio(int idJefe) {
            SolicitudCambioDA solicitudCambioDA = new SolicitudCambioDA();
            return solicitudCambioDA.obtenerSolicitudesDeCambio(idJefe);
        }
    }
}
