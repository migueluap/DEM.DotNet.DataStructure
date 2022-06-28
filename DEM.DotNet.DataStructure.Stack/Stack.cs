using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEM.DotNet.DataStructure.Stack
{
    public class Stack
    {
        private Node head;
        private Node work;

        public Stack()
        {
            head = new Node();
            head.Next = null;
        }

        public void Push(int data)
        { 
            Node tempNode = new Node();
            tempNode.Data = data;

            tempNode.Next = head.Next;

            head.Next = tempNode;
        }

        public int Pop()
        {
            int value = 0;

            if (head.Next != null)
            { 
                work = head.Next;
                value = work.Data;

                head.Next = work.Next;
                work.Next = null;
            }
            return value;
        }

        public int Peek()
        {
            int value = 0;

            if (head.Next != null)
            {
                work = head.Next;
                value = work.Data;
            }
            return value;
        }

        public void Traverse()
        {
            work = head;

            while (work.Next != null)
            {
                work = work.Next;
                int d = work.Data;

                Console.WriteLine("[{0}]", d);
                //Console.WriteLine();
            }


        }
    }
}
