using Microsoft.EntityFrameworkCore;
using WebApi2.Models;

namespace WebApi2.Data
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options) { }

        public DbSet<Student> Student { get; set; }
    }
}
