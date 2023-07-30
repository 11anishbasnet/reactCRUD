using Microsoft.EntityFrameworkCore;
using ReactCrud.Models;

namespace React.Models
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Student> Students { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=StDb;Integrated Security=True;Pooling=False;Encrypt=false");
        }
    }
}
