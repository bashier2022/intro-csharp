using System;
using System.Windows.Forms;
using System.Drawing;

namespace Emulator
{
    public partial class Form_MachineEmulator : Form
    {        
        private ProgramExecuter _executor;        
        private ExecutingComponents _executingComponents;
        
        public Form_MachineEmulator()
        {
            InitializeComponent();
            _executingComponents = new ExecutingComponents();
            _executingComponents._controller = new Controller();
            _executingComponents._dataStack = new DataStack(stackViewerPush, stackViewerPop);
            _executingComponents._ipStack= new DataStack(IPstackViewerPush, IPstackViewerPop);
            _executingComponents._memory = new Memory(memoryViewer, 32);

            //textBox_ProgramCode.Text = DemoPrograms.SimpleWithJumpsIP;
        }

        private void BuildCode_Click(object sender, EventArgs e)
        {           
            var compiler = new Compiler();
            string sourceCode = textBox_ProgramCode.Text.Trim();
            var opcodes = compiler.BuildCode(sourceCode);

            listBox_ExeCode.Items.Clear();
            int label = 0;
            foreach (var opcode in opcodes)
            {
                listBox_ExeCode.Items.Add($"{label++}: {opcode.ToString()}");
            }

            _executor = new ProgramExecuter(opcodes, _executingComponents);

            label_PC.Text = "PC: 0";
            listBox_StackViewer.Items.Clear();
        }

        private void memoryViewer(string memStr , Bitmap memImage)
        {
            textBox_MemoryDisplay.Text = memStr;
            pictureBox_MemoryImage.Image = memImage;
        }
        private  void stackViewerPush(int data)
        {
            listBox_StackViewer.Items.Add(data);
        }
        private  void stackViewerPop()
        {
            listBox_StackViewer.Items.RemoveAt(listBox_StackViewer.Items.Count - 1);
        }
        private void IPstackViewerPush(int data)
        {
            listBox_IPStackViewer.Items.Add(data);
        }
        private void IPstackViewerPop()
        {
            listBox_IPStackViewer.Items.RemoveAt(listBox_IPStackViewer.Items.Count - 1);
        }
        private void ExecuteStep_Click(object sender, EventArgs e)
        {
            if (_executor.IsHalted)
            {
                textBox_ExecutingMessage.Text = "STOPED";                
            }
            else
            {
                
                if (_executor.ExecuteStep())
                {
                    textBox_ExecutingMessage.Text = "Executing";
                }
                else
                {
                    textBox_ExecutingMessage.Text = "Halting on Error";
                }
                

                label_PC.Text = $"PC: {_executingComponents._controller.PC}";
            }
            
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textBox_ProgramCode.Clear();
            listBox_StackViewer.Items.Clear();
            listBox_ExeCode.Items.Clear();

            _executingComponents = new ExecutingComponents();
            _executingComponents._controller = new Controller();
            _executingComponents._dataStack = new DataStack(stackViewerPush, stackViewerPop);
            _executingComponents._ipStack= new DataStack(IPstackViewerPush, IPstackViewerPop);
            _executingComponents._memory = new Memory(memoryViewer, 32);

        }

        private void Run_Click(object sender, EventArgs e)
        {
            while(!_executor.IsHalted)
            {
                btn_ExecuteStep.PerformClick();
            }
            textBox_ExecutingMessage.Text = "STOPED";
        }
    }
}
