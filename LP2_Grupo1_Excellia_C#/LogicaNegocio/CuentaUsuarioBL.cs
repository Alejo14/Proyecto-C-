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

        public CuentaUsuario obtenerCuentaUsuario(string nombre)
        {
            CuentaUsuarioDA cuentaUsuarioDA = new CuentaUsuarioDA();
            BindingList<CuentaUsuario> cuentas = cuentaUsuarioDA.obtenerCuentasUsuario();
            foreach(CuentaUsuario cu in cuentas)
            {
                if(!cu.Bloqueado && cu.NomUsuario == nombre)
                {
                    return cu;
                }
                else if (cu.Bloqueado)
                {
                    return null;
                }
            }
            return null;

        }

        public int insertarUsuario(CuentaUsuario usuario) {
            string contrasena = CreatePassword(10);
            usuario.Contrasena = contrasena;

            string mensajeBienvenida = obtenerMensajeBienvenidaSistema(usuario, contrasena);

            int resultado = EmailSender.enviarEmail(usuario.Persona.Correo, "Bienvenida sistema Excellia", mensajeBienvenida);

            if (resultado < 0) return -4;

            CuentaUsuarioDA cuentaUsuarioDA = new CuentaUsuarioDA();
            int idCuenta = cuentaUsuarioDA.insertarCuentaUsuario(usuario);

            if (idCuenta < 0) return -1;

            PersonaDA personaDA = new PersonaDA();

            int idPersona = personaDA.insertarPersona(usuario.Persona, idCuenta);

            if (idPersona < 0) return -2;

            if (usuario.Persona is Cliente) {
                ClienteDA clienteDA = new ClienteDA();
                int idCliente = clienteDA.insertarCliente((Cliente)usuario.Persona, idPersona);
                if (idCliente < 0) return -3;
            }
            else if (usuario.Persona is Experto) {
                ExpertoDA expertoDA = new ExpertoDA();
                int idExperto = expertoDA.insertarExperto((Experto)usuario.Persona, idPersona);
                if (idExperto < 0) return -3;
            }
            else if (usuario.Persona is JefeProyecto) {
                JefeProyectoDA jefeProyectoDA = new JefeProyectoDA();
                int idJefeProyecto = jefeProyectoDA.insertarJefeProyecto((JefeProyecto)usuario.Persona, idPersona);
                if (idJefeProyecto < 0) return -3;
            }
            else if (usuario.Persona is KAM) {
                KamDA kamDA = new KamDA();
                int idKam = kamDA.insertarKam((KAM)usuario.Persona, idPersona);
                if (idKam < 0) return -3;
            }
            else if (usuario.Persona is Operario) {
                OperarioDA operarioDA = new OperarioDA();
                int idOperario = operarioDA.insertarOperario((Operario)usuario.Persona, idPersona);
                if (idOperario < 0) return -3;
            }

            return 1;
        }

        public bool recuperarContraseña(CuentaUsuario cu)
        {
            string recuperacion = obtenerMensajeRecuperacion(cu);
            try
            {
                EmailSender.enviarEmail(cu.Persona.Correo, "Recuperación de Contraseña", recuperacion);
                return true;
            }
            catch
            {
                return false;
            }
            
        }

        public int validarUsuario (ref CuentaUsuario usuario) {

            CuentaUsuarioDA cuentaUsuarioDA = new CuentaUsuarioDA();

            BindingList<CuentaUsuario> cuentasUsuario = cuentaUsuarioDA.obtenerCuentasUsuario();

            bool encontrado = false;
            bool usuarioEncontrado = false;

            foreach (CuentaUsuario usuarioBD in cuentasUsuario) {
                encontrado = ((usuario.NomUsuario == usuarioBD.NomUsuario) && (usuario.Contrasena == usuarioBD.Contrasena));
                if (encontrado) {
                    usuario = usuarioBD;
                    break;
                }
                if (!usuarioEncontrado)
                    usuarioEncontrado = (usuario.NomUsuario == usuarioBD.NomUsuario);
            }
            if (encontrado)
                return determinarTipoUsuario(usuario.Persona);
            else if (usuarioEncontrado)
                return -1;
            else
                return -2;
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
                else if(trabajadorUsuario is Administrador)
                {
                    idTipo = 3;//Este es el administrador
                }
            }


            return idTipo;
        }

        private string obtenerMensajeBienvenidaSistema(CuentaUsuario usuario, string contrasena) {
            string mensaje = "Estimado/a " + usuario.Persona.Nombre + ",\r\nMediante la presente, le damos la bienvenida " +
                "al sistema de Excellia. Adjunto, encontrará sus credenciales para poder ingresar al sistema:\r\n\r\n" +
                "Usuario: " + usuario.NomUsuario + "\r\nContraseña: " + contrasena +
                "\r\n\r\nAtentamente,\r\n\r\nEl equipo de Excellia";
            return mensaje;
        }

        private string obtenerMensajeRecuperacion(CuentaUsuario cu)
        {
            string mensaje = "Estimado/a " + cu.Persona.Nombre + ",\r\nSu contraseña es: " +
                 cu.Contrasena + "\r\n\r\nAtentamente,\r\n\r\nEl equipo de Excellia";
            return mensaje;
        }
    }
}
