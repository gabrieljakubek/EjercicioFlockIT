using ApiEjercicio.Entitie;
using ApiEjercicio.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiEjercicio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PosicionController : ControllerBase
    {
        private readonly IBuscarProvincia _buscarProvincia;
        private readonly ILogServicio _logServicio;
        public PosicionController(IBuscarProvincia buscarProvincia, ILogServicio logServicio)
        {
            _buscarProvincia = buscarProvincia;
            _logServicio = logServicio;
        }
        [HttpGet]
        public async Task<IActionResult> Get(string provincia)
        {
            ProvinciaBuscada prov = new ProvinciaBuscada() { Nombre = provincia };
            _logServicio.LogInfo(String.Format("Se busca la provincia:{0}", provincia));
            var resultado = await _buscarProvincia.ObtenerLatitudLongitud(prov);
            if (resultado != null)
            {
                return Ok(resultado);
            }
            else
            {
                return BadRequest("No se encontro una provincia con dicho nombre");
            }
        }
    }
}
