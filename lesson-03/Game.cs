using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_03
{
    public class Game
    {
        private const char DEAD_CHAR = '-';
        private const char LIVE_CHAR = '*';

        private CellState[,] board;

        public Game(int rows, int columns)
        {
            rows = rows + 2;
            columns = columns + 2;
            board = new CellState[rows, columns];
        }

        public void TurnOn(int i, int j)
        {
            board[i, j] = CellState.IsAlive;
        }
        public bool IsAlive(int i, int j) => board[i, j] == CellState.IsAlive;
        public void TurnOff(int i, int j)
        {
            this.board[i, j] = CellState.IsDead;
        }
        public bool IsDead(int i, int j) => board[i, j] == CellState.IsDead;

        public override string ToString()
        {        
            int rows = board.GetLength(0);
            int columns = board.GetLength(1);
            var sb = new StringBuilder();

            for (int i = 1; i < rows - 1; i++)
            {
                for (int j = 1; j < columns - 1; j++)
                {
                    if (this.IsAlive(i,j))
                    {
                        sb.Append(LIVE_CHAR);
                    }
                    else
                    {
                        sb.Append(DEAD_CHAR);
                    }
                }
               sb.Append("\n");
            }
            return sb.ToString();
        }

        public void Fill_Board_From_Array_of_strings(string[] arr_str)
        {
            int rows = board.GetLength(0);
            int columns = board.GetLength(1);

            for (int i = 0; i < rows - 2; i++)
            {
                string row_st = arr_str[i];
                Console.WriteLine($"r({i}) =: {row_st}");
                for (int j = 0; j < columns - 2; j++)
                {
                    if (row_st[j] == '1')
                    {
                        this.TurnOn(i+1, j+1); 
                    }
                    else
                    {
                        this.TurnOff(i+1, j+1); 
                    }
                }
            }
        }

        public void Fill_Board(int[,] matrix)
        {
            int rows = board.GetLength(0);
            int columns = board.GetLength(1);

            for (int i = 1; i < rows - 1; i++)
            {
                for (int j = 1; j < columns - 1; j++)
                {
                    if (matrix[i-1, j-1] == 1)
                    {
                        this.TurnOn(i, j);
                    }
                    else
                    {
                        this.TurnOff(i, j);
                    }
                }
            }
        }

        private int CountNeighbors(int i, int j)
        {
            int c = 0;

            for (int k = -1; k < 2; k++)
            {
                for (int l = -1; l < 2; l++)
                {
                    c = c + (int)this.board[i + k, j + l];
                }
            }
            c = c - (int)this.board[i, j];

            return c;
        }

        public void ComputeNextGeneration()
        {
            int rows = board.GetLength(0);
            int columns = board.GetLength(1);

            var board_02 = new CellState[rows, columns];
            int c = 0;
            for (int i = 1; i < rows - 1; i++)
            {
                for (int j = 1; j < columns -1; j++)
                {
                    c = CountNeighbors(i, j);
                    if (IsAlive(i, j))
                    {
                        if (c == 2 || c==3)
                        {
                            board_02[i, j] = CellState.IsAlive;
                        }
                        else
                        {
                            board_02[i, j] = CellState.IsDead;
                        }
                    }
                    else
                    {
                        if (c==3)
                        {
                            board_02[i, j] = CellState.IsAlive;
                        }
                    }
                }
            }
            board = board_02;
        }
    }
}