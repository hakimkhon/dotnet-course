using Models.Notifications;

public class BankTransferPayment : Payment
{
    public override void Pay(decimal amount)
    {
        Console.WriteLine($"Bank o‘tkazmasi orqali to‘landi: {amount} so‘m");
    }
}