using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class BinaryTree<T> where T : IComparable
    {
        T nodedata;
        public BinaryTree<T> leftnode { get; set; }
        public BinaryTree<T> rightnode { get; set; }
        bool result = false;

        public BinaryTree(T nodedata)                                  
        {
            this.nodedata = nodedata;
            this.nodedata = nodedata;
            this.leftnode = null;
            this.rightnode = null;
        }

        public void Insert(T item)
        {
            T currentnodevalue = this.nodedata;
            if ((currentnodevalue.CompareTo(item)) > 0)
            {
                if (this.leftnode == null)
                    this.leftnode = new BinaryTree<T>(item);
                else
                    this.leftnode.Insert(item);
            }
            else
            {
                if (this.rightnode == null)
                    this.rightnode = new BinaryTree<T>(item);
                else
                    this.rightnode.Insert(item);
            }
        }
        public void Display()
        {
            if (this.leftnode != null)
            {
                this.leftnode.Display();
            }
            Console.WriteLine(this.nodedata.ToString());
            if (this.rightnode != null)
            {
                this.rightnode.Display();
            }
        }
    }
}