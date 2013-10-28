using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    public class Vertex
    {
        public string Name
        {
            get;
            private set;
        }

        public bool Visited
        {
            get;
            set;
        }

        public Vertex(string name)
        {
            this.Name = name;
        }

        public void Display()
        {
            Console.WriteLine(this.Name);
        }
    }

    public class Edge
    {
        public Vertex Start
        {
            get;
            private set;
        }

        public Vertex End
        {
            get;
            private set;
        }

        public Edge(Vertex start, Vertex end)
        {
            this.Start = start;
            this.End = end;
        }
    }
}
