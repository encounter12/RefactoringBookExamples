# Null Object (improvements)

NullCustomer class is unnecessary since Customer class does not have any behavior (methods), so there is no behavior to override. The solution is to delete NullCustomer.cs and add ```CreateDefault()``` static factory method in [Customer.cs](NullObject.Console/Models/Customer.cs), which creates Customer object with default values:

```csharp
public static Customer CreateDefault() => new Customer
{
    Name = "occupant",
    Plan = BillingPlan.Basic(),
    History = PaymentHistory.CreateDefault(),
    IsDefault = true
};
```

In the above static factory method we asign a new instance of [DefaultPaymentHistory.cs](NullObject.Console/Models/DefaultObjects/DefaultPaymentHistory.cs) (former: NullPaymentHistory), which inherits from PaymentHistory, so that we could override the method ```GetWeeksDelinquentInLastYear()``` and provide it's default behavior.

After that we invoke ```Customer.CreateDefault()``` in [Site.cs](NullObject.Console/Models/Site.cs) when site.Customer is null:

```csharp
public class Site
{
    private Customer? customer;

    public Customer Customer
    {
        get => this.customer == null ? Customer.CreateDefault() : this.customer;
        set => this.customer = value;
    }
}
```

So, I also removed the virtual keyword from Customer's name and Billing plan since they will not have to be overriden anymore.