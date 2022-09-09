using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emulator
{
    public class ComandLine
    {
        public int comandNumber;
        public int comandCode;
        public string value;

        public ComandLine(int comandNumber, int comandCode, string value)
        {
            this.comandNumber = comandNumber;
            this.comandCode = comandCode;
            this.value = value;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(comandNumber.ToString());
            sb.Append(": ");
            sb.Append(comandCode.ToString());
            if (value != "")
            {
                sb.Append(" ");
                sb.Append(value);
            }            
            return sb.ToString();
        }
    }
}
