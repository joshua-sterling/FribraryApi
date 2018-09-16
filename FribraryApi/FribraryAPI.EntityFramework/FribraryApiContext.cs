using FribraryAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FribraryAPI.EntityFramework
{
    public class FribraryApiContext : DbContext
    {
        public FribraryApiContext(DbContextOptions<FribraryApiContext> options) : base(options)
        {

        }

        public DbSet<Artist> Artists { get; set; }
    }
}
