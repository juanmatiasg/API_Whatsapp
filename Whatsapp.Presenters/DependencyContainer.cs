using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Whatsapp.UseCasesPorts;

namespace Whatsapp.Presenters
{
    public static  class DependencyContainer
    {
        public static IServiceCollection AddPresenter(this IServiceCollection services)
        {
        
            services.AddScoped<ISendMessageOutputPort, WhatsappPresenter>();
            return services;
        }
    }
}
