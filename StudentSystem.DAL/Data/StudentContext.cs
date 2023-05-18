using Microsoft.EntityFrameworkCore;
using StudentSystem.DAL.Configuration;
using StudentSystem.DAL.Data.Models;

namespace StudentSystem.DAL.Data
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options) : base(options) { }

        public DbSet<Course> Courses => Set<Course>();
        public DbSet<HomeworkSubmission> HomeworkSubmissions => Set<HomeworkSubmission>();
        public DbSet<Resource> Resources => Set<Resource>();
        public DbSet<Student> Students => Set<Student>();
        public DbSet<StudentCourse> StudentCources => Set<StudentCourse>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new CourseConfiguration());
            modelBuilder.ApplyConfiguration(new HomeworkSubmissionConfiguration());
            modelBuilder.ApplyConfiguration(new ResourceConfiguration());
            modelBuilder.ApplyConfiguration(new StudentConfiguration());
            modelBuilder.ApplyConfiguration(new StudentCourseConfiguration());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Initial Catalog=StudentSystem2;Trusted_Connection=True;TrustServerCertificate=True;");
            }
        }
    }
}
