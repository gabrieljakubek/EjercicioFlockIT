using ApiEjercicio.Entitie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiEjercicio.Service
{
    public interface IBuscarProvincia
    {
        Task<RespuestaBuscarProvincia> ObtenerLatitudLongitud(ProvinciaBuscada provincia);
    }
}
