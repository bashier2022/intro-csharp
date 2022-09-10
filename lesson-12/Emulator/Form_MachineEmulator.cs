using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Emulator
{
    public partial class Form_MachineEmulator : Form
    {
        Compiler compilation = new Compiler();
        ProgramExecuter progExec;
        DataStack ProgStack;

        public Form_MachineEmulator()
        {
            InitializeComponent();            
        }

        private void BuildCode()
        {
            string sourceCode = textBox_ProgramCode.Text.Trim();
            string[] progLines = sourceCode.Split('\n');

            int n = progLines.Length;
            for (int i = 0; i<n; i++)
            {
                string line = progLines[i].Trim();
                ComandLine cl = compilation.DecodeComandLine(i, line);
                compilation.programList.Add(cl);
            }
            ProgStack = new DataStack(stackViewerPush, stackViewerPop);
            progExec = new ProgramExecuter(compilation.programList, ProgStack);
            
        }

        private void BuildCode_Click(object sender, EventArgs e)
        {
            compilation = new Compiler();
            listBox_ExeCode.Items.Clear();
            BuildCode();
            for (int i = 0; i<compilation.programList.Count; i++)
            {
                listBox_ExeCode.Items.Add(compilation.programList[i].ToString());
            }
        }
        private  void stackViewerPush(int data)
        {
            listBox_StackViewer.Items.Add(data);
        }
        private  void stackViewerPop()
        {
            listBox_StackViewer.Items.RemoveAt(listBox_StackViewer.Items.Count - 1);
        }
        private void ExecuteStep_Click(object sender, EventArgs e)
        {
            if (!progExec.end)
            {
                ComandLine cl = progExec.ToBeExecutedStep();
                progExec.ExecuteStep(cl);
                textBox_ExecutingMessage.Text = "Executing";
                
            }
            else
            {
                textBox_ExecutingMessage.Text = "STOPED";
            }
            label_PC.Text = $"PC = {progExec.programCounter.ToString()}";
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textBox_ProgramCode.Clear();
        }

        private void Run_Click(object sender, EventArgs e)
        {
            while(!progExec.end)
            {
                btn_ExecuteStep.PerformClick();
            }
            textBox_ExecutingMessage.Text = "STOPED";
        }
    }
}
