using Civiq.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Civiq.Domain.Entities
{
    public class Evidence : BaseEntity
    {
        public int ViolationId { get; set; }
        public Violation Violation { get; set; }

        public string ImageUrl { get; set; }
        public string VideoUrl { get; set; }
        public DateTime SnapshotTime { get; set; }
    }
}
