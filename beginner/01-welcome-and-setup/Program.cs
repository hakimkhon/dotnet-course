using System;

internal class Program
{
    private static void Main(string[] args)
    {
        string name = "Hakimxon", job = "Tarmoq administratori";
        int age = 32, staj = 8;

        Console.WriteLine($"Mening ismim: {name} \nYoshim: {age} da");
        Console.WriteLine($"Kasbim: {job}, \nTajribam: {staj} yil");

        string yourName, yourAge;

        Console.Write("Ismingizni kiriting: ");
        yourName = Console.ReadLine();

        Console.Write("Yoshingizni kiriting: ");
        yourAge = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine($"Assalomu alaykum {yourName}");
        Console.WriteLine($"siz {yourAge} yoshdasiz");
        Console.WriteLine($"Siz bilan tanishganimdan hursandman!");
    }
}