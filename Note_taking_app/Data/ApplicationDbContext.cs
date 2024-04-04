using Microsoft.EntityFrameworkCore;
using note_taking_app.Models;

namespace note_taking_app.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Note> Note { get; set; }
        public DbSet<Models.Task> Task { get; set; }

        public DbSet<Models.File> File { get; set; }
    }
}
