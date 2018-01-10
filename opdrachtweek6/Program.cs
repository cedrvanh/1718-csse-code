using System;
using System.Collections;
using System.Collections.Generic;

namespace Opdrachtweek6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Author> author = new List<Author>() 
            {
                new Author() { name = "Cedric", email = "lorem@outlook.com", gender = 'M' },
                new Author() { name = "Peter", email = "ipsum@outlook.com", gender = 'M' },
                new Author() { name = "Tykeisha", email = "test@outlook.com", gender = 'V' }
            };

            Book b1 = new Book("Leuk boek", author[0], 20, 5);
            Book b2 = new Book("Minder leuk boek", author[2], 30, 10);

            Console.WriteLine(b1.getTitle + " " + b1.getAuthor);
            Console.WriteLine(b2);
        }
    }
}
