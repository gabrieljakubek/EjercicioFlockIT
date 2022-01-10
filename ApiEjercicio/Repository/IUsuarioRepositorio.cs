using ApiEjercicio.Entitie;
using System.Threading.Tasks;

namespace ApiEjercicio.Repository
{
    public interface IUsuarioRepositorio
    {
        Task<RespuestaUsuario> ValidarUsuario(Usuario usuario);
    }
}
