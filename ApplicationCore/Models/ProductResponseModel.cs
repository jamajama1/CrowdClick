using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Models
{
    public class ProductResponseModel
    {
        //public int Id { get; set; }
        public string Name { get; set; }
        public String PicUrl { get; set; }
        public decimal Price { get; set; }
        public int MOQ { get; set; }
        public string MOQType { get; set; }
    }
}
