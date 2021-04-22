using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public class tNode
    {
        public int data;
        public tNode leftPtr;
        public tNode rightPtr;

        public tNode(int data)
        {
            this.data = data;
            leftPtr = null;
            rightPtr = null;
        }
    }
    public class BinaryTree
    {
        public tNode root;

        public BinaryTree()
        {
            root = null;
        }
        
        public void inOrderTraversal(tNode root)
        {
            if (root == null)
                return;
            inOrderTraversal(root.leftPtr);
            Console.WriteLine($"{root.data} ");
            inOrderTraversal(root.rightPtr);
        }

        public void preOrderTraversal(tNode root)
        {
            if (root == null)
                return;
            Console.WriteLine($"{root.data} ");
            preOrderTraversal(root.leftPtr);
            preOrderTraversal(root.rightPtr);
        }

        public void postOrderTraversal(tNode root)
        {
            if (root == null)
                return;

            postOrderTraversal(root.leftPtr);
            postOrderTraversal(root.rightPtr);
            Console.WriteLine($"{root.data} ");
        }

        public bool isBST(tNode root,int min,int max)
        {
            //if (root == null)
            //    return true;
            //if (root.data < min)
            //    return false;
            //if (root.data > max)
            //    return false;
            //return (isBST(root.rightPtr, root.data, max) && isBST(root.leftPtr,min,root.data));

            if (root == null)
                return true;
            if (root.data < min)
                return false;
            if (root.data > max)
                return false;
            return (isBST(root.rightPtr, root.data, max) && isBST(root.leftPtr, min, root.data));
        }

        
    }
}
