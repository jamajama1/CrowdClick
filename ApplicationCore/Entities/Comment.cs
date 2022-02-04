using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entities
{
    public class Comment
    {
        public int Id { get; set; }
        public string CommentText { get; set; }
        public DateTime TimeStamp { get; set; }

        // Navigation properties
        public int ProductId { get; set; }
        public Project Product { get; set; }
        public int? UserProductId { get; set; }
        public UserProduct UserProduct { get; set; }
    }
}
