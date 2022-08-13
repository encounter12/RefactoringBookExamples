public class BillingPlan
{
    public string? Name { get; set; }

    public BillingPlan(string? name) => this.Name = name;
    
    public static BillingPlan Basic => new BillingPlan("Basic billing plan");

    public static BillingPlan Special => new BillingPlan("Special billing plan");
}
