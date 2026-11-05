using System;
using System.ComponentModel.DataAnnotations;

int son = 8;

System.Console.Write("1-savol natijasi: ");
if (son > 0)
{
    System.Console.WriteLine("Musbat");
}
else if (son < 0)
{
    System.Console.WriteLine("Manfiy");
}
else
{
    System.Console.WriteLine("nol");
}

// 2. Son juft yoki toq ekanini aniqlang.
System.Console.Write("2-savol natijasi: ");
if (son % 2 == 0)
{
    System.Console.WriteLine("Juft");
}
else
{
    System.Console.WriteLine("Toq");
}

// 3. kattasini aniqlang. Agar sonlar teng bo'lsa, bu haqda xabar chiqaring.
int son1 = 9;
int son2 = 4;

System.Console.Write("3-savol natijasi: ");
if (son1 == son2)
{
    System.Console.WriteLine("Sonlar teng");
}
else
{
    System.Console.WriteLine($"Kattasi: {((son1 > son2) ? son1 : son2)}");
}
// 4. 90-100 — A'lo, 70-89 — Yaxshi, 60-69 — Qoniqarli, 0-59 — Qoniqarsiz.
int ball = 10;

System.Console.Write("4-savol natijasi: ");
if (90 <= ball && ball <= 100)
{
    System.Console.WriteLine("A'lo");
}
else if (70 <= ball && ball <= 89)
{
    System.Console.WriteLine("Yaxshi");
}
else if (60 <= ball && ball <= 69)
{
    System.Console.WriteLine("Qoniqarli");
}
else if (0 <= ball && ball <= 59)
{
    System.Console.WriteLine("Qoniqarsiz");
}
else System.Console.WriteLine("0 dan 100 gacha ball kiriting");

/// 5. Savol: Ikkita butun son va amal belgisini (+, -, *, /) kiriting. 
///switch yordamida hisoblang. Bo'lishda butun son bo'linmasidan foydalaning. 
///Bo'luvchi 0 emas deb oling.

int son_1 = 8;
int son_2 = 2;
string amal = "+";

System.Console.Write("5-savol natijasi: ");
switch (amal)
{
    case "+": System.Console.WriteLine(son_1 + son_2); break;
    case "-": System.Console.WriteLine(son_1 - son_2); break;
    case "*": System.Console.WriteLine(son_1 * son_2); break;
    case "/": System.Console.WriteLine(son_1 / son_2); break;

    default: System.Console.WriteLine("no to'g'ri amal belgisini kiritdingiz!"); break;
}

/// 5. Savol: Ikkita butun son va amal belgisini (+, -, *, /) kiriting. 
///switch yordamida hisoblang. Bo'lishda butun son bo'linmasidan foydalaning. 
///Bo'luvchi 0 emas deb oling.

int qiyinSon1 = 7;
int qiyinSon2 = 3;
int qiyinSon3 = 8;

System.Console.Write("6-savol natijasi: ");
if (((qiyinSon1 + qiyinSon2) > qiyinSon3) && ((qiyinSon1 + qiyinSon3) > qiyinSon2) && ((qiyinSon3 + qiyinSon2) > qiyinSon1))
{
    if (qiyinSon1 == qiyinSon2 && qiyinSon1 == qiyinSon3)
    {
        System.Console.WriteLine("Uchburchak: teng tomonli");
    }
    else if (qiyinSon1 == qiyinSon2 || qiyinSon1 == qiyinSon3)
    {
        System.Console.WriteLine("Uchburchak: teng yonli");
    }
    else System.Console.WriteLine("Uchburchak: turli tomonli");
}
else System.Console.WriteLine("Uchburchak hosil qilmaydi");

/// 7. Savol: 0 dan 1000 gacha bo'lgan N butun sonini kiriting. 
/// for yordamida 1 dan N gacha bo'lgan sonlarni chiqaring.
System.Console.Write("7-savol natijasi: ");
int butunSon = 5;
for (int i = 1; i <= butunSon; i++)
{
    System.Console.Write($"{i} ");
}
// 8. while yordamida N dan 1 gacha kamayib boradigan sonlarni chiqaring.
System.Console.Write("\n8-savol natijasi: ");
while (butunSon > 0)
{
    System.Console.Write(butunSon-- + " ");
}

// 9. for yordamida 1 dan N gacha bo'lgan sonlar yig'indisini hisoblang.
int yigindi = 0;
int sonSavol_9 = 5;
for (int i = 1; i <= sonSavol_9; i++)
{
    yigindi += i;
}
System.Console.WriteLine($"\n9-savol natijasi: Yig'indi: {yigindi}");

