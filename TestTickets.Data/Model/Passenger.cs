using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTickets.Data.Model
{
    public enum Gender 
    {
        M, F
    }
    public class Passenger : IEntity
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Patronymic { get; set; }
        public string DocType { get; set; }
        public string DocNumber { get; set; }
        public DateOnly BirthDate { get; set; }
        public string Gender { get; set; }
        public string PassengerType { get; set; }
        public IList<Ticket> Tickets { get; set; }
    }
}
