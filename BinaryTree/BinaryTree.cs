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

        public BinaryTree(int nums)
        {
            root = new Node(nums); 
        }

        public void Add(int nums)
        {
            //Node newNode = new Node(nums);
            //newNode.Nums = nums;
            if (root == null)
            {
                root = new Node(nums);
                return;
            }
            else
            {
                Node currentlocation = root;
                //Node seedling;
                while (true)
                {
                    //seedling = currentlocation;
                    if (nums < currentlocation.Nums)
                    {
                        //currentlocation = currentlocation.Left;
                        if (currentlocation.Left == null)
                        {
                            currentlocation.Left = new Node(nums);
                            count++;
                            break;
                        }
                        else
                            currentlocation = currentlocation.Left;
                    }
                    if(nums >= currentlocation.Nums)
                    {
                        if (currentlocation.Right == null)
                        {
                            currentlocation.Right = new Node(nums);
                            count++;
                            break;
                        }
                        else
                            currentlocation = currentlocation.Right;
                    }
                }
            }
        }

        public bool Search(int nums)
        {
            Node currentlocation = root;
            while(currentlocation != null)
            {
                if (nums == currentlocation.Nums)
                {
                    return (true);
                }
                if(nums > currentlocation.Nums)
                {
                    if(currentlocation.Right == null)
                    {
                        break;
                    }
                    else
                        currentlocation = currentlocation.Right;
                }
                    if(nums < currentlocation.Nums)
                    {
                        if (currentlocation.Left == null)
                        {
                            break;
                        }
                        else
                        currentlocation = currentlocation.Left;
                }
            }
            return (false);
        }
    }
}
