using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entities
{
    public class InvestmentOption
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal FundsMin { get; set; }
        public decimal FundsMax { get; set; }
        public List<ProductInvestment> ProductInvestments { get; set; }
    }
}
