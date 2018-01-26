using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_car
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();

            car1.AskData();
            car1.ShowCarInfo();
            car1.Accelerate();
            car1.ShowCarInfo();
            car1.Brake();
            car1.ShowCarInfo();
            

            Car car2 = new Car();
            car2.AskData();
            car2.ShowCarInfo();           
            car2.Accelerate();
            car2.ShowCarInfo();
            car2.Brake();
            car2.ShowCarInfo();

            Console.ReadKey();

        }
    }
}
