using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amnon_sProjects.ShortestPath
{
    internal class Graph
    {
        // Data
        public int VertexAmount { get; }
        public int[,] AdjacencyMatrix { get;}
        public int[,] AdjacencyMatrixTranspose { get;}
        public HashSet<Vertex> VertexSet { get; }
        public HashSet<Edge> EdgeSet { get; }

        // Ctor
        public Graph(int vAmount, HashSet<Edge> edgeSet, HashSet<Vertex> vertexSet)
        {
            this.VertexAmount = vAmount;
            this.EdgeSet = edgeSet;
            this.VertexSet = vertexSet;
            this.AdjacencyMatrix = new int[VertexAmount, this.VertexAmount];
            this.AdjacencyMatrixTranspose = new int[VertexAmount, VertexAmount];
            this.BuildGraph();
        }

        // ---------------------- Building the matrix -------------------
        public void BuildGraph()
        {
            foreach (Edge edge in this.EdgeSet)
            {
                int from = edge.FromVertex.Index, to = edge.ToVertex.Index;
                int weight = edge.Weight;
                this.AdjacencyMatrix[from, to] = weight;
                this.AdjacencyMatrixTranspose[to, from] = weight;
            }
        }

        // --------------------- Traversing methods ----------------------

        public void BFS(Vertex source, bool onTranspose /*True -> traverse G transpose*/)
        {
            foreach (Vertex v in this.VertexSet) // Initializing heuristic value to infinity 
                v.HValue = int.MaxValue;
            source.HValue = 0; // Initialize source distance from source to be 0
            Queue<Vertex> queue = new Queue<Vertex>();
            queue.Enqueue(source);// Add source to the queue 
            while (queue.Any())
            {
                Vertex curr = queue.Dequeue();
                if (!onTranspose)
                {
                    foreach (var neigh in curr.NeighborsSet.Where(neigh =>
                        neigh.HValue == int.MaxValue)) // Traverse the unvisited nodes
                    {
                        neigh.HValue = curr.HValue + 1; // Dist from source = father dist + 1
                        queue.Enqueue(neigh);
                    }
                }else
                {
                    foreach (Vertex neigh in curr.NeighborsSet.Where(neigh =>
                        neigh.HValue == int.MaxValue))
                    {
                        neigh.HValue = curr.HValue + 1;
                        queue.Enqueue(neigh);
                    }
                }
            }
        }
    }
}
