using System;

namespace Amnon_sProjects.Sudoku
{
    internal class SudokoGenerator
    {
        // Data
        private const int RowAmount = 9;
        private const int ColAmount = 9;
        private int[,] _board;

        // -------------------------------------- Generate a board ----------------------------------
        public int[,] generateOne()
        {
            // Initialized board
            this._board = new int[RowAmount, ColAmount];

            /*
             * 1) Randomly place ones in the board ( without breaking sudoku rules)
             * 2) Fill each box with 2-9
             */
            var isExistInCol = new bool[ColAmount];
            var isExistInBox = new bool[ColAmount];

            for (var row = 0; row < RowAmount; row++)
            {
                int col;
                // Pick column randomly
                do
                {
                    var rnd = new Random();
                    col = rnd.Next(9);
                } while (isExistInCol[col] || isExistInBox[col / 3 + (row / 3) * 3]);

                this._board[row, col] = 1;
                isExistInCol[col] = true;
                isExistInBox[col / 3 + (row / 3) * 3] = true;

                // Find current box 
                var boxR = (row / 3) * 3;
                var boxC = (col / 3) * 3;

                // Adjust next cube
                int i, j;
                if (col + 1 != boxC + 3)
                {
                    i = row;
                    j = col + 1;
                }
                else if (row + 1 != boxR + 3)
                {
                    i = row + 1;
                    j = boxC;
                }
                else
                {
                    i = boxR;
                    j = boxC;
                }
                // Fill box with numbers 2 - 9
                var currentNumberToPut = 2;
                while (i != row || j != col)
                {
                    this._board[i, j] = currentNumberToPut++;
                    if (j + 1 != boxC + 3)
                    {
                        j++;
                        continue;
                    }
                    if (i + 1 != boxR + 3)
                    {
                        j = boxC;
                        i++;
                        continue;
                    }
                    i = boxR;
                    j = boxC;
                }
            }
            return this._board;
        }
    }
}
