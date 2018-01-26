using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_company
{
    class Company
        //Fields
        
    {        
        public string Title;
        public string Address;
        public string Phone;
        public double Outcome;
        public double Expense;
    }

    //Constructor
    public Company()
    {
        Title = null;
        Address = null;
        Phone = null;
        Outcome = 0.00;
        Expense = 0.00;
    }
    
    public Company(string title, string address, string phone, double outcome, double expense)
    {
        Title = title;
        Address = address;
        Phone = phone;
        Outcome = outcome;
        Expense = expense;
    }
    
    //Copy Constructor
    public Company(Company previousCompany)
    {
        Title = previousCompany.Title;
        Address = previousCompany.Address;
        Phone = previousCompany.Phone;
        Outcome = previousCompany.Outcome;
        Expense = previousCompany.Expense;

    }

    //Methods

    public void ShowCompanyInfo()
    {
        Console.WriteLine($"Yrityksen nimi:{Title}");
        Console.WriteLine($"Yrityksen osoite:{Address}");
        Console.WriteLine($"Yrityksen puhelinnumero:{Phone}");
        Console.WriteLine($"Yrityksen tulot:{Outcome}");
        Console.WriteLine($"Yrityksen menot:{Expense}");
    }

    public void Profit()
    {
        Profit = ((Outcome - Expense) / Expense * 100);

        if (Profit >= 300)
        {
            Console.WriteLine("Firmalla menee hyvin.");
        }
            
        else if (Profit >= 200)
        {
            Console.WriteLine("Firmalla menee tyydyttävästi.");
        }
        else
        {
            Console.WriteLine("Firmalla menee kehnosti.");
        }
            
        

    }
    
}
