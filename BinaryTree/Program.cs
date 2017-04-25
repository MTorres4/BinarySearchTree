using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree Tree1 = new BinaryTree();
            Tree1.Add(14);
            Tree1.Add(7);
            Tree1.Add(22);
            Tree1.Add(9);
            Tree1.Add(12);

            bool SearchTree = Tree1.Search(12);

            if(SearchTree)
            {
                Console.WriteLine("Found");
            }

            else
            {
                Console.WriteLine("Not Found");
            }

            Console.ReadLine();
        }
    }
}
