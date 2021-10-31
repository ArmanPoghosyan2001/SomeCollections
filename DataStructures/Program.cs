using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {

            LinkListQueue<int> stack = new LinkListQueue<int>();
            stack.Enqueue(3);
            stack.Enqueue(4);
            stack.Enqueue(5);
            stack.Enqueue(6);
            stack.Enqueue(7);

            var t = stack.Dequeue();
            var k = stack.Peek();
        }
    }
}
