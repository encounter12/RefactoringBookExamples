public class Customer
{
    public string? Name { get; set; }

    public BillingPlan? Plan { get; set; }

    public PaymentHistory History => new PaymentHistory();
}
