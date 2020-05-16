using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amnon_sProjects.ShortestPath
{
    internal class Vertex
    {
        //Data
        public int Index { get; }
        public int Value { get; }
        public int HValue { get; set; }
        public int CurrWeight { get; set; }
        public Vertex FatherVertex { get; set; }
        public HashSet<Vertex> NeighborsSet { get;}
        public HashSet<Vertex> TransposeNeighborsSet { get; }

        //Ctor
        public Vertex(int value, int index)
        {
            this.Index = index;
            this.Value = value;
            this.FatherVertex = null;
            this.HValue = 0;
            this.CurrWeight = 0;
            this.NeighborsSet = new HashSet<Vertex>();
            this.TransposeNeighborsSet = new HashSet<Vertex>();
        }
        
        // ------------------------ Add neighbors -------------------
        public void AddNeighbor(Vertex neigh)
        {
            this.NeighborsSet.Add(neigh);
        }
        public void AddTransposeNeighbor(Vertex tNeigh)
        {
            this.TransposeNeighborsSet.Add(tNeigh);
        }

        // -------------------------- Overrides ---------------------
        public override string ToString()
        {
            return this.Value.ToString();
        }
        public override int GetHashCode()
        {
            return (this.Value.ToString() + this.Index.ToString()).GetHashCode();
        }
        public override bool Equals(object obj)
        {
            return (obj as Vertex).Index == this.Index;
        }
    }
}
