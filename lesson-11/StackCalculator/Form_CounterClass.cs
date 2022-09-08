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
        private CounterViewAdapter counterAdapter;
        public Form_CounterClass()
        {
            InitializeComponent();
            counterAdapter = new CounterViewAdapter();
            counterAdapter.OnUpdateCallBack = OnValueUpdate;
        }

        private void btn_SetValue_Click(object sender, EventArgs e)
        {
            if (textBox_Value.Text !="")
            {

                if (int.TryParse(textBox_Value.Text, out int c))
                {
                    counterAdapter.SetValue(c);
                    textBox_Value.Text = "";
                }
            }
        }

        public void OnValueUpdate(string text, int current, Color color)
        {
            label_Counter.Text = text;
            label_Counter.ForeColor = color;
        }
        private void btn_Inc_Click(object sender, EventArgs e)
        {
           counterAdapter.Inc();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            counterAdapter.Dec();
        }

        private void btnAdvance_Click(object sender, EventArgs e)
        {
            var s = txtDistance.Text;
            int n;
            if(int.TryParse(s, out n))
            {
                counterAdapter.Advance(n);
            }
        }
    }
}
