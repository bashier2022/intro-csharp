using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emulator
{
    public class Compiler
    {
        public Dictionary<string, string> CompDict;

        public List<ComandLine> programList = new List<ComandLine>();
        
        public Compiler()
        {
            CompDict = new Dictionary<string, string>();
            AddBasicFunctions();
        }

        private void AddBasicFunctions()
        {
            CompDict.Add("NOP", "00");
            CompDict.Add("PUSH", "01");
            CompDict.Add("DROP", "02");
            CompDict.Add("ADD", "03");
            CompDict.Add("SUB", "04");
            CompDict.Add("MUL", "05");
            CompDict.Add("DIV", "06");
            CompDict.Add("MOD", "07");
            CompDict.Add("INC", "08");
            CompDict.Add("DEC", "09");
            CompDict.Add("NEG", "10");
            CompDict.Add("DUP", "11");
            CompDict.Add("CMP", "12");
            CompDict.Add("SWAP", "13");
            CompDict.Add("ROL3", "14");
            CompDict.Add("HLT", "15");
            CompDict.Add("JZ", "16");
            CompDict.Add("JNZ", "17");
        }

        public ComandLine DecodeComandLine(int i, string line)
        {
            string[] par = line.Split(' ');
           
            int comandCode = int.Parse(CompDict[par[0].Trim()]);
            string value = "";
            if (par.Length > 1)
            {
                value = par[1].Trim();
            }
            return new ComandLine(i, comandCode, value);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            return base.ToString();
        }
    }
}
