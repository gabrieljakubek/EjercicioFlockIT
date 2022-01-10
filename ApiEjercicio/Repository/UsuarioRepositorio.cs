using ApiEjercicio.Entitie;
using ApiEjercicio.Service;
using Microsoft.Extensions.Configuration;
using System;
using System.Threading.Tasks;

namespace ApiEjercicio.Repository
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        private readonly ILogServicio _logServicio;
        public UsuarioRepositorio(ILogServicio logServicio)
        {
            _logServicio = logServicio;
        }
        public async Task<RespuestaUsuario> ValidarUsuario(Usuario usuario)
        {
            var usuarioValido = new Usuario() { User = Startup.StaticConfig.GetValue<string>("UsuarioValido:User"), Password = Startup.StaticConfig.GetValue<string>("UsuarioValido:Password") };
            try
            {
                var respuestaUsuario = new RespuestaUsuario();
                if (usuario.User == usuarioValido.User && usuario.Password == usuarioValido.Password)
                {
                    respuestaUsuario.Id = 1;
                    respuestaUsuario.User = usuario.User;
                    respuestaUsuario.Perfil = "Administrador";
                }
                else
                {
                    throw new Exception("Usuario no valido");
                }
                return respuestaUsuario;
            }
            catch (Exception ex)
            {
                _logServicio.LogError(ex, String.Format("Error al validar el usuario:{0}", usuario.User));
                return null;
            }
        }
    }
}
