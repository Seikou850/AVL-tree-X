using System;
using System.Diagnostics.PerformanceData;
using AVLTreeLab;

namespace Binary_Search_Tree
{
    class BinTree<T> where T : IComparable
    {
        protected Node<T> root;

        public BinTree() //creates an empty tree
        {
            root = null;
        }
        
        public BinTree(Node<T> node) //creates a tree with node as the root
        {
            root = node;
        }
        public void InOrder(ref string buffer)
        {
            inOrder(root, ref buffer);
        }

        private void inOrder(Node<T> tree, ref string buffer)
        {
            if (tree != null)
            {
                inOrder(tree.Left, ref buffer);
                buffer += tree.Data.ToString() + "(" + tree.count + ")"  + "," ;
                inOrder(tree.Right, ref buffer);
                
            }
        }

        public void PreOrder(ref string buffer)
        {
            preOrder(root, ref buffer);
        }

        private void preOrder(Node<T> tree, ref string buffer)
        {
            if (tree != null)
            {
                buffer += tree.Data.ToString() + ",";
                preOrder(tree.Left, ref buffer);
                preOrder(tree.Right, ref buffer);
            }
        }

        public void PostOrder(ref string buffer)
        {
            postOrder(root, ref buffer);
        }

        private void postOrder(Node<T> tree, ref string buffer)
        {
            if (tree != null)
            {
                postOrder(tree.Left, ref buffer);
                postOrder(tree.Right, ref buffer);
                buffer += tree.Data.ToString() + ",";
            }
        }

        public void Display(ref string buffer)
        {
            display(root, ref buffer);
        }
        private void display(Node<T> tree, ref string buffer)
        {
            if (tree != null)
            {
                display(tree.Left, ref buffer);
                buffer += tree.Data.ToString() + ",";
                display(tree.Right, ref buffer);
            }
        }

        public void Height()
            //Return the max level of the tree
            // Hints: As done for the InOrder method above implement first a private method int Height(Node<T> tree){…}
        {

            // height(root);
            Console.Write("The height of your tree is: ");
            Console.WriteLine(height(root));
        }

        private static int height(Node<T> tree)
        {
            if (tree == null)
                return 0;

            int leftHeight = height(tree.Left);
            int rightHeight = height(tree.Right);

            return Math.Max(leftHeight, rightHeight) + 1;
        }
        
        public bool Contains(T item)
        {
            if(isPresent(root, item))
            {
                return true;
            }

            return false;
        }

        private bool isPresent(Node<T> tree, T item)
        {
            if (tree == null)
                return false;
            if (item.CompareTo(tree.Data) == 0)
                return true;
            else if (item.CompareTo(tree.Data)< 0)
                return isPresent(tree.Left, item);
            else if (item.CompareTo(tree.Data) > 0)
                return isPresent(tree.Right, item);

            return false;
        }
        
        public void count()
        {
            Console.WriteLine("The total number of words is: " + Count(root));
        }
        private int Count(Node<T> tree)
        {
            if (tree == null)
            {
                return 0;
            }

            return 1 + Count(tree.Left) + Count(tree.Right);
        }
        
    }
}

    