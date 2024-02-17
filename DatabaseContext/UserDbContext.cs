using Microsoft.EntityFrameworkCore;
using Kumustagram_API.Models;

namespace Kumustagram_API.DatabaseContext
{
    public class UserDbContext : DbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options) 
        {

        }
        public DbSet<User> Users { get; set; }
    }
}
