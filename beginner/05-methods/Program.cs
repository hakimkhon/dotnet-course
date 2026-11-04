class Program
{
    static void Main()
    {
        // 1. Savol: Salomlashuv xabarini chiqaring
        System.Console.WriteLine("  Task_01:");
        ShowWelcome();

        // 2. Savol: Ism bilan salomlashing
        System.Console.WriteLine("  Task_02:");
        ShowGreeting("Ali");
        ShowGreeting("Madina");

        // 3. Savol: Standart qiymatni qaytaring
        System.Console.WriteLine("  Task_03:");
        System.Console.WriteLine(GetPassingScore()); ;

        // 4. Savol: Ikki sonni qo‘shing
        System.Console.WriteLine("  Task_04:");
        System.Console.WriteLine(Add(4, 7));
        System.Console.WriteLine(Add(0, 5));
        System.Console.WriteLine(Add(-3, 3));

        // 5. Savol: Buyurtma haqida xabar tuzing
        System.Console.WriteLine("  Task_05:");
        System.Console.WriteLine(CreateOrderMessage("Book", 2));
        System.Console.WriteLine(CreateOrderMessage("Pen", 5));

        // 6. Savol: Yosh va kun bo‘yicha chipta narxini aniqlang
        System.Console.WriteLine("  Task_06:");
        System.Console.WriteLine(GetTicketPrice(-1, false) == 1 ? "Free" : GetTicketPrice(-1, false) == -1 ? "Invalid age" : GetTicketPrice(-1, false));
        System.Console.WriteLine(GetTicketPrice(121, true) == 1 ? "Free" : GetTicketPrice(121, true) == -1 ? "Invalid age" : GetTicketPrice(121, true));
        System.Console.WriteLine(GetTicketPrice(6, true) == 1 ? "Free" : GetTicketPrice(6, true) == -1 ? "Invalid age" : GetTicketPrice(6, true));
        System.Console.WriteLine(GetTicketPrice(7, false) == 1 ? "Free" : GetTicketPrice(7, false) == -1 ? "Invalid age" : GetTicketPrice(7, false));
        System.Console.WriteLine(GetTicketPrice(60, true) == 1 ? "Free" : GetTicketPrice(60, true) == -1 ? "Invalid age" : GetTicketPrice(60, true));
        System.Console.WriteLine(GetTicketPrice(61, true) == 1 ? "Free" : GetTicketPrice(61, true) == -1 ? "Invalid age" : GetTicketPrice(61, true));

        // 7. Savol: Bo‘linma va qoldiqni toping
        System.Console.WriteLine("  Task_07:");
        int bolinma;
        int qoldiq;
        System.Console.WriteLine(TryDivide(17, 5, out bolinma, out qoldiq) ? $"Quotient: {bolinma}; Remainder: {qoldiq}" : $"Cannot divide by zero.");
        System.Console.WriteLine(TryDivide(12, 3, out bolinma, out qoldiq) ? $"Quotient: {bolinma}; Remainder: {qoldiq}" : $"Cannot divide by zero.");
        System.Console.WriteLine(TryDivide(8, 0, out bolinma, out qoldiq) ? $"Quotient: {bolinma}; Remainder: {qoldiq}" : $"Cannot divide by zero.");

        // 8. Savol: Chegaralangan bonusni ballga qo‘shing
        System.Console.Write("  Task_08:");
        int scope_01 = 70;
        int scope_02 = 95;
        int scope_03 = 40;
        int scope_04 = 105;
        int scope_05 = 50;
        System.Console.Write($"\nBefore: {scope_01}, "); AddBonus(ref scope_01, 20);
        System.Console.Write($"\nBefore: {scope_02}, "); AddBonus(ref scope_02, 10);
        System.Console.Write($"\nBefore: {scope_03}, "); AddBonus(ref scope_03, 0);
        System.Console.Write($"\nBefore: {scope_04}, "); AddBonus(ref scope_04, 5);
        System.Console.Write($"\nBefore: {scope_05}, "); AddBonus(ref scope_05, -1);

        // 9. Savol: Ombor savdosini tekshiring
        System.Console.WriteLine("\n  Task_09");
        int ombordagiSon_1 = 20;
        int ombordagiSon_2 = 10;
        int ombordagiSon_3 = 10;
        int ombordagiSon_4 = 5;
        System.Console.WriteLine($"Success: {TrySellItems(ref ombordagiSon_1, 5)}; Stock: {ombordagiSon_1}");
        System.Console.WriteLine($"Success: {TrySellItems(ref ombordagiSon_2, 10)}; Stock: {ombordagiSon_2}");
        System.Console.WriteLine($"Success: {TrySellItems(ref ombordagiSon_3, 12)}; Stock: {ombordagiSon_3}");
        System.Console.WriteLine($"Success: {TrySellItems(ref ombordagiSon_4, -1)}; Stock: {ombordagiSon_4}");

        // 10. Savol: Uchta sonning min, max va o‘rtadagi qiymatini toping
        System.Console.WriteLine("  Task_10");
        int kichik;
        int orta;
        int katta;
        GetNumberStats(8, 3, 5, out kichik, out katta, out orta);
        GetNumberStats(9, 2, 6, out kichik, out katta, out orta);
        GetNumberStats(4, 4, 1, out kichik, out katta, out orta);
        GetNumberStats(7, 7, 7, out kichik, out katta, out orta);

        // 11. Savol: Uchta bahoning o‘rtachasini tekshiring
        System.Console.WriteLine("  Task_11");
        int ortachaBaho;
        System.Console.WriteLine(TryCalculateAverage(80, 90, 10, out ortachaBaho) ? $"Success: True; Average: {ortachaBaho}" : "Success: False; Average: 0");
        System.Console.WriteLine(TryCalculateAverage(70, 71, 72, out ortachaBaho) ? $"Success: True; Average: {ortachaBaho}" : "Success: False; Average: 0");
        System.Console.WriteLine(TryCalculateAverage(0, 50, 100, out ortachaBaho) ? $"Success: True; Average: {ortachaBaho}" : "Success: False; Average: 0");
        System.Console.WriteLine(TryCalculateAverage(80, -1, 90, out ortachaBaho) ? $"Success: True; Average: {ortachaBaho}" : "Success: False; Average: 0");
        System.Console.WriteLine(TryCalculateAverage(80, 101, 90, out ortachaBaho) ? $"Success: True; Average: {ortachaBaho}" : "Success: False; Average: 0");

    }

    static void ShowWelcome()
    {
        System.Console.WriteLine("Welcome to C# methods!");
    }
    static void ShowGreeting(string name)
    {
        System.Console.WriteLine($"Hello, {name}!");
    }

    static string GetPassingScore()
    {
        return "Passing score: 60";
    }

    static int Add(int first, int second)
    {
        return first + second;
    }

    static string CreateOrderMessage(string product, int quantity)
    {
        return $"Order: {quantity} {product}";
    }

    static int GetTicketPrice(int age, bool isWeekend)
    {
        if (0 <= age && age <= 6)
            return 1;  //free

        else if (7 <= age && age <= 60)
        {
            if (isWeekend)
                return 15000;
            return 10000;
        }
        else if (61 <= age && age <= 120)
        {
            if (isWeekend)
                return 12000;
            return 10000;
        }

        return -1; //Invalid age
    }

    static bool TryDivide(int number, int divisor, out int quotient, out int remainder)
    {
        if (divisor == 0)
        {
            quotient = 0;
            remainder = 0;
            return false;
        }
        quotient = number / divisor;
        remainder = number % divisor;
        return true;
    }

    static void AddBonus(ref int score, int bonus)
    {
        if (0 <= score && score <= 100 && 0 <= bonus && bonus <= 30)
        {
            score = System.Math.Min(100, score + bonus);
            System.Console.Write($"After: {score}");
        }
        else System.Console.Write($"After: {score}");
    }

    static bool TrySellItems(ref int stock, int quantity)
    {
        if (stock < 0 || quantity < 0)
        {
            return false;
        }
        else if (stock - quantity >= 0)
        {
            stock -= quantity;
            return true;
        }
        return false;
    }

    static void GetNumberStats(int first, int second, int third, out int min, out int middle, out int max)
    {
        max = (first > second) ? first : second;
        max = (max > third) ? max : third;
        min = (first < second) ? first : second;
        min = (min < third) ? min : third;
        middle = first + second + third - max - min;

        System.Console.WriteLine($"Min: {min}; Middle: {middle}; Max: {max}");
    }

    static bool TryCalculateAverage(int first, int second, int third, out int average)
    {
        if (first < 0 || second < 0 || third < 0 || first > 100 || second > 100 || third > 100)
        {
            average = 0;
            return false;
        }
        average = (first + second + third) / 3;
        return true;
    }

}
