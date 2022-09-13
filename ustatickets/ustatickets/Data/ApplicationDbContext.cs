using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ustatickets.Models;

namespace ustatickets.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //Definir Compuesta
            builder.Entity<Actor_Movie>().HasKey(am => new
            {
                am.ActorId,
                am.MovieId

            });

            //traer foranea de movie
            builder.Entity<Actor_Movie>()
                .HasOne(m => m.Movie)
                .WithMany(am => am.Actor_Movies)
                .HasForeignKey(m => m.MovieId);
           
            //traer  foranea  de actor 
            builder.Entity<Actor_Movie>()
                .HasOne(a => a.Actor)
                .WithMany(am => am.Actor_Movies)
                .HasForeignKey(a => a.ActorId);

            base.OnModelCreating(builder);
        }

        public DbSet <Actor> Actor { get; set; }
        public DbSet<Cinema> Cinema { get; set; }
        public DbSet<Director> Director { get; set; }
        public DbSet<Movie> Movie { get; set; }
        public DbSet<Actor_Movie> Actor_Movie { get; set; }
    }
}