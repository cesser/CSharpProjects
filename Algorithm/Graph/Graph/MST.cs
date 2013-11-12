using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    /// <summary>
    /// Get the mini spanning tree
    /// </summary>
    public static class MST
    {
        public static void MST1(Graph g, Vertex startVertex)
        {
            Stack<Vertex> stack = new Stack<Vertex>();

            stack.Push(startVertex);

            while (stack.Count > 0)
            {
                Vertex v = stack.Pop();

                v.Visited = true;

                Vertex next = g.GetNextUnvisitedVertex(v);

                if (next != null)
                {
                    int start = g.VertexCollection.IndexOf(v);
                    int end = g.VertexCollection.IndexOf(next);
                    g.DisplayEdge(start, end);

                    stack.Push(v);
                    stack.Push(next);
                }
            }

            g.ClearVisitInfo();
        }
    }
}
