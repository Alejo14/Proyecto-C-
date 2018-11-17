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

        public int registrarEvalucionSolicitud(SolicitudCambio solCambioEvaluada, bool solicitudAprobada) {

            if (solicitudAprobada)
                solCambioEvaluada.Estado = TipoEstadoSolicitud.APROBADA;
            else
                solCambioEvaluada.Estado = TipoEstadoSolicitud.DESAPROBADA;

            SolicitudCambioDA solicitudCambioDA = new SolicitudCambioDA();
            int resultado = solicitudCambioDA.registrarEvalucionSolicitud(solCambioEvaluada);

            return resultado;
        }
    }
}
