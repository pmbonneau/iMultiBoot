using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Threading;

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

        private List<string> addSecondaryOperatingSystemImagesToFlash(IPSWlib.Editor SecondaryOperatingSystemIPSW, List<string> ImagesToFlash)
        {
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

        private void DecryptFirmwareImages(string DecryptionKeysContainerFileName, List<string> ImagesToFlash)
        {
            ToolsManagerLib.XPwnTools XPwnTools = new ToolsManagerLib.XPwnTools();

            string[] ID;
            string[] FileName;
            string[] IV;
            string[] Key;

            XmlDocument XmlContainer = new XmlDocument();
            XmlContainer.Load(".\\Keys\\" + DecryptionKeysContainerFileName + ".xml");
            int NodeCount = 0;
            XmlNodeList DecryptionNodeListID = XmlContainer.SelectNodes("/Container/DecryptionKeys/ID");
            ID = new string[DecryptionNodeListID.Count];
            foreach (XmlNode DecryptionNode in DecryptionNodeListID)
            {
                ID[NodeCount] = DecryptionNode.InnerText;
                NodeCount++;
            }

            NodeCount = 0;
            XmlNodeList DecryptionNodeListFile = XmlContainer.SelectNodes("/Container/DecryptionKeys/File");
            FileName = new string[DecryptionNodeListFile.Count];
            foreach (XmlNode DecryptionNode in DecryptionNodeListFile)
            {
                FileName[NodeCount] = DecryptionNode.InnerText;
                NodeCount++;
            }

            NodeCount = 0;
            XmlNodeList DecryptionNodeListIV = XmlContainer.SelectNodes("/Container/DecryptionKeys/IV");
            IV = new string[DecryptionNodeListIV.Count];
            foreach (XmlNode DecryptionNode in DecryptionNodeListIV)
            {
                IV[NodeCount] = DecryptionNode.InnerText;
                NodeCount++;
            }

            NodeCount = 0;
            XmlNodeList DecryptionNodeListKey = XmlContainer.SelectNodes("/Container/DecryptionKeys/Key");
            Key = new string[DecryptionNodeListKey.Count];
            foreach (XmlNode DecryptionNode in DecryptionNodeListKey)
            {
                Key[NodeCount] = DecryptionNode.InnerText;
                NodeCount++;
            }

            for (int i = 0; i < ImagesToFlash.Count; i++)
            {
                for (int j = 0; j < FileName.Length; j++)
                {
                    if (Path.GetFileName(ImagesToFlash[i]) == FileName[j])
                    {
                        XPwnTools.DecryptFirmwareImage(ImagesToFlash[i], ImagesToFlash[i] + "_dec", IV[j], Key[j]);
                        Thread.Sleep(5000);
                        File.Delete(ImagesToFlash[i]);
                        File.Move(ImagesToFlash[i] + "_dec", ImagesToFlash[i]);
                    }
                }
            }
        }

        private void PatchFirmwareImages(string PatchContainerFileName, List<string> ImagesToFlash)
        {
            BinaryPatcherLib.BinaryPatcher PatchEngine;

            for (int i = 0; i < ImagesToFlash.Count; i++)
            {
                if (File.Exists(".\\Patches\\" + PatchContainerFileName + "\\" + Path.GetFileNameWithoutExtension(ImagesToFlash[i]) + ".xml"))
                {
                    PatchEngine = new BinaryPatcherLib.BinaryPatcher(ImagesToFlash[i], ".\\Patches\\" + PatchContainerFileName + "\\" + Path.GetFileNameWithoutExtension(ImagesToFlash[i]) + ".xml");
                    PatchEngine.ApplyPatchToFile();
                }
            }
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
                IPSWlib.Editor SecondaryOperatingSystemIPSW = new IPSWlib.Editor(SecondaryOperatingSystemPathIPSW, WorkingDirectory);
                ImagesToFlashSecondaryOS = addSecondaryOperatingSystemImagesToFlash(SecondaryOperatingSystemIPSW, ImagesToFlashSecondaryOS);

                DecryptFirmwareImages(SecondaryOperatingSystemIPSW.getFileNameIPSW(), ImagesToFlashSecondaryOS);
                PatchFirmwareImages(SecondaryOperatingSystemIPSW.getFileNameIPSW(), ImagesToFlashSecondaryOS);

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
