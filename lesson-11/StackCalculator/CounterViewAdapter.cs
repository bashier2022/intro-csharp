using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackCalculator
{
    public class CounterViewAdapter 
    {
        private Counter counter = new Counter();

        public Action<string, int, Color> OnUpdateCallBack;
        
        public void Inc()
        {
            counter.Inc();
            Notify();
        }

        private void Notify()
        {
            if (OnUpdateCallBack != null)
            {
                int value = counter.Value;
                string text;
                Color color;

                if(value < 0)
                {
                    text = $"({-value})";
                    color = Color.Red;
                }
                else if (value > 0)
                {
                    text = $"{value}";
                    color = Color.Green;                    
                }
                else
                {
                    text = "0";
                    color = Color.Black;
                }
                OnUpdateCallBack(text, value, color);
            }
        }

        public void Dec()
        {
            counter.Dec();
            Notify();
        }

        public void SetValue(int val)
        {
            counter.SetValue(val);
            Notify();
        }

        public void Advance(int n)
        {
            for (int i = 0; i < n; i++)
            {
                counter.Inc();
            }
            Notify();
        }
    }
}
