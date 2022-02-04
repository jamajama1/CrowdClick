using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entities
{
    public class Material
    {
        public int Id { get; set; }
        public string? Description { get; set; }
        public string Link { get; set; }

        //Navigation properties
        public int ProductId { get; set; }
        public Project Product { get; set; }
        public int MaterialTypeId { get; set; }
        public MaterialType MaterialType { get; set; }
    }
}
