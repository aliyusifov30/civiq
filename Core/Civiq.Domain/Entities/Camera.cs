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
    public class Camera : BaseEntity
    {
        public string Location { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public CameraType CameraType { get; set; }
        public CameraState CameraState { get; set; }
    }
}
