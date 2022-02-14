using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }        
        public string? Description { get; set; }
        public int MinimumOrderQuantity { get; set; }
        //public string? MinimumOrderQuantityType { get; set; }
        public int MyProperty { get; set; }
        public string? SuggestedPrice { get; set; }
        public Decimal Price { get; set; }
        public string ProductUrl { get; set; }
        public string PicUrl { get; set; }
        public int? UnitsInStock { get; set; }
        public int? UnitsOnOrder { get; set; }
        public Boolean Discontinued { get; set; }

        //Navigation properties
        public int? CategoryId { get; set; }
        public Category Category { get; set; }
        public int VendorId { get; set; }
        public Vendor Vendor { get; set; }
        public List<Product_Variant> Product_Variants { get; set; }
        public List<Product_Option> Product_Options { get; set; }
    }
}
