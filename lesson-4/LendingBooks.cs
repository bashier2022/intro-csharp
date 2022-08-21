using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_4
{
    public class LendingBooks
    {
        private Dictionary<string, List<LendBook>> _lendedBooksDict = new Dictionary<string, List<LendBook>>(); // the string is the book ISBN
        public Dictionary<string, List<LendBook>> LendedBooksDict => _lendedBooksDict;

        private void addAlendedBookToDictionary(Person p, Book b)
        {
            string isbn = b.Isbn;
            string id = p.Id.ToString();
            LendBook lb = new LendBook(p, b);
            List<LendBook> lst;
            if (_lendedBooksDict.ContainsKey(isbn))
            {
                lst=_lendedBooksDict[isbn];
                lst.Add(lb);
            }
            else
            {
                lst = new List<LendBook>();
                lst.Add(lb);
                _lendedBooksDict.Add(isbn, lst);
            }
        }

        public (bool lended, string message) lendBook(Catalog catalog, Book book, Person person) // for 1 week
        {
            if (book.IsAvailable)
            {
                book.lendTheBook();
                addAlendedBookToDictionary(person, book);
                return (true, "the book was lended");
            }
            else
            {
                return (false, "No more Copies for book to be lended");
            }
        }
        public (bool back, string message) giveBack(Catalog catalog, Book book, Person person)
        {
            book.ReturnTheBook();
            //// change the lenden Dictionary
            List<LendBook> lst = _lendedBooksDict[book.Isbn];
            foreach (LendBook lb in lst)
            {
                if (person.Id == lb.person.Id)
                {
                    lst.Remove(lb);
                    return (true, $"{lb.person.Name}-{lb.person.Id} returned the Book {lb.book.Title}");

                }
            }
            return (true, $"giving back the Book was failed");
        }
        public int CountTheLendedBooks()
        {
            int c = 0;
            foreach (var item in LendedBooksDict.Values)
            {
                foreach (LendBook lendBook in item)
                {
                    c++;
                }
            }
            return c;
        }
        public string report() // all users who did not return books in time
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(CountTheLendedBooks().ToString() + " are lended Books \n");
            foreach (var item in LendedBooksDict.Values)
            {
                foreach (LendBook lendBook in item)
                {
                    sb.Append(lendBook.person.ToString() +"\n" + lendBook.book.ToString() + (DateTime.Now - lendBook.date).ToString() + "\n");
                }
            }
            return sb.ToString();
        }
    }
}
