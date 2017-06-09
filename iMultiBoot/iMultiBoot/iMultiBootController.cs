using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace iMultiBoot
{
    public class iMultiBootController
    {
        AppleMobileDevice iDevice;
        string WorkingDirectory = "";
        string MainOperatingSystemPathIPSW = "";
        bool MainOperatingSystemSelected = false;
        bool SecondaryOperatingSystemSelected = false;
        string SecondaryOperatingSystemPathIPSW = "";

        public void setAppleMobileDevice(AppleMobileDevice iDeviceParam)
        {
            iDevice = iDeviceParam;
        }

        public AppleMobileDevice getAppleMobileDevice()
        {
            return iDevice;
        }

        public void setWorkingDirectory(string pWorkingDirectory)
        {
            WorkingDirectory = pWorkingDirectory + "\\" + "iMultiBoot" + "\\";
        }

        public string getWorkingDirectory()
        {
            return WorkingDirectory;
        }

        public void setMainOperatingSystemPathIPSW(string FilePath)
        {
            MainOperatingSystemPathIPSW = FilePath;
            MainOperatingSystemSelected = true;
        }

        public string getMainOperatingSystemPathIPSW()
        {
            return MainOperatingSystemPathIPSW;
        }

        public void setSecondaryOperatingSystemPathIPSW(string FilePath)
        {
            SecondaryOperatingSystemPathIPSW = FilePath;
            SecondaryOperatingSystemSelected = true;
        }

        public string getSecondaryOperatingSystemPathIPSW()
        {
            return SecondaryOperatingSystemPathIPSW;
        }

        private List<string> addSecondaryOperatingSystemImagesToFlash(List<string> ImagesToFlash)
        {
            IPSWlib.Editor SecondaryOperatingSystemIPSW = new IPSWlib.Editor(SecondaryOperatingSystemPathIPSW, WorkingDirectory);
            string[] SecondaryOperatingSystemFiles;
            string WorkingDirectorySecondaryOS = WorkingDirectory + SecondaryOperatingSystemIPSW.getBuildNumber() + "_Secondary";

            Directory.CreateDirectory(WorkingDirectorySecondaryOS);

            SecondaryOperatingSystemFiles = SecondaryOperatingSystemIPSW.getAllFilesIPSW();

            for (int i = 0; i < SecondaryOperatingSystemFiles.Length; i++)
            {
                if (SecondaryOperatingSystemFiles[i].Contains("iBoot.") == true)
                {
                    ImagesToFlash.Add(SecondaryOperatingSystemFiles[i]);
                }
                else if (SecondaryOperatingSystemFiles[i].Contains("LLB") == true)
                {
                    string ImageFileName = Path.GetFileName(SecondaryOperatingSystemFiles[i]);
                    string[] SplittedImageFileName = ImageFileName.Split('.');
                    string UpdatedImageFileName = "";
                    SplittedImageFileName[0] = SplittedImageFileName[0] + "B";
                    UpdatedImageFileName = SplittedImageFileName[0] + "." + SplittedImageFileName[1] + "." + SplittedImageFileName[2] + "." + SplittedImageFileName[3];
                    File.Copy(SecondaryOperatingSystemFiles[i], WorkingDirectorySecondaryOS + "\\" + UpdatedImageFileName);
                }
                else if (SecondaryOperatingSystemFiles[i].Contains("DeviceTree") == true)
                {
                    ImagesToFlash.Add(SecondaryOperatingSystemFiles[i]);
                }
                else if (SecondaryOperatingSystemFiles[i].Contains("applelogo") == true)
                {
                    ImagesToFlash.Add(SecondaryOperatingSystemFiles[i]);
                }
                else if (SecondaryOperatingSystemFiles[i].Contains("recoverymode") == true)
                {
                    ImagesToFlash.Add(SecondaryOperatingSystemFiles[i]);
                }
            }

            return ImagesToFlash;
        }

        public void PrepareMainOperatingSystemIPSW()
        {
            IPSWlib.Editor MainOperatingSystemIPSW;
            List<string> ImagesToFlashSecondaryOS = new List<string>();

            if (MainOperatingSystemSelected == true)
            {
                MainOperatingSystemIPSW = new IPSWlib.Editor(MainOperatingSystemPathIPSW, WorkingDirectory);
            }
            else
            {
                MainOperatingSystemIPSW = null;
            }

            if (SecondaryOperatingSystemSelected == true)
            {
                ImagesToFlashSecondaryOS = addSecondaryOperatingSystemImagesToFlash(ImagesToFlashSecondaryOS);
                for (int i = 0; i < ImagesToFlashSecondaryOS.Count; i++)
                {
                    ImagesToFlashSecondaryOS[i] = MainOperatingSystemIPSW.AddToAllFlashFolder(ImagesToFlashSecondaryOS[i], "Secondary");
                }

                for (int i = 0; i < ImagesToFlashSecondaryOS.Count; i++)
                {
                    MainOperatingSystemIPSW.AddToFlashManifest(ImagesToFlashSecondaryOS[i]);
                }
            }

            MainOperatingSystemIPSW.RebuildIPSW(WorkingDirectory + MainOperatingSystemIPSW.getFileNameIPSW(), WorkingDirectory + MainOperatingSystemIPSW.getFileNameIPSW() + ".ipsw");
        }
    }
}
