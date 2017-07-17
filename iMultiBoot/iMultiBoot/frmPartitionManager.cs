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
    public partial class frmPartitionManager : Form
    {
        AppleMobileDevice Device;
        iMultiBootController Controller;

        public frmPartitionManager(AppleMobileDevice pDevice, iMultiBootController pController)
        {
            InitializeComponent();
            Device = pDevice;
            Controller = pController;
        }

        private void btnResizeDataPartition_Click(object sender, EventArgs e)
        {
            Device.PartitionList.RemoveAt(1);
            Partition NewPartition = new Partition("Data", Convert.ToInt32(txtNewDataPartitionSize.Text));
            Device.DataPartition = NewPartition;
            Device.PartitionList.Add(NewPartition);
            lbPartitionTable.Items.Add("Not Defined");
            lbPartitionTable.Items.Add("Not Defined");
            lbPartitionTable.Items.Add("Not Defined");
            lbPartitionTable.Items.Add("Not Defined");
            lbPartitionTable.Items.Add("Not Defined");
            lbPartitionTable.Items.Add("Not Defined");
        }

        private void lbPartitionTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPartitionInformationNumber.Text = e.ToString();
            txtPartitionInformationSize.Text = Convert.ToString(Device.DataPartitionRemainingCapacity);
        }

        private void btnDeletePartition_Click(object sender, EventArgs e)
        {
            Device.PartitionList.RemoveAt(Convert.ToInt32(txtPartitionInformationNumber) - 1);
        }

        private void btnCreatePartition_Click(object sender, EventArgs e)
        {
            Partition NewPartition = new Partition(txtPartitionCreationName.Text,Convert.ToInt32(txtPartitionCreationSize.Text));
            Device.PartitionList.Add(NewPartition);
        }
    }
}
