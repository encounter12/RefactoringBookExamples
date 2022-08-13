using static System.Console;
using NullObject.Console;

// explore console output when site has no customer,
// then change siteHasCustomer's vaue to: true and evaluate again console output
Site site = SiteFactory.Create(siteHasCustomer: false);

Customer? customer = site.Customer;

BillingPlan? plan;

if (customer == null)
{
    plan = BillingPlan.Basic;
}
else
{
    plan = customer.Plan;
}

string? customerName;

if (customer == null)
{
    customerName = "occupant";
}
else
{
    customerName = customer.Name;
}

int? weeksDelinquent;

if (customer == null)
{
    weeksDelinquent = 0;
}
else
{
    weeksDelinquent = customer.History.GetWeeksDelinquentInLastYear();
}

WriteLine($"Billing plan: {plan?.Name}");

WriteLine($"Customer's name: {customerName}");

WriteLine($"Weeks delinquent: {weeksDelinquent}");