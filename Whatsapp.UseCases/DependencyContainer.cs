
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Whatsapp.UseCasesPorts;

namespace Whatsapp.UseCases
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddUseCases(this IServiceCollection services)
        {
            
            services.AddTransient<ISendMessageInputPort, SendMessageInteractor>();
   

            return services;
        }
    }
}
