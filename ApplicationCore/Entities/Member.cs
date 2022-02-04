using System.Collections.Generic;

namespace ApplicationCore.Entities
{
    public class Member
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        //public int ParticipatedIn { get; set; }

        // Navigation properties
        public List<ProductTeam> ProductTeams { get; set; }
        public int? UserId { get; set; }
        public User User { get; set; }
        public int? VendorId { get; set; }
        public Vendor Vendor { get; set; }
    }
}