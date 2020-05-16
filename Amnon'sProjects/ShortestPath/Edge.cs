namespace Amnon_sProjects.ShortestPath
{
    internal class Edge
    {
        // Data
        public Vertex FromVertex { get; }
        public Vertex ToVertex { get; }
        public int Weight { get; }

        // Ctor
        public Edge(Vertex from, Vertex to, int weight)
        {
            this.FromVertex = from;
            this.ToVertex = to;
            this.Weight = weight;
            this.FromVertex.AddNeighbor(to);
            this.ToVertex.AddTransposeNeighbor(from);
        }

        // -------------------------- Overrides ---------------------
        public override string ToString()
        {
            return "(" + this.FromVertex + "," + this.ToVertex + ")";
        }
        public override bool Equals(object obj)
        {
            Edge other = obj as Edge;
            return this.FromVertex.Equals(other.FromVertex)
                   && this.ToVertex.Equals(other.ToVertex);
        }
        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = (FromVertex != null ? FromVertex.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (ToVertex != null ? ToVertex.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ Weight;
                return hashCode;
            }
        }
    }
}
