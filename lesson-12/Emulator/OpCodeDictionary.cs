using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emulator
{
    public enum OpCodeEnum
    {
        NOP,
        PUSHIP,
        POPIP,
        DROPIP,
        PUSH,
        DROP,
        ADD,
        SUB,
        MUL,
        DIV,
        MOD,
        INC,
        DEC,
        NEG,
        DUP,
        CMP,
        SWAP,
        ROL3,
        HLT,
        JMP,
        JZ,
        JNZ,
        STORE,
        LOAD
    }

    public class OpCodeDictionary
    {
        private Dictionary<string, (OpCodeEnum, int, Func<ExecutingComponents, int, bool>)> OpCodeMap;
        private FunctionMap _Fm;
        public OpCodeDictionary(FunctionMap fm)
        {
            _Fm = fm;
            OpCodeMap = new Dictionary<string, (OpCodeEnum, int, Func<ExecutingComponents, int, bool>)>();
            ////Name       OpCode        args   function
            OpCodeMap.Add("NOP", (OpCodeEnum.NOP, 0, _Fm.NOP));
            OpCodeMap.Add("PUSHIP", (OpCodeEnum.PUSHIP, 0, _Fm.PUSHIP));
            OpCodeMap.Add("POPIP", (OpCodeEnum.POPIP, 0, _Fm.POPIP));
            OpCodeMap.Add("DROPIP", (OpCodeEnum.DROPIP, 0, _Fm.DROPIP));
            OpCodeMap.Add("PUSH", (OpCodeEnum.PUSH, 0, _Fm.PUSH));
            OpCodeMap.Add("DROP", (OpCodeEnum.DROP, 0, _Fm.DROP));
            OpCodeMap.Add("ADD", (OpCodeEnum.ADD, 2, _Fm.ADD));
            OpCodeMap.Add("SUB", (OpCodeEnum.SUB, 2, _Fm.SUB));
            OpCodeMap.Add("MUL", (OpCodeEnum.MUL, 2, _Fm.MUL));
            OpCodeMap.Add("DIV", (OpCodeEnum.DIV, 2, _Fm.DIV));
            OpCodeMap.Add("MOD", (OpCodeEnum.MOD, 2, _Fm.MOD));
            OpCodeMap.Add("INC", (OpCodeEnum.INC, 1, _Fm.INC));
            OpCodeMap.Add("DEC", (OpCodeEnum.DEC, 1, _Fm.DEC));
            OpCodeMap.Add("NEG", (OpCodeEnum.NEG, 1, _Fm.NEG));
            OpCodeMap.Add("DUP", (OpCodeEnum.DUP, 1, _Fm.DUP));
            OpCodeMap.Add("CMP", (OpCodeEnum.CMP, 2, _Fm.CMP));
            OpCodeMap.Add("SWAP", (OpCodeEnum.SWAP, 2, _Fm.SWAP));
            OpCodeMap.Add("ROL3", (OpCodeEnum.ROL3, 3, _Fm.ROL3));
            OpCodeMap.Add("HLT", (OpCodeEnum.HLT, 0, _Fm.HLT));
            OpCodeMap.Add("JMP", (OpCodeEnum.JZ, 0, _Fm.JMP));
            OpCodeMap.Add("JZ", (OpCodeEnum.JZ, 1, _Fm.JZ));
            OpCodeMap.Add("JNZ", (OpCodeEnum.JNZ, 1, _Fm.JNZ));
            OpCodeMap.Add("STORE", (OpCodeEnum.STORE, 0, _Fm.STORE));
            OpCodeMap.Add("LOAD", (OpCodeEnum.LOAD, 0, _Fm.LOAD));
        }
        public (OpCodeEnum, int, Func<ExecutingComponents, int, bool>) Get(string name)
        {
            if (OpCodeMap.TryGetValue(name, out var result))
            {
                return result;
            }
            else
            {
                //TODO: report an error
                return OpCodeMap["NOP"];
            }
        }
    }
}
