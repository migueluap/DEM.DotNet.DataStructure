using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

          
namespace DEM.DotNet.DataStructure.Queue
{
    internal class Node
    {
        private int data;
        private Node next;

        public int Data { get => data; set => data = value; }
        internal Node Next { get => next; set => next = value; }

        public override string ToString()
        {
            return String.Format("[{0}]", data);
        }
    }
}
