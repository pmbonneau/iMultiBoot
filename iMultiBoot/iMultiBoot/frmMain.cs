using System;
using System.Windows.Forms;

namespace iMultiBoot
{
    public partial class frmMain : Form
    {
        iMultiBootController Controller;

        public frmMain()
        {
            InitializeComponent();
            MessageBox.Show("Some features of iMultiBoot require flashing low-level components which might contain critical information needed by the iOS device to work properly. This software is provided as-is without warranty, iMultiBoot can cause permanent damages to iOS devices. I'm not responsible of any damages this software may do to any of your equipment. By clicking OK, you understand this.", "Disclaimer", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Controller = new iMultiBootController();
        }

        private void btnBegin_Click(object sender, EventArgs e)
        {
            pnlMain.Visible = true;
        }

        private void btnConfigureSoftware_Click(object sender, EventArgs e)
        {
            frmSoftwareConfiguration SoftwareConfiguration = new frmSoftwareConfiguration(Controller);
            SoftwareConfiguration.Show();
        }

        private void btnSelectDevice_Click(object sender, EventArgs e)
        {
            frmDeviceSelection DeviceSelection = new frmDeviceSelection(Controller);
            DeviceSelection.Show();
            btnManagePartitions.Enabled = true;
        }

        private void btnSelectOperatingSystems_Click(object sender, EventArgs e)
        {
            frmSelectionOS SelectionOS = new frmSelectionOS(Controller);
            SelectionOS.Show();
            btnBuildFirmware.Enabled = true;
        }

        private void btnBuildFirmware_Click(object sender, EventArgs e)
        {
            DialogResult DialogResult = MessageBox.Show("This will build the firmware package (IPSW) then erase restore the iOS device. Click OK only if you are ready to erase restore your iOS device, otherwise click cancel.", "Build Firmware Package and Restore iOS Device", MessageBoxButtons.OKCancel);
            if (DialogResult == DialogResult.OK)
            {
                MessageBox.Show("Set your iOS device in DFU Mode or Recovery Mode, then click OK.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Controller.PrepareMainOperatingSystemIPSW();
                gbConnectionSSH.Enabled = true;
                txtDeviceHostName.Enabled = true;
                txtUserName.Enabled = true;
                txtUserPassword.Enabled = true;
                btnInstallOperatingSystems.Enabled = true;
            }
            else if (DialogResult == DialogResult.Cancel)
            {
                return;
            }
        }

        private void btnManagePartitions_Click(object sender, EventArgs e)
        {
            frmPartitionManager PartitionManager = new frmPartitionManager(Controller.getAppleMobileDevice(), Controller);
            PartitionManager.Show();
            btnSelectOperatingSystems.Enabled = true;
        }

        private void btnInstallOperatingSystems_Click(object sender, EventArgs e)
        {
            Controller.ConnectSSH(txtDeviceHostName.Text, txtUserName.Text, txtUserPassword.Text);
            MessageBox.Show("Connected to iOS device, click OK to start the install process.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Controller.InstallRequiredTools();
            Controller.PartitionDeviceStorage();
            Controller.RestoreOperatingSystems();
            MessageBox.Show("Installation successfully completed.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCredits_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This project would not be possible without help from :" + Environment.NewLine + "@xerub" + Environment.NewLine + "@winocm" + Environment.NewLine + "@iH8Sn0w" + Environment.NewLine + "@JonathanSeals" + Environment.NewLine + "@danzatt", "Credits", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
