using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    public class Graph
    {
        private int vertexNumber;

        public int MaxVertexNumber
        {
            get
            {
                return vertexNumber;
            }
        }

        public bool HasDirect
        {
            get;
            private set;
        }

        public List<Vertex> VertexCollection
        {
            get;
            private set;
        }

        //public List<Edge> Edges
        //{
        //    get;
        //    private set;
        //}

        public int[,] AdjacencyMatrix
        {
            get;
            private set;
        }

        public Graph(int vertexNumber, bool hasDirect = false)
        {
            this.vertexNumber = vertexNumber;
            this.VertexCollection = new List<Vertex>();
            this.AdjacencyMatrix = new int[vertexNumber, vertexNumber];

            this.HasDirect = hasDirect;
        }

        public void AddVertex(Vertex v)
        { 
            if(!this.VertexCollection.Contains(v))
            {
                this.VertexCollection.Add(v);
            }
        }

        public void AddEdge(int start, int end, int weight = int.MaxValue)
        {
            if (start < this.MaxVertexNumber && end < this.MaxVertexNumber)
            {
                Vertex vstart = this.VertexCollection[start];
                Vertex vend = this.VertexCollection[end];

                this.AddEdge(vstart, vend, weight);
            }
        }

        public void AddEdge(Vertex start, Vertex end)
        {
            this.AddEdge(start, end, 1);
        }

        public void AddEdge(Vertex start, Vertex end, int weight)
        {
            if (!this.VertexCollection.Contains(start))
                this.VertexCollection.Add(start);

            if (!this.VertexCollection.Contains(end))
                this.VertexCollection.Add(end);

            int startIndex = this.VertexCollection.IndexOf(start);
            int endIndex = this.VertexCollection.IndexOf(end);

            if (this.AdjacencyMatrix[startIndex, endIndex] == 0)
                this.AdjacencyMatrix[startIndex, endIndex] = weight;
            else
                throw new ArgumentException();

            if(!HasDirect)
            {
                //need to set reverse value as well
                if (this.AdjacencyMatrix[endIndex, startIndex] == 0)
                    this.AdjacencyMatrix[endIndex, startIndex] = weight;
                else
                    throw new ArgumentException();

            }
        }

        public void DisplayEdge(int start, int end)
        {
            if (0 <= start && start < this.MaxVertexNumber && 0 <= end  && end< this.MaxVertexNumber)
            {
                Console.WriteLine(this.VertexCollection[start].Name + this.VertexCollection[end].Name);
            }
        }

        public void PrintAdjacencyMatrix()
        {
            if (this.AdjacencyMatrix != null)
            {
                for (int i = 0; i < this.MaxVertexNumber; i++)
                {
                    for (int j = 0; j < this.MaxVertexNumber; j++)
                    {
                        Console.Write(this.AdjacencyMatrix[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
        }

        public Vertex GetNextUnvisitedVertex(Vertex vertex)
        {
            if(vertex == null || !this.VertexCollection.Contains(vertex))
                return null;

            int index = this.VertexCollection.IndexOf(vertex);

            for (int i = 0; i < this.MaxVertexNumber; i++)
            {
                if (index != i && this.AdjacencyMatrix[index, i] > 0 && this.VertexCollection[i].Visited == false)
                    return this.VertexCollection[i];
            }

            return null;
        }

        public void ClearVisitInfo()
        {
            foreach (var vertex in this.VertexCollection)
            {
                vertex.Visited = false;
            }
        }
    }
}
