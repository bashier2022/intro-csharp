namespace lesson_02
{
    internal class Program
    {
        static void PrintBoard(int[,] board)
        {
            char populated = '#';
            char not_populated = '-';

            for (int i = 1; i < board.GetLength(0) - 1; i++)
            {
                for (int j = 1; j < board.GetLength(1) - 1; j++)
                {
                    if (board[i, j] == 1)
                    {
                        Console.Write($"{populated}");
                    }
                    else
                    {
                        Console.Write($"{not_populated}");
                    }
                }
                Console.WriteLine();
            }

        }
        static int[,] ReadBoard()
        {
            int[,] A =
            {
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0},
                {0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 1, 0},
                {0, 1, 0, 1, 0, 1, 1, 0, 0, 0, 1, 0},
                {0, 0, 1, 0, 1, 0, 0, 1, 1, 0, 0, 0},
                {0, 0, 1, 0, 0, 0, 1, 0, 1, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
            };
            return A;
        }
        static int[,] ZeroBoard(int n, int m)
        {
            int[,] A = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    A[i, j] = 0; 
                }
            }
            return A;
        }
        static int Count_Neighbors(int[,] B, int i, int j)
        {
            int c = 0;
            for (int k = -1; k < 2; k++)
            {
                for (int l = -1; l < 2; l++)
                {
                    c = c + B[i + k, j + l];
                }
            }
            c = c - B[i, j];

            return c;
        }
        static void Copy_To_Values(int[,] A, int[,] B)
        {
            for(int i= 0; i < A.GetLength(0); i++)
                for(int j= 0; j < A.GetLength(1); j++)
                    B[i,j] = A[i,j];
        }
        static void reset_Game_Board(int[,] B)
        {
            //for (int i = 0; i < B.GetLength(0); i++)
            //    for (int j = 0; j < B.GetLength(1); j++)
            //        B[i, j] = 0;
            Console.WriteLine("vor Clearing");
            PrintBoard(B);
            Array.Clear(B, 0, B.GetLength(0) * B.GetLength(1));
            Console.WriteLine("after cleaning");
            PrintBoard(B);
        }
        static bool Populated(int[,] board, int i, int j)
        {
            return board[i, j] == 1;
        }
        static void Calculate_Next_Generation(int[,] board, int[,] A)
        {
            int n = board.GetLength(0);
            int m = board.GetLength(1);

            for (int i = 1; i < n - 1; i++)
            {
                for (int j = 1; j < m - 1; j++)
                {
                    int c = Count_Neighbors(board, i, j);
                    // Rules
                    // For a space that is populated:
                    // Each cell with one or no neighbors dies, as if by solitude.
                    // Each cell with four or more neighbors dies, as if by overpopulation.
                    // Each cell with two or three neighbors survives.
                    // For a space that is empty or unpopulated:
                    // Each cell with three neighbors becomes populated.

                    if (Populated(board, i, j))
                    {
                        if ((c == 2) || (c==3))
                        {
                            A[i, j] = 1;
                        }
                        else { A[i, j] = 0; }
                    }
                    else
                    {
                        if (c==3) { A[i, j] = 1; } else { A[i, j] = 0; }
                    }
                }
            }
            //Copy_To_Values(A, board);
        }
        static void Main(string[] args)
        {
            //int n = 40;
            //int m = 40;
            int[,] board; // = new int[n + 2, m + 2];
            int k = 10;
            board = ReadBoard();
            int n = board.GetLength(0);
            int m = board.GetLength(1);
            int[,] next_generation = ZeroBoard(n, m);
            while (k>0)
            {
                reset_Game_Board(next_generation);
                PrintBoard(board);
                Console.Write("Calculate next generation? [press enter] : ");
                Console.ReadLine();
                Calculate_Next_Generation(board, next_generation);
                Copy_To_Values(next_generation, board);
                k -= 1;

            }
        }
    }
}