
namespace lesson_01
{
    internal class Program
    {
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
            if (lst.Length > 0)
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
        static void print_doubles_V2(double[] lst)
        {
            //        1. write a function that will print an array of double
            //          double[] a = { 1.1, 3.0, 5.2 };
            //          print(a);
            //          will print: [1.1, 3.0, 5.2 ]
            Console.WriteLine("V2");
            if (lst is null)
            {
                Console.WriteLine("Nothing");
                return;
            }
            Console.Write("[");
            
            for (int i = 1; i < lst.Length; i++)
            {
                Console.Write($"{lst[i]}, ");
            }
            if (lst.Length  > 0)
            {
                Console.Write($"{lst[lst.Length-1]}");
            }
            Console.WriteLine("]");
        }
        static void test_print_doubles_V2()
        {
            print_doubles_V2(null);
            double[] lst_01 = { };
            print_doubles_V2(lst_01);
            double[] lst_02 = { 2.5 };
            print_doubles_V2(lst_02);
            double[] lst_03 = { 2.5, 7.1, -4.009 };
            print_doubles_V2(lst_03);
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

        //3. is_magic  : function will test if a 2D array[,]  is magic square


        static void Print2D(int[,] arr)
        {
            // print 2D normal array[,]
            int n = 0;
            int m = 0;
            string c_1 = "";
            string c_2 = "";
            Console.WriteLine("Printing 2D Array");
            if (arr != null)
            {
                n = arr.GetLength(0);
                m = arr.GetLength(1);
                c_1 = "["; c_2 = "]";
                Console.WriteLine(c_1);
                for (int i = 0; i < n; i++)
                {
                    Console.Write($"  {c_1} {arr[i, 0]}");
                    for (int j = 1; j < m; j++)
                    {
                        Console.Write($", {arr[i, j]}");
                    }
                    Console.WriteLine($"{c_2}");
                }
                Console.WriteLine(c_2);
            }
        }
        static void Print2D_Jagged(int[][] J_arr)
        {
            //2. print 2D jagged array[][ ]
            Console.WriteLine("Printing Jadded Array");
            string c_1 = "[";
            string c_2 = "]";
            if (J_arr != null)
            {
                Console.WriteLine(c_1);
                for (int i = 0; i < J_arr.Length; i++)
                {
                    Console.Write($"  {c_1}");
                    if (J_arr[i] != null)
                    {
                        if (J_arr[i].Length > 0) { Console.Write($"{J_arr[i][0]}"); }
                        for (int j = 1; j < J_arr[i].Length; j++)
                        {
                            Console.Write($", {J_arr[i][j]}");
                        }
                    }
                    Console.WriteLine(c_2);
                }
                Console.WriteLine(c_2);
            }
        }
        static void Test_Print2D()
        {

            int[,] sqaure = { { 8, 1, 6 },
                              { 3, 5, 7 },
                              { 4, 9, 3 } };
            int[][] J_sqaure = new int[3][] {
                                                new int[3]{ 8, 1, 6 },
                                                new int[2], //null, //new int[2]{ 5, 7 },
                                                new int[4]{ 4, 9, 3, 5 }
                                            };

            Print2D(sqaure);
            sqaure = null;
            Print2D(sqaure);
            sqaure = new int[2,3] ;
            Print2D(sqaure);
            Print2D_Jagged(J_sqaure);

        }
        static int sum_row(int[,] square, int r)
        {
            int sum = 0;
            int n = square.GetLength(0);
            for (int c = 0; c < n; c++) { sum += square[r, c]; }
            return sum;
        }
        static int sum_col(int[,] square, int c)
        {
            int sum = 0;
            int n = square.GetLength(0);
            for (int r = 0; r < n; r++) { sum += square[r, c]; }
            return sum;
        }

        static int sum_first_diagonal(int[,] square)
        {
            int sum = 0;
            int n = square.GetLength(0);
            for (int i = 0; i < n; i++) { sum += square[i, i]; }
            return sum;
        }
        static int sum_second_diagonal(int[,] square)
        {
            int sum = 0;
            int n = square.GetLength(0);
            for (int i = 0; i < n; i++) { sum += square[i, n - i - 1]; }
            return sum;
        }
        static bool is_magic_square(int[,] square)
        {
            //3. is_magic  : function will test if a 2D array[,]  is magic square
            bool ok = true;
            int n = square.GetLength(0);
            int m = square.GetLength(1);
            int s = 0;
            if (n!= m) { ok = false; }
            s = sum_row(square, 0);

            for (int r = 0; r < n; r++)
            {
                ok = ok && (s == sum_row(square, r));
            }
            for (int c = 0; c < n; c++)
            {
                ok = ok && (s == sum_row(square, c));
            }
            ok = ok && (s == sum_first_diagonal(square));
            ok = ok && (s == sum_second_diagonal(square));
            return ok;
        }

        static void Main(string[] args)
        {
            test_print_doubles();

            test_sum_of_doubles();

            Test_SolveQuadratic();

            test_print_doubles_V2();

            Test_Print2D();
            int[,] sqaure = { { 8, 1, 6 },
                              { 3, 5, 7 },
                              { 4, 9, 3 } };

            Console.WriteLine(is_magic_square(sqaure));

        }
    }
}