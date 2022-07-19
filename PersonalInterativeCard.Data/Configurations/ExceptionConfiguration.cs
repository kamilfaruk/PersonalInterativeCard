using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace PersonalInterativeCard.Data.Configurations
{
    public class ExceptionConfiguration : IEntityTypeConfiguration<Entities.Exception>
    {
        public void Configure(EntityTypeBuilder<Entities.Exception> builder)
        {
            builder.Property(s => s.Message).HasMaxLength(500);
            builder.Property(s => s.Source).HasMaxLength(500);
            //TODO: Konfigurasyonlara daha sonra devam et...
        }
    }
}
