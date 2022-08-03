
namespace lesson_01
{
    internal class Program
    {
        

        
        //3. function that will compute the average of a double[]
        //    - be ware of gotchas


        //4. write a function that will solve quadratic formula like we did in python

        //    SolveQuadratic(4, -2, 3)  // to solve 4x^2-2x+3 = 0
        static void print_doubles(double[] lst)
        {
            //        1. write a function that will print an array of double
            //          double[] a = { 1.1, 3.0, 5.2 };
            //          print(a);
            //          will print: [1.1, 3.0, 5.2 ]
            if (lst is null)
            {
                Console.WriteLine("Nothing");
                return;
            }
            Console.Write("[");
            if (lst.Length >= 1)
            {
                Console.Write($"{lst[0]}");
            }
            for (int i = 1; i < lst.Length; i++)
            {
                Console.Write($", {lst[i]}");
            }
            Console.WriteLine("]");
        }
        static void test_print_doubles()
        {
            print_doubles(null);
            double[] lst_01 = { };
            print_doubles(lst_01);
            double[] lst_02 = { 2.5 };
            print_doubles(lst_02);
            double[] lst_03 = { 2.5, 7.1, -4.009 };
            print_doubles(lst_03);
        }

        static double sum_of_doubles(double[] lst)
        {
            // 2. function that will compute the sum of an array of double[]           
            double sum = 0.0;
            if (lst is null)
            {
                Console.WriteLine("Nothing: NULL value ");
                return sum;
            }
            for (int i = 0; i < lst.Length; i++)
                {
                    sum += lst[i];
                }
                return sum;            
        }
        static void test_sum_of_doubles()
        {
            double[] lst_01 = { };
            Console.WriteLine( sum_of_doubles(lst_01));
            double[] lst_02 = { 2.5 };
            Console.WriteLine(sum_of_doubles(lst_02));
            double[] lst_03 = { 2.5, 7.1, -4.009 };
            Console.WriteLine(sum_of_doubles(lst_03));
            Console.WriteLine(sum_of_doubles(null)); // hier is warning
        }
        static void SolveQuadratic(double a, double b, double c)        
        {
            //4. write a function that will solve quadratic formula like we did in python

            //    SolveQuadratic(4, -2, 3)  // to solve 4x^2-2x+3 = 0
            double x1 = 0.0;
            double x2 = 0.0;
            double discriminant = b * b - 4.0 * a * c;
            if (a == 0)
            {
                Console.WriteLine("No quadratic Equation");
                if (b == 0)
                {
                    if (c != 0)
                    {
                        Console.WriteLine("Wrong quadratic Equation !!!");
                    }
                    else 
                    { 
                        Console.WriteLine("infinit real solutions (ALL R) for quadratic Equation !!!");
                    }
                }
                else
                {
                    Console.WriteLine($"One real Solution \n x = {(-c)/b}");
                }
                
            }
            else if (discriminant < 0)
            {
                Console.WriteLine("The quadratic Equation has No real Solutions");
            }
            else if (discriminant == 0)
            {
                x1 = (-b) / (2.0 * a);
                Console.WriteLine($"One real Solution \n x = {x1}");
            }
            else
            {
                double d = System.Math.Sqrt(discriminant);
                x1 = (-b + d) / (2.0 * a);
                x2 = (-b - d) / (2.0 * a);
                Console.WriteLine($"two real Solutions \n x1 = {x1} \n x2 = {x2}");
            }

        }
        static void Test_SolveQuadratic()
        {
            SolveQuadratic(4, -2, 3);
            SolveQuadratic(4, -2, -3);
            SolveQuadratic(1, -2, 1);
            SolveQuadratic(0, -2, 1);
            SolveQuadratic(0, 0, 1);
            SolveQuadratic(0, 0, 0);
        }
        static void Main(string[] args)
        {
            test_print_doubles();

            test_sum_of_doubles();

            Test_SolveQuadratic();

        }
    }
}