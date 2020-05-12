using System.Collections.Generic;

namespace Amnon_sProjects.Sudoku
{
    /*
     * Solve by using backTrace algorithm
     */
    internal class SudokoSolver
    {
        //Data

        private const int RowAmount = 9;
        private const int ColAmount = 9;

        public class Cube
        {
            public int CubeRow{ get; set; }
            public int CubeCol{ get; set; }
            public Cube(int row, int col)
            {
                this.CubeRow = row;
                this.CubeCol = col;
            }
        }

        //----------------------------------------- Solve -----------------------------------------------
        public bool Solve(int[,] aBoard)
        {
            var firstEmpty = this.FindFirstEmpty(aBoard);
            if (firstEmpty == null)
                return true;

            int row = firstEmpty.CubeRow, col = firstEmpty.CubeCol;
            for(int index = 1; index < 10; index++)
                if (this.IsValid2(aBoard, index, firstEmpty))
                {
                    aBoard[row, col] = index;
                    if (Solve(aBoard))
                        return true;
                    aBoard[row, col] = 0;
                }

            return false; // there is no solution
        }

        //---------------------------------- Find first empty cube --------------------------------------
        public Cube FindFirstEmpty(int [,] aBoard)
        {
            for (int row = 0; row < RowAmount; row++)
                for (int col = 0; col < ColAmount; col++)
                    if (aBoard[row, col] == 0)
                        return new Cube(row, col);
            return null;
        }

        //--------------------------- Check if current cube value is valid ------------------------------
        public List<Cube> IsValid(int [,] aBoard, int value, Cube cubePos)
        {
            var problematicCubes = new List<Cube>();

            // Check row
            for (int col = 0; col < ColAmount; col++)
                if (aBoard[cubePos.CubeRow, col] == value && col != cubePos.CubeCol)
                    problematicCubes.Add(new Cube(cubePos.CubeRow, col));

            // Check col
            for (int row = 0; row < ColAmount; row++)
                if (aBoard[row, cubePos.CubeCol] == value && row != cubePos.CubeRow)
                    problematicCubes.Add(new Cube(row, cubePos.CubeCol));

            // Check box
            int boxY = (cubePos.CubeRow / 3) * 3; // find the desired cube row
            int boxX = (cubePos.CubeCol / 3) * 3; // finde the desired cube col
            for(int row = boxY; row < boxY + 3; row++)
                for(int col = boxX; col < boxX + 3; col++)
                    if(aBoard[row,col] == value && row != cubePos.CubeRow && col != cubePos.CubeCol)
                        problematicCubes.Add(new Cube(row, col));

            return problematicCubes;
        }

        public bool IsValid2(int[,] aBoard, int value, Cube cubePos)
        {
            // Check row
            for (int col = 0; col < ColAmount; col++)
                if (aBoard[cubePos.CubeRow, col] == value && col != cubePos.CubeCol)
                   return false;

            // Check col
            for (int row = 0; row < ColAmount; row++)
                if (aBoard[row, cubePos.CubeCol] == value && row != cubePos.CubeRow)
                    return false;

            // Check box
            int boxY = (cubePos.CubeRow / 3) * 3; // find the desired cube row
            int boxX = (cubePos.CubeCol / 3) * 3; // finde the desired cube col
            for (int row = boxY; row < boxY + 3; row++)
                for (int col = boxX; col < boxX + 3; col++)
                    if (aBoard[row, col] == value && row != cubePos.CubeRow && col != cubePos.CubeCol)
                        return false;

            return true;
        }

    }
}
