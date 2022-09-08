using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StackCalculator
{
    public partial class Form_CounterClass : Form
    {
        BetweenFormAndCounter counter;
        public Form_CounterClass()
        {
            InitializeComponent();
            counter = new BetweenFormAndCounter();
            counter.ViewChangedData = DisplayCounter;
        }

        private void btn_SetValue_Click(object sender, EventArgs e)
        {
            if (textBox_Value.Text !="")
            {

                if (int.TryParse(textBox_Value.Text, out int c))
                {
                    counter.SetValue(c);
                    textBox_Value.Text = "";
                }
            }
        }

        public void DisplayCounter()
        {
            label_Counter.Text = counter.Value.ToString();
        }
        private void btn_Inc_Click(object sender, EventArgs e)
        {
           counter.Inc();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            counter.Dec();
        }
    }
}
