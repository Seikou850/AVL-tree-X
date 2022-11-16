using System;
using AVLTreeLab;
using Binary_Search_Tree;

namespace AVLTreeLab
{
    class AVLTree<T> : BSTree<T> where T : IComparable
    {
        public int key;
        public int count;

        public new void InsertItem(T item)
        {
            insertItem(item, ref root);
        }

        class countNode<T> where T : IComparable
        {
            public int count;

            static countNode<T> newNode(int key)
            {
                countNode<T> node = new countNode<T>();
                node.count = 1;
                return (node);
            }
            
        }

        private Node<T> insertItem(T item, ref Node<T> tree)
        {
            if (tree == null)
                tree = new Node<T>(item);
            else if (item.CompareTo(tree.Data) < 0)
            {
                insertItem(item, ref tree.Left);
            }
            else if (item.CompareTo(tree.Data) > 0)
            {
                insertItem(item, ref tree.Right);
            }

            tree.BalanceFactor = height(tree.Left) -
                                 height(tree.Right);
            if (tree.BalanceFactor <= -2)
                rotateLeft(ref tree);
            if (tree.BalanceFactor >= 2)
                rotateRight(ref tree);

            if (item.CompareTo(tree.Data) == 0)
            {
                (tree.count)++;
                return tree;
            }
            return tree;
        }

        private void rotateRight(ref Node<T> tree)
        {
            if (tree.Left.BalanceFactor < 0) //double rotate
                rotateLeft(ref tree.Left);

            Node<T> oldRoot = tree;
            Node<T> newRoot = oldRoot.Left;

            oldRoot.Left = newRoot.Right;
            newRoot.Left = oldRoot;

            tree = newRoot;
        }

        private void rotateLeft(ref Node<T> tree)
        {
            if (tree.Right.BalanceFactor > 0) //double rotate
                rotateRight(ref tree.Right);

            Node<T> oldRoot = tree;
            Node<T> newRoot = oldRoot.Right;

            oldRoot.Right = newRoot.Left;
            newRoot.Left = oldRoot;

            tree = newRoot;
        }

        private int height(Node<T> tree)
        {
            if (tree == null)
                return 0;

            int leftHeight = height(tree.Left);
            int rightHeight = height(tree.Right);

            return Math.Max(leftHeight, rightHeight) + 1;

        }
    }
}

//  class countNode<T> where T : IComparable
// {
//     public int count;
//     
//     static countNode<T> newNode(int key)
//     {
//         countNode<T> node = new countNode<T>();
//         node.count = 1;
//         return (node);
//     }
//
//     static AVLTree<T> insert(AVLTree<T> tree, int key)
//     {
//         if (key == tree.key)
//         {
//             (tree.count)++;
//             return tree;
//         }
//
//         return tree;
//     }
// }



    