/// 10. Savol (qiyinroq): N butun sonini kiriting. 
/// for yordamida 1 dan N gacha bo'lgan juft sonlarni chiqaring va ularning yig'indisini hisoblang. 
/// Juft son bo'lmasa, Juft son yo'q deb chiqaring va yig'indini 0 deb chiqaring. N 0 dan 1000 gacha bo'lsin.
System.Console.WriteLine("10-savol natijasi: ");
int sonSavol_10 = 10;
int juftYigindi = 0;
for (int i = 1; i <= sonSavol_10; i++)
{
    if (i % 2 == 0)
    {
        System.Console.Write(i + " ");
        juftYigindi += i;
    }
}
System.Console.Write((juftYigindi == 0) ? "Juft son yo'q Yig'indi: 0" : $"\nYig'indi: {juftYigindi}");

/// 11. Savol: 0 dan 1000 gacha bo'lgan N butun sonini kiriting. 
///for yordamida 1 dan N gacha bo'lgan, 5 ga qoldiqsiz bo'linadigan sonlarni chiqaring.

System.Console.Write("\n11-savol natijasi: ");
int sonSavol_11 = 23;
for (int i = 5; i <= sonSavol_11; i += 5)
{
    System.Console.Write(i + " ");
}

/// 12. Savol: -1000 dan 1000 gacha bo'lgan butun son kiriting. 
///for yordamida uning 1 dan 10 gacha ko'paytirish jadvalini chiqaring.
System.Console.WriteLine("\n12-savol natijasi: ");
int oraliqSon = 4;
for (int i = 1; i <= 10; i++)
{
    System.Console.WriteLine($"{oraliqSon} x {i} = {oraliqSon * i}");
}

/// 13. Savol (qiyinroq): 0 dan 1000 gacha bo'lgan N butun sonini kiriting. 
/// for yordamida 1 dan N gacha bo'lgan sonlar orasida 3 ga qoldiqsiz bo'linadiganlari 
/// nechta ekanini va ularning yig'indisini hisoblang. 
System.Console.WriteLine("13-savol natijasi: ");
int berilganSon = 2;
int uchgaKarraliSonYigindisi = 0;
int uchgaKarraliSonlarSoni = 0;
for (int i = 3; i <= berilganSon; i += 3)
{
    uchgaKarraliSonlarSoni++;
    uchgaKarraliSonYigindisi += i;
}
System.Console.WriteLine($"Soni: {uchgaKarraliSonlarSoni} \nYig'indisi: {uchgaKarraliSonYigindisi}");

/// 14. Savol (qiyinroq): 0 dan 12 gacha bo'lgan N butun sonini kiriting. 
/// for yordamida N! faktorialni hisoblang. 0! = 1.
System.Console.Write("14-savol natijasi: ");
int faktorialSon = 5;
int faktorialNatija = 1;
for (int i = 1; i <= faktorialSon; i++)
{
    faktorialNatija *= i;
}
System.Console.WriteLine($"Faktorial: {faktorialNatija}");

/// 15. Savol: 0 yoki undan katta butun son kiriting. while yordamida sonning raqamlari yig'indisini hisoblang. 
/// Oxirgi raqamni % 10 bilan oling va sonni 10 ga butun bo'lib bo'ling.
System.Console.Write("15-savol natijasi: ");
int number = 1258;
int raqamlariYigindisi = 0;
while (number > 0)
{
    raqamlariYigindisi += number % 10;
    number /= 10;
}
System.Console.WriteLine($"Raqamlar yig'indisi: {raqamlariYigindisi}");

/// 16. Savol (qiyinroq): 0 dan 1000 gacha butun son kiriting. 
/// for yordamida 2 dan N - 1 gacha bo'luvchilarni tekshirib, 
/// kiritilgan son tub yoki tub emasligini aniqlang. 
/// Tub son faqat 1 ga va o'ziga bo'linadi. 2 dan kichik qiymatlar tub emas. 
/// Bo'luvchi topilmasa, Tub son; aks holda Tub son emas deb chiqaring.
System.Console.WriteLine("16-savol natijasi: ");

System.Console.Write("0 va 1000 orasida butun son kiriitng: ");
int tubSon;
string kiritilganSon = System.Console.ReadLine();
bool tubmi = true;

tubSon = Convert.ToInt32(kiritilganSon);
if (tubSon == 0 || tubSon == 1)
{
    System.Console.WriteLine("Tub son emas");
    tubmi = false;
}
for (int i = 2; i * i <= tubSon; i++)
{

    if (tubSon % i == 0)
    {
        System.Console.WriteLine("Tub son emas");
        tubmi = false;
        break;
    }
}
if (tubmi)
{
    System.Console.WriteLine("Tub son");
}