using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emulator
{
    public class Controller
    {
        public int PC { get; set; } = 0;
    }

    public class ProgramExecuter
    {
        
        private ExecutingComponents _executionComponents;
        private List<Instruction> _instructions;
        
        public ProgramExecuter(List<Instruction> instructions, ExecutingComponents executionComponents)
        {
            _instructions = instructions;
            _executionComponents = executionComponents;
            
        }

        public bool IsHalted =>    _executionComponents._controller.PC >= _instructions.Count 
                                || CurrentInstruction()._opCode == OpCodeEnum.HLT;

        private Instruction CurrentInstruction() => _instructions[_executionComponents._controller.PC];
        
        private bool NotEnoughParameters(DataStack st, int n) => n > st.Count;
            
        public bool ExecuteStep()
        {
            if (IsHalted)
            {
                return false;
            }

            var instruction = CurrentInstruction();
            if (NotEnoughParameters(_executionComponents._dataStack, instruction._argc))
            {
                _executionComponents._controller.PC = _instructions.Count;
                return false;
            }

            return instruction.Execute(_executionComponents, instruction._operand); //(_stack, _controller, _ipStack);                                    
        }
    }
}
