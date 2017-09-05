using System;
using IPSWlib;
using System.Collections.Generic;
using System.IO;

namespace iMultiBoot
{
    [Serializable]
    public class OperatingSystem
    {
        public OperatingSystem(string pSystemVersion, string pSystemBuildNumber)
        {
            SystemVersion = pSystemVersion;
            SystemBuildNumber = pSystemBuildNumber;
        }

        public OperatingSystem(string pFilePathIPSW)
        {
            FileNameIPSW = Path.GetFileNameWithoutExtension(pFilePathIPSW);
            FilePathIPSW = pFilePathIPSW;

            string[] SplittedFileName = FileNameIPSW.Split('_');
            SystemVersion = SplittedFileName[1];
            SystemBuildNumber = SplittedFileName[2];
        }

        public string FilePathIPSW { get; set; }
        public string FileNameIPSW { get; set; }
        public Editor FirmwarePackage { get; set; }
        public List<string> ImagesToFlash { get; set; }
        public string SystemVersion { get; set; }
        public string SystemBuildNumber { get; set; }
        public char SystemID { get; set; }
        public string LocalWorkingDirectory { get; set; }
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
    }
}
