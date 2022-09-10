using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emulator
{
    public class ExecutingComponents
    {
        public DataStack _dataStack;
        public DataStack _ipStack;
        public Controller _controller;
        public int _operand;

        public ExecutingComponents(DataStack dataStack, DataStack ipStack, Controller controller, int operand)
        {
            _dataStack = dataStack;
            _ipStack = ipStack;
            _controller = controller;
            _operand = operand;
        } 
        
       
    }
    public class FunctionMap
    {
        private OpCodeEnum _opCode;
        private int _arity;
        private Func<ExecutingComponents, bool> _exeCodeFunction;

        public OpCodeEnum opCode => _opCode;
        public FunctionMap(OpCodeEnum opCode,int arity, Func<ExecutingComponents, bool> exeCodeFunction)
        {
            _opCode = opCode;
            _arity = arity;
            _exeCodeFunction = exeCodeFunction;
        }

        Func<ExecutingComponents, bool> PUSHIP = (exeComp) =>
        {
            ++exeComp._controller.PC;
            exeComp._ipStack.PUSH(exeComp._operand);
            return true;
        };
        Func<ExecutingComponents, bool> DROPIP = (exeComp) =>
        {
            exeComp._controller.PC = exeComp._ipStack.POP();
            return true;
        };
        Func<ExecutingComponents, bool> POPIP = (exeComp) =>
        {
            ++exeComp._controller.PC;
            exeComp._ipStack.POP();
            return true;
        };
        Func<ExecutingComponents, bool> NOP = (exeComp) =>
        {
            ++exeComp._controller.PC;
            return true;
        };
        Func<ExecutingComponents, bool> PUSH = (exeComp) =>
        {
            ++exeComp._controller.PC;            
            exeComp._dataStack.PUSH(exeComp._operand);
            return true;
        };
        Func<ExecutingComponents, bool> DROP = (exeComp) =>
        {
            ++exeComp._controller.PC;
            exeComp._dataStack.POP();
            return true;
        };
        Func<ExecutingComponents, bool> ROL3 = (exeComp) =>
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
        Func<ExecutingComponents, bool> ADD = (exeComp) =>
        {
            ++exeComp._controller.PC;
            int a = exeComp._dataStack.POP();
            int b = exeComp._dataStack.POP();
            exeComp._dataStack.PUSH(b+a);
            return true;
        };
        Func<ExecutingComponents, bool> SUB = (exeComp) =>
        {
            ++exeComp._controller.PC;
            int a = exeComp._dataStack.POP();
            int b = exeComp._dataStack.POP();
            exeComp._dataStack.PUSH(b - a);
            return true;
        };
        Func<ExecutingComponents, bool> MUL = (exeComp) =>
        {
            ++exeComp._controller.PC;
            int a = exeComp._dataStack.POP();
            int b = exeComp._dataStack.POP();
            exeComp._dataStack.PUSH(b * a);
            return true;
        };
        Func<ExecutingComponents, bool> DIV = (exeComp) =>
        {
            ++exeComp._controller.PC;
            int a = exeComp._dataStack.POP();
            int b = exeComp._dataStack.POP();
            exeComp._dataStack.PUSH(b / a);
            return true;
        };
        Func<ExecutingComponents, bool> MOD = (exeComp) =>
        {
            ++exeComp._controller.PC;
            int a = exeComp._dataStack.POP();
            int b = exeComp._dataStack.POP();
            exeComp._dataStack.PUSH(b % a);
            return true;
        };
        Func<ExecutingComponents, bool> CMP = (exeComp) =>
        {
            ++exeComp._controller.PC;
            int a = exeComp._dataStack.POP();
            int b = exeComp._dataStack.POP();
            if (b>a)
            { exeComp._dataStack.PUSH(1); }
            else if (b<a) { exeComp._dataStack.PUSH(-1); }
            else { exeComp._dataStack.PUSH(0); }
            return true;
        };
        Func<ExecutingComponents, bool> SWAP = (exeComp) =>
        {
            ++exeComp._controller.PC;
            int a = exeComp._dataStack.POP();
            int b = exeComp._dataStack.POP();
            exeComp._dataStack.PUSH(a);
            exeComp._dataStack.PUSH(b);
            return true;
        };
        Func<ExecutingComponents, bool> INC= (exeComp) =>
        {
            ++exeComp._controller.PC;
            int a = exeComp._dataStack.POP();
            a++;
            exeComp._dataStack.PUSH(a);
            return true;
        };
        Func<ExecutingComponents, bool> DEC = (exeComp) =>
        {
            ++exeComp._controller.PC;
            int a = exeComp._dataStack.POP();
            a--;
            exeComp._dataStack.PUSH(a);
            return true;
        };
        Func<ExecutingComponents, bool> NEG = (exeComp) =>
        {
            ++exeComp._controller.PC;
            int a = exeComp._dataStack.POP();
            a = -a;
            exeComp._dataStack.PUSH(a);
            return true;
        };
        Func<ExecutingComponents, bool> DUP = (exeComp) =>
        {
            ++exeComp._controller.PC;
            int a = exeComp._dataStack.TOP();
            exeComp._dataStack.PUSH(a);
            return true;
        };
        Func<ExecutingComponents, bool> JZ = (exeComp) =>
        {
            ++exeComp._controller.PC;
            int a = exeComp._dataStack.POP();
            if (a == 0)
            {
                exeComp._controller.PC = exeComp._operand;
            }
            return true;
        };
        Func<ExecutingComponents, bool> JNZ = (exeComp) =>
        {
            ++exeComp._controller.PC;
            int a = exeComp._dataStack.POP();
            if (a != 0)
            {
                exeComp._controller.PC = exeComp._operand;
            }
            return true;
        };

    }

   
   
}
