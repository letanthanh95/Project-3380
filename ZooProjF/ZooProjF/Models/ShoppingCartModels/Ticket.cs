using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZooProjF.Models
{
    public class Ticket
    {
        public int TicketId { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public decimal Price { get; set; }
        public string ImageURL { get; set; }
        public string ImageThumbnailURL { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
