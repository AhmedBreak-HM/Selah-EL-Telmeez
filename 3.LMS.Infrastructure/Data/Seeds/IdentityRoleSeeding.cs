using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace _3.LMS.Infrastructure.Data.Seeds
{
    public class IdentityRoleSeeding : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(new IdentityRole[] {
                    new IdentityRole{ Id="1", Name="Admin",NormalizedName="ADMIN"},
                    new IdentityRole{ Id="2", Name="Student", NormalizedName="STUDENT"},
                    new IdentityRole{ Id="3", Name="Teacher", NormalizedName="TEACHER"},
                    new IdentityRole{ Id="4", Name="Parent", NormalizedName="PARENT"}});
        }
    }
}