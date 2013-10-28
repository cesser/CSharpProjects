using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph g = InitIndirectedGraph();

            g.PrintAdjacencyMatrix();

            //BFS.BFS1(g, g.VertexCollection[0]);
            //DFS.DFS1(g, g.VertexCollection[0]);
            MST.MST1(g, g.VertexCollection[0]);
            Console.Read();
        }

        static Graph InitIndirectedGraph()
        {
            Graph g = new Graph(20);
            
            for (int i = 0; i < g.MaxVertexNumber; i++)
            {
                g.AddVertex(new Vertex(((char)('A' + i)).ToString()));
            }

            g.AddEdge(0, 1);
            g.AddEdge(1, 2);
            g.AddEdge(2, 3);
            g.AddEdge(0, 4);
            g.AddEdge(4, 5);
            g.AddEdge(5, 6);
            g.AddEdge(0, 7);
            g.AddEdge(7, 8);
            g.AddEdge(8, 9);
            g.AddEdge(0, 10);
            g.AddEdge(10, 11);
            g.AddEdge(11, 12);


            return g;
        }
    }
}