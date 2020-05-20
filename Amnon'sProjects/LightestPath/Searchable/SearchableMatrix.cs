using System.Collections.Generic;

namespace Amnon_sProjects.ShortestPath.Searchable
{
    internal class SearchableMatrix : ISearchable<StatePosition>
    {
        // Data
        private readonly int[,] _matrix;
        private int[,] _heuristicValues;
        private readonly StatePosition _start;
        private readonly StatePosition _goal;
        private readonly int _rowAmount;
        private readonly int _colAmount;

        // Ctor
        public SearchableMatrix(int[,] matrix, StatePosition start, StatePosition goal, int rowAmount, int colAmount)
        {
            this._heuristicValues = new int[rowAmount,colAmount];
            this._matrix = matrix;
            this._start = start;
            this._goal = goal;
            this._rowAmount = rowAmount;
            this._colAmount = colAmount;
        }

        // ------------------------ Override methods -------------------------
        public List<State<StatePosition>> GetAllPossibleStates(State<StatePosition> state)
        {
            StatePosition curr = state.SValue;
            state.SCost -= this._heuristicValues[curr.Row, curr.Col];
            List<State<StatePosition>> output = new List<State<StatePosition>>();

            // Check up overflow
            if (curr.Row != 0 && this._matrix[curr.Row - 1, curr.Col] != int.MaxValue)
                output.Add(new State<StatePosition>(new StatePosition(curr.Row - 1, curr.Col))
                {
                    SCost = state.SCost + this._matrix[curr.Row - 1, curr.Col] +
                            this._heuristicValues[curr.Row - 1, curr.Col]
                });
            
            // Check down overflow
            if (curr.Row != this._rowAmount - 1 && this._matrix[curr.Row + 1, curr.Col] != int.MaxValue)
                output.Add(new State<StatePosition>(new StatePosition(curr.Row + 1, curr.Col))
                {
                    SCost = state.SCost + this._matrix[curr.Row + 1, curr.Col] +
                            this._heuristicValues[curr.Row + 1, curr.Col]
                });

            // Check left overflow
            if (curr.Col != 0 && this._matrix[curr.Row, curr.Col - 1] != int.MaxValue)
                output.Add(new State<StatePosition>(new StatePosition(curr.Row, curr.Col - 1))
                {
                    SCost = state.SCost + this._matrix[curr.Row, curr.Col - 1] +
                            this._heuristicValues[curr.Row, curr.Col - 1]
                });

            // Check right overflow
            if (curr.Col != this._colAmount - 1 && this._matrix[curr.Row, curr.Col + 1] != int.MaxValue)
                output.Add(new State<StatePosition>(new StatePosition(curr.Row, curr.Col + 1))
                {
                    SCost = state.SCost + this._matrix[curr.Row, curr.Col + 1] +
                            this._heuristicValues[curr.Row, curr.Col + 1]
                });

            /*
            // Check right top
            if (curr.Col != this._colAmount - 1 && curr.Row != 0 &&
                this._matrix[curr.Row - 1, curr.Col + 1] != int.MaxValue)
                output.Add(new State<StatePosition>(new StatePosition(curr.Row - 1, curr.Col + 1))
                {
                    SCost = state.SCost + this._matrix[curr.Row - 1, curr.Col + 1] +
                            this._heuristicValues[curr.Row - 1, curr.Col + 1]
                });

            // Check right button
            if (curr.Col != this._colAmount - 1 && curr.Row != this._rowAmount - 1 &&
                this._matrix[curr.Row + 1, curr.Col + 1] != int.MaxValue)
                output.Add(new State<StatePosition>(new StatePosition(curr.Row + 1, curr.Col + 1))
                {
                    SCost = state.SCost + this._matrix[curr.Row + 1, curr.Col + 1] +
                            this._heuristicValues[curr.Row + 1, curr.Col + 1]
                });

            // Check left top
            if (curr.Col != 0 && curr.Row != 0 && this._matrix[curr.Row - 1, curr.Col - 1] != int.MaxValue)
                output.Add(new State<StatePosition>(new StatePosition(curr.Row - 1, curr.Col - 1))
                {
                    SCost = state.SCost + this._matrix[curr.Row - 1, curr.Col - 1] +
                            this._heuristicValues[curr.Row - 1, curr.Col - 1]
                });

            // Check left button
            if (curr.Col != 0 && curr.Row != this._rowAmount - 1 &&
                this._matrix[curr.Row + 1, curr.Col - 1] != int.MaxValue)
                output.Add(new State<StatePosition>(new StatePosition(curr.Row + 1, curr.Col - 1))
                {
                    SCost = state.SCost + this._matrix[curr.Row + 1, curr.Col - 1] +
                            this._heuristicValues[curr.Row + 1, curr.Col - 1]
                });
            */
            return output;
        }

        public void AddHeuristicValues(int[,] valuesToAdd)
        {
            this._heuristicValues = valuesToAdd;
        }

        public State<StatePosition> GetInitialState()
        {
            return new State<StatePosition>(this._start) { SCost = 0 };
        }

        public State<StatePosition> GetGoalState()
        {
            return new State<StatePosition>(this._goal) { SCost = 0 };
        }

        public bool IsGoalState(State<StatePosition> state)
        {
            return state.SValue.Equals(this._goal);
        }

        protected bool Equals(SearchableMatrix other)
        {
            return Equals(_matrix, other._matrix) && Equals(_start, other._start) && 
                   Equals(_goal, other._goal);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = (_matrix != null ? _matrix.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (_start != null ? _start.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (_goal != null ? _goal.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ _rowAmount;
                hashCode = (hashCode * 397) ^ _colAmount;
                return hashCode;
            }
        }
    }
}
