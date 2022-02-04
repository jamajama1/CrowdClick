using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entities
{
    public class Investor
    {
        public int Id { get; set; }
        public decimal Pledged { get; set; }
        public DateTime TimeStamp { get; set; }

        public int ProductId { get; set; }
        public Project Product { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int? ProductInvestmentId { get; set; }
        public ProductInvestment ProductInvestment { get; set; }
    }
}
