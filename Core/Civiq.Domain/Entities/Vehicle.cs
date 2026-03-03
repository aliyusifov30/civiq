using Civiq.Domain.Entities.Common;
using Civiq.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Civiq.Domain.Entities
{
    public class Vehicle : BaseEntity
    {

        public String PlateNumber { get; set; }
        public String Color { get; set; }
        public String CountryCode { get; set; }

        public VehicleType VehicleType { get; set; }
    }
}
