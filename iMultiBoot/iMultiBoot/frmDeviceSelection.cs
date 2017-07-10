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
    public partial class frmDeviceSelection : Form
    {
        public frmDeviceSelection()
        {
            InitializeComponent();
        }

        iMultiBootController Controller;
        AppleMobileDevice iDevice;

        public frmDeviceSelection(iMultiBootController pController)
        {
            InitializeComponent();
            Controller = pController;
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            string InternalCodeName = "";
            int NandTotalCapacity = 0;
            if (Convert.ToString(cmbDeviceSelection.SelectedItem) == "iPod Touch 4th (N81AP)")
            {
                InternalCodeName = "n81ap";
            }
            iDevice = new AppleMobileDevice(InternalCodeName);

            if (Convert.ToString(cmbCapacitySelection.SelectedItem) == "8 GB")
            {
                NandTotalCapacity = 8;
            }
            else if (Convert.ToString(cmbCapacitySelection.SelectedItem) == "16 GB")
            {
                NandTotalCapacity = 16;
            }
            else if (Convert.ToString(cmbCapacitySelection.SelectedItem) == "32 GB")
            {
                NandTotalCapacity = 32;
            }
            iDevice.setNandTotalCapacity(NandTotalCapacity);
            iDevice.setNandRemainingCapacity(Convert.ToDouble(txtRemainingCapacity.Text));
            Controller.setAppleMobileDevice(iDevice);
            Close();
        }
    }
}
