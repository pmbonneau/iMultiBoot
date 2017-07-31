using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iMultiBoot
{
    class iOS6 : IOperatingSystem
    {
        public string SystemVersion { get; set; }
        public string SystemBuildNumber { get; set; }
        public string RemoteWorkingDirectory { get; set; }
        public Partition SystemPartition { get; set; }
        public Partition DataPartition { get; set; }
        public string LowLevelBootloader { get; set; }
        public string iBoot { get; set; }
        public string DeviceTree { get; set; }
        public string BootLogo { get; set; }
        public string RecoveryLogo { get; set; }
        public string KernelCache { get; set; }
        public string RootFileSystem { get; set; }

        public iOS6(string pSystemVersion, string pSystemBuildNumber)
        {
            SystemVersion = pSystemVersion;
            SystemBuildNumber = pSystemBuildNumber;
        }
    }
}
