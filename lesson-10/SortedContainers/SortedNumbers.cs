using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedContainers
{
    public interface  SortedNumbers
    {
        int max();
        int min();
        int Count();
        bool Add(int value);
        bool Remove(int value);
        int get(int index);
    }
}
