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
            //Graph g = InitIndirectedGraph();

            Graph g = InitIndirectedGraph2();

            g.PrintAdjacencyMatrix();

            //BFS.BFS1(g, g.VertexCollection[0]);
            //DFS.DFS1(g, g.VertexCollection[0]);
            //MST.MST1(g, g.VertexCollection[0]);
            
            

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

        static Graph InitIndirectedGraph2()
        {
            Graph g = new Graph(7);

            for (int i = 0; i < g.MaxVertexNumber; i++)
            {
                g.AddVertex(new Vertex(((char)('A' + i)).ToString()));
            }

            g.AddEdge(0, 1, 2);
            g.AddEdge(0, 3, 1);
            g.AddEdge(1, 3, 3);
            g.AddEdge(1, 4, 10);
            g.AddEdge(2, 5, 5);
            g.AddEdge(2, 0, 4);
            g.AddEdge(3, 2, 2);
            g.AddEdge(3, 5, 8);
            g.AddEdge(3, 4, 2);
            g.AddEdge(3, 6, 4);
            g.AddEdge(4, 6, 6);
            g.AddEdge(6, 5, 1);


            return g;
        }
    }
}