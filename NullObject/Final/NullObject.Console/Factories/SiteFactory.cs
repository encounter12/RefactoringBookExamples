using NullObject.Console;

public static class SiteFactory
{
    public static Site Create(bool siteHasCustomer)
    {
        var site = new Site(); 

        if (siteHasCustomer)
        {
            site.Customer = new Customer
            {
                Name = "Michael",
                Plan = BillingPlan.Special()
            };
        }

        return site;
    }
}
