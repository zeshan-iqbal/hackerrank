using System.Collections.Generic;

namespace Day9_Recursion
{
    public class Day18_Stack_Queue
    {
        Stack<char> stack = new Stack<char>();
        Queue<char> queue = new Queue<char>();

        public void pushCharacter(char c)
        {
            stack.Push(c);
        }

        public void enqueueCharacter(char c)
        {
            queue.Enqueue(c);
        }

        public char popCharacter()
        {
            return stack.Pop();
        }

        public char dequeueCharacter()
        {
            return queue.Dequeue();
        }
    }
}