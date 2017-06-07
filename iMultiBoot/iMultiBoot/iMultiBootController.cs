using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iMultiBoot
{
    public class iMultiBootController
    {
        AppleMobileDevice iDevice;
        string TemporaryDirectory = "";
        string MainOperatingSystemPathIPSW = "";
        string SecondaryOperatingSystemPathIPSW = "";

        public void setAppleMobileDevice(AppleMobileDevice iDeviceParam)
        {
            iDevice = iDeviceParam;
        }

        public AppleMobileDevice getAppleMobileDevice()
        {
            return iDevice;
        }

        public void setTemporaryDirectory(string pTemporaryDirectory)
        {
            TemporaryDirectory = pTemporaryDirectory;
        }

        public string getTemporaryDirectory()
        {
            return TemporaryDirectory;
        }

        public void setMainOperatingSystemPathIPSW(string FilePath)
        {
            MainOperatingSystemPathIPSW = FilePath;
        }

        public string getMainOperatingSystemPathIPSW()
        {
            return MainOperatingSystemPathIPSW;
        }

        public void setSecondaryOperatingSystemPathIPSW(string FilePath)
        {
            SecondaryOperatingSystemPathIPSW = FilePath;
        }

        public string getSecondaryOperatingSystemPathIPSW()
        {
            return SecondaryOperatingSystemPathIPSW;
        }

        public void PrepareMainOperatingSystemIPSW()
        {
            IPSWlib.Editor MainOperatingSystemIPSW = new IPSWlib.Editor(MainOperatingSystemPathIPSW, TemporaryDirectory + "\\");
        }
    }
}
