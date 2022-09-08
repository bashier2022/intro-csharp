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
    public partial class Form_lambda : Form
    {

        private string message = "";

        public Form_lambda()
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
            if (label_DisplayInput.Text == "")
            {
                message = "There is no Number";
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

        Func<int, int, int> Add = (a, b) => a + b;
        Func<int, int, int> Subtract = (a, b) => a - b;
        Func<int, int, int> Multiply = (a, b) => a * b;
        Func<int, int, int> Divide = (a, b) => a / b;
        
        private void OperationExecute(Func<int,int,int> op)
        {
            int c = listBox_Stack.Items.Count;

            if (c < 2)
            {
                DisplayMessage("Two Values required");
            }
            else
            {
                int b = int.Parse(listBox_Stack.Items[c - 1].ToString());
                int a = int.Parse(listBox_Stack.Items[c - 2].ToString());

                int result = op(a, b);

                listBox_Stack.Items.RemoveAt(c - 1);
                listBox_Stack.Items.RemoveAt(c - 2);
                listBox_Stack.Items.Add(result.ToString());
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
        private void Delete_Number_click(object sender, EventArgs e)
        {
            label_DisplayInput.Text = "0";
        }
        private void ClearStack_click(object sender, EventArgs e)
        {
            listBox_Stack.Items.Clear();
        }
        private void btn_Divsion_Click(object sender, EventArgs e)
        {
            OperationExecute((a, b) => a / b);
        }
        private void btn_Multiplay_Click(object sender, EventArgs e)
        {
            OperationExecute((a, b) => a * b);
        }
        private void btn_Adding_Click(object sender, EventArgs e)
        {
            OperationExecute(Add);
        }
        private void btn_Subtract_Click(object sender, EventArgs e)
        {
            OperationExecute((a, b) => a - b);
        }
    }
}
