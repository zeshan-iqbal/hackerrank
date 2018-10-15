//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Runtime.ConstrainedExecution;

//namespace Day9_Recursion
//{
//    //https://www.hackerrank.com/challenges/30-binary-trees
//    class Node_BST
//    {
//        public Node_BST left, right;
//        public int data;
//        public Node_BST(int data)
//        {
//            this.data = data;
//            left = right = null;
//        }
//    }

//    public class Day23_LevelOrderTraversingBST
//    {
//        static Queue<Node_BST> nodes = new Queue<Node_BST>();
//        static void levelOrder(Node_BST root)
//        {
//            if(root != null)
//                nodes.Enqueue(root);
            
//            while (nodes.TryDequeue(out var node))
//            {
//                Console.WriteLine($"{node.data} ");
//                if(node.left != null)
//                    nodes.Enqueue(node.left);
//                if (node.right != null)
//                    nodes.Enqueue(node.right);
//            }
//        }
//    }
//}