using System;

namespace Binary_Search_Tree
{
    class BSTree<T> : BinTree<T> where T:IComparable
    {

        public BSTree()
        {
            root = null;
        }

        private void insertItem(T item , ref Node<T>  tree)
        {
            if ( tree == null )
                tree = new Node<T>(item);

            else if ( item.CompareTo( tree.Data )< 0)
                insertItem( item,  ref tree.Left);

            else if ( item.CompareTo( tree.Data ) >0 ) 
                insertItem( item,  ref tree.Right );
        }

        public void InsertItem (T item)
        {    insertItem( item, ref root );  }

        
    }
}