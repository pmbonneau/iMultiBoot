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
        string MainOperatingSystemPathIPSW = "";

        public void setAppleMobileDevice(AppleMobileDevice iDeviceParam)
        {
            iDevice = iDeviceParam;
        }

        public AppleMobileDevice getAppleMobileDevice()
        {
            return iDevice;
        }

        public void setMainOperatingSystemPathIPSW(string FilePath)
        {
            MainOperatingSystemPathIPSW = FilePath;
        }

        public string getMainOperatingSystemPathIPSW()
        {
            return MainOperatingSystemPathIPSW;
        }
    }
}
