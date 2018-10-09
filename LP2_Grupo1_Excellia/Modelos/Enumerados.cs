using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public enum TipoFaseProyecto
    {
        PLANEACION, ANALISIS, DESARROLLO, PRUEBAS, PREPARACION,
        POSTPRODUCCION, COMPLETADO
    }
    public enum TipoCargo { ANALISTA_DESARROLLO, PROGRAMADOR, TESTER }
    public enum TipoRequerimiento { FUNCIONAL, NO_FUNCIONAL }
    public enum TipoEstadoMeta { }
    public enum TipoEstadoSolicitud { ENVIADA, APROBADA, DESAPROBADA }
}
