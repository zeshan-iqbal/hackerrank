using System.Globalization;
//https://www.hackerrank.com/challenges/30-linked-list/problem?h_r=next-challenge&h_v=zen&h_r=next-challenge&h_v=zen
namespace Day9_Recursion
{
    using System;
    class Node
    {
        public int data;
        public Node next;
        public Node(int d)
        {
            data = d;
            next = null;
        }

    }
    class Solution
    {
        public static Node insert(Node head, int data)
        {
            var node = new Node(data);

            if (head == null)
                return node;

            Node tail = head;
            while (tail.next != null)
            {
                tail = tail.next;
            }

            tail.next = node;
            return head;
        }

        public static void display(Node head)
        {
            Node start = head;
            while (start != null)
            {
                Console.Write(start.data + " ");
                start = start.next;
            }
        }
        static void Main_LinkedList(String[] args)
        {

            Node head = null;
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                head = insert(head, data);
            }
            display(head);
        }
    }

}