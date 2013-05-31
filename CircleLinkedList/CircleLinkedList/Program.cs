using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleLinkedList
{
    /// <summary>
    /// Have a circle linked list and want to find 
    /// 1. the loop node
    /// 2. the mid node
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = InitList();

            LinkedNode node = FindLoopNode(list);

            Console.Read();
        }

        private static LinkedNode FindLoopNode(LinkedList list)
        {
            List<LinkedNode> checkedNodes = new List<LinkedNode>();

            LinkedNode node = list.StartNode;
            while (!checkedNodes.Contains(node))
            {
                checkedNodes.Add(node);
                Console.WriteLine("check node:" + node.Data);
                node = node.NextNode;
            }

            if(checkedNodes.Count > 1)
                Console.WriteLine("loop node is:" + node.Data);

            return node;
        }

        private static LinkedList InitList()
        {
            LinkedNode node = new LinkedNode() { Data = "1" };
            LinkedList list = new LinkedList(node);
            list.AddNode(new LinkedNode(){ Data ="2"});
            list.AddNode(new LinkedNode() { Data = "3" });
            list.AddNode(new LinkedNode() { Data = "4" });
            list.AddNode(new LinkedNode() { Data = "5" });
            list.AddNode(node);
            return list;
        }
    }

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
    }

    public class LinkedNode
    {
        public string Data { get; set; }

        public LinkedNode NextNode { get; set; }
    }
}
