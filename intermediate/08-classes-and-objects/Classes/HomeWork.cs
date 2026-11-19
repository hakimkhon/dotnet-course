namespace MyApp;

using System;

class TrafficLight
{
    int index = 0;
    string[] colors = ["Red", "Green", "Yellow"];
    public void NextColor()
    {
        index++;
        if (index == colors.Length)
        {
            index = 0;
            GetColor();
        }
        else
            GetColor();
    }

    public void GetColor()
    {
        Console.WriteLine(colors[index]);
    }
}

class Wallet
{
    int Balance = 0;

    public void AddMoney(int amount)
    {
        if (amount > 0)
        {
            Balance += amount;
        }
    }

    public bool SpendMoney(int amount)
    {
        if (amount > 0 && Balance - amount >= 0)
        {
            Balance -= amount;
            return true;
        }
        return false;
    }

    public int GetBalance() => Balance;
}

class WorkoutLog
{
    int[] Durations = new int[5];
    int Count;

    bool AddWorkout(int minutes)
    {
        return true;
    }
}

class Song
{
    string Title = "";
    int DurationSeconds;
    int PlayCount = 0;
    void Play() => PlayCount++;
    string GetInfo()
    {
        return $"{Title} - {DurationSeconds} soniya {PlayCount} marta ijro etildi";
    }
}

class Playlist
{
    Song[] Songs = new Song[5];
    int Count = 0;
    bool AddSong(Song song)
    {
        // if (song.)
        {

        }
        return true;
    }
}

class Product
{
    string Code = "";
    string Name = "";
    int Price;
    int Quantity;
    bool TrySell(int amount)
    {
        if (amount >= 0 && Quantity - amount >= 0)
        {
            Quantity = -amount;
            return true;
        }
        return false;
    }
    int GetStockValue() => Price * Quantity;
}
class Warehouse
{
    Product[] Products = new Product[5];
    int Count = 0;
    bool AddProduct(Product product)
    {
        return true;
    }
}

