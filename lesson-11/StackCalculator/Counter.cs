using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackCalculator
{
    public class Counter
    {
        private int counter = 0;
        public void SetValue(int val)
        {
            counter = val;
        }
        public int Value => counter;
        
        public void Inc()
        {
            ++counter;
        }
        public void Dec()
        {
            --counter;
        }
    }
}
