using _0.LMS.Domain.AggregateModels.SubscriptionModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace _3.LMS.Infrastructure.Data.Configurations
{
    public class UserApplicationConfiguration : IEntityTypeConfiguration<UserApplication>
    {
        public void Configure(EntityTypeBuilder<UserApplication> builder)
        {
            // Method intentionally left empty.
        }
    }
}