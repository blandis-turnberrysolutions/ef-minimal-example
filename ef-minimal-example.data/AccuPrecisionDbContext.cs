using ef_minimal_example.domain;
using Microsoft.EntityFrameworkCore;

namespace ef_minimal_example.data;

public class AccuPrecisionDbContext : DbContext
{
    public AccuPrecisionDbContext() : base()
    {

    }

    public AccuPrecisionDbContext(DbContextOptions<AccuPrecisionDbContext> options) : base(options)
    {
        ChangeTracker.LazyLoadingEnabled = false;
        // ChangeTracker.AutoDetectChangesEnabled = false;
        // ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        _ = modelBuilder.ApplyConfigurationsFromAssembly(typeof(QuoteEntityTypeConfiguraiton).Assembly);

        base.OnModelCreating(modelBuilder);
    }

    protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
    {
        _ = configurationBuilder
        .Properties<DateOnly>()
        .HaveConversion<DateOnlyValueConverter>();
    }

    public virtual DbSet<Quote> Quotes { get; set; }
}