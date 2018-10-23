using System;
using System.Text;
using System.ComponentModel;
using Modelo;
using AccesoDatos;

namespace LogicaNegocio
{
    public class CuentaUsuarioBL
    {
        public BindingList<CuentaUsuario> obtenerCuentasUsuario() {
            CuentaUsuarioDA cuentaUsuarioDA = new CuentaUsuarioDA();
            return cuentaUsuarioDA.obtenerCuentasUsuario();
        }
        public string insertarUsuario(CuentaUsuario usuario) {
            string contrasena = CreatePassword(10);
            usuario.Contrasena = contrasena;

            CuentaUsuarioDA cuentaUsuarioDA = new CuentaUsuarioDA();
            int idCuenta = cuentaUsuarioDA.insertarCuentaUsuario(usuario);

            if (idCuenta < 0) return "";

            PersonaDA personaDA = new PersonaDA();

            int idPersona = personaDA.insertarPersona(usuario.Persona, idCuenta);

            if (idPersona < 0) return "";

            if (usuario.Persona is Cliente) {
                ClienteDA clienteDA = new ClienteDA();
                int idCliente = clienteDA.insertarCliente((Cliente)usuario.Persona, idPersona);
                if (idCliente < 0) return "";
            }
            else if (usuario.Persona is Experto) {
                ExpertoDA expertoDA = new ExpertoDA();
                int idExperto = expertoDA.insertarExperto((Experto)usuario.Persona, idPersona);
                if (idExperto < 0) return "";
            }
            else if (usuario.Persona is JefeProyecto) {
                JefeProyectoDA jefeProyectoDA = new JefeProyectoDA();
                int idJefeProyecto = jefeProyectoDA.insertarJefeProyecto((JefeProyecto)usuario.Persona, idPersona);
                if (idJefeProyecto < 0) return "";
            }
            else if (usuario.Persona is KAM) {
                KamDA kamDA = new KamDA();
                int idKam = kamDA.insertarKam((KAM)usuario.Persona, idPersona);
                if (idKam < 0) return "";
            }
            else if (usuario.Persona is Operario) {
                OperarioDA operarioDA = new OperarioDA();
                int idOperario = operarioDA.insertarOperario((Operario)usuario.Persona, idPersona);
                if (idOperario < 0) return "";
            }

            return contrasena;
        }
        public int validarUsuario (CuentaUsuario usuario) {

            CuentaUsuarioDA cuentaUsuarioDA = new CuentaUsuarioDA();

            BindingList<CuentaUsuario> cuentasUsuario = cuentaUsuarioDA.obtenerCuentasUsuario();

            bool encontrado = false;

            foreach (CuentaUsuario usuarioBD in cuentasUsuario) {
                encontrado = ((usuario.NomUsuario == usuarioBD.NomUsuario) && (usuario.Contrasena == usuarioBD.Contrasena));
                if (encontrado) {
                    usuario = usuarioBD;
                    break;
                }
            }
            if (encontrado)
                return determinarTipoUsuario(usuario.Persona);   
            else
                return -1;
        }
        private string CreatePassword(int length)
        {
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            return res.ToString();
        }
        private int determinarTipoUsuario(Persona personaUsuario) {
            int idTipo = 0;

            if (personaUsuario is Cliente)
                idTipo = 0;
            else if (personaUsuario is Trabajador)
            {
                Trabajador trabajadorUsuario = (Trabajador)(personaUsuario);
                if(trabajadorUsuario is Operario)
                {
                    idTipo = 1;
                }
                else if(trabajadorUsuario is JefeProyecto)
                {
                    idTipo = 2;
                }
                else
                {
                    idTipo = 3;
                }
            }

            else {
                idTipo = 4;//Esto indica que es administrador
            }

            return idTipo;
        }
    }
}
