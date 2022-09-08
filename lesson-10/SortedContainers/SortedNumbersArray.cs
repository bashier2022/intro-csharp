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
        private bool _ascending = true;
        public SortedNumbersArray(int n, bool asceding)
        {
            _array = new int[n];
            _ascending = asceding;
        }
        public bool SortedAscending() => _ascending;

        private int FindPlaceToAddItem(int x)
        {
            int idx = Array.BinarySearch(_array, 0, Count(), x);
            if (idx < 0)
            {
                idx = ~idx;
            }
            return idx;
        }
        private int FindPlaceToAddItem2(int x)
        {
            bool save_asc = _ascending; 
            _ascending = true;
            int left = 0;
            int right = Count()-1;
            if (x > Get(right)) // if we use (x > _array[right]), we don't need the var save_asc
            {
                _ascending = save_asc;
                return right + 1;
            }
            if (x < Get(left))
            {
                _ascending = save_asc;
                return left;
            }
            int mid = (left + right) / 2;
            while (left < right) // the condition left <= mid <= right is satisfied
            {
                if (x > Get(mid))
                {
                    left = mid + 1;
                }
                else if (x < Get(mid))
                {
                    right = mid;
                }
                else
                {
                    _ascending = save_asc;
                    return mid;
                }
                mid = (left + right) / 2;
            }
            _ascending = save_asc;
            return mid; // left and right are and mid are equals
        }
        private void ShiftRight(int position)
        {
            int c = Count();
            while (c > position)
            {
                _array[c] = _array[c-1];
                c--;
            }
        }
        public bool Add(int value)
        {

            if (_length >= _array.Length)
            {
                return false;
            }
            int position = 0;

            if (Count() > 0)
            {
                position = FindPlaceToAddItem(value);
                ShiftRight(position);
            }
            _array[position] = value;
            _length++;
            return true;
        }
        
        public bool Add2(int value)
        {

            if (_length >= _array.Length)
            {
                return false;
            }

            int position = _length;

            while ((position > 0) &&  (_array[position-1] > value))
            {
                _array[position] = _array[position-1];
                position--;
            }
            _array[position] = value;
            _length++;
            return true;
        }

        public void Clear()
        {
            _length = 0;
        }

        public int Count() => _length;

        public int Get(int index)
        {
            int idx = index;

            if (!_ascending)
            {
                idx = Count() - 1- index;
            }
            return _array[idx];
        }
        public int Max()
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

        public int Min()
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
                for (int k = i-1; k < _length-1; k++)
                {
                    _array[k] = _array[k+1];
                }
                _length--;
            }
            return found;
        }

        public override string ToString()
        {
            return SequenceUtils.AsString(this);
        }
    }
}