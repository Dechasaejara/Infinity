using Infinity.Server.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infinity.Server.Data
{
    public class InfinityDbContext : DbContext
    {
        public InfinityDbContext(DbContextOptions<InfinityDbContext> options) : base(options) { }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<DetailNote> Notes { get; set; }
        public DbSet<CheatSheet> CheatSheets { get; set; }
        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<Solution> Solutions { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
