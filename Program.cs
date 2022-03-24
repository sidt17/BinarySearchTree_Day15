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
            BinaryTree<int> binarytree = new BinaryTree<int>(56);
            binarytree.Insert(30);
            binarytree.Insert(70);
            Console.WriteLine("Binary Search Tree ");
            binarytree.Display();
            Console.ReadLine();
        }
    }
}