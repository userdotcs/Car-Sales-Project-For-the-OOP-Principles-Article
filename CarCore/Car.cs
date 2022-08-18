using System;

namespace ArticleForCarSalesProject.CarCore;
abstract class Car
{
    public string Name;
    public float OilTankSize;
    public int SeatCount, Price;
    public string Horn;
    public void PrintToList()
    {
        Console.WriteLine(
            $"------------------------------\n" +
            $"Name: {this.Name}\n" +
            $"Price: {this.Price}\n" +
            $"SeatCount: {this.SeatCount}\n" +
            $"------------------------------");
    }
    public void PlayHorn()
    {
        Console.WriteLine(Horn);
    }
}