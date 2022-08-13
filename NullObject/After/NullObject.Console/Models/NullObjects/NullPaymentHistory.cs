public class NullPaymentHistory : PaymentHistory
{
    public override int GetWeeksDelinquentInLastYear() => 0;
}