using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedContainers
{
    public class SorteNumbersList : SortedNumbers
    {
        private List<int> _numbersList;

        public SorteNumbersList()
        {
            _numbersList = new List<int>();
        }

        public bool Add(int value)
        {
            int position = 0;
            while((position < _numbersList.Count) && (_numbersList[position] < value))
            {
                position++;
            }
            _numbersList.Insert(position, value);
            return true;
        }

        public void Clear()
        {
            _numbersList = new List<int>();
        }

        public int Count() => _numbersList.Count;
        
        public int Get(int index) => _numbersList[index];
        
        public int Max() => _numbersList[_numbersList.Count-1];
        
        public int Min() => _numbersList[0];
        
        public bool Remove(int value)
        {
            int c = _numbersList.Count;
            _numbersList.Remove(value);
            return c>_numbersList.Count;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("[");
            if (Count() >= 1)
            {
                sb.Append(Get(0));
                for (int i = 1; i < Count(); i++)
                {
                    sb.Append($", {Get(i)}");
                }
            }
            sb.Append("]");
            return sb.ToString();
        }

    }
}
