using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for FunctionMap
/// </summary>
public class ExecutingComponents
{
    public DataStack _dataStack;
    public DataStack _ipStack;
    public Controller _controller;
    public Memory _memory;
    public ExecutingComponents() { }
    public ExecutingComponents(DataStack dataStack, DataStack ipStack, Controller controller, Memory memory)
    {
        _dataStack = dataStack;
        _ipStack = ipStack;
        _controller = controller;
        _memory = memory;
    }
}
public class FunctionMap
{
    public FunctionMap() { }
    public Func<ExecutingComponents, int, bool> LOAD = (exeComp, arg) =>
    {
        ++exeComp._controller.PC;
        int val = exeComp._memory.Load(arg);
        exeComp._dataStack.PUSH(val);
        return true;
    };
    public Func<ExecutingComponents, int, bool> STORE = (exeComp, arg) =>
    {
        ++exeComp._controller.PC;
        short val = (short)exeComp._dataStack.TOP();
        exeComp._memory.Store(arg, val);
        return true;
    };
    public Func<ExecutingComponents, int, bool> PUSHIP = (exeComp, arg) =>
    {
        ++exeComp._controller.PC;
        exeComp._ipStack.PUSH(arg);
        return true;
    };
    public Func<ExecutingComponents, int, bool> DROPIP = (exeComp, arg) =>
    {
        exeComp._controller.PC = exeComp._ipStack.POP();
        return true;
    };
    public Func<ExecutingComponents, int, bool> POPIP = (exeComp, arg) =>
    {
        ++exeComp._controller.PC;
        exeComp._ipStack.POP();
        return true;
    };
    public Func<ExecutingComponents, int, bool> NOP = (exeComp, arg) =>
    {
        ++exeComp._controller.PC;
        return true;
    };
    public Func<ExecutingComponents, int, bool> PUSH = (exeComp, arg) =>
    {
        ++exeComp._controller.PC;
        exeComp._dataStack.PUSH(arg);
        return true;
    };
    public Func<ExecutingComponents, int, bool> DROP = (exeComp, arg) =>
    {
        ++exeComp._controller.PC;
        exeComp._dataStack.POP();
        return true;
    };
    public Func<ExecutingComponents, int, bool> ROL3 = (exeComp, arg) =>
    {
        ++exeComp._controller.PC;
        int a = exeComp._dataStack.POP();
        int b = exeComp._dataStack.POP();
        int c = exeComp._dataStack.POP();
        exeComp._dataStack.PUSH(b);
        exeComp._dataStack.PUSH(c);
        exeComp._dataStack.PUSH(a);
        return true;
    };
    public Func<ExecutingComponents, int, bool> ADD = (exeComp, arg) =>
    {
        ++exeComp._controller.PC;
        int a = exeComp._dataStack.POP();
        int b = exeComp._dataStack.POP();
        exeComp._dataStack.PUSH(b + a);
        return true;
    };
    public Func<ExecutingComponents, int, bool> SUB = (exeComp, arg) =>
    {
        ++exeComp._controller.PC;
        int a = exeComp._dataStack.POP();
        int b = exeComp._dataStack.POP();
        exeComp._dataStack.PUSH(b - a);
        return true;
    };
    public Func<ExecutingComponents, int, bool> MUL = (exeComp, arg) =>
    {
        ++exeComp._controller.PC;
        int a = exeComp._dataStack.POP();
        int b = exeComp._dataStack.POP();
        exeComp._dataStack.PUSH(b * a);
        return true;
    };
    public Func<ExecutingComponents, int, bool> DIV = (exeComp, arg) =>
    {
        ++exeComp._controller.PC;
        int a = exeComp._dataStack.POP();
        int b = exeComp._dataStack.POP();
        exeComp._dataStack.PUSH(b / a);
        return true;
    };
    public Func<ExecutingComponents, int, bool> MOD = (exeComp, arg) =>
    {
        ++exeComp._controller.PC;
        int a = exeComp._dataStack.POP();
        int b = exeComp._dataStack.POP();
        exeComp._dataStack.PUSH(b % a);
        return true;
    };
    public Func<ExecutingComponents, int, bool> CMP = (exeComp, arg) =>
    {
        ++exeComp._controller.PC;
        int a = exeComp._dataStack.POP();
        int b = exeComp._dataStack.POP();
        if (b > a)
        { exeComp._dataStack.PUSH(1); }
        else if (b < a) { exeComp._dataStack.PUSH(-1); }
        else { exeComp._dataStack.PUSH(0); }
        return true;
    };
    public Func<ExecutingComponents, int, bool> SWAP = (exeComp, arg) =>
    {
        ++exeComp._controller.PC;
        int a = exeComp._dataStack.POP();
        int b = exeComp._dataStack.POP();
        exeComp._dataStack.PUSH(a);
        exeComp._dataStack.PUSH(b);
        return true;
    };
    public Func<ExecutingComponents, int, bool> INC = (exeComp, arg) =>
    {
        ++exeComp._controller.PC;
        int a = exeComp._dataStack.POP();
        a++;
        exeComp._dataStack.PUSH(a);
        return true;
    };
    public Func<ExecutingComponents, int, bool> DEC = (exeComp, arg) =>
    {
        ++exeComp._controller.PC;
        int a = exeComp._dataStack.POP();
        if (a > 0) a--;
        exeComp._dataStack.PUSH(a);
        return true;
    };
    public Func<ExecutingComponents, int, bool> NEG = (exeComp, arg) =>
    {
        ++exeComp._controller.PC;
        int a = exeComp._dataStack.POP();
        a = -a;
        exeComp._dataStack.PUSH(a);
        return true;
    };
    public Func<ExecutingComponents, int, bool> DUP = (exeComp, arg) =>
    {
        ++exeComp._controller.PC;
        int a = exeComp._dataStack.TOP();
        exeComp._dataStack.PUSH(a);
        return true;
    };
    public Func<ExecutingComponents, int, bool> HLT = (exeComp, arg) =>
    {
        return false;
    };
    public Func<ExecutingComponents, int, bool> JMP = (exeComp, arg) =>
    {
        exeComp._controller.PC = arg;
        return true;
    };
    public Func<ExecutingComponents, int, bool> JZ = (exeComp, arg) =>
    {
        ++exeComp._controller.PC;
        int a = exeComp._dataStack.POP();
        if (a == 0)
        {
            exeComp._controller.PC = arg;
        }
        return true;
    };
    public Func<ExecutingComponents, int, bool> JNZ = (exeComp, arg) =>
    {
        ++exeComp._controller.PC;
        int a = exeComp._dataStack.POP();
        if (a != 0)
        {
            exeComp._controller.PC = arg;
        }
        return true;
    };

}