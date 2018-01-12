using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_book
{
    class Book
    {
        //Fields
        public string Title;
        public string Author;
        public int Id;
        public int Price;  
        
        //Constructor
        public Book()
        {
            Title = "unknown";
            Author = "unknown";
            Id = 0;
            Price = 0;
        }
        public Book(string title, string author, int id, int price)
        {
            this.Title = title;
            this.Author = author;
            this.Id = id;
            this.Price = price;
        }

        //Methods
        public void PrintBookInfo()
        {
            Console.WriteLine($"Kirjan nimi:{Title}\n" +
                              $"Kirjoittajan nimi:{Author}\n" +
                              $"Id-numero:{Id}\n" +
                              $"Kappalehinta:{Price}");
        }

        public string CompareBook(Book book)
        {
            if (this.Price > book.Price)
                return $"{this.Title} on kalliimpi kuin {book.Title} ";
            else
                return $"{book.Title} on kalliimpi kuin {this.Title} ";

        }
    }
}
