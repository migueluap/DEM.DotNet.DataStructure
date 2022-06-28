using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEM.DotNet.DataStructure.Queue
{
    public class Queue
    {
        private Node head;
        private Node work;

        public Queue()
        {
            head = new Node();
            head.Next = null;
        }

        public void Traverse()
        {
            work = head;

            while (work.Next != null)
            {
                work = work.Next;
                int d = work.Data;

                Console.Write("<- [{0}]", d);
            }
            Console.WriteLine();
        }

        public void Enqueue(int data) 
        {
            work = head;

            while (work.Next != null )
            {
                work = work.Next;
            }

            Node tempNode = new Node();

            tempNode.Data = data;
            tempNode.Next = null;

            work.Next = tempNode;
        }

        public int Dequeue()
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
    }
}
