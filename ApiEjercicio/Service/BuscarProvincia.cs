using ApiEjercicio.Entitie;
using ApiEjercicio.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiEjercicio.Service
{
    public class BuscarProvincia : IBuscarProvincia
    {
        private readonly IProvinciaRepositorio _provinciaRepositorio;
        public BuscarProvincia(IProvinciaRepositorio provinciaRepositorio)
        {
            _provinciaRepositorio = provinciaRepositorio;
        }
        public async Task<RespuestaBuscarProvincia> ObtenerLatitudLongitud(ProvinciaBuscada provincia)
        {                    
            return await _provinciaRepositorio.ObtenerLatitudLongitud(provincia);
        }
    }
}
