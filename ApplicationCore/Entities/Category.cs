using System.Collections.Generic;

namespace ApplicationCore.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        //Navigation property
        List<Product> Products { get; set; }
    }
}