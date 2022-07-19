using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonalInterativeCard.Data.Entities;

namespace PersonalInterativeCard.Data.Configurations
{
    public class LogConfiguration : IEntityTypeConfiguration<Log>
    {
        public void Configure(EntityTypeBuilder<Log> builder)
        {
            builder.Property(s => s.Application).HasMaxLength(100);
            builder.Property(s => s.Level).HasMaxLength(100);
            builder.Property(s => s.Message).HasMaxLength(8000);
            builder.Property(s => s.Logger).HasMaxLength(8000);
            builder.Property(s => s.Callsite).HasMaxLength(8000);
            builder.Property(s => s.Exception).HasMaxLength(8000);
        }
    }
}
