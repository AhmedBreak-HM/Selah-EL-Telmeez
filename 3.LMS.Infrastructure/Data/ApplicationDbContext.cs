using _0.LMS.Domain.AggregateModels.SubjectModels;
using _0.LMS.Domain.AggregateModels.UserModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.LMS.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<RecentLesson> RecentLessons { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
            builder.Entity<IdentityRole>().HasData(new IdentityRole[] {
                    new IdentityRole{ Id="1", Name="Admin",NormalizedName="ADMIN"},
                    new IdentityRole{ Id="2", Name="Student", NormalizedName="STUDENT"},
                    new IdentityRole{ Id="3", Name="Teacher", NormalizedName="TEACHER"},
                    new IdentityRole{ Id="4", Name="Parent", NormalizedName="PARENT"}});
        }
    }
}
