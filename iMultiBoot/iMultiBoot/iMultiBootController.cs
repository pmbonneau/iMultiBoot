using System.Collections.Generic;
using System.IO;
using System.Xml;
using DiskUtilityLib;
using System;

namespace iMultiBoot
{
    public class iMultiBootController
    {
        AppleMobileDevice iDevice;
        string WorkingDirectory = "";
        string DeviceWorkingDirectory = "";
        string MainOperatingSystemPathIPSW = "";
        bool MainOperatingSystemSelected = false;
        bool SecondaryOperatingSystemSelected = false;
        string SecondaryOperatingSystemPathIPSW = "";
        string WorkingDirectorySecondaryOS = "";
        IOperatingSystem[] OperatingSystemsArray = new IOperatingSystem[4];
        SecureShell SSH;

        public void setAppleMobileDevice(AppleMobileDevice iDeviceParam)
        {
            iDevice = iDeviceParam;
            CompleteDeviceWithStorageInfo(iDevice);
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

        public void CreateOperatingSystemInstance(string FileNameIPSW, int Position)
        {
            string[] SplittedFileName;
            string Version;
            string BuildNumber;

            SplittedFileName = FileNameIPSW.Split('_');

            Version = SplittedFileName[1];
            BuildNumber = SplittedFileName[2];

            if (Version[0] == '5')
            {
                IOperatingSystem iOS5Instance = new iOS5(Version, BuildNumber);
                OperatingSystemsArray[Position] = iOS5Instance;
            }
            else if (Version[0] == '6')
            {
                IOperatingSystem iOS6Instance = new iOS6(Version, BuildNumber);
                OperatingSystemsArray[Position] = iOS6Instance;
            }
        }

        private void CompleteDeviceWithStorageInfo(AppleMobileDevice iDevice)
        {
            XmlDocument XmlContainer = new XmlDocument();
            XmlContainer.Load(".\\Devices\\" + iDevice.InternalCodeName + ".xml");

            XmlNodeList SystemNodeList = XmlContainer.SelectNodes("/Device/System");

            foreach (XmlNode SystemNode in SystemNodeList)
            {
                if (SystemNode.ChildNodes[2].InnerText == Convert.ToString(iDevice.NandTotalCapacity))
                {
                    iDevice.PartitionTableType = SystemNode.ChildNodes[3].InnerText;
                    iDevice.UseLwVM = Convert.ToBoolean(SystemNode.ChildNodes[4].InnerText);
                    iDevice.SystemPartition.Size = Convert.ToInt16(SystemNode.ChildNodes[5].InnerText);
                    iDevice.DataPartition.Size = Convert.ToInt16(SystemNode.ChildNodes[6].InnerText);
                }
            }
        }

        public IOperatingSystem getOperatingSystemInstance(int Position)
        {
            return OperatingSystemsArray[Position];
        }

        private string getiOSVersion(string FileNameIPSW)
        {
            string[] SplittedFileName;
            SplittedFileName = FileNameIPSW.Split('_');
            return SplittedFileName[1];
        }

        private string getiOSBuildNumber(string FileNameIPSW)
        {
            string[] SplittedFileName;
            SplittedFileName = FileNameIPSW.Split('_');
            return SplittedFileName[2];
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

            if (Directory.Exists(WorkingDirectorySecondaryOS) == false)
            {
                Directory.CreateDirectory(WorkingDirectorySecondaryOS);
            }

            SecondaryOperatingSystemFiles = SecondaryOperatingSystemIPSW.getAllFilesIPSW();

            for (int i = 0; i < SecondaryOperatingSystemFiles.Length; i++)
            {
                if (SecondaryOperatingSystemFiles[i].Contains("iBoot.") == true)
                {
                    if (OperatingSystemsArray[1].iBoot == null)
                    {
                        OperatingSystemsArray[1].iBoot = SecondaryOperatingSystemFiles[i];
                    }
                    ImagesToFlash.Add(OperatingSystemsArray[1].iBoot);
                }
                else if (SecondaryOperatingSystemFiles[i].Contains("LLB") == true)
                {
                    if (OperatingSystemsArray[1].LowLevelBootloader == null)
                    {
                        OperatingSystemsArray[1].LowLevelBootloader = SecondaryOperatingSystemFiles[i];
                    }
                    ImagesToFlash.Add(OperatingSystemsArray[1].LowLevelBootloader);
                }
                else if (SecondaryOperatingSystemFiles[i].Contains("DeviceTree") == true)
                {
                    if (OperatingSystemsArray[1].DeviceTree == null)
                    {
                        OperatingSystemsArray[1].DeviceTree = SecondaryOperatingSystemFiles[i];
                    }
                    ImagesToFlash.Add(OperatingSystemsArray[1].DeviceTree);
                }
                else if (SecondaryOperatingSystemFiles[i].Contains("applelogo") == true)
                {
                    if (OperatingSystemsArray[1].BootLogo == null)
                    {
                        OperatingSystemsArray[1].BootLogo = SecondaryOperatingSystemFiles[i];
                    }
                    ImagesToFlash.Add(OperatingSystemsArray[1].BootLogo);
                }
                else if (SecondaryOperatingSystemFiles[i].Contains("recoverymode") == true)
                {
                    if (OperatingSystemsArray[1].RecoveryLogo == null)
                    {
                        OperatingSystemsArray[1].RecoveryLogo = SecondaryOperatingSystemFiles[i];
                    }
                    ImagesToFlash.Add(OperatingSystemsArray[1].RecoveryLogo);
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
                        File.Delete(ImagesToFlash[i]);
                        File.Move(ImagesToFlash[i] + "_dec", ImagesToFlash[i]);
                    }
                }
            }
        }

