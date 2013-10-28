using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    /// <summary>
    /// Depth first search
    /// </summary>
    public static class DFS
    { 
        public static void DFS1(Graph g, Vertex startVertex)
        {
            Stack<Vertex> stack = new Stack<Vertex>();
            stack.Push(startVertex);
            
            while (stack.Count > 0)
            {
                Vertex v = stack.Pop();
                if (!v.Visited)
                {
                    v.Display();
                    v.Visited = true;
                }

                Vertex next = g.GetNextUnvisitedVertex(v);

                if (next != null)
                {
                    stack.Push(v);
                    stack.Push(next);
                }
            }

            g.ClearVisitInfo();
        }
    }
}
