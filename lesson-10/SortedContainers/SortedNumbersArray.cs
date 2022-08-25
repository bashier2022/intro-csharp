using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedContainers
{
    public class SortedNumbersArray : SortedNumbers
    {
        private int[] _array;
        private int _length = 0;
        public SortedNumbersArray(int n)
        {
            _array = new int[n];
        }
        public bool Add(int value)
        {
            int Position = 0;
            if (_length < _array.Length)
            {
                Position = _length;
                while((Position > 0) && (_array[Position-1] > value))
                {
                    _array[Position] = _array[Position-1];
                    Position--;
                }
                _array[Position] = value;
                _length++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public int Count() => _length;

        public int get(int index)
        {
            //if (index < 0 || index >= _length)
            //{
            //    return _array[_array.Length];
            //}
           return _array[index];
        }

        public int max()
        {
            if (_length > 0)
            {
                return _array[_length - 1];
            }
            else
            {
                return _array[_array.Length];
            }
        }

        public int min()
        {
            if (_length > 0)
            {
                return _array[0];
            }
            else
            {
                return _array[_array.Length];
            }
        }

        public bool Remove(int value)
        {
            bool found = false;
            int i = 0;
            while ((!found) && (i < _length))
            {
                if (value == _array[i])
                {
                    found = true;
                }
                i++;
            }

            if (found)
            {
                for(int k = i-1; k < _length-1; k++)
                {
                    _array[k] = _array[k+1];
                }
                _length--;
            }
            return found;
        }
    }
}
