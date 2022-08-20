using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_4
{
    public class Book
    {
        private string _title;
        private List<string> _authors;
        private string _isbn;
        private int _copies;
        private int _lendedCopies = 0;

        public Book(string title, List<string> authors, string isbn, int copies)
        {
            _title = title;
            _authors = authors;
            _isbn = isbn;
            _copies = copies;
        }
        public string Title { get { return _title; } }
        public List<string> Authors { get { return _authors; } }
        public string Isbn { get { return _isbn; } }
        public int copies { get { return _copies; } set { _copies = value; } }
        public bool IsAvailable => _copies > _lendedCopies;
        public bool lendBook()
        {
            if (IsAvailable)
            {
                _lendedCopies++;
                return true;
            }
            else { return false; }
        }
    }
}
