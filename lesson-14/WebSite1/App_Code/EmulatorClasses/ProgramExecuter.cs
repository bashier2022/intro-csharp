using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Drawing;
using System.Text;


/// <summary>
/// Summary description for ProgramExecuter
/// </summary>
/// 
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
public class Controller
{
    private int _pc = 0;
    private Action<int> _viewPc;
    public Controller(Action<int> viewPc)
    {
        if (viewPc != null)
        {
            _viewPc = viewPc;
        }
    }
    private void OnChange()
    {
        _viewPc(PC);
    }
    public void Reset()
    {
        PC = 0;
    }
    public int PC
    {
        get
        {
            return _pc;
        }
        set
        {
            _pc = value;
            OnChange();
        }
    }
}
public class ProgramExecuter
{
    private ExecutingComponents _executionComponents;
    private List<Instruction> _instructions;

    private Viewers _view;
    public ProgramExecuter(List<Instruction> instructions, Viewers viewers)
    {
        _instructions = instructions;
        _view = viewers;
        SetParameters();
    }

    private void SetParameters()
    {
        _executionComponents = new ExecutingComponents();
        _executionComponents._controller = new Controller(_view.viewPc);
        _executionComponents._dataStack = new DataStack(_view.viewProgStackPush, _view.viewProgStackPop);
        _executionComponents._ipStack = new DataStack(_view.viewIpStackPush, _view.viewIpStackPop);
        _executionComponents._memory = new Memory(_view.viewMemoryData, 16);

    }

    public bool IsHalted => _executionComponents._controller.PC >= _instructions.Count
                            || CurrentInstruction()._opCode == OpCodeEnum.HLT;

    private Instruction CurrentInstruction() => _instructions[_executionComponents._controller.PC];

    private bool IsIpPopOperation(Instruction intstruction)
    {
        return intstruction._opCode == OpCodeEnum.POPIP || intstruction._opCode == OpCodeEnum.DROPIP;
    }
    private bool IsDataPopOperation(Instruction intstruction)
    {
        return intstruction._opCode == OpCodeEnum.DROP;
    }
    public bool ExecuteStep()
    {

        if (IsHalted)
        {
            _view.viewProcessMessage("Halted");
            return false;
        }

        var instruction = CurrentInstruction();
        if (IsNotExecutable(instruction))
        {
            _executionComponents._controller.PC = _instructions.Count;
            _view.viewProcessMessage("Error: NOT Executable Instruction");
            return false;
        }
        _view.viewProcessMessage("Proceeding Execution");
        return instruction.Execute(_executionComponents, instruction._operand);
    }

    private bool IsNotExecutable(Instruction instruction)
    {
        if (IsIpPopOperation(instruction) && _executionComponents._ipStack.Count == 0) return true;
        if (IsDataPopOperation(instruction) && _executionComponents._dataStack.Count == 0) return true;
        if (instruction._argc > _executionComponents._dataStack.Count) return true;
        return false;
    }

    internal void Reset()
    {
        _executionComponents._controller.Reset();
        _executionComponents._dataStack.CLEAR();
        _executionComponents._ipStack.CLEAR();
        _executionComponents._memory = new Memory(_view.viewMemoryData, 16);
    }
}