using System.Collections.Generic;
using System.IO;
using System.Xml;
using DiskUtilityLib;
using System;
using System.Text;

namespace iMultiBoot
{
    [Serializable]
    public class iMultiBootController
    {
        AppleMobileDevice iDevice;
        string WorkingDirectory = "";
        string DeviceWorkingDirectory = "";
        string MainOperatingSystemPathIPSW = "";
        bool MainOperatingSystemSelected = false;
        bool SecondaryOperatingSystemSelected = false;
        string SecondaryOperatingSystemPathIPSW = "";
        OperatingSystem[] OperatingSystemsArray = new OperatingSystem[4];
        SecureShell SSH;

        public iMultiBootController()
        {
            setWorkingDirectory(Directory.GetParent(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)).FullName + "\\Roaming");
        }

        public void setAppleMobileDevice(AppleMobileDevice iDeviceParam)
        {
            iDevice = iDeviceParam;
            CompleteDeviceWithStorageInfo(iDevice);
        }

        public string[] getAvailableDevices()
        {
            string[] AvailableDevices;
            AvailableDevices = Directory.GetFiles(".\\Devices\\", "*", SearchOption.AllDirectories);
            for (int i = 0; i < AvailableDevices.Length; i++)
            {
                AvailableDevices[i] = Path.GetFileNameWithoutExtension(AvailableDevices[i]);
            }
            return AvailableDevices;
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

        public void CreateOperatingSystemInstance(string FilePathIPSW, int Position)
        {           
            OperatingSystem OperatingSystemInstance = new OperatingSystem(FilePathIPSW);
            OperatingSystemsArray[Position] = OperatingSystemInstance;

            switch(Position)
            {
                case 0:
                    OperatingSystemsArray[0].SystemID = 'A';
                    OperatingSystemsArray[0].InstanceID = "Primary";
                    break;
                case 1:
                    OperatingSystemsArray[1].SystemID = 'B';
                    OperatingSystemsArray[1].InstanceID = "Secondary";
                    break;
                case 2:
                    OperatingSystemsArray[2].SystemID = 'C';
                    OperatingSystemsArray[2].InstanceID = "Third";
                    break;
                case 3:
                    OperatingSystemsArray[3].SystemID = 'D';
                    OperatingSystemsArray[3].InstanceID = "Fourth";
                    break;
            }
        }

        private void CompleteDeviceWithStorageInfo(AppleMobileDevice iDevice)
        {
            XmlDocument XmlContainer = new XmlDocument();
            XmlContainer.Load(".\\Devices\\" + iDevice.InternalCodeName + ".xml");

            XmlNodeList SystemNodeList = XmlContainer.SelectNodes("/Device/System");

            foreach (XmlNode SystemNode in SystemNodeList)
            {
                if (SystemNode.ChildNodes[0].InnerText == Convert.ToString(iDevice.NandTotalCapacity))
                {
                    iDevice.PartitionTableType = SystemNode.ChildNodes[1].InnerText;
                    iDevice.UseLwVM = Convert.ToBoolean(SystemNode.ChildNodes[2].InnerText);

                    int SystemPartitionCapacity = Convert.ToInt16(SystemNode.ChildNodes[3].InnerText);
                    int DataPartitionCapacity = Convert.ToInt16(SystemNode.ChildNodes[4].InnerText);

                    Partition SystemPartition = new Partition("System", SystemPartitionCapacity);
                    Partition DataPartition = new Partition("Data", DataPartitionCapacity);

                    iDevice.SystemPartition = SystemPartition;
                    iDevice.DataPartition = DataPartition;
                }
            }
            iDevice.SystemPartition.Number = "0";
            iDevice.DataPartition.Number = "1";
        }

        public OperatingSystem getOperatingSystemInstance(int Position)
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

        private void addOperatingSystemFirmwareImagesToFlash(OperatingSystem pOperatingSystem)
        {
            string[] OperatingSystemFiles;
            string WorkingDirectoryOS = WorkingDirectory + pOperatingSystem.SystemBuildNumber + "_" + pOperatingSystem.InstanceID;

            if (Directory.Exists(WorkingDirectoryOS) == false)
            {
                Directory.CreateDirectory(WorkingDirectoryOS);
            }

            OperatingSystemFiles = pOperatingSystem.FirmwarePackage.getAllFilesIPSW();

            for (int i = 0; i < OperatingSystemFiles.Length; i++)
            {
                if (OperatingSystemFiles[i].Contains("iBoot.") == true)
                {
                    if (OperatingSystemsArray[1].iBoot == null)
                    {
                        OperatingSystemsArray[1].iBoot = OperatingSystemFiles[i];
                    }
                    pOperatingSystem.ImagesToFlash.Add(OperatingSystemsArray[1].iBoot);
                }
                else if (OperatingSystemFiles[i].Contains("LLB") == true)
                {
                    if (OperatingSystemsArray[1].LowLevelBootloader == null)
                    {
                        OperatingSystemsArray[1].LowLevelBootloader = OperatingSystemFiles[i];
                    }
                    pOperatingSystem.ImagesToFlash.Add(OperatingSystemsArray[1].LowLevelBootloader);
                }
                else if (OperatingSystemFiles[i].Contains("DeviceTree") == true)
                {
                    if (OperatingSystemsArray[1].DeviceTree == null)
                    {
                        OperatingSystemsArray[1].DeviceTree = OperatingSystemFiles[i];
                    }
                    pOperatingSystem.ImagesToFlash.Add(OperatingSystemsArray[1].DeviceTree);
                }
                else if (OperatingSystemFiles[i].Contains("applelogo") == true)
                {
                    if (OperatingSystemsArray[1].BootLogo == null)
                    {
                        OperatingSystemsArray[1].BootLogo = OperatingSystemFiles[i];
                    }
                    pOperatingSystem.ImagesToFlash.Add(OperatingSystemsArray[1].BootLogo);
                }
                else if (OperatingSystemFiles[i].Contains("recoverymode") == true)
                {
                    if (OperatingSystemsArray[1].RecoveryLogo == null)
                    {
                        OperatingSystemsArray[1].RecoveryLogo = OperatingSystemFiles[i];
                    }
                    pOperatingSystem.ImagesToFlash.Add(OperatingSystemsArray[1].RecoveryLogo);
                }
            }
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

        public void PrepareMainOperatingSystemFirmwarePackage()
        {
            if (OperatingSystemsArray[0] == null)
            {
                return;
            }
            OperatingSystemsArray[0].FirmwarePackage = new IPSWlib.Editor(OperatingSystemsArray[0].FilePathIPSW, WorkingDirectory);
            for (int i = 1; i < OperatingSystemsArray.Length; i++)
            {
                if (OperatingSystemsArray[i] != null)
                {
                    OperatingSystemsArray[i].ImagesToFlash = new List<string>();
                    OperatingSystemsArray[i].FirmwarePackage = new IPSWlib.Editor(OperatingSystemsArray[i].FilePathIPSW, WorkingDirectory);

                    addOperatingSystemFirmwareImagesToFlash(OperatingSystemsArray[i]);

                    DecryptFirmwareImages(OperatingSystemsArray[i].FirmwarePackage.getFileNameIPSW(), OperatingSystemsArray[i].ImagesToFlash);

                    PatchFirmwareImages(OperatingSystemsArray[i].FirmwarePackage.getFileNameIPSW(), OperatingSystemsArray[i].ImagesToFlash);

                    OperatingSystemsArray[i].LocalWorkingDirectory = WorkingDirectory + OperatingSystemsArray[i].SystemBuildNumber + "_" + OperatingSystemsArray[i].InstanceID;

                    string ImageFileName = Path.GetFileName(OperatingSystemsArray[i].LowLevelBootloader);
                    string[] SplittedImageFileName = ImageFileName.Split('.');
                    string UpdatedImageFileName = "";
                    SplittedImageFileName[0] = SplittedImageFileName[0] + OperatingSystemsArray[i].SystemID;
                    UpdatedImageFileName = SplittedImageFileName[0] + "." + SplittedImageFileName[1] + "." + SplittedImageFileName[2] + "." + SplittedImageFileName[3];
                    File.Copy(OperatingSystemsArray[i].LowLevelBootloader, OperatingSystemsArray[i].LocalWorkingDirectory + "\\" + UpdatedImageFileName);
                    OperatingSystemsArray[i].LowLevelBootloader = OperatingSystemsArray[i].LocalWorkingDirectory + "\\" + UpdatedImageFileName;

                    string DecryptedRootFileSystemImagePath = DecryptRootFileSystemImage(OperatingSystemsArray[i].FirmwarePackage.getFileNameIPSW(), OperatingSystemsArray[i].FirmwarePackage.getRootFileSystemImagePath());
                    File.Move(DecryptedRootFileSystemImagePath, OperatingSystemsArray[i].LocalWorkingDirectory + "\\" + "RootFileSystem.dmg");
                    OperatingSystemsArray[i].RootFileSystem = OperatingSystemsArray[i].LocalWorkingDirectory + "\\" + "RootFileSystem.dmg";

                    for (int j = 0; j < OperatingSystemsArray[i].FirmwarePackage.getAllFilesIPSW().Length; j++)
                    {
                        if (OperatingSystemsArray[i].FirmwarePackage.getAllFilesIPSW()[j].Contains("kernel"))
                        {
                            File.Copy(OperatingSystemsArray[i].FirmwarePackage.getAllFilesIPSW()[j], OperatingSystemsArray[1].LocalWorkingDirectory + "\\" + Path.GetFileName(OperatingSystemsArray[i].FirmwarePackage.getAllFilesIPSW()[j]));
                            OperatingSystemsArray[1].KernelCache = OperatingSystemsArray[1].LocalWorkingDirectory + "\\" + Path.GetFileName(OperatingSystemsArray[i].FirmwarePackage.getAllFilesIPSW()[j]);
                        }
                    }

                    for (int j = 0; j < OperatingSystemsArray[i].ImagesToFlash.Count; j++)
                    {
                        OperatingSystemsArray[i].ImagesToFlash[j] = OperatingSystemsArray[0].FirmwarePackage.AddToAllFlashFolder(OperatingSystemsArray[i].ImagesToFlash[j], OperatingSystemsArray[i].InstanceID);
                    }

                    for (int j = 0; j < OperatingSystemsArray[i].ImagesToFlash.Count; j++)
                    {
                        OperatingSystemsArray[0].FirmwarePackage.AddToFlashManifest(OperatingSystemsArray[i].ImagesToFlash[j]);
                    }
                }
            }
            OperatingSystemsArray[0].FirmwarePackage.RebuildIPSW(WorkingDirectory + OperatingSystemsArray[0].FirmwarePackage.getFileNameIPSW(), WorkingDirectory + OperatingSystemsArray[0].FirmwarePackage.getFileNameIPSW() + ".ipsw");
            ToolsManagerLib.iDeviceRestore iDeviceRestore = new ToolsManagerLib.iDeviceRestore();
            iDeviceRestore.EraseRestore(WorkingDirectory + OperatingSystemsArray[0].FirmwarePackage.getFileNameIPSW() + ".ipsw");
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
                OperatingSystemsArray[1].FileNameIPSW = SecondaryOperatingSystemIPSW.getFileNameIPSW();
                OperatingSystemsArray[1].SystemID = 'B';
                ImagesToFlashSecondaryOS = addSecondaryOperatingSystemImagesToFlash(SecondaryOperatingSystemIPSW, ImagesToFlashSecondaryOS);

                DecryptFirmwareImages(SecondaryOperatingSystemIPSW.getFileNameIPSW(), ImagesToFlashSecondaryOS);
                PatchFirmwareImages(SecondaryOperatingSystemIPSW.getFileNameIPSW(), ImagesToFlashSecondaryOS);

                OperatingSystemsArray[1].LocalWorkingDirectory = WorkingDirectory + SecondaryOperatingSystemIPSW.getBuildNumber() + "_Secondary";
                string ImageFileName = Path.GetFileName(OperatingSystemsArray[1].LowLevelBootloader);
                string[] SplittedImageFileName = ImageFileName.Split('.');
                string UpdatedImageFileName = "";
                SplittedImageFileName[0] = SplittedImageFileName[0] + "B";
                UpdatedImageFileName = SplittedImageFileName[0] + "." + SplittedImageFileName[1] + "." + SplittedImageFileName[2] + "." + SplittedImageFileName[3];
                File.Copy(OperatingSystemsArray[1].LowLevelBootloader, OperatingSystemsArray[1].LocalWorkingDirectory + "\\" + UpdatedImageFileName);
                OperatingSystemsArray[1].LowLevelBootloader = OperatingSystemsArray[1].LocalWorkingDirectory + "\\" + UpdatedImageFileName;

                string DecryptedRootFileSystemImagePath = DecryptRootFileSystemImage(SecondaryOperatingSystemIPSW.getFileNameIPSW(), SecondaryOperatingSystemIPSW.getRootFileSystemImagePath());
                File.Move(DecryptedRootFileSystemImagePath, OperatingSystemsArray[1].LocalWorkingDirectory + "\\" + "RootFileSystem.dmg");
                OperatingSystemsArray[1].RootFileSystem = OperatingSystemsArray[1].LocalWorkingDirectory + "\\" + "RootFileSystem.dmg";

                for (int i = 0; i < SecondaryOperatingSystemIPSW.getAllFilesIPSW().Length; i++)
                {
                    if (SecondaryOperatingSystemIPSW.getAllFilesIPSW()[i].Contains("kernel"))
                    {
                        File.Copy(SecondaryOperatingSystemIPSW.getAllFilesIPSW()[i], OperatingSystemsArray[1].LocalWorkingDirectory + "\\" + Path.GetFileName(SecondaryOperatingSystemIPSW.getAllFilesIPSW()[i]));
                        OperatingSystemsArray[1].KernelCache = OperatingSystemsArray[1].LocalWorkingDirectory + "\\" + Path.GetFileName(SecondaryOperatingSystemIPSW.getAllFilesIPSW()[i]);
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

        public void ConnectSSH(string DeviceHostName, string UserName, string UserPassword)
        {
            SSH = new SecureShell();
            SSH.Connect(DeviceHostName, UserName, UserPassword);
        }

        public void InstallRequiredTools()
        {
            SSH.ExecuteRemoteCommand("mkdir " + DeviceWorkingDirectory);

            string RemoteToolsDirectory = DeviceWorkingDirectory + "Tools//";
            SSH.ExecuteRemoteCommand("mkdir " + RemoteToolsDirectory);

            SSH.UploadFile(".\\Tools\\kloader6.deb", RemoteToolsDirectory);
            SSH.ExecuteRemoteCommand("dpkg -i " + RemoteToolsDirectory + "kloader6.deb");

            SSH.UploadFile(".\\Tools\\xpwntool.deb", RemoteToolsDirectory);
            SSH.ExecuteRemoteCommand("dpkg -i " + RemoteToolsDirectory + "xpwntool.deb");

            SSH.UploadFile(".\\Tools\\hfsresize.deb", RemoteToolsDirectory);
            SSH.ExecuteRemoteCommand("dpkg -i " + RemoteToolsDirectory + "hfsresize.deb");

            SSH.UploadFile(".\\Tools\\gptfdisk.deb", RemoteToolsDirectory);
            SSH.ExecuteRemoteCommand("dpkg -i " + RemoteToolsDirectory + "gptfdisk.deb");

            SSH.UploadFile(".\\Tools\\attach.deb", RemoteToolsDirectory);
            SSH.ExecuteRemoteCommand("dpkg -i " + RemoteToolsDirectory + "attach.deb");

            SSH.UploadFile(".\\Tools\\detach.deb", RemoteToolsDirectory);
            SSH.ExecuteRemoteCommand("dpkg -i " + RemoteToolsDirectory + "detach.deb");

            SSH.UploadFile(".\\Tools\\rsync.deb", RemoteToolsDirectory);
            SSH.ExecuteRemoteCommand("dpkg -i " + RemoteToolsDirectory + "rsync.deb");
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
            for (int i = 1; i < OperatingSystemsArray.Length; i++)
            {
                if (OperatingSystemsArray[i] != null)
                {
                    OperatingSystemsArray[i].RemoteWorkingDirectory = DeviceWorkingDirectory + OperatingSystemsArray[i].SystemBuildNumber + "//";
                    SSH.ExecuteRemoteCommand("mkdir " + OperatingSystemsArray[i].RemoteWorkingDirectory);
                    SSH.UploadFile(OperatingSystemsArray[i].RootFileSystem, OperatingSystemsArray[i].RemoteWorkingDirectory);
                    string RemoteRootFileSystemImagePath = OperatingSystemsArray[i].RemoteWorkingDirectory + Path.GetFileName(OperatingSystemsArray[i].RootFileSystem);
                    SSH.ExecuteRemoteCommand(RestoreRootFileSystem(RemoteRootFileSystemImagePath, OperatingSystemsArray[i].SystemPartition));
                    SSH.ExecuteRemoteCommand(RestoreDataPartition(OperatingSystemsArray[i]));
                    BuildFStab(OperatingSystemsArray[i]);
                    FixSystemBag(OperatingSystemsArray[i]);
                    SSH.ExecuteRemoteCommand(InstallKernelCache(OperatingSystemsArray[i]));
                    InstallLowLevelBootloader(OperatingSystemsArray[i]);
                    InstallBootLauncher(OperatingSystemsArray[i]);
                    SSH.ExecuteRemoteCommand("rm -rf " + OperatingSystemsArray[i].RemoteWorkingDirectory);
                }
            }
            SSH.ExecuteRemoteCommand("reboot");
            SSH.Disconnect();
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

        private string RestoreDataPartition(OperatingSystem pOperatingSystem)
        {
            return "rsync -rav " + pOperatingSystem.SystemPartition.MountPoint + "//var//*" + " " + pOperatingSystem.DataPartition.MountPoint;
        }

        private string InstallKernelCache(OperatingSystem OperatingSystem)
        {
            SSH.UploadFile(OperatingSystem.KernelCache, OperatingSystem.RemoteWorkingDirectory);

            string KernelcacheIV = "";
            string KernelcacheKey = "";
            XmlDocument XmlContainer = new XmlDocument();
            XmlContainer.Load(".\\Keys\\" + OperatingSystem.FileNameIPSW + ".xml");

            XmlNodeList PatchNodeListID = XmlContainer.SelectNodes("/Container/DecryptionKeys/ID");

            foreach (XmlNode NodeID in PatchNodeListID)
            {
                if (NodeID.InnerText == "Kernelcache")
                {
                    KernelcacheIV = NodeID.NextSibling.NextSibling.InnerText;
                    KernelcacheKey = NodeID.NextSibling.NextSibling.NextSibling.InnerText;
                }
            }
            return "xpwntool " + OperatingSystem.RemoteWorkingDirectory + Path.GetFileName(OperatingSystem.KernelCache) + " " + "/System/Library/Caches/com.apple.kernelcaches/kernelcach" + char.ToLower(OperatingSystem.SystemID) + " -iv " + KernelcacheIV + " -k " + KernelcacheKey + " -decrypt";
        }

        private void BuildFStab(OperatingSystem pOperatingSystem)
        {
            List<string> FStabContent = new List<string>();
            FStabContent.Add(pOperatingSystem.SystemPartition.DiskDevicePath + " / hfs rw 0 1");
            FStabContent.Add(pOperatingSystem.DataPartition.DiskDevicePath + " /private/var hfs rw 0 2");
            File.AppendAllLines(pOperatingSystem.LocalWorkingDirectory + "\\" + "fstab", (FStabContent));
            SSH.ExecuteRemoteCommand("rm " + pOperatingSystem.SystemPartition.MountPoint + "/etc/fstab");
            SSH.UploadFile(pOperatingSystem.LocalWorkingDirectory + "\\" + "fstab", pOperatingSystem.SystemPartition.MountPoint + "/etc/fstab");
        }

        private void FixSystemBag(OperatingSystem pOperatingSystem)
        {
            SSH.ExecuteRemoteCommand("mkdir " + pOperatingSystem.DataPartition.MountPoint + "/keybags");
            SSH.ExecuteRemoteCommand("cp -rfp " + "/var/keybags/systembag.kb" + " " + pOperatingSystem.DataPartition.MountPoint + "/keybags/");
        }

        private void InstallLowLevelBootloader(OperatingSystem pOperatingSystem)
        {
            SSH.ExecuteRemoteCommand("mkdir /Bootloaders");
            SSH.UploadFile(pOperatingSystem.LocalWorkingDirectory + "\\" + Path.GetFileName(pOperatingSystem.LowLevelBootloader), "/Bootloaders/");
        }

        private void InstallBootLauncher(OperatingSystem pOperatingSystem)
        {
            string RemoteToolsDirectory = DeviceWorkingDirectory + "Tools//";
            switch (pOperatingSystem.SystemVersion)
            {
                case "5.1":
                    SSH.UploadFile(".\\Tools\\ios5bootstrap.deb", RemoteToolsDirectory);
                    SSH.ExecuteRemoteCommand("dpkg -i " + RemoteToolsDirectory + "ios5bootstrap.deb");
                    StreamWriter FileWriter = new StreamWriter(pOperatingSystem.LocalWorkingDirectory + "\\" + "iOS5Bootstrap.sh", false, Encoding.UTF8);
                    FileWriter.WriteLine("#!/bin/bash");
                    FileWriter.Write("kloader6 " + "/Bootloaders/" + Path.GetFileName(pOperatingSystem.LowLevelBootloader));
                    FileWriter.Close();
                    SSH.ExecuteRemoteCommand("rm /usr/bin/iOS5Bootstrap.sh");
                    SSH.UploadFile(pOperatingSystem.LocalWorkingDirectory + "\\" + "iOS5Bootstrap.sh", "/usr/bin/");
                    SSH.ExecuteRemoteCommand("chmod 755 /usr/bin/iOS5Bootstrap.sh");
                    break;
            }
        }

        public void CleanupWorkingDirectory()
        {
            if (Directory.Exists(WorkingDirectory))
            {
                DirectoryInfo InfoDirectory = new DirectoryInfo(WorkingDirectory);
                foreach (FileInfo File in InfoDirectory.GetFiles())
                {
                    File.Delete();
                }

                foreach (DirectoryInfo InfoDir in InfoDirectory.GetDirectories())
                {
                    InfoDir.Delete(true);
                }
            }
        }
    }
}
