using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entities
{
    public class Parameter
    {
        public int Id { get; set; }
        public DateTime EndDate { get; set; }
        public decimal Goal { get; set; }
        public DateTime TimeStamp { get; set; }

        //Navigation property
        public int ProductId { get; set; }
        public Project Product { get; set; }
    }
}
