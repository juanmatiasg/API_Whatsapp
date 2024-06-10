
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whatsapp.Http.Service
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddHttpService(this IServiceCollection services)
        {

            services.AddScoped<IWhatsappService, WhatsappService>();
            services.AddScoped(typeof(BaseService<>));
            services.AddScoped<HttpClient>();

            return services;
        }
    }
}
