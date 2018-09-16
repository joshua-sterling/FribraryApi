using FribraryAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FribraryAPI.EntityFramework
{
    public class FribraryApiContext : DbContext
    {
        public DbSet<Artist> Artists { get; set; }
    }
}
