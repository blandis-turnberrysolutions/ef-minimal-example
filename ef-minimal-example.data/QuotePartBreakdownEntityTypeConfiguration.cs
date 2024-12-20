using ef_minimal_example.domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ef_minimal_example.data;

public class QuotePartBreakdownEntityTypeConfiguraiton : IEntityTypeConfiguration<QuotePartBreakdown>
{
    public void Configure(EntityTypeBuilder<QuotePartBreakdown> builder)
    {
        _ = builder
            .ToTable("quote_part_breakdown")
            .HasKey(bd => bd.QuotePartBreakdownId);
        _ = builder.HasMany(bd => bd.SubQuotePartBreakdowns)
            .WithOne(bd => bd.ParentQuotePartBreakdown)
            .HasForeignKey(bd => bd.ParentQuotePartBreakdownId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.Cascade);
        _ = builder.HasOne(bd => bd.Quote)
            .WithMany(bd => bd.QuotePartBreakdowns)
            .HasForeignKey(bd => bd.QuoteId);
        _ = builder.HasOne(bd => bd.QuotePart)
          .WithMany(bd => bd.QuotePartBreakdowns)
          .HasForeignKey(bd => bd.QuotePartId);
    }
}
