using ApiEjercicio.Entitie;
using System.Threading.Tasks;

namespace ApiEjercicio.Repository
{
    public interface IProvinciaRepositorio
    {
        Task<RespuestaBuscarProvincia> ObtenerLatitudLongitud(ProvinciaBuscada prov);
    }
}
