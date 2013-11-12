using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAndBinarySearch
{
    public static class TreeTraversal
    {
        public static void PreOrderTraversal(TreeNode node)
        {
            if (node != null)
            {
                Console.WriteLine(node.Data);
                PreOrderTraversal(node.LeftNode);
                PreOrderTraversal(node.RightNode);
            }
        }

        public static void InOrderTraversal(TreeNode node)
        {
            if (node != null)
            {
                InOrderTraversal(node.LeftNode);
                Console.WriteLine(node.Data);
                InOrderTraversal(node.RightNode);
            }
        }

        public static void PostOrderTraversal(TreeNode node)
        {
            if (node != null)
            {
                PostOrderTraversal(node.LeftNode);
                PostOrderTraversal(node.RightNode);
                Console.WriteLine(node.Data);
            }
        }

    }
}
