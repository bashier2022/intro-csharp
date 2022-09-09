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
        public bool end = false;
        bool pcUpdated = false;
        List<ComandLine> programList;
        DataStack progStack;
        public ProgramExecuter(List<ComandLine> progList, DataStack progDataStack)
        {
            programList = progList;
            progStack = progDataStack;
        }
        public ComandLine ToBeExecutedStep()
        {
            return programList[programCounter];
        }

        private bool HaveEnoughParameters(int n)
        {
            if (programList.Count > 0)
            {
                return true;
            }
            else
            {
                end = true;
            }
            programCounter = programList.Count;
            pcUpdated = true;
            return false;

        }
        public bool ExecuteStep(ComandLine cl)
        {
            int a, b, c, d;
            pcUpdated = false;
            switch (cl.comandCode)
            {
                case 0: // NOP
                    break;
                case 1: // PUSH
                    a= int.Parse(cl.value);
                    progStack.PUSH(a);
                    break;
                case 2: // DROP
                    if (HaveEnoughParameters(1))
                    {
                        progStack.POP();
                    }
                    break;
                case 3: // ADD
                    if (HaveEnoughParameters(2))
                    {
                        a= progStack.POP();
                        b= progStack.POP();
                        progStack.PUSH(b+a);
                    }
                    
                    break;
                case 4: // SUB
                    if (HaveEnoughParameters(2))
                    {
                        a= progStack.POP();
                        b= progStack.POP();
                        progStack.PUSH(b - a);
                    }
                    break;
                case 5: // MUL
                    if (HaveEnoughParameters(2))
                    {
                        a= progStack.POP();
                        b= progStack.POP();
                        progStack.PUSH(b * a);
                    }
                    break;
                case 6: // DIV
                    if (HaveEnoughParameters(2))
                    {
                        a= progStack.POP();
                        b= progStack.POP();
                        if (a!=0)
                        {
                            progStack.PUSH(b / a);
                        }
                        else
                        {
                            end = true;
                        }
                    }
                    break;
                case 7: // MOD
                    if (HaveEnoughParameters(2))
                    {
                        a= progStack.POP();
                        b= progStack.POP();
                        if (a!=0)
                        {
                            progStack.PUSH(b % a);
                        }
                        else
                        {
                            end = true;
                        }
                    }
                    break;
                case 8: // INC
                    if (HaveEnoughParameters(1))
                    {
                        a= progStack.POP();
                        a++;
                        progStack.PUSH(a);
                    }
                    break;
                case 9: // DEC
                    if (HaveEnoughParameters(1))
                    {
                        a= progStack.POP();
                        a--;
                        progStack.PUSH(a);
                    }
                    break;
                case 10: // NEG
                    if (HaveEnoughParameters(1))
                    {
                        a= progStack.POP();
                        a=-a;
                        progStack.PUSH(a);
                    }
                    break;
                case 11: //DUP
                    if (HaveEnoughParameters(1))
                    {
                        a= progStack.TOP();
                        progStack.PUSH(a);
                    }
                    break;
                case 12: // CMP
                    if (HaveEnoughParameters(2))
                    {
                        a= progStack.POP();
                        b= progStack.POP();
                        if (b>a)
                        {
                            progStack.PUSH(1);
                        }
                        else if (b<a)
                        {
                            progStack.PUSH(-1);
                        }
                        progStack.PUSH(0);
                    }
                    break;
                case 13: // SWAP
                    if (HaveEnoughParameters(2))
                    {
                        a= progStack.POP();
                        b= progStack.POP();
                        progStack.PUSH(a);
                        progStack.PUSH(b);
                    }
                    break;
                case 14: // ROL3
                    if (HaveEnoughParameters(3))
                    {
                        a= progStack.POP();
                        b= progStack.POP();
                        c= progStack.POP();
                        progStack.PUSH(b);
                        progStack.PUSH(c);
                        progStack.PUSH(a);
                    }
                    break;
                case 15: // HLT
                    end = true;
                    programCounter = programList.Count;
                    pcUpdated = true;
                    break;
                case 16:
                    if (HaveEnoughParameters(1))
                    {
                        a = progStack.POP();
                        if (a == 0)
                        {
                            programCounter = int.Parse(cl.value);
                            pcUpdated = true;
                        }
                    }
                    break;
                case 17:
                    if (HaveEnoughParameters(1))
                    {
                        a = progStack.POP();
                        if (a != 0)
                        {
                            programCounter = int.Parse(cl.value);
                            pcUpdated = true;
                        }
                    }
                    break;
            }
            if (!pcUpdated)
            {
                programCounter++;                
            }
            if (programCounter > programList.Count-1)
            {
                end = true;
            }
            return end;
        }
    }
}
