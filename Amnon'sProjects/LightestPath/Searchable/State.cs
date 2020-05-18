using System;

namespace Amnon_sProjects.ShortestPath.Searchable
{
    internal class State<T> :IComparable
    {
        // Data
        public T SValue { get; set; }
        public int SCost { get; set; }
        public State<T> Father { get; set; }
        public bool Visited { get; set; }

        // Ctor
        public State(T sValue)
        {
            this.Visited = false;
            SValue = sValue;
            SCost = int.MaxValue;
            Father = null;
        }

        // ------------------------ Override methods -------------------------
        public override string ToString()
        {
            return this.SValue.ToString() + " ==> " + this.SCost;
        }

        public override bool Equals(object obj)
        {
            return SValue.Equals((obj as State<T>).SValue);
        }

        public override int GetHashCode()
        {
            return (SValue.ToString()).GetHashCode();
        }

        public int CompareTo(object obj)
        {
            var other = obj as State<T>;
            return (this.SCost).CompareTo(other.SCost);
        }
    }
}
