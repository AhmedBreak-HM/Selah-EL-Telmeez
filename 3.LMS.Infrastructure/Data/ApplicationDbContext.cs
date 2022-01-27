using _0.LMS.Domain.AggregateModels.SubjectModels;
using _0.LMS.Domain.AggregateModels.UserModels;
using _1.LMS.Application.Issues;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace _3.LMS.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Subject> Subjects { get; set; }

        // Issue (⩺_⩹) : 0001
        public DbSet<SubjectModelOwnsOneMappingIssue> SubjectsWrapper { get; set; }
        // ------(⩺_⩹)-------

        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<RecentLesson> RecentLessons { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);

        }
    }
}