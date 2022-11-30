using Microsoft.EntityFrameworkCore;
using ustatickets.Models;
using ustaTickets.Data.Base;

namespace ustatickets.Data.Services
{
    public class ActorService : EntityBaseRepository<Actor>, IActorService
    {
        public ActorService(ApplicationDbContext context) : base(context) { }        
    }
}