        private string DecryptRootFileSystemImage(string DecryptionKeysContainerFileName, string EncryptedRootFileSystemImagePath)
        {
            ToolsManagerLib.DmgUtility DmgDecryptionTool = new ToolsManagerLib.DmgUtility();
            string[] ID;
            string[] FileName;
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
            XmlNodeList DecryptionNodeListKey = XmlContainer.SelectNodes("/Container/DecryptionKeys/Key");
            Key = new string[DecryptionNodeListKey.Count];
            foreach (XmlNode DecryptionNode in DecryptionNodeListKey)
            {
                Key[NodeCount] = DecryptionNode.InnerText;
                NodeCount++;
            }

            for (int i = 0; i < FileName.Length; i++)
            {
                if (Path.GetFileName(EncryptedRootFileSystemImagePath) == FileName[i])
                {
                    DmgDecryptionTool.DecryptImage(EncryptedRootFileSystemImagePath, Path.GetDirectoryName(EncryptedRootFileSystemImagePath) + "\\" + Path.GetFileNameWithoutExtension(EncryptedRootFileSystemImagePath) + "_dec.dmg", Key[i]);
                    File.Delete(EncryptedRootFileSystemImagePath);
                }
            }
            return Path.GetDirectoryName(EncryptedRootFileSystemImagePath) + "\\" + Path.GetFileNameWithoutExtension(EncryptedRootFileSystemImagePath) + "_dec.dmg";
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

                WorkingDirectorySecondaryOS = WorkingDirectory + SecondaryOperatingSystemIPSW.getBuildNumber() + "_Secondary";
                string ImageFileName = Path.GetFileName(OperatingSystemsArray[1].LowLevelBootloader);
                string[] SplittedImageFileName = ImageFileName.Split('.');
                string UpdatedImageFileName = "";
                SplittedImageFileName[0] = SplittedImageFileName[0] + "B";
                UpdatedImageFileName = SplittedImageFileName[0] + "." + SplittedImageFileName[1] + "." + SplittedImageFileName[2] + "." + SplittedImageFileName[3];
                File.Copy(OperatingSystemsArray[1].LowLevelBootloader, WorkingDirectorySecondaryOS + "\\" + UpdatedImageFileName);
                OperatingSystemsArray[1].LowLevelBootloader = WorkingDirectorySecondaryOS + "\\" + UpdatedImageFileName;

                string DecryptedRootFileSystemImagePath = DecryptRootFileSystemImage(SecondaryOperatingSystemIPSW.getFileNameIPSW(), SecondaryOperatingSystemIPSW.getRootFileSystemImagePath());
                File.Move(DecryptedRootFileSystemImagePath, WorkingDirectorySecondaryOS + "\\" + "RootFileSystem.dmg");
                OperatingSystemsArray[1].RootFileSystem = WorkingDirectorySecondaryOS + "\\" + "RootFileSystem.dmg";

                for (int i = 0; i < SecondaryOperatingSystemIPSW.getAllFilesIPSW().Length; i++)
                {
                    if (SecondaryOperatingSystemIPSW.getAllFilesIPSW()[i].Contains("kernel"))
                    {
                        File.Copy(SecondaryOperatingSystemIPSW.getAllFilesIPSW()[i], WorkingDirectorySecondaryOS + "\\" + Path.GetFileName(SecondaryOperatingSystemIPSW.getAllFilesIPSW()[i]));
                        OperatingSystemsArray[1].KernelCache = WorkingDirectorySecondaryOS + "\\" + Path.GetFileName(SecondaryOperatingSystemIPSW.getAllFilesIPSW()[i]);
                    }
                }

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
            ToolsManagerLib.iDeviceRestore iDeviceRestore = new ToolsManagerLib.iDeviceRestore();
            iDeviceRestore.EraseRestore(WorkingDirectory + MainOperatingSystemIPSW.getFileNameIPSW() + ".ipsw");
        }

