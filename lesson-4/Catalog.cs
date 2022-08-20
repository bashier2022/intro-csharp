using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_4
{
    public class Catalog
    {
        private List<Book> _books;
        private Dictionary<string, List<LendBook>> _lendedBooksDict; // the string is the book ISBN

        public Catalog()
        {
            _books = new List<Book>();
            _lendedBooksDict = new Dictionary<string, List<LendBook>>();
        }
        public List<Book> Books
        {
            get { return _books; }
        }
        public Dictionary<string, List<LendBook>> LendedBooksDict
        {
            get { return _lendedBooksDict; }
        }
        public (bool ok, Book b) findByTitle(string title)
        {
            foreach (Book bb in _books) { if (bb.Title == title) return (true, bb); }
            return (true, null);
        }

        public (bool ok, Book b) findByISBN(string isbn)
        {
            foreach (Book bb in _books) { if (bb.Title == isbn) return (true, bb); }
            return (true, null);
        }
        public bool isAuthorOfTheBook(Book bb, string author)
        {
            return bb.Authors.Contains(author);
        }
        public List<Book> findByAuthor(string author)
        {
            List<Book> result = new List<Book>();
            foreach (Book bb in _books) { if (isAuthorOfTheBook(bb, author)) result.Add(bb); }
            return result;
        }
        public (bool ok, Book b) isBookInLibrary(Book book)
        {
            foreach (Book bb in _books) { if (bb.Isbn == book.Isbn) return (true, bb); }
            return (false, book);
        }
        public void add(Book nb)
        {
            var (ok , book) = isBookInLibrary(nb);
            if (ok)
            {
                book.copies = book.copies + book.copies;
            }
            else
            {
                _books.Add(nb);
            }
        }

        private void addAlendedBookToDictionary(Book bm, Person p)
        {
            string isbn = bm.Isbn;
            LendBook lb = new LendBook(isbn, p.Id.ToString(), DateTime.Now);
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
      
        public (bool lended, string message) lendBook(string isbn, Person whome) // for 1 week
        {
            var (ok, book) = findByISBN(isbn);
            if (ok)
            {
                if (book.IsAvailable)
                {
                    return (true, "the book was lended");
                    // procedure for lending a book
                    book.lendBook();
                    addAlendedBookToDictionary(book, whome);
                }
                else { return (false, "No more Copies for book to be lended"); }
            }
            else
            {
                return (false, "the book is not available");
            }
        }
        public void giveBack(string isbn, Person whome)
        {

        }

        public string report() // all users who did not return books in time
        {
            StringBuilder sb = new StringBuilder();

            return sb.ToString();
        }


    }
}
