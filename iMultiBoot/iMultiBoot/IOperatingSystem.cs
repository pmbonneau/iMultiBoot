using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iMultiBoot
{
    public interface IOperatingSystem
    {
        string SystemVersion { get; set; }
        string SystemBuildNumber { get; set; }
        string LowLevelBootloader { get; set; }
        string iBoot { get; set; }
        string DeviceTree { get; set; }
        string BootLogo { get; set; }
        string RecoveryLogo { get; set; }
        string KernelCache { get; set; }
        string RootFileSystem { get; set; }
    }
}
