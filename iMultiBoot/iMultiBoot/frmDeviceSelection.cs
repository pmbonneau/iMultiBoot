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
        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            string InternalCodeName = "";
            int NandTotalCapacity = 32000;
            int NandBlockSize = 0;
            int DataPartitionCapacity = 0;
            if (Convert.ToString(cmbDeviceSelection.SelectedItem) == "iPod Touch 4th (N81AP)")
            {
                InternalCodeName = "n81ap";
                NandBlockSize = 8192;
            }

            if (Convert.ToString(cmbCapacitySelection.SelectedItem) == "8 GB")
            {
                NandTotalCapacity = 8000;
                DataPartitionCapacity = 5600;
            }
            else if (Convert.ToString(cmbCapacitySelection.SelectedItem) == "16 GB")
            {
                NandTotalCapacity = 16000;
                DataPartitionCapacity = 12000;
            }
            else if (Convert.ToString(cmbCapacitySelection.SelectedItem) == "32 GB")
            {
                NandTotalCapacity = 32000;
                DataPartitionCapacity = 26000;
            }

            Partition SystemPartition = new Partition("System", NandTotalCapacity - DataPartitionCapacity);
            Partition DataPartition = new Partition("Data", DataPartitionCapacity);

            iDevice = new AppleMobileDevice(InternalCodeName, SystemPartition, DataPartition);

            iDevice.NandTotalCapacity = NandTotalCapacity;
            iDevice.NandBlockSize = NandBlockSize;

            Controller.setAppleMobileDevice(iDevice);

            Close();
        }
    }
}
