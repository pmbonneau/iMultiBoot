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
            lbPartitionTable.Items.Add(Device.SystemPartition.Name);
            lbPartitionTable.Items.Add(Device.DataPartition.Name);
        }

        private void btnResizeDataPartition_Click(object sender, EventArgs e)
        {
            Device.PartitionList.RemoveAt(1);
            Partition NewPartition = new Partition("Data", Convert.ToInt32(txtNewDataPartitionSize.Text));
            Device.DataPartition = NewPartition;
            Device.PartitionList.Add(NewPartition);
        }

        private void lbPartitionTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPartitionInformationNumber.Text = Convert.ToString(lbPartitionTable.SelectedIndex + 1);
            txtPartitionInformationSize.Text = Convert.ToString(Device.PartitionList[lbPartitionTable.SelectedIndex].Size);
        }

        private void btnDeletePartition_Click(object sender, EventArgs e)
        {
            lbPartitionTable.SelectedIndex--;
            lbPartitionTable.Items.RemoveAt(Convert.ToInt32(txtPartitionInformationNumber.Text));
            Device.PartitionList.RemoveAt(Convert.ToInt32(txtPartitionInformationNumber.Text));
        }

        private void btnCreatePartition_Click(object sender, EventArgs e)
        {
            Partition NewPartition = new Partition(txtPartitionCreationName.Text,Convert.ToInt32(txtPartitionCreationSize.Text));
            NewPartition.Number = Convert.ToString(Device.PartitionList.Count);
            Device.PartitionList.Add(NewPartition);
            lbPartitionTable.Items.Add(NewPartition.Name);
            txtPartitionCreationName.Text = "";
            txtPartitionCreationSize.Text = "";
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
