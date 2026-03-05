using Civiq.Application.Interfaces.Events;
using Microsoft.Extensions.DependencyInjection;

namespace Civiq.Infrastructure
{
    public class InMemoryEventBus : IEventBus
    {
        private readonly IServiceProvider _serviceProvider;
        public InMemoryEventBus(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task Publish<TEvent>(TEvent @event)
        {
            Type type = typeof(TEvent);

            var handlers = _serviceProvider.GetServices<IEventHandler<TEvent>>().ToList();

            foreach (var handler in handlers)
            {
                IEventHandler<TEvent> typeHandler = (IEventHandler<TEvent>)handler;
                await typeHandler.Handle(@event);
            }
        }
    }
}
