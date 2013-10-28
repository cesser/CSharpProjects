using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    /// <summary>
    /// Breadth first search
    /// </summary>
    public static class BFS
    {
        public static void BFS1(Graph g, Vertex startVertex)
        {
            if (g == null)
                return;

            Queue<Vertex> q = new Queue<Vertex>();
           
            q.Enqueue(startVertex);
            startVertex.Visited = true;

            while (q.Count > 0)
            {
                Vertex v = q.Dequeue();
                v.Display();
                

                Vertex next = g.GetNextUnvisitedVertex(v);
                while (next != null)
                {
                    q.Enqueue(next);
                    next.Visited = true;
                    next = g.GetNextUnvisitedVertex(v);
                }
            }

            g.ClearVisitInfo();

        }
    }
}