        public void ConnectSSH()
        {
            SSH = new SecureShell();
        }

        public void InstallRequiredTools()
        {
            SSH.UploadFile(".\\Tools\\test.deb", "\\");
            SSH.ExecuteRemoteCommand("dpkg -i /test.deb");
        }

        private void ResizeMainDataPartition()
        {
            HFSResize HFSResizer = new HFSResize();
            SSH.ExecuteRemoteCommand(HFSResizer.ResizeHFS("/private/var/", iDevice.DataPartition.Size));

            GPTfdisk GPTfdiskEditor = new GPTfdisk();
            GPTfdiskEditor.FileSystemBlockSize = iDevice.NandBlockSize;
            string PartitionUniqueGUID;
            string PartitionFirstSectorTempString;
            int PartitionFirstSector;
            string CommandOutput = "";
            int PositionUniqueGUID;
            int PositionFirstSector;
            CommandOutput = SSH.ExecuteRemoteCommandWithOutput(GPTfdiskEditor.getConsoleOutputPartitionUniqueGUID("2"));
            PositionUniqueGUID = CommandOutput.IndexOf("GUID", CommandOutput.IndexOf("GUID") + 1);
            PartitionUniqueGUID = CommandOutput.Substring(PositionUniqueGUID + 6, 36);
            CommandOutput = SSH.ExecuteRemoteCommandWithOutput(GPTfdiskEditor.getConsoleOutputPartitionInfo("2"));
            PositionFirstSector = CommandOutput.IndexOf("First");
            PartitionFirstSectorTempString = CommandOutput.Substring(PositionFirstSector + 14, 7);
            PartitionFirstSector = Convert.ToInt32(PartitionFirstSectorTempString.TrimEnd());
            SSH.ExecuteRemoteCommand(GPTfdiskEditor.AdjustDeviceDataPartition(PartitionFirstSector, iDevice.DataPartition.Size, PartitionUniqueGUID));
        }

        public void PartitionDeviceStorage()
        {
            ResizeMainDataPartition();
            for (int i = 2; i < iDevice.PartitionList.Count; i++)
            {
                CreatePartition(iDevice.PartitionList[i]);
                iDevice.PartitionList[i].MountPoint = "/" + iDevice.PartitionList[i].Name;
                SSH.ExecuteRemoteCommand("mkdir " + iDevice.PartitionList[i].MountPoint);
                SSH.ExecuteRemoteCommand(FormatVolume(iDevice.PartitionList[i]));
                SSH.ExecuteRemoteCommand(MountVolume(iDevice.PartitionList[i]));
            }

        }

        private void CreatePartition(Partition pPartition)
        {
            GPTfdisk GPTfdiskEditor = new GPTfdisk();
            GPTfdiskEditor.FileSystemBlockSize = iDevice.NandBlockSize;
            string PartitionLastSectorTempString;
            int PartitionLastSector;
            int PreviousPartitionNumber = Convert.ToInt16(pPartition.Number) - 1;
            string CommandOutput = "";
            int PositionLastSector;
            CommandOutput = SSH.ExecuteRemoteCommandWithOutput(GPTfdiskEditor.getConsoleOutputPartitionInfo(Convert.ToString(PreviousPartitionNumber)));
            PositionLastSector = CommandOutput.IndexOf("Last");
            PartitionLastSectorTempString = CommandOutput.Substring(PositionLastSector + 13, 7);
            PartitionLastSector = Convert.ToInt32(PartitionLastSectorTempString.TrimEnd());
            SSH.ExecuteRemoteCommand(GPTfdiskEditor.CreateNewPartition(pPartition.Name, pPartition.Number, PartitionLastSector, pPartition.Size));
        }

