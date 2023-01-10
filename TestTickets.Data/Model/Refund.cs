using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTickets.Data.Model
{
    public class Refund : IEntity
    {
        public DateTime OperationTime { get; set; }
        public string OperationPlace { get; set; }
        public string TicketNumber{ get; set; }
    }
}
