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
        public BinaryTree<T> lefttree { get; set; }
        public BinaryTree<T> righttree { get; set; }
        bool result = false;
        int leftcount = 0;
        int rightcount = 0;
        public int size=0;
        public BinaryTree(T nodedata)
        {
            this.nodedata = nodedata;
            this.nodedata = nodedata;
            this.lefttree = null;
            this.righttree = null;
           
        }

        public void Insert(T item)
        {
          size++;

            T currentnodevalue = this.nodedata;
            if ((currentnodevalue.CompareTo(item)) > 0)
            {
                if (this.lefttree == null)
                    this.lefttree = new BinaryTree<T>(item);
                else
                    this.lefttree.Insert(item);
                
            }
            else
            {
                if (this.righttree == null)
                    this.righttree = new BinaryTree<T>(item);
                else
                    this.righttree.Insert(item);
               
            }
        }
        public void Display()
        {
            if (this.lefttree != null)
            {
                this.leftcount++;
                this.lefttree.Display();
            }
            Console.WriteLine(this.nodedata.ToString());
            if (this.righttree != null)
            {
                this.rightcount++;
                this.righttree.Display();
            }
            size++;
        }
        
        public void Size()
        {
            Console.WriteLine("Size of Binary Serach Tree " + ( size++));
        }

    }
}