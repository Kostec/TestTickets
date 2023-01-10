using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTickets.Data.Model
{
    public class Route : IEntity
    {
        public string AirlineCode { get; set; }
        public int FlightNum { get; set; }
        public string DepartPlace { get; set; }
        public DateTime DepartDateTime { get; set; }
        public string ArrivePlace { get; set; }
        public DateTime ArriveDateTime { get; set; }
        public string PnrId { get; set; }
        public IList<Ticket> Tickets { get; set; }
    }
}
