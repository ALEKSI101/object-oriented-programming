using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_company
{
    class Program
    {
        static void Main(string[] args)
        {
            Company newCompany = new Company();
            newCompany.Title = "Sterling & Cooper";
            newCompany.Address = "Majatalo 55";
            newCompany.Phone = "0400962521";
            newCompany.Outcome = 100.00;
            newCompany.Expense = 50.00;

            Console.ReadKey();
            
        }
    }
}
