using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTickets.Data.Model
{
    public class Ticket : IEntity
    {
        public string OperationType { get; set; }
        public DateTime OperationTime { get; set; }
        public string OperationPlace { get; set; }
        [Key, Column(Order = 1)]
        public Passenger Passenger { get; set; }
        public IList<Route> Routes { get; set; }

        public string TicketNumber { get; set; }
        public int TicketType { get; set; }
    }
}
