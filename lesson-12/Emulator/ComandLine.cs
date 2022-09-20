using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emulator
{
    public class Instruction
    {        
        public OpCodeEnum _opCode;
        public int _operand; //  because what to do if not operand???
        public int _argc;

        private Func<ExecutingComponents, int, bool> _execute;
        public Instruction(OpCodeEnum opCode, int operand, int argc, Func<ExecutingComponents, int, bool> execute)
        {
            _opCode = opCode;
            _operand = operand;
            _argc = argc;
            _execute = execute;
        }

        public override string ToString()
        {
            string operand = ""; //_operand == 0 ? string.Empty : $" {_operand}";
            if (_opCode == OpCodeEnum.PUSH || _opCode == OpCodeEnum.JNZ || _opCode == OpCodeEnum.JZ ||
                _opCode == OpCodeEnum.PUSHIP || _opCode == OpCodeEnum.STORE || _opCode == OpCodeEnum.LOAD)
            {
                operand = _operand.ToString();
            }
            return $"{_opCode} {operand}";
        }

        public bool Execute(ExecutingComponents exeComponents, int operand)
        {
            return _execute(exeComponents, operand);
        }

         
    }
}
