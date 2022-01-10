using ApiEjercicio.Repository;
using ApiEjercicio.Service;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiEjercicio.Core
{
    public static class IoC
    {
        public static IServiceCollection AddDependencyProvinciaRepositorio(this IServiceCollection services)
        {
            services.AddTransient<IProvinciaRepositorio, ProvinciaRepositorio>();
            return services;
        }
        public static IServiceCollection AddDependencyUsuarioRepositorio(this IServiceCollection services)
        {
            services.AddTransient<IUsuarioRepositorio, UsuarioRepositorio>();
            return services;
        }
        public static IServiceCollection AddDependencyAutorizacionService(this IServiceCollection services)
        {
            services.AddTransient<IAutorizacion, Autorizacion>();
            return services;
        }
        public static IServiceCollection AddDependencyBuscarProvinciaService(this IServiceCollection services)
        {
            services.AddTransient<IBuscarProvincia, BuscarProvincia>();
            return services;
        }
        public static IServiceCollection AddDependencyLogServicio(this IServiceCollection services)
        {
            services.AddTransient<ILogServicio, LogServicio>();
            return services;
        }
    }
}
