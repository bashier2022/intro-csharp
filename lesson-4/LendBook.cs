using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_4
{
    public class LendBook
    {
        public string ISBN  { get; set; }
        public string ID   { get; set; }
        public DateTime date { get; set; }

        public LendBook(string iSBN, string iD, DateTime lending_date)
        {
            ISBN = iSBN;
            ID = iD;
            date = lending_date;
        }
    }
}
