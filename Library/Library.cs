using System;

namespace Library
{
    public class Library
    {
        public string Name { get; set; }
        public string Section { get; set; }
        public Book book { get; set; }
        public Author author { get; set; }
        public static int Numberofbooks { get; set; }

        public Library()
        {
            book = new Book();
            author = new Author();
            Name = "Azgayin gradaran";
            Section = "Haykakan grakanutyun";
            book.Name = "es ev na";
            author.Name = "Nar-Dos";
        }

        public Library(string Name, string Section, Book book, Author author)
        {
            this.Name = Name;
            this.Section = Section;
            this.book = book;
            this.author = author;
        }

        static Library()
        {
            Numberofbooks = 3000;
        }

        public Library(string Name, string Section)
        {
            this.Name = Name;
            this.Section = Section;
            book.Name = "Erker";
            author.Name = "Aksel Bakunc";
        }

        public void Print()
        {
            Console.WriteLine($"max book number: {Numberofbooks}");
            Console.WriteLine($"Library Name: { Name}");
            Console.WriteLine($"Section: {Section}");
            Console.WriteLine($"Book Name:{book.Name}");
            Console.WriteLine($"Author :{author.Name}");
        }
    }
}
   