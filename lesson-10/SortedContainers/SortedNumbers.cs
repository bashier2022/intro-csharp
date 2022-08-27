using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedContainers
{
    public interface  SortedNumbers
    {
        int Max();
        int Min();
        int Count();
        bool Add(int value);
        bool Remove(int value);
        int Get(int index);
        void Clear();
    }
}
