using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEM.DotNet.DataStructure.HashTableSeparateChain
{
    internal class LinkedList
    {
        private Node head;
        private Node work;
        private Node work2;

        public LinkedList()
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
                //int d = work.Data;

                Console.Write("{0}->", work);
            }

            //Console.WriteLine();
        }

        public void Add(int key, string value)
        {
            work = head;

            while (work.Next != null)
            {
                work = work.Next;
            }

            Node tempNode = new Node();
            tempNode.Key = key;
            tempNode.Value = value;

            tempNode.Next = null;

            work.Next = tempNode;
        }


        public void Empty()
        {
            head.Next = null;
        }

        public bool IsEmpty()
        {
            if (head.Next == null)
                return true;
            else
                return false;
        }

        public Node Search(int key)
        {
            if (IsEmpty() == true)
                return null;

            work2 = head;

            while (work2.Next != null)
            {
                work2 = work2.Next;

                if (work2.Key == key)
                    return work2;
            }

            return null;
        }
        public int SearchIndex(int key)
        {
            int n = -1;
            work = head;

            while (work.Next != null)
            {
                work = work.Next;
                n++;

                if (work.Key == key)
                    return n;
            }

            return -1;
        }

        public Node SearchBefore(int key)
        {
            work2 = head;

            while (work2.Next != null && work2.Next.Key != key)
                work2 = work2.Next;

            return work2;
        }

        public void Delete(int key)
        {
            if (IsEmpty() == true)
                return;

            Node nodeBefore = SearchBefore(key);
            Node nodeFound = Search(key);

            if (nodeFound == null)
                return;

            nodeBefore.Next = nodeFound.Next;

            nodeFound.Next = null;
        }

        public void Insert(int where, int key, string value)
        {
            work = Search(where);

            if (work == null)
                return;

            Node tempNode = new Node();
            tempNode.Key = key;
            tempNode.Value = value;

            tempNode.Next = work.Next;
        }

        public void InsertStart(int key, string value)
        {
            Node tempNode = new Node();
            tempNode.Key = key;
            tempNode.Value = value;

            tempNode.Next = work.Next;

            head.Next = tempNode;
        }

        public Node GetByKey(int indexParameter)
        {
            Node work2 = null;
            int index = -1;

            work = head;

            while (work.Next != null)
            { 
                work = work.Next;
                index++;
            
                if (index == indexParameter)
                    work2 = work2;
            }

            return work2;
        }
        public int this[int index]
        {
            get
            {
                work = GetByKey(index);
                return work.Key;
            }
            set
            { 
                work = GetByKey(index);
                if (work != null) 
                    work.Key = value;
            }
        }
    }
}
