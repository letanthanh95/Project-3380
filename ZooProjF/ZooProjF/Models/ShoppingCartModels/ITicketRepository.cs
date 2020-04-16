using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZooProjF.Models.ShoppingCartModels
{
    interface ITicketRepository
    {
        IEnumerable<Ticket> Tickets { get; set; }
        Ticket GetTicketById(int ticketId);
    }
}
