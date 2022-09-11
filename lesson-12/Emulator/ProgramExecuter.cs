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
                return false;
            }

            var instruction = CurrentInstruction();
            if (IsNotExecutable(instruction))
            {
                _executionComponents._controller.PC = _instructions.Count;
                return false;
            }

            return instruction.Execute(_executionComponents, instruction._operand);                                   
        }

        private bool IsNotExecutable(Instruction instruction)
        {
            if (IsIpPopOperation(instruction) && _executionComponents._ipStack.Count == 0) return true;
            if (IsDataPopOperation(instruction) && _executionComponents._dataStack.Count == 0) return true;
            if (instruction._argc > _executionComponents._dataStack.Count) return true;
            return false;
        }
    }
}
