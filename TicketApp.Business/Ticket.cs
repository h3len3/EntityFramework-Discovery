using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketApp.Business
{
    public class Ticket
    {
        public int TicketId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
