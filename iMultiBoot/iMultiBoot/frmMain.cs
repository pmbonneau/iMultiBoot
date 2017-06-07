using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iMultiBoot
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        iMultiBootController Controller = new iMultiBootController();

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
        }

        private void btnSelectOperatingSystems_Click(object sender, EventArgs e)
        {
            frmSelectionOS SelectionOS = new frmSelectionOS(Controller);
            SelectionOS.Show();
        }

        private void btnInstall_Click(object sender, EventArgs e)
        {
            Controller.PrepareMainOperatingSystemIPSW();
        }
    }
}
