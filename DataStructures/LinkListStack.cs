using DataStructures.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class LinkListStack<T>
    {
        Node<T> top;

        public LinkListStack()
        {
            this.top = null;
        }

        public void Push(T data)
        {
            Node<T> newNode = new Node<T>(data);
            if (top==null)
            {
                newNode.next = null;
            }
            else
            {
                newNode.next = top;
            }
            top = newNode;
        }

        public T Pop()
        {
            if (top==null)
            {
                throw new NullReferenceException("Stack is empty");
            }
            Node<T> temp = top;
            top = top.next;
            return temp.data;
        }

        public T Peek()
        {
            if (top == null)
            {
                throw new NullReferenceException("Stack is empty");
            }
            return top.data;
        }
    }

}
