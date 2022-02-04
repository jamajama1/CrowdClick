using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entities
{
    public class Status
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // Navigation properties
        public List<Project> Products { get; set; }
        public List<StatusHistory> StatusHistories { get; set; }
    }
}
