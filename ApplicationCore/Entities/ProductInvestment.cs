using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entities
{
    public class ProductInvestment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        // Navigation properties
        public List<Investor> Investors { get; set; }
        public int ProductId { get; set; }
        public Project Product { get; set; }
        public int InvestmentOptionId { get; set; }
        public InvestmentOption InvestmentOption { get; set; }
    }
}
