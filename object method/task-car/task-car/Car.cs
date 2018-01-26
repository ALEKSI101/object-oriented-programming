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
        public double Speed;

        //Constructor
               
        public Car()
        {
            Brand = null;
            Speed = 0;
        }


        //Methods
        


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
        public void Accelerate()
        {
            Speed = Speed + 10;
        }
        public void Accelerate(int moreSpeed)
        {
            if (moreSpeed > 0)
            {
                Speed = Speed + moreSpeed;
                Console.WriteLine($"Auto kiihdyttää. Uusi nopeus on: {Speed}");
            }
            else
            {
                Console.WriteLine($"Negatiivinen muutos ei ole sallittu!");
            }

            
                        

        }
        public void Brake()

        {
            Speed = Speed * 0.9;
            Console.WriteLine($"Auto jarruttaa. Nopeus jarrutuksen jälkeen on: { Speed  }");
        }
    }
}
