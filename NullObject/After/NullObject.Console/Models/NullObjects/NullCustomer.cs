public class NullCustomer : Customer
{
    public override bool IsNull => true;

    public override string Name => "occupant";

    public override BillingPlan Plan { get; set; } = BillingPlan.Basic();

    public override PaymentHistory History => PaymentHistory.CreateNull();
}