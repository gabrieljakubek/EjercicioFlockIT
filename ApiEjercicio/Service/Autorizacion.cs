using ApiEjercicio.Entitie;
using ApiEjercicio.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiEjercicio.Service
{
    public class Autorizacion : IAutorizacion
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;
        public Autorizacion(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }
        public async Task<RespuestaUsuario> ValidarUsuario(Usuario usuario)
        {
            usuario.Password = Convert.ToBase64String(Encoding.UTF8.GetBytes(usuario.Password));
            return await _usuarioRepositorio.ValidarUsuario(usuario);
        }
    }
}
