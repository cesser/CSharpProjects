using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleLinkedList
{
    public class LinkedList
    {
        public LinkedNode StartNode { get; set; }

        private LinkedNode CurrentNode { get; set; }

        public LinkedList(LinkedNode startNode)
        {
            this.StartNode = startNode;
            this.CurrentNode = startNode;
        }

        public void AddNode(LinkedNode node)
        {
            if (this.CurrentNode != null)
            {
                this.CurrentNode.NextNode = node;
                this.CurrentNode = node;
            }
        }

        public LinkedNode FindLoopNode()
        {
            List<LinkedNode> checkedNodes = new List<LinkedNode>();

            LinkedNode node = this.StartNode;
            while (!checkedNodes.Contains(node))
            {
                checkedNodes.Add(node);
                Console.WriteLine("check node:" + node.Data);
                node = node.NextNode;
            }

            if (checkedNodes.Count > 1)
                Console.WriteLine("loop node is:" + node.Data);

            return node;
        }
    }

    public class CircleLinkedList
    {
        private int linkedListLength;
        private int currentIndex;
        private LinkedNode[] nodes;


        public CircleLinkedList(int length)
        {
            linkedListLength = length;
            nodes = new LinkedNode[length];
        }

        public void AddNode(LinkedNode node)
        {
            int index = GetNextIndex();
            currentIndex = index;
            nodes[index] = node;
        }

        public void Display()
        { 
        
        }

        private int GetNextIndex()
        { 
            //if(currentIndex )
            return 0;
        }

    }

    public class LinkedNode
    {
        public string Data { get; set; }

        public LinkedNode NextNode { get; set; }
    }
}
