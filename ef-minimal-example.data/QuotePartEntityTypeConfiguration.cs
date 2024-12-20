using ef_minimal_example.domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ef_minimal_example.data;

public class QuotePartEntityTypeConfiguraiton : IEntityTypeConfiguration<QuotePart>
{
    public void Configure(EntityTypeBuilder<QuotePart> builder)
    {
        _ = builder
            .ToTable("quote_part")
            .HasKey(bd => bd.QuotePartId);
        _ = builder.HasMany(bd => bd.QuotePartBreakdowns)
          .WithOne(bd => bd.QuotePart)
          .HasForeignKey(bd => bd.QuotePartId);
    }
}