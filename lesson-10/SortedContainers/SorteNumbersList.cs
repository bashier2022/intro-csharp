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
        private bool _ascending = true;
        public SorteNumbersList(bool ascending)
        {
            _numbersList = new List<int>();
            _ascending = ascending;
        }
        public bool Add(int value)
        {
            int position = 0;
            while ((position < _numbersList.Count) && (_numbersList[position] < value))
            {
                ++position;
            }
            _numbersList.Insert(position, value);
            return true;
        }

        public void Clear()
        {
            _numbersList = new List<int>();
        }

        public int Count() => _numbersList.Count;

        //public int Get(int index) => _numbersList[index];

        public int Get(int index)
        {
            int idx = index;
            if (!_ascending)
            {
                idx = Count() - 1 - index;
            }
            return _numbersList[idx];
        }
        public int Max() => _numbersList[_numbersList.Count-1];

        public int Min() => _numbersList[0];

        public bool Remove(int value)
        {
            int c = _numbersList.Count;
            _numbersList.Remove(value);
            return c>_numbersList.Count;
        }

        public bool SortedAscending() => _ascending;
        public override string ToString()
        {
            return SequenceUtils.AsString(this);
        }
    }
}
