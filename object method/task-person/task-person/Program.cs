using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_person
{
    class Program
    {
        static void Main(string[] args)
        {
            Person personAleksi = new Person();
            personAleksi.Name = "Aleksi L";

            Person newPerson = new Person("Joe Doe", 17);
            newPerson.PrintPersonInfo();
            newPerson.GrowOld();
            newPerson.PrintPersonInfo();
            Console.ReadKey();


        }
    }
}
