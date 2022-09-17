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
            bool neg = (a > 0 && b < 0) || (a<0 && b>0);
            if (a == 0) return 0;
            if (b == 0) return 0;
            if (a<0) a=-a;
            if (b<0) b=-b;
            for (int i = 0; i < a; i++)
            {
                result += b;
            }
            if (neg)
            {
                result = -result;
            }
            return result;
        }

        //Add function :
        //     double Power(int a, int b) { return a*b; }
        //        the above code is wrong, but first we will write and run the tests,
        //that computes the a to the power b.you cant use Math.Power or * but you can call the previous function Mul / Add
        //a^-3 == 1/a^3
        //a^8 = a^4 * a^4
        //a^8 = (a^4)^2
        //a^7/a^3  = a^(7-3) = a^4
        //first add a new test class and write down as many tests as you can, before implementing the real Power function;
        //most of the tests will fail.
        //Now start adding logic to the function and see how the tests become green.
        //when all tests are green.
        //commit and push.
        //think about a new test method and try to have a test that fails. (edited)
        public double Power(int a, int b)
        {
            int result = 1;
            bool r = false;
            if (b == 0) return 1;
            if (a == 0) return 0;
            if (b< 0)
            {
                b=-b;
                r = true;                
            }
            for (int i = 0; i < b; i++)
            {
                result = Mult(result, a);
            }
            if (r)
            {
                return 1.0/(double)result;
            }
            return result;
        }
    }
}
