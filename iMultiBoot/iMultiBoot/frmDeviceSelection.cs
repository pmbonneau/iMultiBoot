using System;
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

            string[] AvailableDevices = Controller.getAvailableDevices();
            for (int i = 0; i < AvailableDevices.Length; i++)
            {
                switch (AvailableDevices[i])
                {
                    case "k94ap":
                        cmbDeviceSelection.Items.Add("iPad 2nd (K94AP)");
                        break;
                    case "n81ap":
                        cmbDeviceSelection.Items.Add("iPod Touch 4th (N81AP)");
                        break;
                    case "n88ap":
                        cmbDeviceSelection.Items.Add("iPhone 3Gs (N88AP)");
                        break;
                    case "n90ap":
                        cmbDeviceSelection.Items.Add("iPhone 4 (N90AP)");
                        break;
                    default:
                        cmbDeviceSelection.Items.Add(AvailableDevices[i]);
                        break;
                }
            }
        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            string InternalCodeName = "";
            int NandTotalCapacity = 32000;
            int NandBlockSize = 0;

            switch (Convert.ToString(cmbDeviceSelection.SelectedItem))
            {
                case "iPad 2nd (K94AP)":
                    InternalCodeName = "k94ap";
                    NandBlockSize = 8192;
                    break;
                case "iPod Touch 4th (N81AP)":
                    InternalCodeName = "n81ap";
                    NandBlockSize = 8192;
                    break;
                case "iPhone 3Gs (N88AP)":
                    InternalCodeName = "n88ap";
                    NandBlockSize = 8192;
                    break;
                case "iPhone 4 (N90AP)":
                    InternalCodeName = "n90ap";
                    NandBlockSize = 8192;
                    break;
            }

            switch (Convert.ToString(cmbCapacitySelection.SelectedItem))
            {
                case "8 GB":
                    NandTotalCapacity = 8000;
                    break;
                case "16 GB":
                    NandTotalCapacity = 16000;
                    break;
                case "32 GB":
                    NandTotalCapacity = 32000;
                    break;
                case "64 GB":
                    NandTotalCapacity = 64000;
                    break;
                case "128 GB":
                    NandTotalCapacity = 128000;
                    break;
            }

            iDevice = new AppleMobileDevice(InternalCodeName);

            iDevice.NandTotalCapacity = NandTotalCapacity;
            iDevice.NandBlockSize = NandBlockSize;

            Controller.setAppleMobileDevice(iDevice);

            Close();
        }
    }
}
