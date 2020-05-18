using System;

namespace Amnon_sProjects.ShortestPath.Searchable
{
    internal class StatePosition
    {
        // Data
        public int Row { get; }
        public int Col { get; }

        // Ctor
        public StatePosition(int row, int col)
        {
            Row = row;
            Col = col;
        }

        // ------------------------ Override methods -------------------------
        public override string ToString()
        {
            return "(" + Row + "," + Col + ")";
        }

        public override bool Equals(object obj)
        {
            var other = obj as StatePosition;
            return Row == other.Row && Col == other.Col;
        }

        public override int GetHashCode()
        {
            return (Row + "|" + Col).GetHashCode();
        }
    }
}
