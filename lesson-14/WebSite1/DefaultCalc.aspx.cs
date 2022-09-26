using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;


public partial class DefaultCalc : System.Web.UI.Page
{
    int _id;
    
    private void Page_Load(object sender, EventArgs e)
    {
        textBox_ProgramCode.Text = DemoPrograms.SimpleWithJumpsIPstore;
        //Session.Timeout = 1;
        //Application.
        _id = GetHashCode();
    }


    private void memoryViewer(ListItemCollection items, Bitmap memImage)
    {
        ListBoxMemoryData.Items.Clear();
        foreach(ListItem item in items)
        {
            ListBoxMemoryData.Items.Add(item);
        }        
        //ImageMap_MemoryViewer. = memImage;
        //ImageMemory. = memImage.ToString();
    }
    private void stackViewerPush(int data)
    {
        listBox_StackViewer.Items.Add(data.ToString());
    }
    private void stackViewerPop()
    {
        if (listBox_StackViewer.Items.Count > 0)
        {
            listBox_StackViewer.Items.RemoveAt(listBox_StackViewer.Items.Count - 1);
        }
    }
    private void IPstackViewerPush(int data)
    {
        listBox_IPStackViewer.Items.Add(data.ToString());
    }
    private void IPstackViewerPop()
    {
        if (listBox_IPStackViewer.Items.Count > 0)
        {
            listBox_IPStackViewer.Items.RemoveAt(listBox_IPStackViewer.Items.Count - 1);
        }
    }
    private void PcViewer(int data)
    {
        tbxPcValue.Text = $"{data}";
    }
    private void ProcessMessageViewer(string message)
    {
        textBox_ExecutingMessage.Text = message;
    }

    private void DisplayViewers(Viewers v)
    {
        listBox_IPStackViewer.Items.Add(v.viewProgStackPush.Method.Name.ToString());
        listBox_IPStackViewer.Items.Add(v.viewProgStackPop.Method.Name.ToString());
        listBox_IPStackViewer.Items.Add(v.viewIpStackPush.Method.Name.ToString());
        listBox_IPStackViewer.Items.Add(v.viewIpStackPop.Method.Name.ToString());
        listBox_IPStackViewer.Items.Add(v.viewMemoryData.Method.Name.ToString());
        listBox_IPStackViewer.Items.Add(v.viewPc.Method.Name.ToString());
        listBox_IPStackViewer.Items.Add(v.viewProcessMessage.Method.Name.ToString());
    }
    private void CreateProgramExecuter(List<Instruction> instructions, Viewers viewers)
    {
        var _executor = new ProgramExecuter(instructions, viewers);
        Session["X"]= _executor;
    }
    
    protected void BuildCode_Click(object sender, EventArgs e)
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
        Viewers viewers = GetViewers();
        //DisplayViewers(viewers);
        //_executor = new ProgramExecuter(opcodes, viewers);
        lblPC.Text = "PC:";
        PcViewer(0);
        CreateProgramExecuter(opcodes, viewers);
        listBox_StackViewer.Items.Clear();
    }

    private Viewers GetViewers()
    {
        var viewers = new Viewers();

        viewers.viewProgStackPush = stackViewerPush;
        viewers.viewProgStackPop = stackViewerPop;
        viewers.viewIpStackPush = IPstackViewerPush;
        viewers.viewIpStackPop = IPstackViewerPop;
        viewers.viewMemoryData = memoryViewer;
        viewers.viewPc = PcViewer;
        viewers.viewProcessMessage = ProcessMessageViewer;
        return viewers;
    }


    protected void ExecuteStep_Click(object sender, EventArgs e)
    {
        var _executor =(ProgramExecuter) Session["X"];
        _executor.ExecuteStep(GetViewers());
    }



    protected void Run_Click(object sender, EventArgs e)
    {
        var _executor = (ProgramExecuter)Session["X"];
        while (_executor.ExecuteStep(GetViewers()))
        {
        }
    }
}