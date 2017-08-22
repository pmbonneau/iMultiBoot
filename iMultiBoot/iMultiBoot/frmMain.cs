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
            Controller.PrepareMainOperatingSystemIPSW();
            gbConnectionSSH.Enabled = true;
            txtDeviceHostName.Enabled = true;
            txtUserName.Enabled = true;
            txtUserPassword.Enabled = true;
            btnInstallOperatingSystems.Enabled = true;
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
            Controller.InstallRequiredTools();
            Controller.PartitionDeviceStorage();
            Controller.RestoreOperatingSystems();
        }
    }
}
