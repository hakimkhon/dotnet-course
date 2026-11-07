using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("  Task 01");
        Area.CalculateArea(5);
        Area.CalculateArea(4, 6);
        Area.CalculateArea(8, 3, 14);

        Console.WriteLine("  Task 02");
        Max.GetMax(12, 8);
        Max.GetMax(4, 19, 11);
        Max.GetMax(5.7, 8.2);

        Console.WriteLine("\n  Task 03");
        Console.WriteLine(Converting.ConvertToText(125));
        Console.WriteLine(Converting.ConvertToText(12.5));
        Console.WriteLine(Converting.ConvertToText(30 - 01 - 2025)); // Xato chiqyapti shunisi

        Console.WriteLine("\n  Task 04");
        Console.Write("Butun son kiriting: ");
        int butunSon = Convert.ToInt32(Console.ReadLine());
        int summa = 0;
        butunSon = Math.Abs(butunSon);
        while (butunSon > 0)
        {
            summa += butunSon % 10;
            butunSon /= 10;
        }
        Console.WriteLine($"Raqamlar yig'indisi: {summa}");

        Console.WriteLine(" Task_05");
        Console.Write("musbat son kiriting (Tub ekanligini aniqlash uchun): ");
        int tubSon = Convert.ToInt32(Console.ReadLine());
        TubSon(tubSon);
        
        Console.WriteLine(" Task_06");
        Console.Write("ikkita son kiriting: \n birinchi ");
        int son1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("ikkinchi ");
        int son2 = Convert.ToInt32(Console.ReadLine());
        JuftSonlarYigindisi(son1, son2);

    }

    class Area
    {
        public static void CalculateArea(int tomon)
        {
            Console.WriteLine($"Kvatdarning yuzi: {tomon * tomon}");
        }

        public static void CalculateArea(int eni, int boyi)
        {
            Console.WriteLine($"To'g'ri to'rt burchakning yuzi: {eni * boyi}");
        }

        public static void CalculateArea(int katet_1, int katet_2, int gpotenuza)
        {
            Console.WriteLine($"To'g'ri burchakli uchburchakning yuzi: {katet_1 * katet_2 / 2}");
        }
    }

    class Max
    {
        public static void GetMax(int a, int b)
        {
            Console.Write(a > b ? $"Maximum: {a} " : $"Maximum: {b} ");
        }

        public static void GetMax(int a, int b, int c)
        {
            a = a > b ? a : b;
            Console.Write(a > c ? $"Maximum: {a} " : $"Maximum: {c} ");
        }

        public static void GetMax(double a, double b)
        {
            Console.Write(a > b ? $"Maximum: {a} " : $"Maximum: {b} ");
        }
    }

    class Converting
    {
        public static string ConvertToText(int son)
        {
            string result = Convert.ToString(son);
            // return $"{son}";
            return result;
        }

        public static string ConvertToText(double son)
        {
            string result = Convert.ToString(son);
            // return $"{son}";
            return result;
        }

        public static string ConvertToText(DateTime sana)
        {
            return sana.ToString("yyyy-MM-dd");
        }
    }

    static void TubSon(int tubSon)
    {
        bool tubmi = true;

        if (tubSon == 0 || tubSon == 1)
        {
            Console.WriteLine("Tub son emas");
            tubmi = false;
        }
        for (int i = 2; i * i <= tubSon; i++)
        {
            if (tubSon % i == 0)
            {
                Console.WriteLine("Tub son emas");
                tubmi = false;
                break;
            }
        }
        if (tubmi)
        {
            Console.WriteLine("Tub son");
        }
    }

    static void JuftSonlarYigindisi(int first, int second)
    {
        int summa = 0;
        int min = first < second ? first : second;
        second = first > second ? first : second;

        for (int i = min; i <= second; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write(i + ", ");
                summa += i;                
            }            
        }
        Console.Write($"Sum: {summa} ");
    }   

        
}

