using Microsoft.EntityFrameworkCore;

namespace CodeFirstDemo.Context
{
    public class UserDbContext : DbContext
    {
        public UserDbContext(DbContextOptions options) : base(options)
        {
        }

        DbSet<User> Users { get; set; }
    }
}
