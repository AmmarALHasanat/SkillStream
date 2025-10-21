using Microsoft.EntityFrameworkCore;
using SkillStream.Models;

namespace SkillStream.Entities
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Test> Tests { get; set; }

    }
}
