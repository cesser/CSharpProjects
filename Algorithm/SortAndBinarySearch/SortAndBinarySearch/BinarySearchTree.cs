using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAndBinarySearch
{
    public class BinarySearchTree
    {
        private BinaryTree tree;

        public BinarySearchTree()
        {
            this.tree = new BinaryTree();
        }

        public void AddNode(TreeNode node)
        {
            TreeNode current = this.tree.Root;
            while (true)
            {
                if (current.Data <= node.Data)
                {
                    if (current.RightNode != null)
                        current = current.RightNode;
                    else
                    {
                        current.RightNode = node;
                        break;
                    }
                }
                else
                {
                    if (current.LeftNode != null)
                        current = current.LeftNode;
                    else
                    {
                        current.LeftNode = node;
                        break;
                    }
                }
                
            }
        }
    }
}
