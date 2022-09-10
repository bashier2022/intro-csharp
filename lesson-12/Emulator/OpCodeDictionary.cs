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
        private static Dictionary<string, OpCodeEnum> OpCodeMap = new Dictionary<string, OpCodeEnum>()
        {
            { "NOP",  OpCodeEnum.NOP  },
            { "PUSH", OpCodeEnum.PUSH },
            { "DROP", OpCodeEnum.DROP },
            { "ADD",  OpCodeEnum.ADD  },
            { "SUB",  OpCodeEnum.SUB  },
            { "MUL",  OpCodeEnum.MUL  },
            { "DIV",  OpCodeEnum.DIV  },
            { "MOD",  OpCodeEnum.MOD  },
            { "INC",  OpCodeEnum.INC  },
            { "DEC",  OpCodeEnum.DEC  },
            { "NEG",  OpCodeEnum.NEG  },
            { "DUP",  OpCodeEnum.DUP  },
            { "CMP",  OpCodeEnum.CMP  },
            { "SWAP", OpCodeEnum.SWAP },
            { "ROL3", OpCodeEnum.ROL3 },
            { "HLT",  OpCodeEnum.HLT  },
            { "JZ",   OpCodeEnum.JZ   },
            { "JNZ",  OpCodeEnum.JNZ  },
        };

        public static OpCodeEnum Get(string name)
        {
            if(OpCodeMap.TryGetValue(name, out var result))
            {
                return result;
            }
            else
            {
                //TODO: report an error
                return OpCodeEnum.NOP;
            }
        }

    }
}
