using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class Tree
    {
        private Node root;
        private int count;

        public Tree()
        {
            root = null;
            count = 0;
        }

        public void Add(int data)
        {
            Node newNode = new Node();
            newNode.Data = data;
            if(root == null)
            {

            }
        }
    }
}
