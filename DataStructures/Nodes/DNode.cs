using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Nodes
{
    public class DNode<T>
    {
        public T data;
        public DNode<T> prev;
        public DNode<T> next;
        public DNode(T d)
        {
            data = d;
            prev = null;
            next = null;
        }
    }
}
