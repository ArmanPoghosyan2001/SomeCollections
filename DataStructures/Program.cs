using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {

            DoubleLinkedList<int> single = new DoubleLinkedList<int>();
            single.InsertLast(5);
            single.InsertLast(51);
            single.InsertLast(52);
            single.InsertLast(53);
            single.InsertLast(54);

            single.ReverseLinkedList();
        }
    }
}
