using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iMultiBoot
{
    public class Partition
    {
        public string Name { get; set; }
        public int Size { get; set; }
        public int LastSector { get; set; }

        public Partition(string pName, int pSize)
        {
            Name = pName;
            Size = pSize;
        }
    }
}
