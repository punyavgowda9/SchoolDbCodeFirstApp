using Microsoft.EntityFrameworkCore;

namespace SchoolDbCodeFirstApp.Models
{
    public class SchoolDbContext : DbContext
    {
        public SchoolDbContext(DbContextOptions<SchoolDbContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .HasOne(s => s.grade)
                .WithMany(g => g.Students)
                .HasForeignKey(s => s.GradeId);
        }
    }
}