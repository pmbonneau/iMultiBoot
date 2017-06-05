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

        private void btnBegin_Click(object sender, EventArgs e)
        {
            pnlMain.Visible = true;
        }

        private void btnSelectDevice_Click(object sender, EventArgs e)
        {
            frmDeviceSelection DeviceSelection = new frmDeviceSelection();
            DeviceSelection.Show();
        }
    }
}
