using Civiq.Domain.Entities.Common;
using Civiq.Domain.EntityStates;
using Civiq.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Civiq.Domain.Entities
{
    public class Violation : BaseEntity
    {
        public ViolationType ViolationType { get; set; }
        public ViolationState ViolationState { get; set; }

        public DateTime Timestamp { get; set; }
        public double ConfidenceScore { get; set; }
        public string EvidenceUrl { get; set; }


        public Vehicle Vehicle { get; set; }
        public Guid VehicleId { get; set; }
        
        public Camera Camera { get; set; }
        public Guid CameraId { get; set; }
    }
}
