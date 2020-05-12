using System;
using System.Collections.Generic;
using System.Linq;

namespace Amnon_sProjects.Sudoku
{
    internal class SudokoGenerator
    {
        // Data
        private static readonly Random Random = new Random();
        private const int RowAmount = 9;
        private const int ColAmount = 9;
        private readonly int[,] _board;
        private readonly List<int> _numberList;
        private readonly SudokoSolver _solver;

        //Ctor
        public SudokoGenerator()
        {
            this._solver = new SudokoSolver();
            this._board = new int[RowAmount, ColAmount];
            this._numberList = new List<int>();
            for(int i = 1 ; i <= 9 ; i++ )
                this._numberList.Add(i);
        }

        // -------------------------------------- Generate a board ----------------------------------
        private bool Generate()
        {
            SudokoSolver.Cube aCube = this._solver.FindFirstEmpty(this._board);
            if (aCube is null)
                return true;
            Shuffle(this._numberList);
            foreach (var value in this._numberList.Where(value => this._solver.IsValid2(this._board, value, aCube)).ToArray())
            {
                this._board[aCube.CubeRow, aCube.CubeCol] = value;
                if (this.Generate())
                    return true;
                this._board[aCube.CubeRow, aCube.CubeCol] = 0;
            }

            return false;
        }

        public int[,] GetGeneratedBoard()
        {
            this.Generate();
            return this._board;
        }

        // ------------------------- Shuffle a list using  Fisher-Yates shuffle: -------------------
       
        public static void Shuffle(IList<int> list)
        {
            int listSize = list.Count;
            while (listSize > 1)
            {
                listSize--;
                int randomNumber = Random.Next(listSize + 1);
                int value = list[randomNumber];
                list[randomNumber] = list[listSize];
                list[listSize] = value;
            }
        }
    }
}
