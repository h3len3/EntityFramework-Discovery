using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketApp.Business
{
    public class Customer
    {
        public Customer()
        {
            Tickets = new List<Ticket>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime CreatedOn { get; set; }
        public List<Ticket> Tickets
        {
            get; set;
        }
    }
}
