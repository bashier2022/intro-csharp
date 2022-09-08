using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackCalculator
{
    public class BetweenFormAndCounter
    {
        Counter counter= new Counter();
        public Action ViewChangedData;
        public void Inc()
        {
            counter.Inc();
            OnUpDate();
        }
        public void Dec()
        {
            counter.Dec();
            OnUpDate();


        }
        public void SetValue(int val)
        {
            counter.SetValue(val);
            OnUpDate();
        }

        private void OnUpDate()
        {
            if (ViewChangedData != null)
            {
                ViewChangedData();
            }
        }
    }
}
