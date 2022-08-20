using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_4
{
    public class LendBook
    {
        public Person person  { get; set; }
        public Book book   { get; set; }
        public DateTime date { get; set; }

        public LendBook(Person _person, Book _book) 
        {
            person = _person;
            book = _book;
            date = DateTime.Now;
        }
    }
}
