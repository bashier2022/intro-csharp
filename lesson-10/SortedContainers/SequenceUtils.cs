using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedContainers
{
    public static class SequenceUtils
    {
        public static string AsString(this SortedNumbers s)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("[");
            if (s.Count() >= 1)
            {
                sb.Append(s.Get(0));
                for (int i = 1; i < s.Count(); i++)
                {
                    sb.Append($", {s.Get(i)}");
                }
            }
            sb.Append("]");
            return sb.ToString();
        }

        public static int First(this SortedNumbers s)
        {
            return s.Get(0);
        }
    }
}
