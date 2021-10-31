using DataStructures.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class LinkListQueue<T>
    {
        Node<T> front;
        Node<T> rear;

        public LinkListQueue()
        {
            this.front = this.rear = null;
        }

        public void Enqueue(T data)
        {
            Node<T> newNode = new Node<T>(data);
            if (rear == null)
            {
                rear = front = newNode;
            }
            else
            {
                rear.next = newNode;
                rear = newNode;
            }
        }
        public T Dequeue()
        {
            if (front == null)
            {
                throw new NullReferenceException("The Queue is empty");
            }

            Node<T> temp = front;
            front = front.next;

            if (front == null)
            {
                rear = null;
            }

            return temp.data;
        }
        public T Peek()
        {
            if (front == null)
            {
                throw new NullReferenceException("The Queue is empty");
            }
            return front.data;
        }
    }
}
