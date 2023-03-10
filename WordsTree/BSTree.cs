using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace WordsTree
{
    class BSTree<T> : BinTree<T> where T : IComparable
    {
        public BSTree()
        {
            root = null;
        }

        public void InsertItem(T item)
        {
            insertItem(item, ref root);
        }

        private void insertItem(T item, ref Node<T> tree) // ref as we are changing the tree
        {
            //stopping condition
            if (tree == null)
                tree = new Node<T>(item);
            //recursive
            else if (item.CompareTo(tree.Data) < 0)
                insertItem(item, ref tree.Left);
            else if (item.CompareTo(tree.Data) > 0)
                insertItem(item, ref tree.Right);
            else
            { } // if they where the same do nothing
        }

    }
}
