using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_4
{
    public class Person
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public Person(string id, string name, string address)
        {
            Id = id;
            Name = name;
            Address = address;
        }
        public override string ToString()
        {
            return Id + "  " + Name;
        }
    }
}
