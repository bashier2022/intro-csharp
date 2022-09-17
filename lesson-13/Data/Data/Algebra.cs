using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Algebra
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Mult(int a, int b)
        {

            int result = 0;
            bool neg =(a > 0 && b < 0) || (a<0 && b>0);
            if (a == 0) return 0;
            if (b == 0) return 0;
            if (a<0) a=-a;
            if (b<0) b=-b;
            for(int i = 0; i < a; i++)
            {
                result += b;
            }
            if (neg)
            {
                result = -result;
            }
            return result;
        }
    }
}
