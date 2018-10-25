using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class CuentaUsuario
    {
        private int idCuenta;
        private string nomUsuario;
        private string contrasena;
        private bool bloqueado;
        private Persona persona;
        private Administrador administrador;

        public CuentaUsuario()
        {
            this.persona = new Persona();
            this.administrador = new Administrador();
        }

        public CuentaUsuario(int idCuenta, string nomUsuario, string contrasena,
                bool bloqueado)
        {
            this.idCuenta = idCuenta;
            this.nomUsuario = nomUsuario;
            this.contrasena = contrasena;
            this.bloqueado = bloqueado;
            this.persona = new Persona();
            this.administrador = new Administrador();
        }
        public int IdCuenta { get => idCuenta; set => idCuenta = value; }
        public string NomUsuario { get => nomUsuario; set => nomUsuario = value; }
        public string Contrasena { get => contrasena; set => contrasena = value; }
        public bool Bloqueado { get => bloqueado; set => bloqueado = value; }
        public Persona Persona { get => persona; set => persona = value; }
        public Administrador Administrador { get => administrador; set => administrador = value; }
        public string TipoUsuario {
            get {
                string tipoString = "";

                if (persona is KAM)
                    tipoString = "KAM";
                else if (persona is JefeProyecto)
                    tipoString = "Jefe de Proyecto";
                else if (persona is Experto)
                    tipoString = "Experto";
                else if (persona is Cliente)
                    tipoString = "Cliente";
                else if (persona is Operario)
                {
                    Operario op = (Operario)persona;
                    if (op.Cargo == TipoCargo.ANALISTA_DESARROLLO)
                        tipoString = "Analista";
                    else if (op.Cargo == TipoCargo.PROGRAMADOR)
                        tipoString = "Programador";
                    else
                        tipoString = "Tester";
                }

                else
                    tipoString = "Administrador";

                return tipoString;
            }
        }
    }
}
