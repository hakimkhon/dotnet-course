using System;

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

        // 12. Savol: Uch xil shakl perimetrini overload qiling
        System.Console.WriteLine("  Task_12");
        System.Console.WriteLine(Shakl.GetPerimeter(4));
        System.Console.WriteLine(Shakl.GetPerimeter(3, 5));
        System.Console.WriteLine(Shakl.GetPerimeter(2, 7));
        System.Console.WriteLine(Shakl.GetPerimeter(3, 4, 5));
        System.Console.WriteLine(Shakl.GetPerimeter(1, 2, 3));
        System.Console.WriteLine(Shakl.GetPerimeter(0, 5));

        // 13. Savol: Talaba hisobotini overload qiling
        System.Console.WriteLine("  Task_13");
        Student.ShowStudent("Ali");
        Student.ShowStudent("Sara", 18, 60);
        Student.ShowStudent("Bek", 16, 59);
        Student.ShowStudent("Lola", 130, 80);
        Student.ShowStudent("Olim", 15, 101);

        // 14. Savol: Chegirma summali xaridni overload qiling
        System.Console.WriteLine("  Task_14");
        System.Console.WriteLine(Chegirma.CalculateTotal(5000, 3));
        System.Console.WriteLine(Chegirma.CalculateTotal(5000, 3, 2000));
        System.Console.WriteLine(Chegirma.CalculateTotal(1200, 2, 400));
        System.Console.WriteLine(Chegirma.CalculateTotal(5000, 0));
        System.Console.WriteLine(Chegirma.CalculateTotal(5000, 2, 10000));
        System.Console.WriteLine(Chegirma.CalculateTotal(100, 3, 150));


        // 15. Savol: GeometryGuru dasturini yarating
        System.Console.WriteLine("  Task_15");
        while (true)
        {
            ShowMainMenu();
            int shakl = (int)ReadDouble("Tanlang: ");
            if (shakl == 0)
            {
                System.Console.WriteLine("Goodbye!");
                break;
            }
            else if (1 <= shakl && shakl <= 3)
            {
                ShowCalculationMenu();
                int yuzaYokiPerimetr = (int)ReadDouble("Tanlang: ");
                if (yuzaYokiPerimetr == 0) continue;
                else if (yuzaYokiPerimetr == 1 || yuzaYokiPerimetr == 2)
                {
                    if (shakl == 1)
                    {
                        System.Console.Write("Doira radiusini kiriting: ");
                        if (yuzaYokiPerimetr == 1)
                        {
                            double radius = Convert.ToDouble(System.Console.ReadLine());
                            System.Console.WriteLine($"Radius: {radius}; Area: {GetCircleArea(radius)}");
                        }
                        else
                        {
                            double radius = Convert.ToDouble(System.Console.ReadLine());
                            System.Console.WriteLine($"Radius: {radius}; Perimeter: {GetCirclePerimeter(radius)}");
                        }
                    }
                    if (shakl == 2)
                    {
                        System.Console.WriteLine("to‘g‘ri to‘rtburchakning tomonlarini kiriting: ");
                        if (yuzaYokiPerimetr == 1)
                        {
                            System.Console.Write("eni: ");
                            double eni = Convert.ToDouble(System.Console.ReadLine());
                            System.Console.Write("bo'yi: ");
                            double boyi = Convert.ToDouble(System.Console.ReadLine());
                            System.Console.WriteLine($"Width: {eni}; Height: {boyi}; Area: {GetRectangleArea(eni, boyi)}");
                        }
                        else
                        {
                            System.Console.Write("eni: ");
                            double eni = Convert.ToDouble(System.Console.ReadLine());
                            System.Console.Write("bo'yi: ");
                            double boyi = Convert.ToDouble(System.Console.ReadLine());
                            System.Console.WriteLine($"Width: {eni}; Height: {boyi}; Perimetri: {GetRectanglePerimeter(eni, boyi)}");
                        }
                    }
                    if (shakl == 3)
                    {
                        System.Console.Write("kvadrat tomonini kiriting: ");
                        if (yuzaYokiPerimetr == 1)
                        {
                            double tomoni = Convert.ToDouble(System.Console.ReadLine());
                            System.Console.WriteLine($"Side: {tomoni}; Area: {GetSquareArea(tomoni)}");
                        }
                        else
                        {
                            double tomoni = Convert.ToDouble(System.Console.ReadLine());
                            System.Console.WriteLine($"Side: {tomoni}; Perimeter: {GetSquarePerimeter(tomoni)}");
                        }
                    }
                }
                else System.Console.WriteLine("---- 0-2 orasida son kiriting ----");
            }
            else System.Console.WriteLine("---- 0-3 orasida son kiriting ----");
        }
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

    static class Shakl
    {
        public static int GetPerimeter(int tomon)
        {
            return tomon * 4;
        }
        public static int GetPerimeter(int eni, int boyi)
        {
            if (eni != 0 && boyi != 0)
            {
                return 2 * (eni + boyi);
            }
            return -1;
        }
        public static int GetPerimeter(int a, int b, int c)
        {
            if (a + b > c && a + c > b && b + c > a)
            {
                return a + b + c;
            }
            return -1;
        }
    }

    class Student
    {
        public static void ShowStudent(string name)
        {
            System.Console.WriteLine($"Student: {name}");
        }
        public static void ShowStudent(string name, int age, int score)
        {
            if (0 <= age && age <= 120 && 0 <= score && score <= 100)
            {
                string result = score >= 60 ? "Passed" : "Needs practice";
                System.Console.WriteLine($"Student: {name}; Age: {age}; Score: {score}; Result: {result} ");

            }
            else System.Console.WriteLine("Invalid student data");
        }
    }

    class Chegirma
    {
        public static int CalculateTotal(int birlikNarx, int miqdor)
        {
            if (1 <= birlikNarx && birlikNarx <= 1_000_000 && 0 <= miqdor && miqdor <= 1000)
            {
                return birlikNarx * miqdor;
            }
            return -1;
        }
        public static int CalculateTotal(int birlikNarx, int miqdor, int chegirma)
        {
            int jamiNarx = CalculateTotal(birlikNarx, miqdor);
            if (jamiNarx >= 0 && 0 <= chegirma && chegirma <= jamiNarx)
            {
                return jamiNarx - chegirma;
            }
            return -1;
        }
    }

    static void ShowMainMenu()
    {
        System.Console.WriteLine("Quyidagi shakllardan birini tanlang");
        System.Console.WriteLine("1 - Circle, \n2 - Rectangle, \n3 - Square, \n0 - Exit");
    }
    static void ShowCalculationMenu()
    {
        System.Console.WriteLine("Yuza yoki Perimetr birini tanlang");
        System.Console.WriteLine("1 - Area, \n2 - Perimeter, \n0 - Back");
    }
    static double GetCircleArea(double radius) => Math.PI * radius * radius;
    static double GetCirclePerimeter(double radius) => 2 * Math.PI * radius;
    static double GetRectangleArea(double width, double height) => width * height;
    static double GetRectanglePerimeter(double width, double height) => 2 * (width + height);
    static double GetSquareArea(double side) => side * side;
    static double GetSquarePerimeter(double side) => 4 * side;

    static double ReadDouble(string prompt)
{
    while (true)
    {
        System.Console.Write(prompt);
        if (double.TryParse(System.Console.ReadLine(), out double value))
            return value;
        System.Console.WriteLine("Iltimos, son kiriting!");
    }
}


}
