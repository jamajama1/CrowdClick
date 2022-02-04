using System.Collections.Generic;

namespace ApplicationCore.Entities
{
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // Navigation properties
        public List<ProductTeam> MyProperty { get; set; }
    }
}