using System;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            library.Print();
            DefiningCustomConstructors();
        }

        static void DefiningCustomConstructors()
        {
            Console.WriteLine("-----------  Defining Custom Constructors ------------");
            Book book = new Book();
            Author author = new Author();
            book.Name = "Jantaxty";
            author.Name = "Albert Camus";

            Library library = new Library("Avetiq Isahakyani anvan gradaran", "Artasahmanyan grakanutyun", book, author);
            library.Print();
            Console.WriteLine();

            Library library1 = new Library("Azgain gradaran", "Haykakan grakanutyun");
            library1.Print();
        }
    }
}