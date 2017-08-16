using System;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

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
            txtWorkingDirectory.Text = pController.getWorkingDirectory();
        }

        private void btnBrowseTempDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog vFolderBrowserDialog = new FolderBrowserDialog();
            vFolderBrowserDialog.Description = "Select Working Directory";
            DialogResult result = vFolderBrowserDialog.ShowDialog();
            if (vFolderBrowserDialog.SelectedPath != "")
            {
                Controller.setWorkingDirectory(vFolderBrowserDialog.SelectedPath);
            }
            txtWorkingDirectory.Text = Controller.getWorkingDirectory();
        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            Controller.setDeviceWorkingDirectory(txtDeviceWorkingDirectory.Text);
            Close();
        }

        private void btnSerializeController_Click(object sender, EventArgs e)
        {
            SaveFileDialog vSaveFileDialog = new SaveFileDialog();
            DialogResult result = vSaveFileDialog.ShowDialog();
            Stream DataStream = File.Open(vSaveFileDialog.FileName, FileMode.Create);
            BinaryFormatter ObjectToBinary = new BinaryFormatter();
            ObjectToBinary.Serialize(DataStream, Controller);
            DataStream.Close();
        }

        private void btnDeserializeController_Click(object sender, EventArgs e)
        {
            OpenFileDialog vOpenFileDialog = new OpenFileDialog();
            DialogResult result = vOpenFileDialog.ShowDialog();
            Stream DataStream = File.Open(vOpenFileDialog.FileName, FileMode.Open);
            BinaryFormatter ObjectFromBinary = new BinaryFormatter();
            Controller = (iMultiBootController)ObjectFromBinary.Deserialize(DataStream);
            DataStream.Close();
        }
    }
}
