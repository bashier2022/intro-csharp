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
    public partial class Form_StackCalculator : Form
    {
        private string message = "";
        public Form_StackCalculator()
        {
            InitializeComponent();
        }

        private void OnDigit_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string digit = btn.Text;
            if (label_DisplayInput.Text == "0")
            {
                label_DisplayInput.Text = digit;
            }
            else
            {
                label_DisplayInput.Text = label_DisplayInput.Text + digit;
            }
            message = "";
            DisplayMessage(message);
        }

        private void DisplayMessage(string message)
        {
            label_Message.Text = message;
        }
        private void OnPush_click(object sender, EventArgs e)
        {
            if (label_DisplayInput.Text == "0")
            {
                message = "Zero can't be pushed";
                DisplayMessage(message);
            }
            else
            {
                listBox_Stack.Items.Add(label_DisplayInput.Text);
                label_DisplayInput.Text = "0";
                message = "";
                DisplayMessage(message);
            }
        }

        private int Calculate(int a, int b, string op)
        {
            switch (op)
            {
                case "+":
                    return a + b;
                    break;
                case "-":
                    return a - b;
                    break;
                case "*":
                    return a * b;
                    break;
                case "/":
                    if (b != 0)
                    {
                        return a / b;
                    }
                    else
                    {
                        return 0;
                    }
                    break;
            }
            return 0;
        }

        private bool LegalEvaluation(int a, int b, string op)
        {
            return (op != "/") || (b != 0);
        }
        private void OnOperation_click(object sender, EventArgs e)
        {
            int c = listBox_Stack.Items.Count;

            if (c < 2)
            {
                DisplayMessage("Two Values required");
            }
            else
            {
                Button btn = (Button)sender;
                string op = btn.Text;
                int a = int.Parse(listBox_Stack.Items[c - 1].ToString());
                int b = int.Parse(listBox_Stack.Items[c - 2].ToString());
                if (LegalEvaluation(a, b, op))
                {
                    listBox_Stack.Items.RemoveAt(c - 1);
                    listBox_Stack.Items.RemoveAt(c - 2);
                    int result = Calculate(a, b, op);
                    listBox_Stack.Items.Add(result.ToString());
                }
                else
                {
                    DisplayMessage("Can't Divide by Zero");
                }
            }
            
        }

        private void Inc_Dec_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int add = 1;
            if (btn.Text == "Dec")
            {
                add = -1;
            }
            int val = int.Parse(label_DisplayInput.Text);
            val += add;
            label_DisplayInput.Text = val.ToString();

        }
    }
}
