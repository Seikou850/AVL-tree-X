using System;

namespace Binary_Search_Tree
{
    class Node<T>
    {
        private T data;
        private int balaceFactor = 0;
        public Node<T> Left, Right;
        public int count;


        public int BalanceFactor
        {
            get { return balaceFactor; }
            set { balaceFactor = value; }
        }

        public Node(T item)
        {
            data = item;
            Left = null;
            Right = null;
        }

        public T Data
        {
            set { data = value; }
            get { return data; }
        }
    }
}