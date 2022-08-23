using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_4
{
    public class LendingBooks
    {
        private Dictionary<string, List<LendBook>> _lendedBooksDict = new(); // the string is the book ISBN
        
        public Dictionary<string, List<LendBook>> LendedBooksDict => _lendedBooksDict;

        private void addAlendedBookToDictionary(Person p, Book b)
        {                        
            LendBook lb = new LendBook(p, b);                        
            if (_lendedBooksDict.ContainsKey(b.Isbn))
            {
                var lst = _lendedBooksDict[b.Isbn];
                lst.Add(lb);
            }
            else
            {
                var lst = new List<LendBook>() { lb };                
                _lendedBooksDict.Add(b.Isbn, lst);

                // _lendedBooksDict.Add(b.Isbn, new() { lb });
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
            var lst = _lendedBooksDict[book.Isbn];
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
            foreach (var lst in LendedBooksDict.Values)
            {
               c += lst.Count;
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
