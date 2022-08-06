using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_03
{
    public class Game
    {
        private char ch_dead = '-';
        private char ch_alive = '*';

        private CellState[,] board_02;
        public CellState[,] board;

        private int rows;
        private int columns;

        public Game(int rows, int columns)
        {
            this.rows = rows + 2;
            this.columns = columns + 2;
            this.board = new CellState[this.rows, this.columns];
            this.board_02 = new CellState[this.rows, this.columns];
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < columns; j++)
                {
                    this.turnoff(i, j);
                }
            this.Reset_Board_02();
        }

        public void turnon(int i, int j)
        {
            this.board[i, j] = CellState.IsAlive;
        }
        public bool IsTurnon(int i, int j)
        {
            return this.board[i, j] == CellState.IsAlive;
        }
        public void turnoff(int i, int j)
        {
            this.board[i, j] = CellState.IsDead;
        }
        public bool IsTurnoff(int i, int j)
        {
            return this.board[i, j] == CellState.IsDead;
        }
        public void print()
        {
            for (int i = 1; i < this.rows - 1; i++)
            {
                for (int j = 1; j < this.columns - 1; j++)
                {
                    if (this.IsTurnon(i,j))
                    {
                        Console.Write(ch_alive);
                    }
                    else
                    {
                        Console.Write(ch_dead);
                    }
                }
                Console.WriteLine();
            }
        }

        public void Fill_Board_From_Array_of_strings(string[] arr_str)
        {
            for (int i = 0; i < this.rows - 2; i++)
            {
                string row_st = arr_str[i];
                Console.WriteLine($"r({i}) =: {row_st}");
                for (int j = 0; j < this.columns - 2; j++)
                {
                    if (row_st[j] == '1')
                    {
                        this.turnon(i+1, j+1); // this.board[i+1, j+1] = CellState.IsAlive;
                    }
                    else
                    {
                        this.turnoff(i+1, j+1); // this.board[i+1, j+1] = CellState.IsDead;
                    }
                }
            }
        }

        public void Fill_Board(int[,] matrix)
        {
            for (int i = 1; i < this.rows - 1; i++)
            {
                for (int j = 1; j < this.columns - 1; j++)
                {
                    //this.board[i, j] = (CellState)matrix[i-1, j-1];
                    if (matrix[i-1, j-1] == 0)
                    {
                        this.turnon(i, j);
                    }
                    else
                    {
                        this.turnoff(i, j);
                    }
                }
            }
        }

        private int count_neighbors(int i, int j)
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
        private void copy_values_to_board()
        {
            for (int i = 1; i < this.rows - 1; i++)
            {
                for (int j = 1; j < this.columns -1; j++)
                {
                    this.board[i, j] = this.board_02[i, j];
                }
            }
        }
        public void next_generation()
        {
            int c = 0;
            for (int i = 1; i < this.rows - 1; i++)
            {
                for (int j = 1; j < this.columns -1; j++)
                {
                    c = this.count_neighbors(i, j);
                    if (this.IsTurnon(i, j))
                    {
                        if (c == 2 || c==3)
                        {
                            this.board_02[i, j] = CellState.IsAlive;
                        }
                        else
                        {
                            this.board_02[i, j] = CellState.IsDead;
                        }
                    }
                    else
                    {
                        if (c==3)
                        {
                            this.board_02[i, j] = CellState.IsAlive;
                        }
                    }
                }
            }
            this.copy_values_to_board();
            this.Reset_Board_02();
        }

        private void Reset_Board_02()
        {
            for (int i = 1; i < this.rows - 1; i++)
            {
                for (int j = 1; j < this.columns - 1; j++)
                {
                    this.board_02[i, j] = CellState.IsDead;
                }
            }
        }
    }
}