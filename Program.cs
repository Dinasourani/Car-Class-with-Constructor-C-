using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    class Car
{
    public string Brand;
    public int Year;

    public Car(string brand, int year)
    {
        Brand = brand;
        Year = year;
    }
    public void ShowInfo()
    {
        Console.WriteLine("Brand: " + Brand);
        Console.WriteLine("Year: " + Year);
    }
}
    class Program
    {
        static void Main(string[] args)
        {
            Car c1 = new Car("BMW", 2022);
            c1.ShowInfo();

            Console.ReadKey();
        }
    }
}
