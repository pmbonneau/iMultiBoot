using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iMultiBoot
{
    public class AppleMobileDevice
    {
        int NandTotalCapacity = 0;
        double NandRemainingCapacity = 0.0;

        public string InternalCodeName { get; set; }

        public AppleMobileDevice(string pInternalCodeName)
        {
            InternalCodeName = pInternalCodeName;
        }

        public void setNandTotalCapacity(int pNandTotalCapacity)
        {
            NandTotalCapacity = pNandTotalCapacity;
        }

        public int getNandTotalCapacity()
        {
            return NandTotalCapacity;
        }

        public void setNandRemainingCapacity(double pNandRemainingCapacity)
        {
            NandRemainingCapacity = pNandRemainingCapacity;
        }

        public double getNandRemainingCapacity()
        {
            return NandRemainingCapacity;
        }
    }
}
