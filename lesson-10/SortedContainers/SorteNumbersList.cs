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

        public int Count() => _numbersList.Count;
        
        public int get(int index) => _numbersList[index];
        
        public int max() => _numbersList[_numbersList.Count-1];
        
        public int min() => _numbersList[0];
        
        public bool Remove(int value)
        {
            int c = _numbersList.Count;
            _numbersList.Remove(value);
            return c>_numbersList.Count;
        }

    }
}
