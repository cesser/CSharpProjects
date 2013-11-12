using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    /// <summary>
    /// Find shorest path from one node to another
    /// </summary>
    public static class ShortestPath
    {

        public static void GetAllShortestPaths(Vertex node, Graph g)
        {
            foreach (var vertex in g.VertexCollection)
            {
                if (vertex != null)
                    GetShortestPath(node, vertex);
            } 
        }

      


    }
}
