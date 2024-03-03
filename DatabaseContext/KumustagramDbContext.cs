using Microsoft.EntityFrameworkCore;
using Kumustagram_API.Models;
using Microsoft.Extensions.Hosting;

namespace Kumustagram_API.DatabaseContext
{
    public class KumustagramDbContext : DbContext
    {
        public KumustagramDbContext(DbContextOptions<KumustagramDbContext> options) : base(options) 
        {

        }



        public DbSet<User> Users { get; set; }
        public DbSet<Content> Contents { get; set; }
        public DbSet<ContentLike> ContentLikes { get; set; }
        public DbSet<ContentComment> ContentComments { get; set; }
        public DbSet<Follower> Followers { get; set; }
        public DbSet<Following> Followings { get; set; }

    }
}