        private void DeletePartition(string PartitionNumberToDelete)
        {
            GPTfdisk GPTfdiskEditor = new GPTfdisk();
            SSH.ExecuteRemoteCommand(GPTfdiskEditor.DeletePartition(PartitionNumberToDelete));
        }

        public string FormatVolume(Partition pPartition)
        {
            DiskUtilityLib.NewFS NewFS = new DiskUtilityLib.NewFS();
            string TargetDiskDevice;
            if (iDevice.UseLwVM == true)
            {
                TargetDiskDevice = "disk0s1s" + pPartition.Number;
            }
            else
            {
                TargetDiskDevice = "disk0s" + pPartition.Number;
            }
            pPartition.DiskDevicePath = "/dev/" + TargetDiskDevice;
            return NewFS.HFS(pPartition.Name, Convert.ToString(iDevice.NandBlockSize), pPartition.DiskDevicePath, pPartition.JournaledFlag, pPartition.ProtectedFlag);
        }

        private string MountVolume(Partition pPartition)
        {
            DiskUtilityLib.Mount Mount = new DiskUtilityLib.Mount();
            return Mount.HFS(pPartition.DiskDevicePath, pPartition.MountPoint);
        }

        private string MountVolume(string pDiskDevicePath, string pMountPoint)
        {
            DiskUtilityLib.Mount Mount = new DiskUtilityLib.Mount();
            return Mount.HFS(pDiskDevicePath, pMountPoint);
        }

        public void setDeviceWorkingDirectory(string pDeviceWorkingDirectory)
        {
            DeviceWorkingDirectory = pDeviceWorkingDirectory + "//" + "iMultiBoot" + "//";
        }

        public string getDeviceWorkingDirectory()
        {
            return DeviceWorkingDirectory;
        }

        public void RestoreOperatingSystems()
        {
            SSH.ExecuteRemoteCommand("mkdir " + DeviceWorkingDirectory);
            for (int i = 1; i < OperatingSystemsArray.Length; i++)
            {
                OperatingSystemsArray[i].RemoteWorkingDirectory = DeviceWorkingDirectory + OperatingSystemsArray[i].SystemBuildNumber + "//";
                SSH.ExecuteRemoteCommand("mkdir " + OperatingSystemsArray[i].RemoteWorkingDirectory);
                SSH.UploadFile(OperatingSystemsArray[i].RootFileSystem, OperatingSystemsArray[i].RemoteWorkingDirectory);
                string RemoteRootFileSystemImagePath = OperatingSystemsArray[i].RemoteWorkingDirectory + Path.GetFileName(OperatingSystemsArray[i].RootFileSystem);
                SSH.ExecuteRemoteCommand(RestoreRootFileSystem(RemoteRootFileSystemImagePath, OperatingSystemsArray[i].SystemPartition));
            }
        }

        private string RestoreRootFileSystem(string pRemoteRootFileSystemImagePath, Partition pDestinationPartition)
        {
            DiskUtilityLib.Attach DeviceAttach = new DiskUtilityLib.Attach();
            string DeviceMountPointOS = DeviceWorkingDirectory + pDestinationPartition.Name;
            SSH.ExecuteRemoteCommand("mkdir " + DeviceMountPointOS);
            string DiskDevice = "/dev/" + SSH.ExecuteRemoteCommandWithOutput(DeviceAttach.LinkToDiskDevice(pRemoteRootFileSystemImagePath));

            SSH.ExecuteRemoteCommand(MountVolume(DiskDevice, DeviceMountPointOS));
            return "rsync -rav " + DeviceMountPointOS + "//*" + " //" + pDestinationPartition.Name;
        }

        private string InstallKernelCache(IOperatingSystem OperatingSystem)
        {
            SSH.UploadFile(OperatingSystem.KernelCache, OperatingSystem.RemoteWorkingDirectory);
            return "";
        }
    }
}
