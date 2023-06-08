using eComerce.Models;
using Microsoft.EntityFrameworkCore;

namespace eComerce.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor_Movie>().HasKey(am => new
            {
                am.ActorId,
                am.MovieId
            });

            modelBuilder.Entity<Actor_Movie>().HasOne(m => m.Movie).WithMany(am=>am.Actors_Movies).HasForeignKey(m=>m.MovieId);
            modelBuilder.Entity<Actor_Movie>().HasOne(m => m.Actor).WithMany(am=>am.Actors_Movies).HasForeignKey(m=>m.ActorId);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Actor> Actor { get; set; }
        public DbSet<Movie> Movie { get; set; }
        public DbSet<Actor_Movie> Actor_Movie { get; set; }
        public DbSet<Cinema> Cinema { get; set; }
        public DbSet<Producer> Producer { get; set; }
    }
}
