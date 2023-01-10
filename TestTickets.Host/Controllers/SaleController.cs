using TestTickets.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace WebApplication3.Controllers
{
    [ApiController]
    [Route("api/v1/sale")]
    public class SaleController : ControllerBase
    {
        private AppDbContext db;

        public SaleController(AppDbContext context)
        {
            db = context;
        }

        [HttpGet]
        public HttpResponseMessage Get()
        {
            var tickets = db.Tickets.ToList();
            var refunds = db.Refunds.ToList();
            var passengers = db.Passengers.ToList();
            return new HttpResponseMessage(HttpStatusCode.OK);
        }
    }
}
