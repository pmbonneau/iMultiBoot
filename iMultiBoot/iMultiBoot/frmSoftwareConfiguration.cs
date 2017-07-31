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
    public partial class frmSoftwareConfiguration : Form
    {
        iMultiBootController Controller;
        public frmSoftwareConfiguration()
        {
            InitializeComponent();
        }

        public frmSoftwareConfiguration(iMultiBootController pController)
        {
            InitializeComponent();
            Controller = pController;
        }

        private void btnBrowseTempDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog vFolderBrowserDialog = new FolderBrowserDialog();
            vFolderBrowserDialog.Description = "Select Working Directory";
            DialogResult result = vFolderBrowserDialog.ShowDialog();
            Controller.setWorkingDirectory(vFolderBrowserDialog.SelectedPath);
            txtWorkingDirectory.Text = Controller.getWorkingDirectory();

            Controller.setDeviceWorkingDirectory(txtDeviceWorkingDirectory.Text);
        }
    }
}
