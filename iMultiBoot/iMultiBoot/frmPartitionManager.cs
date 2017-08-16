using System;
using System.Windows.Forms;

namespace iMultiBoot
{
    public partial class frmPartitionManager : Form
    {
        AppleMobileDevice Device;
        iMultiBootController Controller;
        int DeviceAvailableStorage = 0;

        public frmPartitionManager(AppleMobileDevice pDevice, iMultiBootController pController)
        {
            InitializeComponent();
            Device = pDevice;
            Controller = pController;
            lbPartitionTable.Items.Add(Device.SystemPartition.Name);
            lbPartitionTable.Items.Add(Device.DataPartition.Name);
            txtDeviceAvailableStorage.Text = Convert.ToString(DeviceAvailableStorage);
        }

        private void btnResizeDataPartition_Click(object sender, EventArgs e)
        {
            Device.PartitionList.RemoveAt(1);
            Partition NewPartition = new Partition("Data", Convert.ToInt32(txtNewDataPartitionSize.Text));
            Device.DataPartition = NewPartition;
            Device.PartitionList.Add(NewPartition);
            DeviceAvailableStorage = Device.NandTotalCapacity - Device.SystemPartition.Size - Device.DataPartition.Size;
            txtDeviceAvailableStorage.Text = Convert.ToString(DeviceAvailableStorage);
            btnCreatePartition.Enabled = true;
            btnDeletePartition.Enabled = true;
        }

        private void lbPartitionTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnResizeDataPartition.Enabled = false;
            if (lbPartitionTable.SelectedIndex == 1)
            {
                btnResizeDataPartition.Enabled = true;
            }
            txtPartitionInformationNumber.Text = Convert.ToString(lbPartitionTable.SelectedIndex + 1);
            txtPartitionInformationSize.Text = Convert.ToString(Device.PartitionList[lbPartitionTable.SelectedIndex].Size);
        }

        private void btnDeletePartition_Click(object sender, EventArgs e)
        {
            if (lbPartitionTable.SelectedIndex == 0 || lbPartitionTable.SelectedIndex == 1)
            {
                MessageBox.Show("Can't delete primary operating system partitions.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            lbPartitionTable.SelectedIndex--;
            lbPartitionTable.Items.RemoveAt(Convert.ToInt32(txtPartitionInformationNumber.Text));
            DeviceAvailableStorage = DeviceAvailableStorage + Device.PartitionList[Convert.ToInt32(txtPartitionInformationNumber.Text)].Size;
            Device.PartitionList.RemoveAt(Convert.ToInt32(txtPartitionInformationNumber.Text));
            txtDeviceAvailableStorage.Text = Convert.ToString(DeviceAvailableStorage);
        }

        private void btnCreatePartition_Click(object sender, EventArgs e)
        {
            if ((DeviceAvailableStorage - Convert.ToInt32(txtPartitionCreationSize.Text)) < 256)
            {
                MessageBox.Show("Not enough disk space is available to create the new partition.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Partition NewPartition = new Partition(txtPartitionCreationName.Text,Convert.ToInt32(txtPartitionCreationSize.Text));
            NewPartition.Number = Convert.ToString(Device.PartitionList.Count + 1);
            if (cbJournaled.Checked == true)
            {
                NewPartition.JournaledFlag = true;
            }

            if (cbProtected.Checked == true)
            {
                NewPartition.ProtectedFlag = true;
            }
            Device.PartitionList.Add(NewPartition);
            lbPartitionTable.Items.Add(NewPartition.Name);
            DeviceAvailableStorage = DeviceAvailableStorage - NewPartition.Size;
            txtDeviceAvailableStorage.Text = Convert.ToString(DeviceAvailableStorage);
            txtPartitionCreationName.Text = "";
            txtPartitionCreationSize.Text = "";
        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
