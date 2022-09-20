using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emulator
{
    public class Compiler
    {
        OpCodeDictionary opCodeDict = new OpCodeDictionary(new FunctionMap());
        private Instruction decodeLine(string line)
        {
           // OpCodeDictionary opCodeDict = new OpCodeDictionary(new FunctionMap());

            string[] parts = line.Split(' ');
            if( parts.Length > 0)
            {               
                var opCodeText = parts[0].Trim().ToUpper();
                //Func<ExecutingComponents, int, bool> exeFunf;
                var  (opCode, argc, exeFunf) = opCodeDict.Get(opCodeText);
                if( opCode == OpCodeEnum.PUSH || opCode == OpCodeEnum.JNZ || opCode == OpCodeEnum.JZ || 
                    opCode == OpCodeEnum.PUSHIP || opCode== OpCodeEnum.STORE || opCode== OpCodeEnum.LOAD)
                {
                    if(parts.Length > 1 && int.TryParse(parts[1].Trim(), out var operand))
                    {
                        return new Instruction(opCode, operand, argc, exeFunf);
                    }
                    else
                    {
                        //TODO: report an error
                        return new Instruction(opCode, 9999, argc, exeFunf);
                    }
                }
                else
                {
                    return new Instruction(opCode, 0, argc, exeFunf);
                }
            }
            else
            {
                return null;
            }                      
        }

        public List<Instruction> BuildCode(string source)
        {
            var instructions = new List<Instruction>();

            source = source.Trim();
            string[] sourceLines = source.Split('\n');
            
            if(sourceLines.Length == 0)
            {
                instructions.Add(decodeLine("HLT"));
                return instructions;
            }
            
            foreach (var line in sourceLines)
            {
                Instruction instr = decodeLine(line);
                instructions.Add(instr);
            }

            return instructions;
        }        
    }
}
