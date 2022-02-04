using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entities
{
    public class StatusHistory
    {
        public int Id { get; set; }
        public DateTime TimeStamp { get; set; }

        // Navigation properties
        public int ProductId { get; set; }
        public Project Product { get; set; }
        public int? StatusId { get; set; }
        public Status Status { get; set; }
    }
}
