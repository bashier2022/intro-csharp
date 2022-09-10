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

        public Instruction(OpCodeEnum opCode, int operand)
        {            
            _opCode = opCode;
            _operand = operand;
        }

        public override string ToString()
        {
            var operand = _operand == 0 ? string.Empty : $" {_operand}";
            return $"{_opCode}{operand}";
        }
    }
}
