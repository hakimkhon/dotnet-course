using Models.Notifications;

public class CardPayment : Payment
{
    public override void Pay(decimal amount)
    {
        Console.WriteLine($"Karta orqali to‘landi: {amount} so‘m");
    }
}