using LogosAuth.Entities;
using Microsoft.EntityFrameworkCore;

namespace LogosAuth.Data
{
    public class UserDbContext(DbContextOptions<UserDbContext> options) : DbContext(options)
    {
        public DbSet<User> Users { get; set; }
    }
}
