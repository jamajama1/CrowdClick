using System.Collections.Generic;

namespace ApplicationCore.Entities
{
    public class Product_Variant
    {
        public int Id { get; set; }
        public string? SKU { get; set; }
        public Product Product { get; set; }
        public int ProductId { get; set; }
        public List<Variant_Value> Variant_Values { get; set; }
    }
}