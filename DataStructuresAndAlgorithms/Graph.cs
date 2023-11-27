using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms
{
    class Graph
    {
        private int TotalNodes;

        private LinkedList<int>[] adj;

        public Graph(int numOfNodes)
        {
            TotalNodes = numOfNodes;
            adj = new LinkedList<int>[numOfNodes];

            for (int i = 0; i < adj.Length; i++)
                adj[i] = new LinkedList<int>();
        }

        void AddEdge(int nodeStart, int nodeEnd)
        { 
            adj[nodeStart].AddLast(nodeEnd); 
        }

        public void GraphInitialize(Graph graph)
        {
            this.AddEdge(0, 1);
            this.AddEdge(0, 2);
            this.AddEdge(1, 2);
            this.AddEdge(2, 0);
            this.AddEdge(2, 3);
            this.AddEdge(3, 3);
        }

        public void GraphInfo() 
        {
            foreach(var edge in this.adj)
            {
                foreach(var po in edge)
                    Console.WriteLine(po);
                Console.WriteLine("New node.");
            }
        }

        public void BFS(int node)
        {

        }

        public void DFS(int node)
        {

        }
    }
}
