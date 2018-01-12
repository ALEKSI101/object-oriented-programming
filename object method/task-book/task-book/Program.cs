using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_book
{
    class Program
    {
        static void Main(string[] args)
        {
            Book bookRaamattu = new Book();
            bookRaamattu = new Book("Raamattu", "Jeesus", 654612, 10);
            bookRaamattu.PrintBookInfo();

            Book bookTuntematonSotilas = new Book();
            bookTuntematonSotilas = new Book("Tuntematon sotilas", "Väinö Linna", 210, 22);
            bookTuntematonSotilas.PrintBookInfo();
            Console.WriteLine ($"{bookRaamattu.CompareBook(bookTuntematonSotilas)}");
           

                Console.ReadKey();

        }
    }
}
