using Microsoft.Extensions.DependencyInjection;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Whatsapp.UseCases;
using Whatsapp.Presenters;
using Whatsapp.Http.Service;


namespace Whatsapp.IoC
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddArquitecturaLimpiaDependencies(this IServiceCollection services)
        {

            services.AddUseCases();
            services.AddPresenter();
            services.AddHttpService();

            return services;
        }
    }
}
