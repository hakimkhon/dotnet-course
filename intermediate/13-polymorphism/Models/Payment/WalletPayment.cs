using Models.Notifications;

public class WalletPayment : Payment
{
    public override void Pay(decimal amount)
    {
        Console.WriteLine($"Elektron hamyon orqali to‘landi: {amount} so‘m");
    }
}
