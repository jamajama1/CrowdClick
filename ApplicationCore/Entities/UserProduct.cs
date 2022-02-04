using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entities
{
    public class UserProduct
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int ProductsSupported { get; set; }
        public int TotalAmount { get; set; }
        public int CountryId { get; set; }

        // Navigation properties
        public List<Comment> Comments { get; set; }
        public List<Update> Updates { get; set; }
        public List<Project> Products { get; set; }
    }
}
