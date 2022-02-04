using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entities
{
    public class MaterialType
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Material> Materials { get; set; }
    }
}
