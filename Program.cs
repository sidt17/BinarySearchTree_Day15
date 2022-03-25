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
            BinaryTree<int> Tree = new BinaryTree<int>(56);
            Tree.Insert(30);
            Tree.Insert(70);
            Tree.Insert(22);
            Tree.Insert(40);
            Tree.Insert(60);
            Tree.Insert(95);
            Tree.Insert(11);
            Tree.Insert(65);
            Tree.Insert(3);
            Tree.Insert(16);
            Tree.Insert(63);
            Tree.Insert(67);
            Console.WriteLine("Binary Search Tree ");
            Tree.Display();
            bool find = Tree.search(63, Tree);

        }
    }
}