using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assessed_Exercise_2
{
    public class BinaryTree
    {
        public class Node<T> where T : IComparable
        {
            private T data;
            public Node<T> Left, Right;

            public Node(T item)
            {
                data = item;
                Left = null;
                Right = null;
            }
            public T Data
            {
                set{data = value;}
                get{return data;}
            }
        }

        class BinTree<T> where T : IComparable
        {
            
            private Node<T> root;

            public BinTree() //creates an empty tree
            {
                root = null;
            }

            public BinTree(Node<T> node) //creates a tree with node as the root
            {
                root = node;
            }

        }

    }
}