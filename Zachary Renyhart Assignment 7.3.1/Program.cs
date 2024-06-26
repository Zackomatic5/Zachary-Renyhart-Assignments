﻿using BinaryTree;

namespace Zachary_Renyhart_Assignment_7._3._1
{
    internal class Program
    {


        //You are given the root of a binary search tree (BST) and an integer val.

        //Find the node in the BST that the node's value equals val and
        //return the subtree rooted with that node. If such a node does not exist,
        //return null.
        static void Main(string[] args)
        {
            //Instantiate a new binary tree   //This is a constructor
            BinaryTree<int> binarytree = new BinaryTree<int>();
            //This is creating the binary tree and adding a bunch of nodes.
            binarytree.Add(8);
            binarytree.Add(5);
            binarytree.Add(12);
            binarytree.Add(27);
            binarytree.Add(35);
            binarytree.Add(11);
            binarytree.Add(22);
            binarytree.Add(15);
            binarytree.Add(13);

            foreach (var item in binarytree)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            //This is using the methods inside the package
            binarytree.PrintToConsole();
            //This is printing the binary tree
            binarytree.PrintAsTree();
            //This displays true if the binary tree contains "8".




        }

    }
    public class BST<T>
    {
    
    }
}
