using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_03
{
    public class Game
    {
        private char ch_dead = '.';
        private char ch_alive = '*';

        private CellState[,] board_02;
        public CellState[,] board;


        public Game(int rows, int columns)
        {
            this.board = new CellState[rows+2, columns+2];
            this.board_02 = new CellState[rows+2, columns+2];
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < columns; j++)
                {
                    this.board[i, j] = CellState.IsDead;
                    this.board_02[i, j] = CellState.IsDead;

                }
        }
        public void print()
        {
            int rows = board.GetLength(0);
            int columns = board.GetLength(1);

            for (int i = 1; i < rows - 1; i++)
            {
                for (int j = 1; j < columns -1; j++)
                {
                    if (this.board[i, j] == CellState.IsAlive)
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

        internal void Fill_Board(int[,] matrix)
        {
            int rows = board.GetLength(0);
            int columns = board.GetLength(1);

            for (int i = 1; i < rows - 1; i++)
            {
                for (int j = 1; j < columns -1; j++)
                {
                    this.board[i, j] = (CellState) matrix[i-1, j-1];
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
            int rows = board.GetLength(0);
            int columns = board.GetLength(1);

            for (int i = 1; i < rows - 1; i++)
            {
                for (int j = 1; j < columns -1; j++)
                {
                    this.board[i, j] = this.board_02[i, j];
                }
            }
        }
        public void next_generation()
        {
            int rows = board.GetLength(0);
            int columns = board.GetLength(1);
            int c = 0;
            for (int i = 1; i < rows - 1; i++)
            {
                for (int j = 1; j < columns -1; j++)
                {
                    c = this.count_neighbors(i, j);
                    if (this.board[i, j] == CellState.IsAlive)
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
            int rows = this.board_02.GetLength(0);
            int columns = this.board_02.GetLength(1);

            for (int i = 1; i < rows - 1; i++)
            {
                for (int j = 1; j < columns -1; j++)
                {
                    this.board_02[i, j] = CellState.IsDead;
                }
            }
        }
    }
}