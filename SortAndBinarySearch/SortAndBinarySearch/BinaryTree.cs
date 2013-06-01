using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAndBinarySearch
{
    public class BinaryTree
    {
        public TreeNode Root { get; set; }
    }

    public class TreeNode
    {
        public int Data { get; set; }

        public TreeNode LeftNode { get; set; }

        public TreeNode RightNode { get; set; }

        public void AddNode(int data)
        {
            if (data >= this.Data)
            {
                if (this.RightNode != null)
                    this.RightNode.AddNode(data);
                else
                    this.RightNode = new TreeNode() { Data = data };

            }
            else
            {
                if (this.LeftNode != null)
                    this.LeftNode.AddNode(data);
                else
                    this.LeftNode = new TreeNode() { Data = data };
            }
        }

    }
}
