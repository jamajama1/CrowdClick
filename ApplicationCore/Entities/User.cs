using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int ProductsSupported { get; set; }
        public decimal TotalAmount { get; set; }

        // Navigation properties
        public List<Investor> Investors { get; set; }
        public List<Member> Members { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
    }
}
