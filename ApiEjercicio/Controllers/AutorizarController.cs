using ApiEjercicio.Entitie;
using ApiEjercicio.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiEjercicio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutorizarController : ControllerBase
    {
        private readonly IAutorizacion _autorizacion;
        private readonly ILogServicio _logServicio;
        public AutorizarController(IAutorizacion autorizacion, ILogServicio logServicio)
        {
            _autorizacion = autorizacion;
            _logServicio = logServicio;
        }
        // POST api/<Ejercicios>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]Usuario usuario)
        {
            _logServicio.LogInfo(String.Format("Se procede a validar el ususario:{0}", usuario.User));
            var retorno = await _autorizacion.ValidarUsuario(usuario);
            if (retorno != null)
            {
                return Ok(retorno);
            }
            else
            {
                return Unauthorized("Usuario no autorizado, comprobar que el user y password sean correctos");
            }
        }
    }
}
