﻿using System.Globalization;
using System;

// 1-Masala
string language = "C#";
int age = 25;
double height = 5.9;
decimal price = 19.99m;
char className = 'B';
bool ismarried = false;
long population = 5000000000;

Console.WriteLine("Language: " + language);
Console.WriteLine("Age: " + age);
Console.WriteLine("Height: " + height);
Console.WriteLine("Price: " + price);
Console.WriteLine("Class Name: " + className);
Console.WriteLine("Is Married: " + ismarried);
Console.WriteLine("Population: " + population);

// 2-Masala;

int minutes = 20;
var sessionCount = 3;
const int minutesInHour = 60;
string topic = "C#";

minutes = 25;
int copiedMinutes = minutes + 5;
string copiedTopic = "SQL";

Console.WriteLine("Actual: " + minutes);
Console.WriteLine("Total Minutes: " + sessionCount * minutesInHour);
Console.WriteLine($"Minutes original/copy: {minutes}, {copiedMinutes}");
Console.WriteLine($"Topic original/copy: {topic}, {copiedTopic}");


// 3-Masala
int yigindi = 18 + 7;
int ayirma = 18 - 7;
int kopaytma = 18 * 7;
int bolinish = 18 / 7;
int qoldiq = 18 % 7;
float floatBolinish = 18f / 4;
int amallarTartibi = 2 + 3 * 4;
int qavsliAmallar = (2 + 3) * 4;

Console.WriteLine("Yig'indi: " + yigindi);
Console.WriteLine("Ayirma: " + ayirma);
Console.WriteLine("Ko'paytma: " + kopaytma);
Console.WriteLine("Bolinish: " + bolinish);
Console.WriteLine("Qoldiq: " + qoldiq);
Console.WriteLine("Float Bolinish: " + floatBolinish);
Console.WriteLine("Amallar tartibi: " + amallarTartibi);
Console.WriteLine("Qavsli amallar: " + qavsliAmallar);

//4-Masala
int practiceMinutes = 12;
Console.WriteLine(practiceMinutes);

practiceMinutes += 8;
Console.WriteLine(practiceMinutes);
practiceMinutes -= 2;
Console.WriteLine(practiceMinutes);
practiceMinutes *= 3;
Console.WriteLine(practiceMinutes);
practiceMinutes /= 4;
Console.WriteLine(practiceMinutes);
practiceMinutes ++;
Console.WriteLine(practiceMinutes);
practiceMinutes --;
Console.WriteLine(practiceMinutes);

// 5-Masala
int son = 30;
double son2 = 9.7;
int son3 = 7;
int son4 = 2;

int intSon2 = (int)son2;
int convertedSon2 = Convert.ToInt32(son2);
double son5 = ((double)son3 / son4);
double son6 = (double)(7 / 2);

Console.WriteLine(son);
Console.WriteLine(intSon2);
Console.WriteLine(convertedSon2);
Console.WriteLine(son5);
Console.WriteLine(son6);

// 6-Masala
string matnliSon1 = "48", matnliSon2 = "3.75", matnliSon3 = "9.90";
int natija1 = Convert.ToInt32(matnliSon1);
int natija2 = int.Parse(matnliSon1);
double natija3 = double.Parse(matnliSon2, CultureInfo.InvariantCulture);
decimal natija4 = decimal.Parse(matnliSon3, CultureInfo.InvariantCulture);

Console.WriteLine(natija1);
Console.WriteLine(natija2);
Console.WriteLine(natija3);
Console.WriteLine(natija4);

// 7-Masala
string rawTopic = "  Learn C#  ";

