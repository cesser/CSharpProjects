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

        public void AddNode(int data)
        {
            if (this.Root != null)
                this.Root.AddNode(data);
        }
    }

    public class TreeNode
    {
        public int Data { get; set; }

        public TreeNode LeftNode { get; set; }

        public TreeNode RightNode { get; set; }

        public void AddNode(int data)
        {
            if(data == this.Data)
                return;

            if (data > this.Data)
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

        public void DeleteNode(int data)
        {
            if (data == this.Data)
            {
                //delete            
            }
            else
            {
                if (this.Data < data)
                {
                    if(this.RightNode != null)
                        this.RightNode.DeleteNode(data);
                }
                else
                {
                    if(this.LeftNode != null)
                        this.LeftNode.DeleteNode(data);
                }
            }

        }

    }
}
