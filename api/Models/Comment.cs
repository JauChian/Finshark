using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.Models
{
    [Table("Comments")]
    public class Comment
    {
        // ?? ID
        public int Id { get; set; }
        // ????
        public string Title { get; set; } = string.Empty;
        // ????
        public string Content { get; set; } = string.Empty;
        // ????
        public DateTime CreatedOn { get; set; } = DateTime.Now;
        // ???? ID(???)
        public int? StockId { get; set; }
        // ????:????
        public Stock? Stock { get; set; }
    }
}
