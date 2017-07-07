using System;
using System.IO;
using System.Windows.Forms;

namespace iMultiBoot
{
    public partial class frmConfigureOS : Form
    {
        IOperatingSystem OperatingSystem;
        iMultiBootController Controller;

        public frmConfigureOS()
        {
            InitializeComponent();
        }

        public frmConfigureOS(IOperatingSystem pOperatingSystem, iMultiBootController pController)
        {
            InitializeComponent();
            OperatingSystem = pOperatingSystem;
            Controller = pController;
        }

        private void btnDeviceTree_Click(object sender, EventArgs e)
        {
            OpenFileDialog vOpenFileDialog = new OpenFileDialog();
            vOpenFileDialog.Title = "Select Custom DeviceTree Image";
            vOpenFileDialog.Filter = "IMG3 Files|*.img3";
            DialogResult result = vOpenFileDialog.ShowDialog();
            txtDeviceTree.Text = vOpenFileDialog.FileName;

            string GenericDeviceTreeFileName = "DeviceTree." + OperatingSystem.SystemBuildNumber + ".img3";

            Directory.CreateDirectory(Controller.getWorkingDirectory());

            File.Copy(vOpenFileDialog.FileName, Controller.getWorkingDirectory() + "\\" + GenericDeviceTreeFileName);
            OperatingSystem.DeviceTree = Controller.getWorkingDirectory() + "\\" + GenericDeviceTreeFileName;
        }

        private void btnFirstStageBootloader_Click(object sender, EventArgs e)
        {
            OpenFileDialog vOpenFileDialog = new OpenFileDialog();
            vOpenFileDialog.Title = "Select Custom First Stage Bootloader Image";
            vOpenFileDialog.Filter = "IMG3 Files|*.img3";
            DialogResult result = vOpenFileDialog.ShowDialog();
            txtFirstStageBootloader.Text = vOpenFileDialog.FileName;

            string GenericFirstStageBootloaderFileName = "LLB." + OperatingSystem.SystemBuildNumber + ".img3";

            Directory.CreateDirectory(Controller.getWorkingDirectory());

            File.Copy(vOpenFileDialog.FileName, Controller.getWorkingDirectory() + "\\" + GenericFirstStageBootloaderFileName);
            OperatingSystem.DeviceTree = Controller.getWorkingDirectory() + "\\" + GenericFirstStageBootloaderFileName;
        }

        private void btnSecondaryStageBootloader_Click(object sender, EventArgs e)
        {
            OpenFileDialog vOpenFileDialog = new OpenFileDialog();
            vOpenFileDialog.Title = "Select Custom Secondary Stage Bootloader Image";
            vOpenFileDialog.Filter = "IMG3 Files|*.img3";
            DialogResult result = vOpenFileDialog.ShowDialog();
            txtSecondaryStageBootloader.Text = vOpenFileDialog.FileName;

            string GenericSecondaryStageBootloaderFileName = "iBoot." + OperatingSystem.SystemBuildNumber + ".img3";

            Directory.CreateDirectory(Controller.getWorkingDirectory());

            File.Copy(vOpenFileDialog.FileName, Controller.getWorkingDirectory() + "\\" + GenericSecondaryStageBootloaderFileName);
            OperatingSystem.DeviceTree = Controller.getWorkingDirectory() + "\\" + GenericSecondaryStageBootloaderFileName;
        }
    }
}
