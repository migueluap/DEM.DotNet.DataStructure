using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEM.DotNet.DataStructure.HashTableSeparateChain
{
    internal class Node
    {
        private int key;
        private string valuee;

        private Node next;

        public int Key { get => key; set => key = value; }
        public string Value { get => valuee; set => valuee = value; }

        internal Node Next { get => next; set => next = value; }

        public override string ToString()
        {
            return string.Format("[{0}, {1}]", key, valuee);
        }
    }
}
