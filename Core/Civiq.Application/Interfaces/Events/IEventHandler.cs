using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Civiq.Application.Interfaces.Events
{
    public interface IEventHandler<TEvent>
    {
        Task Handle(TEvent @event);
    }
}
