using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emulator
{
    public class ProgramExecuter
    {
        public int programCounter = 0;
       
        bool pcUpdated = false;
        
        private List<Instruction> _instructions;
        private DataStack _stack;
        public ProgramExecuter(List<Instruction> instructions, DataStack stack)
        {
            _instructions = instructions;
            _stack = stack;
        }

        public bool IsHalted =>    programCounter >= _instructions.Count 
                                || CurrentInstruction()._opCode == OpCodeEnum.HLT;

        private Instruction CurrentInstruction() => _instructions[programCounter];
        
        private bool HaveEnoughParameters(int n)
        {
            if (_instructions.Count > 0)
            {
                return true;
            }
            else
            {
               
            }
            programCounter = _instructions.Count;
            pcUpdated = true;
            return false;

        }
        public bool ExecuteStep()
        {
            if (IsHalted)
            {
                return false;
            }

            var instruction = CurrentInstruction();

            int a, b, c, d;
            pcUpdated = false;
            switch ((int)instruction._opCode)
            {
                case 0: // NOP
                    break;
                case 1: // PUSH
                    a = instruction._operand;
                    _stack.PUSH(a);
                    break;
                case 2: // DROP
                    if (HaveEnoughParameters(1))
                    {
                        _stack.POP();
                    }
                    break;
                case 3: // ADD
                    if (HaveEnoughParameters(2))
                    {
                        a = _stack.POP();
                        b = _stack.POP();
                        _stack.PUSH(b + a);
                    }

                    break;
                case 4: // SUB
                    if (HaveEnoughParameters(2))
                    {
                        a = _stack.POP();
                        b = _stack.POP();
                        _stack.PUSH(b - a);
                    }
                    break;
                case 5: // MUL
                    if (HaveEnoughParameters(2))
                    {
                        a = _stack.POP();
                        b = _stack.POP();
                        _stack.PUSH(b * a);
                    }
                    break;
                case 6: // DIV
                    if (HaveEnoughParameters(2))
                    {
                        a = _stack.POP();
                        b = _stack.POP();
                        if (a != 0)
                        {
                            _stack.PUSH(b / a);
                        }
                        else
                        {
                           
                        }
                    }
                    break;
                case 7: // MOD
                    if (HaveEnoughParameters(2))
                    {
                        a = _stack.POP();
                        b = _stack.POP();
                        if (a != 0)
                        {
                            _stack.PUSH(b % a);
                        }
                        else
                        {
                            
                        }
                    }
                    break;
                case 8: // INC
                    if (HaveEnoughParameters(1))
                    {
                        a = _stack.POP();
                        a++;
                        _stack.PUSH(a);
                    }
                    break;
                case 9: // DEC
                    if (HaveEnoughParameters(1))
                    {
                        a = _stack.POP();
                        a--;
                        _stack.PUSH(a);
                    }
                    break;
                case 10: // NEG
                    if (HaveEnoughParameters(1))
                    {
                        a = _stack.POP();
                        a = -a;
                        _stack.PUSH(a);
                    }
                    break;
                case 11: //DUP
                    if (HaveEnoughParameters(1))
                    {
                        a = _stack.TOP();
                        _stack.PUSH(a);
                    }
                    break;
                case 12: // CMP
                    if (HaveEnoughParameters(2))
                    {
                        a = _stack.POP();
                        b = _stack.POP();
                        if (b > a)
                        {
                            _stack.PUSH(1);
                        }
                        else if (b < a)
                        {
                            _stack.PUSH(-1);
                        }
                        _stack.PUSH(0);
                    }
                    break;
                case 13: // SWAP
                    if (HaveEnoughParameters(2))
                    {
                        a = _stack.POP();
                        b = _stack.POP();
                        _stack.PUSH(a);
                        _stack.PUSH(b);
                    }
                    break;
                case 14: // ROL3
                    if (HaveEnoughParameters(3))
                    {
                        a = _stack.POP();
                        b = _stack.POP();
                        c = _stack.POP();
                        _stack.PUSH(b);
                        _stack.PUSH(c);
                        _stack.PUSH(a);
                    }
                    break;
                case 15: // HLT                                      
                    pcUpdated = true;
                    break;
                case 16: //JZ
                    if (HaveEnoughParameters(1))
                    {
                        a = _stack.POP();
                        if (a == 0)
                        {
                            programCounter = 0;
                            pcUpdated = true;
                        }
                    }
                    break;
                case 17: //JNZ
                    if (HaveEnoughParameters(1))
                    {
                        a = _stack.POP();
                        if (a != 0)
                        {
                            programCounter = 1;
                            pcUpdated = true;
                        }
                    }
                    break;
            }
            
            if (!pcUpdated)
            {
                programCounter++;
            }
            
          

            return true;
        }
    }
}
