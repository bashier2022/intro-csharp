using System;
using System.Windows.Forms;
using System.Drawing;


namespace Emulator
{
    //public class Viewers
    //{
    //    public Action<int> viewProgStackPush;
    //    public Action viewProgStackPop;
    //    public Action<int> viewIpStackPush;
    //    public Action viewIpStackPop;
    //    public Action<string, Bitmap> viewMemoryData;
    //    public Action<int> viewPc;
    //}
    public partial class Form_MachineEmulator : Form
    {   
        
        private ProgramExecuter _executor;        
        
        public Form_MachineEmulator()
        {
            InitializeComponent();
 
            textBox_ProgramCode.Text = DemoPrograms.SimpleWithJumpsIPstore;
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
            Viewers viewers = new Viewers();
            viewers.viewProgStackPush = stackViewerPush;
            viewers.viewProgStackPop = stackViewerPop;
            viewers.viewIpStackPush = IPstackViewerPush;
            viewers.viewIpStackPop = IPstackViewerPop;
            viewers.viewMemoryData = memoryViewer;
            viewers.viewPc = PcViewer;
            viewers.viewProcessMessage = ProcessMessageViewer;
            _executor = new ProgramExecuter(opcodes, viewers);

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
            if (listBox_StackViewer.Items.Count > 0)
            {
                listBox_StackViewer.Items.RemoveAt(listBox_StackViewer.Items.Count - 1);
            }
        }
        private void IPstackViewerPush(int data)
        {
            listBox_IPStackViewer.Items.Add(data);
        }
        private void IPstackViewerPop()
        {
            if (listBox_IPStackViewer.Items.Count>0)
            {
                listBox_IPStackViewer.Items.RemoveAt(listBox_IPStackViewer.Items.Count - 1);
            }
        }
        private void PcViewer(int data)
        {
            label_PC.Text =  $"PC: {data}";
        }
        private void ProcessMessageViewer(string message)
        {
            textBox_ExecutingMessage.Text = message;
        }
        private void ExecuteStep_Click(object sender, EventArgs e)
        {
            _executor.ExecuteStep();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            //textBox_ProgramCode.Clear();
            listBox_ExeCode.Items.Clear();
            _executor.Reset();


        }

        private void Run_Click(object sender, EventArgs e)
        {
            while (_executor.ExecuteStep()) { }
            //while(!_executor.IsHalted)
            //{
            //    btn_ExecuteStep.PerformClick();
            //}
        }
    }
    public class Viewers
    {
        public Action<int> viewProgStackPush;
        public Action viewProgStackPop;
        public Action<int> viewIpStackPush;
        public Action viewIpStackPop;
        public Action<string, Bitmap> viewMemoryData;
        public Action<int> viewPc;
        public Action<string> viewProcessMessage;
    }
}
