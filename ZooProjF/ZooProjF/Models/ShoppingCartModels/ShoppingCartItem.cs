using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZooProjF.Models
{
    public class ShoppingCartItem
    {
        public int ShoppingCartItemId { get; set; }
        public Ticket Ticket { get; set; }
        public int Amount { get; set; }
        public int ShoppingCartId { get; set; }
    }
}
