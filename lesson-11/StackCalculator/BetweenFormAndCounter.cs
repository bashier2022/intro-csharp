using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackCalculator
{
    public class BetweenFormAndCounter : Counter
    {
        public Action UpDateValue;
        //public BetweenFormAndCounter() : base()
        //{
        //}
        public void Inc()
        {
            base.Inc();
            if (UpDateValue != null)
            {
                UpDateValue();
            }
        }
        public void Dec()
        {
            base.Dec();
            if (UpDateValue != null)
            {
                UpDateValue();
            }
        }
        public void SetValue(int val)
        {
            base.SetValue(val);
            if (UpDateValue != null)
            {
                UpDateValue();
            }
        }
    }
}
