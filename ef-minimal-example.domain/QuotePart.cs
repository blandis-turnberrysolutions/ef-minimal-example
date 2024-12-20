namespace ef_minimal_example.domain;

public class QuotePart
{
    public int QuotePartId { get; set; }
    public int QuoteId { get; set; }
    public Quote Quote { get; set; }
    public int? LeadTime { get; set; }
    public string Notes { get; set; } = "";
    public int ItemId { get; set; }
    public bool NoQuote { get; set; }
    public List<QuotePartBreakdown> QuotePartBreakdowns { get; set; } = [];
}
