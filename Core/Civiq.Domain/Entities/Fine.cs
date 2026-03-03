using Civiq.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Civiq.Domain.Entities
{
    public class Fine : BaseEntity
    {
        public int Amount { get; set; }

        public int ViolationId { get; set; }
        public Violation Violation { get; set; }
    }
}
