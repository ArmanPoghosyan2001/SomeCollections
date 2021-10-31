using DataStructures.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class DoubleLinkedList<T>
    {
        private DNode<T> head;

        public void InsertFront(T data)
        {
            DNode<T> newNode = new DNode<T>(data);
            newNode.next = head;
            newNode.prev = null;
            if (head != null)
            {
                head.prev = newNode;
            }
            head = newNode;
        }
        public void InsertLast(T data)
        {
            DNode<T> newNode = new DNode<T>(data);
            if (head == null)
            {
                newNode.prev = null;
                head = newNode;
                return;
            }
            DNode<T> lastNode = GetLastNode();
            lastNode.next = newNode;
            newNode.prev = lastNode;
        }
        public DNode<T> GetLastNode()
        {
            DNode<T> temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }
        public void InsertAfter(DNode<T> prev_node, T data)
        {
            if (prev_node == null)
            {
                throw new ArgumentNullException("The given prevoius node cannot be null");
            }
            DNode<T> newNode = new DNode<T>(data);
            newNode.next = prev_node.next;
            prev_node.next = newNode;
            newNode.prev = prev_node;
            if (newNode.next != null)
            {
                newNode.next.prev = newNode;
            }
        }
        //public void DeleteNodebyKey(T key)
        //{
        //    DNode<T> temp = head;
        //    if (temp != null && temp.data == key)
        //    {
        //        head = temp.next;
        //        head.prev = null;
        //        return;
        //    }
        //    while (temp != null && temp.data != key)
        //    {
        //        temp = temp.next;
        //    }
        //    if (temp == null)
        //    {
        //        return;
        //    }
        //    if (temp.next != null)
        //    {
        //        temp.next.prev = temp.prev;
        //    }
        //    if (temp.prev != null)
        //    {
        //        temp.prev.next = temp.next;
        //    }
        //}

        public void ReverseLinkedList()
        {
            DNode<T> prev = null;
            DNode<T> current = head;
            DNode<T> temp = null;
            DNode<T> node = null;
            while (current != null)
            {
                temp = current.next;
                node = current.prev;
                current.next = prev;
                current.prev = node;
                prev = current;
                prev.prev = current.prev;
                current = temp;
            }
            head = prev;
        }
    }
}
