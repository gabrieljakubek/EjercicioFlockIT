using ApiEjercicio.Entitie;
using ApiEjercicio.Service;
using Microsoft.Extensions.Configuration;
using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace ApiEjercicio.Repository
{
    public class ProvinciaRepositorio : IProvinciaRepositorio
    {
        private readonly ILogServicio _logServicio;
        public ProvinciaRepositorio(ILogServicio logServicio)
        {
            _logServicio = logServicio;
        }
        public async Task<RespuestaBuscarProvincia> ObtenerLatitudLongitud(ProvinciaBuscada prov)
        {
            string baseUrl = Startup.StaticConfig.GetValue<string>("ProvicnciasUrl") + prov.Nombre;
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    using (HttpResponseMessage res = await client.GetAsync(baseUrl))
                    {
                        using (HttpContent content = res.Content)
                        {
                            string data = await content.ReadAsStringAsync();
                            if (data != null)
                            {
                                Root root = new Root();
                                root = JsonSerializer.Deserialize<Root>(data);
                                RespuestaBuscarProvincia respuestaBuscarProvincia = new RespuestaBuscarProvincia();
                                respuestaBuscarProvincia.Latitud = root.provincias[0].centroide.lat;
                                respuestaBuscarProvincia.Longitud = root.provincias[0].centroide.lon;
                                return respuestaBuscarProvincia;
                            }
                            else
                            {
                                return null;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                _logServicio.LogError(ex,String.Format( "Error al obtener los datos de la provician:{0}",prov.Nombre));
                return null;
            }
        }
    }
}