string cleanedTopic = rawTopic.Trim();
Console.WriteLine($"Original length: {rawTopic.Length}");
Console.WriteLine($"Clean topic: '{cleanedTopic}'");
Console.WriteLine($"Cleaned length: {cleanedTopic.Length}");
Console.WriteLine($"Uppercase: {cleanedTopic.ToUpper()}");
Console.WriteLine($"Contains 'C#': {cleanedTopic.Contains("C#")}");
Console.WriteLine($"Replacement: {cleanedTopic.Replace("C#", ".NET")}");
bool result = string.IsNullOrWhiteSpace(rawTopic);
Console.WriteLine($"Blank input:: {result}");

// 8-Masala
string name, mazmun, masofa, davomiylik;

System.Console.Write("Ismingizni kiriting: ");
name = System.Console.ReadLine();

System.Console.Write("Manzuni kiriting: ");
mazmun = System.Console.ReadLine();

System.Console.Write("Masofani kiriting (km): ");
masofa = System.Console.ReadLine();

System.Console.Write("Davomiylikni kiriting (soat): ");
davomiylik = System.Console.ReadLine();


double speed = double.TryParse(masofa, out double m) ? double.Parse(masofa) / double.Parse(davomiylik) : 0;

System.Console.WriteLine($"Hello, {name.Trim()}! Today's topic: {mazmun.Trim()}.");
System.Console.WriteLine($"Average speed: {speed} km/h");

// 9-Masala

int realTime = 30;
int planTime = 48;

System.Console.WriteLine(realTime == planTime);
System.Console.WriteLine(realTime != planTime);
System.Console.WriteLine(realTime > planTime);
System.Console.WriteLine(realTime < planTime);
System.Console.WriteLine(realTime >= planTime);
System.Console.WriteLine(realTime <= planTime);

// 10-Masala
string mavzu = "C#";
int rejaDaqiqa = 40; 
int sarfDaqiqa = 40;
decimal narx = 12.50m;
const int birSoat = 60;

System.Console.WriteLine($"Topic: {mavzu}");
System.Console.WriteLine($"Planned: {rejaDaqiqa} minuts");
System.Console.WriteLine($"Actual: {sarfDaqiqa} minuts");
System.Console.WriteLine($"Remaining: {rejaDaqiqa - sarfDaqiqa} minuts");
System.Console.WriteLine($"Cost: {Math.Round(narx / birSoat * sarfDaqiqa, 2)}");
System.Console.WriteLine($"Goal met: {rejaDaqiqa <= sarfDaqiqa}");
System.Console.WriteLine($"Within plan: {rejaDaqiqa >= sarfDaqiqa}");
System.Console.WriteLine($"Needs more time: {rejaDaqiqa > sarfDaqiqa}");

// 11-Masala
System.Console.Write("sekundni kiriting:");
string sekund = System.Console.ReadLine();
int soat, minut, sekundlar;
soat = int.Parse(sekund) / 3600;
minut = (int.Parse(sekund) % 3600) / 60;
sekundlar = int.Parse(sekund) % 60;

System.Console.WriteLine($"Hours: {soat}");
System.Console.WriteLine($"Minutes: {minut}");
System.Console.WriteLine($"Seconds: {sekundlar}");
System.Console.WriteLine($"Reconstructed seconds: {sekund}");

// 12-Masala
System.Console.Write("Selsiy bo'yicha haroratni kiriting: ");
string selsiy = System.Console.ReadLine();

double harorat = double.Parse(selsiy);
double farenheit = (harorat * 9 / 5) + 32;
double kelvin = harorat + 273.15;

System.Console.WriteLine($"Celsius: {harorat:F2}");
System.Console.WriteLine($"Fahrenheit: {farenheit:F2}");
System.Console.WriteLine($"Kelvin: {kelvin:F2}");
System.Console.WriteLine($"Below zero: {harorat < 0}");

// 13-Masala
System.Console.Write("Ismingizni kiriting: ");
string ism = System.Console.ReadLine();
string userName = ism.Trim();
userName = userName.Replace(" ", "_");
userName = userName.ToUpperInvariant();
// string username = System.Text.RegularExpressions.Regex.Replace(userName, @"\s+", "_");

System.Console.WriteLine($"Original length: {ism.Length}");
System.Console.WriteLine($"Username: {userName}");
System.Console.WriteLine($"Username length: {userName.Length}");
System.Console.WriteLine("Contains underscore: " + userName.Contains("_"));
System.Console.WriteLine("Length in range: " + (userName.Length >= 5 && userName.Length <= 12));

// 14-Masala
System.Console.Write("Kitobxonning yoshini kiriting: ");
string yosh = System.Console.ReadLine();
int yoshInt = int.Parse(yosh);

System.Console.Write("kutubxona kartasi borligini kiriting (true/false): ");
string kartasiBor = System.Console.ReadLine();
bool kartasiBorBool = bool.Parse(kartasiBor);

System.Console.Write("kechiktirilgan kitob borligini kiriting (true/false): ");
string kechiktirilganKitob = System.Console.ReadLine();
bool kechiktirilganKitobBool = bool.Parse(kechiktirilganKitob);

// Natijalarni chiqarish
System.Console.WriteLine($"Age requirement met: {yoshInt >= 14}");
System.Console.WriteLine("Can borrow: " + (yoshInt >= 14 && kartasiBorBool && !kechiktirilganKitobBool));
System.Console.WriteLine("Needs assistance: " + (!kartasiBorBool || kechiktirilganKitobBool));

// 15-Masala
System.Console.Write("Enter a number: ");