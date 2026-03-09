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
    public class DetectViolation : BaseEntity
    {
        public Camera Camera { get; set; }
        public Guid CameraId { get; set; }

        public string PlateNumber { get; set; }
        public decimal Confidence { get; set; }
        public string ImageUrl { get; set; }


        public ViolationType ViolationType { get; set; }
        public string SpeedReadings { get; set; } 
        public DateTime DetectedAt { get; set; }

    }
}
