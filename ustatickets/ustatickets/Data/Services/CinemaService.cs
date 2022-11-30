using Microsoft.EntityFrameworkCore;
using ustatickets.Models;
using ustaTickets.Data.Base;

namespace ustatickets.Data.Services
{
    public class CinemaService : EntityBaseRepository<Cinema>, ICinemaService
    {
        public CinemaService(ApplicationDbContext context) : base(context) { }        
    }
}
