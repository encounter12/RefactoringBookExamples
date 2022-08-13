public class Customer : INullObject
{
    public virtual bool IsNull => false;

    public virtual string Name { get; set; }

    public virtual BillingPlan Plan { get; set; }

    public virtual PaymentHistory History => PaymentHistory.Create();

    public static Customer CreateNull() => new NullCustomer();
}
