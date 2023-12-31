// See https://aka.ms/new-console-template for more information
using System;

namespace Classes {
    class Program {
        static void Main(string[] args){
            Book b1 = new Book("Book name 1", "Author 1", 500);
            Book b2 = new Book("Book name 2", "Author 2", 550);

            b1.getDescription();
            b2.getDescription();

            Console.WriteLine(b1.ISBN);
            b1.ISBN = "Some Value";
            b1.Price = 55.00m;

            Console.WriteLine(b1.ISBN);
            Console.WriteLine(b1.Price);

            b1.Name = "We can write a value here.";
            Console.WriteLine(b1.Pagecount);
        }
    }
}
