using ef_minimal_example.data;
using ef_minimal_example.domain;
using Microsoft.EntityFrameworkCore;

namespace ef_minimal_example.console;

public class DefaultCommand(AccuPrecisionDbContext dbContext) : ICommand
{
    private readonly AccuPrecisionDbContext dbContext = dbContext;


    public async Task Execute()
    {
        var quote = await dbContext.Quotes.Include(q => q.QuotePartBreakdowns).FirstOrDefaultAsync(q => q.QuoteId == 54933);

        foreach (var breakdown in quote.QuotePartBreakdowns.Where(qpb => qpb.ParentQuotePartBreakdownId == null))
        {
            Console.WriteLine(breakdown.QuotePartBreakdownId + " -> " + breakdown.PartId);
            RecurseSubParts(breakdown.SubQuotePartBreakdowns, 1);
        }
    }

    private void RecurseSubParts(IEnumerable<QuotePartBreakdown> subQuotePartBreakdowns, int level)
    {
        foreach (var subBreakdown in subQuotePartBreakdowns)
        {
            var description = subBreakdown.QuotePartBreakdownId + " -> " + subBreakdown.PartId;
            Console.WriteLine(description.PadLeft(4 * level + description.Length));
            RecurseSubParts(subBreakdown.SubQuotePartBreakdowns, level + 1);
        }
    }
}