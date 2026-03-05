using Civiq.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Civiq.Domain.Entities
{
    public class Notification : BaseEntity
    {


        public Guid CitizenId { get; set; }
        public Citizen Citizen { get; set; }

        public Guid FineId { get; set; }
        public Fine Fine { get; set; }

        public string Channel { get; set; }


    }
}
