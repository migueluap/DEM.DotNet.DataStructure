using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEM.DotNet.DataStructure.HashTableReHash
{
    enum Estado
    {
        empty,
        busy,
        deleted
    }
    public class Cell
    {
        public int Key { get; set; } = 0;
        public string Value { get; set; } = string.Empty;
        internal Estado Estado { get; set; } = Estado.empty;
    }
}
