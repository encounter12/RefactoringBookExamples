public class Customer
{
    public bool IsDefault { get; private set; } = false;

    public virtual string Name { get; set; }

    public virtual BillingPlan Plan { get; set; }

    public virtual PaymentHistory History { get; set;} = PaymentHistory.Create();

    public static Customer CreateDefault() => new Customer
    {
        Name = "occupant",
        Plan = BillingPlan.Basic(),
        History = PaymentHistory.CreateDefault(),
        IsDefault = true
    };
}
