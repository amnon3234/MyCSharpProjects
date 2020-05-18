using System.Collections.Generic;

namespace Amnon_sProjects.ShortestPath.Searchable
{
    internal interface ISearchable<T>
    {
        State<T> GetInitialState();
        State<T> GetGoalState();
        void AddHeuristicValues(int[,] valuesToAdd);
        bool IsGoalState(State<T> state);
        List<State<T>> GetAllPossibleStates(State<T> state);
    }
}
