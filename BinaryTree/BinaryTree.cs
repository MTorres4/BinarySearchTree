using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class BinaryTree
    {
        public Node root;
        private int count;

        public BinaryTree()
        {
            root = null;
            count = 0;
        }

        public void Add(int nums)
        {
            Node newNode = new Node(nums);
            newNode.Nums = nums;
            if (root == null)
            {
                root = newNode;
            }
            else
            {
                Node currentlocation = root;
                Node seedling;
                while (true)
                {
                    seedling = currentlocation;
                    if (nums < currentlocation.Nums)
                    {
                        currentlocation = currentlocation.Left;
                    }
                    if (currentlocation == null)
                    {
                        seedling.Left = newNode;
                        count++;
                        break;
                    }
                    else
                    {
                        currentlocation = currentlocation.Right;
                        if (currentlocation == null)
                        {
                            seedling.Right = newNode;
                            count++;
                            break;
                        }
                    }
                }
            }
        }

        //public object SearchForNode(object node, Node root)
        //{
        //    current = root;
        //    if (current == null)
        //        return "Sorry, not found";
        //    if(Convert.ToInt32(node)== Convert.ToInt32(current.))
        //}
    }
}
