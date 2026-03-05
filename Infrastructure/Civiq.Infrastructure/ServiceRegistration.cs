using Civiq.Application.Interfaces.Events;
using Civiq.Domain.Events;
using Civiq.Infrastructure.EventHandlers;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Civiq.Infrastructure
{
    public static class ServiceRegistration
    {
        public static void RegisterInfrastructure(this IServiceCollection services)
        {

            #region EventBus

            services.AddSingleton<IEventBus, InMemoryEventBus>();

            services.AddScoped<IEventHandler<ViolationDetectedEvent>, EmailSendEventHandler>(); // subscribe

            #endregion

        }
    }
}
