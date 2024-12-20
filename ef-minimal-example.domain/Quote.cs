namespace ef_minimal_example.domain;

public class Quote
{
    public int QuoteId { get; set; }
    public int QuoteStatusID { get; set; }
    public string RfqNumber { get; set; }
    public DateTime QuoteDate { get; set; }
    public DateOnly DueDate { get; set; }
    public DateTime ExpirationDate { get; set; }
    public decimal Total
    {
        get; set;
    }
    public decimal TargetTotal
    {
        get; set;
    }
    public int CustomerId { get; set; }
    public string CustomerName { get; internal set; }
    // public int PaymentTermsTypeId { get; set; }
    // public string PaymentTerms { get; set; }
    // public int? CustomerContactId { get; set; }
    // public string CustomerContactFullName { get; set; }
    // public int? ShippingAddressId { get; set; }
    // public string ShippingAddressStreet1 { get; set; }
    // public string ShippingAddressStreet2 { get; set; }
    // public string ShippingAddressCity { get; set; }
    // public string ShippingAddressState { get; set; }
    // public string ShippingAddressZip { get; set; }
    // public int? BillingAddressId { get; set; }
    // public string BillingAddressStreet1 { get; set; }
    // public string BillingAddressStreet2 { get; set; }
    // public string BillingAddressCity { get; set; }
    // public string BillingAddressState { get; set; }
    // public string BillingAddressZip { get; set; }
    // public int? SalesContactUserId { get; set; }
    // public string SalesContactFullName { get; set; }
    // public string SalesContactRole { get; set; }
    // public string Notes { get; set; }
    // public int? EstimatedByUserId { get; set; }
    // public string EstimatedByUserFullName { get; set; }
    // public DateTime? EstimatedAt { get; set; }
    public List<QuotePartBreakdown> QuotePartBreakdowns { get; set; }
}
