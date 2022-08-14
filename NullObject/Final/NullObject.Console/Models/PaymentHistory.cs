public class PaymentHistory
{
    public virtual int GetWeeksDelinquentInLastYear() => 3;

    public static PaymentHistory Create() => new PaymentHistory();

    public static PaymentHistory CreateDefault() => new DefaultPaymentHistory();
}
