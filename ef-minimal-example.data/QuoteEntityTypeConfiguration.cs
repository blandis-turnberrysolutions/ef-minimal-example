using ef_minimal_example.domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ef_minimal_example.data;

public class QuoteEntityTypeConfiguraiton : IEntityTypeConfiguration<Quote>
{
    public void Configure(EntityTypeBuilder<Quote> builder)
    {
        _ = builder
            .ToTable("quote")
            .HasMany(bd => bd.QuotePartBreakdowns)
            .WithOne(bd => bd.Quote)
            .HasForeignKey(bd => bd.QuotePartBreakdownId);
    }
}
