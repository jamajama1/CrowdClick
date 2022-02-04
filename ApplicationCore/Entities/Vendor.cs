using System.Collections.Generic;

namespace ApplicationCore.Entities
{
    public class Vendor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }

        // Navigation properties
        public List<Product> Products { get; set; }
        public List<Member> Members { get; set; }
    }
}