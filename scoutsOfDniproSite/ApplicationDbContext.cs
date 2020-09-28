using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using scoutsOfDniproSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace scoutsOfDniproSite
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<User> users { get; set; }
        public DbSet<requestUser> usersRequests { get; set; }
        public DbSet<Roles> roles { get; set; }
        public DbSet<Post> posts { get; set; }
        public DbSet<userScoutMinimum> userScoutMinimums { get; set; }
        public DbSet<Events> events { get; set; }
        public DbSet<DocsLevel> docsLevels { get; set; }
        public DbSet<DocsLevelPost> docsLevelPosts { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }
    }
}
