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
        private List<Person> _authors;
        private string _isbn;
        private int _copies;
        private int _lendedCopies = 0;

        public Book(string title, List<Person> authors, string isbn, int copies)
        {
            _title = title;
            _authors = authors;
            _isbn = isbn;
            _copies = copies;
        }
        public string Title { get { return _title; } }
        public List<Person> Authors { get { return _authors; } }
        public string Isbn { get { return _isbn; } }
        public int Copies { get => _copies; set => _copies = value;  }
        public bool IsAvailable => _copies > _lendedCopies;
        public bool isAuthorOfTheBook(string author)
        {
            foreach (Person person in _authors)
            {
                if (person.Name == author)
                {
                    return true;
                }
            }
            return false; 
        }
        public bool lendTheBook()
        {
            if (IsAvailable)
            {
                _lendedCopies++;
                return true;
            }
            else
            {
                return false;
            }
        }
        public void ReturnTheBook()
        {
            _lendedCopies--;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Title);
            sb.Append("\n");
            foreach(Person p in Authors)
            {
                sb.Append("   " + p.Name + "\n");
            }
            return sb.ToString();
        }
    }
}
