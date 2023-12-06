using ASTL.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ASTL.Data.Configurations
{
    public class UserContextConfiguration : IEntityTypeConfiguration<UserContext>
    {
        public void Configure(EntityTypeBuilder<UserContext> builder)
        {

            builder.ToTable("UserContext", "astl");
            builder.HasKey("userContextID");
            builder.Property(f => f.UserContextId).HasColumnName("userContext");
            builder.Property(f => f.UserContextName).HasColumnName("userContextName");
        }
    }
}
