using Civiq.Domain.Events.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Civiq.Domain.Events
{
    public record ViolationDetectedEvent(
        Guid EventId,
        string PlateNumber,
        string ViolationType,
        Guid CameraId,
        DateTime OccurredAt)
        : BaseEvent(EventId);
}
