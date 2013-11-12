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

            LinkedNode node = list.FindLoopNode();
            //comment
            Console.Read();
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

   
}
