using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_car
{
    class Car
    {
        //Fields
        public string Brand;
        public int Speed;
    }
    // Constructor
    public Car()
    {
        Brand = null;
        Speed = 0;
    }

    // Methods
    public void AskData()
    {
        Console.WriteLine("Auton merkki: ");
        Brand = Console.ReadLine();
        Console.WriteLine("Auton nopeus: ");
        Speed = int.Parse(Console.ReadLine());

    }
    public void ShowCarInfo()
    {
        Console.WriteLine($"Auton merkki: {Brand}\nNopeus:{Speed}\n");
        
    }
}
