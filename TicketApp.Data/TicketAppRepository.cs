using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketApp.Data
{
    public class TicketAppRepository
    {
        public TicketAppRepository()
        {
            InitializeDatabase();
        }

        private void InitializeDatabase()
        {
            using var context = new TicketDataContext();
            context.Database.EnsureCreated();
        }
       
    }
}
