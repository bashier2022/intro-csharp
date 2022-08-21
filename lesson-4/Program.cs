using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace lesson_4
{
    internal class Program
    {
        public static void TestCatalog(Catalog catalog)
        {
            Console.WriteLine(catalog.Books.Count);
            foreach (Book b in catalog.Books.Values)
            {
                Console.WriteLine(b);
            }            
        }
        public static void TestSearchByTitle(Catalog catalog)
        {
            Console.WriteLine("TestSearchByTitle -----------------------");
            var (ok, book) = catalog.findByTitle("String-Rewriting Systems");
            if (ok)
            { Console.WriteLine(book); }
            else
            {
                Console.WriteLine("not found");
            }

        }
        public static void TestSearchByAuthor(Catalog catalog)
        {
            Console.WriteLine("TestSearchByAuthor-----------------------");
            var (found, lst) = catalog.findByAuthor("Friedrich Otto");
            if (found)
            {
                foreach (Book b in lst)
                {
                    Console.WriteLine(b);
                }
            }
            else
            {
                Console.WriteLine("not  Found");
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Book b1, b2, b3, b4;
            Person p1, p2, p3, p4, p5;
            p1 = new Person("1111", "Ronald V. Book", "USA");
            p2 = new Person("2222", "Friedrich Otto", "Kassel Germany");
            p3 = new Person("3333", "Rolv Break", "London");
            p4 = new Person("4444", "Oystein Haugen", "Norweg");
            p5 = new Person("5555", "Bashier Watted", "jatt");

            List<Person> authors1 = new List<Person>() { p1, p2 };
            List<Person> authors2 = new List<Person>() { p3, p4 };
            List<Person> authors3 = new List<Person>() { p2 };
            b1 = new Book("String-Rewriting Systems", authors1, "0387", 2);
            b2 = new Book("Engineering Real Time Systems", authors2, "0130", 1);

            Catalog catalog = new Catalog();

            catalog.add(b1);
            catalog.add(b2);

            Console.WriteLine(catalog.Books.Count);
            TestCatalog(catalog);
            b3 = new Book("Engineering Real Time Systems", authors2, "0130", 4);
            catalog.add(b3);
            TestCatalog(catalog);
            TestSearchByAuthor(catalog);
            b4 = new Book("Monadic Thue-Systems", authors3, "1111", 4);
            catalog.add(b4);
            TestSearchByAuthor(catalog);

            LendingBooks lend_book = new LendingBooks();

            lend_book.lendBook(catalog, b4, p5);

            Console.WriteLine(lend_book.LendedBooksDict.Count);

            var (lended, message) = lend_book.lendBook(catalog, b2, p5);
            Console.WriteLine(message);
            Console.WriteLine(lend_book.LendedBooksDict.Count);
            Console.WriteLine(lend_book.report());
            (lended, message) = lend_book.lendBook(catalog, b1, p5);
            Console.WriteLine(message);
            Console.WriteLine(lend_book.LendedBooksDict.Count);
            Console.WriteLine(lend_book.report());
            (lended, message) = lend_book.lendBook(catalog, b1, p2);
            Console.WriteLine(message);
            Console.WriteLine(lend_book.LendedBooksDict.Count);
            Console.WriteLine(lend_book.report());
            (lended, message) = lend_book.lendBook(catalog, b1, p1);
            Console.WriteLine(message);
            Console.WriteLine(lend_book.LendedBooksDict.Count);
            Console.WriteLine(lend_book.report());
            var (back, mes) = lend_book.giveBack(catalog, b1, p2);
            Console.WriteLine(back);
            Console.WriteLine(mes);
            Console.WriteLine(lend_book.LendedBooksDict.Count);
            Console.WriteLine(lend_book.report());

        }
    }
}