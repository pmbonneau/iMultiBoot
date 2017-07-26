using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iMultiBoot
{
    public class AppleMobileDevice
    {
        public string InternalCodeName { get; set; }
        public int NandTotalCapacity { get; set; }
        public int NandBlockSize { get; set; }
        public string PartitionTableType { get; set; }
        public bool UseLwVM { get; set; }
        public Partition SystemPartition { get; set; }
        public Partition DataPartition { get; set; }
        public List<Partition> PartitionList { get; set; }

        public AppleMobileDevice(string pInternalCodeName)
        {
            InternalCodeName = pInternalCodeName;
        }

        public AppleMobileDevice(string pInternalCodeName, Partition pSystemPartition, Partition pDataPartition)
        {
            InternalCodeName = pInternalCodeName;
            SystemPartition = pSystemPartition;
            DataPartition = pDataPartition;
            PartitionList = new List<Partition>();
            PartitionList.Add(pSystemPartition);
            PartitionList.Add(pDataPartition);
        }
    }
}
