using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace iMultiBoot
{
    public partial class frmSelectionOS : Form
    {
        iMultiBootController Controller;
        AppleMobileDevice iDevice;

        public frmSelectionOS()
        {
            InitializeComponent();
        }

        public frmSelectionOS(iMultiBootController pController)
        {
            InitializeComponent();
            Controller = pController;
            iDevice = Controller.getAppleMobileDevice();
        }

        private void btnSelectMainOS_Click(object sender, EventArgs e)
        {
            OpenFileDialog vOpenFileDialog = new OpenFileDialog();
            vOpenFileDialog.Title = "Select Main OS IPSW";
            vOpenFileDialog.Filter = "IPSW File|*.ipsw";
            DialogResult result = vOpenFileDialog.ShowDialog();
            Controller.setMainOperatingSystemPathIPSW(vOpenFileDialog.FileName);
            Controller.CreateOperatingSystemInstance(vOpenFileDialog.FileName,0);
            lblSelectedMainOS.Text = Path.GetFileName(vOpenFileDialog.FileName);
            btnConfigureMainOS.Enabled = true;
        }

        private void btnSelectSecondaryOS_Click(object sender, EventArgs e)
        {
            OpenFileDialog vOpenFileDialog = new OpenFileDialog();
            vOpenFileDialog.Title = "Select Secondary OS IPSW";
            vOpenFileDialog.Filter = "IPSW File|*.ipsw";
            DialogResult result = vOpenFileDialog.ShowDialog();
            Controller.setSecondaryOperatingSystemPathIPSW(vOpenFileDialog.FileName);
            Controller.CreateOperatingSystemInstance(vOpenFileDialog.FileName,1);
            lblSelectSecondaryOS.Text = Path.GetFileName(vOpenFileDialog.FileName);
            btnConfigureSecondaryOS.Enabled = true;
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
