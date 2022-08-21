using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_4
{
    public class Catalog
    {
        private Dictionary<string, Book> _catalogOfBooks;
        private Dictionary<string, Book> _titleOfBooks;// string is the title of the book
        private Dictionary<string, List<Book>> _authorOfBooks; // string is the name of the author
        public Catalog()
        {
            _catalogOfBooks = new Dictionary<string, Book>();
            _titleOfBooks = new Dictionary<string, Book>();
            _authorOfBooks = new Dictionary<string, List<Book>>();
        }
        public Dictionary<string, Book> Books => _catalogOfBooks; 

        public (bool ok, Book b) findByTitle(string title)
        {
            Book book;
            if (_titleOfBooks.TryGetValue(title, out book))
            {
                return (true, _titleOfBooks[title]);
            }
            else
            {
                return (false, null);
            }
        }

        public (bool ok, Book b) findByISBN(string isbn)
        {
            if (_catalogOfBooks.TryGetValue(isbn, out Book b))
            {
                return (true, b);
            }
            else
            {
                return (false, null);
            }            
        }

        public (bool ok, List<Book> bookList) findByAuthor(string author)
        {
            if (_authorOfBooks.TryGetValue(author, out List<Book> bookList))
            {
                return (true, bookList);
            }
            else
            {
                return (false, null);
            }
        }
        
        public (bool ok, Book b) isBookInLibrary(Book book)
        {
            if (_catalogOfBooks.TryGetValue(book.Isbn, out Book b))
            {
                return (true, b);
            }
            else
            {
                return (false, book);
            }
        }

        public void AddAuthorToDict(Book nb) // the Book nb will be added for the first time
        {
            foreach (Person author in nb.Authors)
            {
                var (found, lst_books) = findByAuthor(author.Name);
                if (found)
                {
                    _authorOfBooks[author.Name].Add(nb); // the book will be added to an existing Author
                }
                else
                {
                    _authorOfBooks.Add(author.Name, new List<Book> { nb });
                }
            }
        }
        public void add(Book nb)
        {
            var (ok, book) = isBookInLibrary(nb);
            if (ok)
            {
                book.Copies = book.Copies + nb.Copies;
            }
            else
            {
                _catalogOfBooks.Add(nb.Isbn, nb);
                _titleOfBooks.Add(nb.Title, nb);
                AddAuthorToDict(nb);
            }
        }
    }
}
