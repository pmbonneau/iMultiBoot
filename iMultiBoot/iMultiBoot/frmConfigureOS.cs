using System;
using System.IO;
using System.Windows.Forms;

namespace iMultiBoot
{
    public partial class frmConfigureOS : Form
    {
        OperatingSystem OperatingSystem;
        iMultiBootController Controller;
        Partition SelectedPartition;

        public frmConfigureOS()
        {
            InitializeComponent();
        }

        public frmConfigureOS(OperatingSystem pOperatingSystem, iMultiBootController pController)
        {
            InitializeComponent();
            OperatingSystem = pOperatingSystem;
            Controller = pController;
            for (int i = 0; i < Controller.getAppleMobileDevice().PartitionList.Count; i++)
            {
                lbPartitionTable.Items.Add(Controller.getAppleMobileDevice().PartitionList[i].Name);
            }
        }

        private void btnDeviceTree_Click(object sender, EventArgs e)
        {
            OpenFileDialog vOpenFileDialog = new OpenFileDialog();
            vOpenFileDialog.Title = "Select Custom DeviceTree Image";
            vOpenFileDialog.Filter = "IMG3 Files|*.img3";
            DialogResult result = vOpenFileDialog.ShowDialog();
            txtDeviceTree.Text = vOpenFileDialog.FileName;

            string GenericDeviceTreeFileName = "DeviceTree." + Controller.getAppleMobileDevice().InternalCodeName + "_custom.img3";

            if (Directory.Exists(Controller.getWorkingDirectory()) == false)
            {
                Directory.CreateDirectory(Controller.getWorkingDirectory());
            }

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

            string GenericFirstStageBootloaderFileName = "LLB." + Controller.getAppleMobileDevice().InternalCodeName + ".RELEASE.img3";

            if (Directory.Exists(Controller.getWorkingDirectory()) == false)
            {
                Directory.CreateDirectory(Controller.getWorkingDirectory());
            }

            File.Copy(vOpenFileDialog.FileName, Controller.getWorkingDirectory() + "\\" + GenericFirstStageBootloaderFileName);
            OperatingSystem.LowLevelBootloader = Controller.getWorkingDirectory() + "\\" + GenericFirstStageBootloaderFileName;
        }

        private void btnSecondaryStageBootloader_Click(object sender, EventArgs e)
        {
            OpenFileDialog vOpenFileDialog = new OpenFileDialog();
            vOpenFileDialog.Title = "Select Custom Secondary Stage Bootloader Image";
            vOpenFileDialog.Filter = "IMG3 Files|*.img3";
            DialogResult result = vOpenFileDialog.ShowDialog();
            txtSecondaryStageBootloader.Text = vOpenFileDialog.FileName;

            string GenericSecondaryStageBootloaderFileName = "iBoot." + Controller.getAppleMobileDevice().InternalCodeName + ".RELEASE.img3";

            if (Directory.Exists(Controller.getWorkingDirectory()) == false)
            {
                Directory.CreateDirectory(Controller.getWorkingDirectory());
            }

            File.Copy(vOpenFileDialog.FileName, Controller.getWorkingDirectory() + "\\" + GenericSecondaryStageBootloaderFileName);
            OperatingSystem.iBoot = Controller.getWorkingDirectory() + "\\" + GenericSecondaryStageBootloaderFileName;
        }

        private void btnBootLogo_Click(object sender, EventArgs e)
        {
            OpenFileDialog vOpenFileDialog = new OpenFileDialog();
            vOpenFileDialog.Title = "Select Custom Boot Logo Image";
            vOpenFileDialog.Filter = "IMG3 Files|*.img3";
            DialogResult result = vOpenFileDialog.ShowDialog();
            txtBootLogo.Text = vOpenFileDialog.FileName;

            string GenericBootLogoImageFileName = "applelogo." + Controller.getAppleMobileDevice().InternalCodeName + "_custom.img3";

            if (Directory.Exists(Controller.getWorkingDirectory()) == false)
            {
                Directory.CreateDirectory(Controller.getWorkingDirectory());
            }

            File.Copy(vOpenFileDialog.FileName, Controller.getWorkingDirectory() + "\\" + GenericBootLogoImageFileName);
            OperatingSystem.BootLogo = Controller.getWorkingDirectory() + "\\" + GenericBootLogoImageFileName;
        }

        private void lbPartitionTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedPartition = Controller.getAppleMobileDevice().PartitionList[lbPartitionTable.SelectedIndex];
        }

        private void btnSetSystem_Click(object sender, EventArgs e)
        {
            if (lbPartitionTable.SelectedIndex == 0 || lbPartitionTable.SelectedIndex == 1)
            {
                MessageBox.Show("Can't set " + SelectedPartition.Name + " as system partition for a secondary OS instance.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            OperatingSystem.SystemPartition = SelectedPartition;
            txtSystemPartition.Text = SelectedPartition.Name;

        }

        private void btnSetData_Click(object sender, EventArgs e)
        {
            if (lbPartitionTable.SelectedIndex == 0 || lbPartitionTable.SelectedIndex == 1)
            {
                MessageBox.Show("Can't set " + SelectedPartition.Name + " as data partition for a secondary OS instance.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            OperatingSystem.DataPartition = SelectedPartition;
            txtDataPartition.Text = SelectedPartition.Name;
        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
