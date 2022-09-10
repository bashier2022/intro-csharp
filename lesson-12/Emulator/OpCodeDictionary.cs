using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emulator
{
    public enum OpCodeEnum
    {
        NOP , 
        PUSH,
        DROP,
        ADD ,
        SUB ,
        MUL ,
        DIV ,
        MOD ,
        INC ,
        DEC ,
        NEG ,
        DUP ,
        CMP ,
        SWAP,
        ROL3,
        HLT ,
        JZ  ,
        JNZ ,
    }

    
    public static class OpCodeDictionary
    {
        private static Dictionary<string, (OpCodeEnum, int)> OpCodeMap = new Dictionary<string, (OpCodeEnum, int)>()
        {
            //Name       OpCode        args
            { "NOP",  (OpCodeEnum.NOP,  0) },
            { "PUSH", (OpCodeEnum.PUSH, 0) },
            { "DROP", (OpCodeEnum.DROP, 0) },
            { "ADD",  (OpCodeEnum.ADD , 2) },
            { "SUB",  (OpCodeEnum.SUB , 2) },
            { "MUL",  (OpCodeEnum.MUL , 2) },
            { "DIV",  (OpCodeEnum.DIV , 2) },
            { "MOD",  (OpCodeEnum.MOD , 2) },
            { "INC",  (OpCodeEnum.INC , 1) },
            { "DEC",  (OpCodeEnum.DEC , 1) },
            { "NEG",  (OpCodeEnum.NEG , 1) },
            { "DUP",  (OpCodeEnum.DUP , 1) },
            { "CMP",  (OpCodeEnum.CMP , 2) },
            { "SWAP", (OpCodeEnum.SWAP, 2) },
            { "ROL3", (OpCodeEnum.ROL3, 3) },
            { "HLT",  (OpCodeEnum.HLT , 0) },
            { "JZ",   (OpCodeEnum.JZ  , 1) },
            { "JNZ",  (OpCodeEnum.JNZ , 1) },
        };

        public static (OpCodeEnum, int) Get(string name)
        {
            if(OpCodeMap.TryGetValue(name, out var result))
            {
                return result;
            }
            else
            {
                //TODO: report an error
                return (OpCodeEnum.NOP, 0);
            }
        }

    }
}
