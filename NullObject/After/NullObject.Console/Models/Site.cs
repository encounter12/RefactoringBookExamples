namespace NullObject.Console;

public class Site
{
    private Customer? customer;

    public Customer Customer
    {
        get => this.customer == null ? Customer.CreateNull() : this.customer;
        set => this.customer = value;
    }
}
