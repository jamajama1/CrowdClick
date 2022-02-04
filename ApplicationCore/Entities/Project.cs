using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entities
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }        
        public string Description { get; set; }
        public string Location { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public decimal Goal { get; set; }
        public decimal Pledges { get; set; }
        //public int Investors { get; set; }

        //Navigation properties
        public List<Parameter> Parameters { get; set; }
        public List<Material> Materials { get; set; }
        public List<StatusHistory> StatusHistories { get; set; }
        public List<Comment> Comments { get; set; }
        public List<Update> Updates { get; set; }
        public List<Investor> Investors { get; set; }
        public List<ProductInvestment> ProductInvestments { get; set; }
        public List<ProductTeam> ProductTeams { get; set; }
        public int StatusId { get; set; }
        public Status Status { get; set; }
        public int UserProductId { get; set; }
        public UserProduct UserProduct { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
