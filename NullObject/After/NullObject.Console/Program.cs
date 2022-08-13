using static System.Console;
using NullObject.Console;

// explore console output when site has no customer,
// then change siteHasCustomer's vaue to: true and evaluate again console output
Site site = SiteFactory.Create(siteHasCustomer: false);

Customer customer = site.Customer;

WriteLine($"Customer's name: {customer.Name}");

WriteLine($"Site customer's initial billing plan: {customer.Plan.Name}");

customer.Plan = BillingPlan.Special();

WriteLine($"Site customer's updated billing plan: {customer.Plan.Name}");

int weeksDelinquent = customer.History.GetWeeksDelinquentInLastYear();

WriteLine($"Weeks delinquent: {weeksDelinquent}");

WriteLine($"Is null customer object: {customer.IsNull}");