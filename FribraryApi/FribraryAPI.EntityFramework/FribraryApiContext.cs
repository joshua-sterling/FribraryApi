using FribraryAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FribraryAPI.EntityFramework
{
    public class FribraryApiContext : DbContext
    {
        public FribraryApiContext(DbContextOptions<FribraryApiContext> options) : base(options)
        {

        }

        public FribraryApiContext() { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Song>()
                .HasOne(s => s.Artist)
                .WithMany(a => a.Songs)
                .IsRequired();
        }

        

        public DbSet<Song> Songs { get; set; }
        public DbSet<Artist> Artists { get; set; }
    }
}
