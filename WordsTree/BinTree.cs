using System;
using System.Collections.Generic;
using System.Text;

namespace WordsTree
{
    class BinTree<T> where T : IComparable
    {
        protected private Node<T> root; //change to protected

        public BinTree()  //creates an empty tree
        {
            root = null;
        }
        public BinTree(Node<T> node)  //creates a tree with node as the root
        {
            root = node;
        }

        public int Count() // recursion
        {
            return count(root);
        }

        private int count(Node<T> tree)
        {
            if (tree == null)
                return 0;
            return 1 + count(tree.Left) + count(tree.Right);
        }

        public int Height()
        {
            return height(root);
        }

        private int height(Node<T> tree)
        {
            //higher count left or right?
            if (count(tree.Left) > 0 || count(tree.Right) > 0)
            {
                if (count(tree.Left) > count(tree.Right))
                {
                    return 1 + height(tree.Left);
                }
                else
                {
                    return 1 + height(tree.Right);
                }
            }
            else return 0;
        }
    }
}
