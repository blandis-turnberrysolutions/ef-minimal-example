namespace ef_minimal_example.domain;

public partial class QuotePartBreakdown
{
    public int QuotePartBreakdownId { get; set; }
    public int? ParentQuotePartBreakdownId { get; set; }
    public int QuoteId { get; set; }
    public int PartId { get; set; }
    public bool IsSelected { get; set; }
    public int Qty { get; set; }
    public decimal UnitPrice
    {
        get; set;
    }
    public decimal ExtendedPrice
    {
        get; set;
    }
    public decimal? TargetUnitPrice
    {
        get; set;
    }
    public decimal? TargetExtendedPrice
    {
        get; set;
    }
    public bool HasUpdates { get; set; }
    public Quote Quote { get; set; }
    public virtual QuotePartBreakdown ParentQuotePartBreakdown { get; set; }
    public List<QuotePartBreakdown> SubQuotePartBreakdowns { get; set; } = [];

    public int? QuotePartId { get; set; }
    public QuotePart QuotePart { get; set; }
}
