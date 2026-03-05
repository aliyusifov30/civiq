using Civiq.Application.Interfaces.Events;
using Civiq.Domain.Events;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Civiq.Infrastructure.EventHandlers
{
    public class EmailSendEventHandler : IEventHandler<ViolationDetectedEvent>
    {
        public async Task Handle(ViolationDetectedEvent @event)
        {
            Console.WriteLine(JsonConvert.SerializeObject(@event));
        }
    }
}
