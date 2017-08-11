using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iMultiBoot
{
    [Serializable]
    public class Partition
    {
        public string Name { get; set; }
        public int Size { get; set; }
        public string Number { get; set; }
        public string MountPoint { get; set; }
        public string DiskDevicePath { get; set; }
        public bool JournaledFlag { get; set; }
        public bool ProtectedFlag { get; set; }

        public Partition(string pName, int pSize)
        {
            Name = pName;
            Size = pSize;
        }
    }
}
