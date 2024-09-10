using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketApp.Data;

namespace TicketApp.Business
{
    public class TicketAppService
    {
        private readonly TicketAppRepository _ticketRepos;

        public TicketAppService()
        {
            _ticketRepos = new TicketAppRepository();
        }

    }
}
