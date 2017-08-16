namespace iMultiBoot
{
    partial class frmPartitionManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDeviceAvailableStorage = new System.Windows.Forms.Label();
            this.txtDeviceAvailableStorage = new System.Windows.Forms.TextBox();
            this.lbPartitionTable = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbPartitionInformation = new System.Windows.Forms.GroupBox();
            this.lblPartitionInformationSize = new System.Windows.Forms.Label();
            this.txtPartitionInformationSize = new System.Windows.Forms.TextBox();
            this.txtPartitionInformationNumber = new System.Windows.Forms.TextBox();
            this.lblPartitionInformationNumber = new System.Windows.Forms.Label();
            this.gbPartitionCreation = new System.Windows.Forms.GroupBox();
            this.cbJournaled = new System.Windows.Forms.CheckBox();
            this.cbProtected = new System.Windows.Forms.CheckBox();
            this.txtPartitionCreationSize = new System.Windows.Forms.TextBox();
            this.lblPartitionCreationSize = new System.Windows.Forms.Label();
            this.txtPartitionCreationName = new System.Windows.Forms.TextBox();
            this.lblPartitionCreationName = new System.Windows.Forms.Label();
            this.btnDeletePartition = new System.Windows.Forms.Button();
            this.btnCreatePartition = new System.Windows.Forms.Button();
            this.btnResizeDataPartition = new System.Windows.Forms.Button();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.gbPartitionTablePreparation = new System.Windows.Forms.GroupBox();
            this.txtNewDataPartitionSize = new System.Windows.Forms.TextBox();
            this.lblDataPartitionSize = new System.Windows.Forms.Label();
            this.gbPartitionInformation.SuspendLayout();
            this.gbPartitionCreation.SuspendLayout();
            this.gbPartitionTablePreparation.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDeviceAvailableStorage
            // 
            this.lblDeviceAvailableStorage.AutoSize = true;
            this.lblDeviceAvailableStorage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeviceAvailableStorage.ForeColor = System.Drawing.Color.White;
            this.lblDeviceAvailableStorage.Location = new System.Drawing.Point(13, 474);
            this.lblDeviceAvailableStorage.Name = "lblDeviceAvailableStorage";
            this.lblDeviceAvailableStorage.Size = new System.Drawing.Size(199, 16);
            this.lblDeviceAvailableStorage.TabIndex = 0;
            this.lblDeviceAvailableStorage.Text = "Device Available Storage (MB) :";
            // 
            // txtDeviceAvailableStorage
            // 
            this.txtDeviceAvailableStorage.Enabled = false;
            this.txtDeviceAvailableStorage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeviceAvailableStorage.Location = new System.Drawing.Point(218, 471);
            this.txtDeviceAvailableStorage.Name = "txtDeviceAvailableStorage";
            this.txtDeviceAvailableStorage.ReadOnly = true;
            this.txtDeviceAvailableStorage.Size = new System.Drawing.Size(83, 22);
            this.txtDeviceAvailableStorage.TabIndex = 1;
            // 
            // lbPartitionTable
            // 
            this.lbPartitionTable.FormattingEnabled = true;
            this.lbPartitionTable.Location = new System.Drawing.Point(12, 26);
            this.lbPartitionTable.Name = "lbPartitionTable";
            this.lbPartitionTable.Size = new System.Drawing.Size(168, 56);
            this.lbPartitionTable.TabIndex = 2;
            this.lbPartitionTable.SelectedIndexChanged += new System.EventHandler(this.lbPartitionTable_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Current Partition Table :";
            // 
            // gbPartitionInformation
            // 
            this.gbPartitionInformation.Controls.Add(this.lblPartitionInformationSize);
            this.gbPartitionInformation.Controls.Add(this.txtPartitionInformationSize);
            this.gbPartitionInformation.Controls.Add(this.txtPartitionInformationNumber);
            this.gbPartitionInformation.Controls.Add(this.lblPartitionInformationNumber);
            this.gbPartitionInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPartitionInformation.ForeColor = System.Drawing.Color.White;
            this.gbPartitionInformation.Location = new System.Drawing.Point(12, 210);
            this.gbPartitionInformation.Name = "gbPartitionInformation";
            this.gbPartitionInformation.Size = new System.Drawing.Size(463, 70);
            this.gbPartitionInformation.TabIndex = 4;
            this.gbPartitionInformation.TabStop = false;
            this.gbPartitionInformation.Text = "Partition Information";
            // 
            // lblPartitionInformationSize
            // 
            this.lblPartitionInformationSize.AutoSize = true;
            this.lblPartitionInformationSize.Location = new System.Drawing.Point(286, 30);
            this.lblPartitionInformationSize.Name = "lblPartitionInformationSize";
            this.lblPartitionInformationSize.Size = new System.Drawing.Size(71, 16);
            this.lblPartitionInformationSize.TabIndex = 11;
            this.lblPartitionInformationSize.Text = "Size (MB) :";
            // 
            // txtPartitionInformationSize
            // 
            this.txtPartitionInformationSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPartitionInformationSize.Location = new System.Drawing.Point(365, 27);
            this.txtPartitionInformationSize.Name = "txtPartitionInformationSize";
            this.txtPartitionInformationSize.ReadOnly = true;
            this.txtPartitionInformationSize.Size = new System.Drawing.Size(83, 22);
            this.txtPartitionInformationSize.TabIndex = 10;
            // 
            // txtPartitionInformationNumber
            // 
            this.txtPartitionInformationNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPartitionInformationNumber.Location = new System.Drawing.Point(82, 27);
            this.txtPartitionInformationNumber.Name = "txtPartitionInformationNumber";
            this.txtPartitionInformationNumber.ReadOnly = true;
            this.txtPartitionInformationNumber.Size = new System.Drawing.Size(83, 22);
            this.txtPartitionInformationNumber.TabIndex = 8;
            // 
            // lblPartitionInformationNumber
            // 
            this.lblPartitionInformationNumber.AutoSize = true;
            this.lblPartitionInformationNumber.Location = new System.Drawing.Point(15, 30);
            this.lblPartitionInformationNumber.Name = "lblPartitionInformationNumber";
            this.lblPartitionInformationNumber.Size = new System.Drawing.Size(62, 16);
            this.lblPartitionInformationNumber.TabIndex = 0;
            this.lblPartitionInformationNumber.Text = "Number :";
            // 
            // gbPartitionCreation
            // 
            this.gbPartitionCreation.Controls.Add(this.cbJournaled);
            this.gbPartitionCreation.Controls.Add(this.cbProtected);
            this.gbPartitionCreation.Controls.Add(this.txtPartitionCreationSize);
            this.gbPartitionCreation.Controls.Add(this.lblPartitionCreationSize);
            this.gbPartitionCreation.Controls.Add(this.txtPartitionCreationName);
            this.gbPartitionCreation.Controls.Add(this.lblPartitionCreationName);
            this.gbPartitionCreation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPartitionCreation.ForeColor = System.Drawing.Color.White;
            this.gbPartitionCreation.Location = new System.Drawing.Point(15, 338);
            this.gbPartitionCreation.Name = "gbPartitionCreation";
            this.gbPartitionCreation.Size = new System.Drawing.Size(463, 110);
            this.gbPartitionCreation.TabIndex = 5;
            this.gbPartitionCreation.TabStop = false;
            this.gbPartitionCreation.Text = "Partition Creation";
            // 
            // cbJournaled
            // 
            this.cbJournaled.AutoSize = true;
            this.cbJournaled.Location = new System.Drawing.Point(362, 84);
            this.cbJournaled.Name = "cbJournaled";
            this.cbJournaled.Size = new System.Drawing.Size(87, 20);
            this.cbJournaled.TabIndex = 15;
            this.cbJournaled.Text = "Journaled";
            this.cbJournaled.UseVisualStyleBackColor = true;
            // 
            // cbProtected
            // 
            this.cbProtected.AutoSize = true;
            this.cbProtected.Location = new System.Drawing.Point(362, 58);
            this.cbProtected.Name = "cbProtected";
            this.cbProtected.Size = new System.Drawing.Size(85, 20);
            this.cbProtected.TabIndex = 14;
            this.cbProtected.Text = "Protected";
            this.cbProtected.UseVisualStyleBackColor = true;
            // 
            // txtPartitionCreationSize
            // 
            this.txtPartitionCreationSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPartitionCreationSize.Location = new System.Drawing.Point(362, 26);
            this.txtPartitionCreationSize.Name = "txtPartitionCreationSize";
            this.txtPartitionCreationSize.Size = new System.Drawing.Size(83, 22);
            this.txtPartitionCreationSize.TabIndex = 13;
            // 
            // lblPartitionCreationSize
            // 
            this.lblPartitionCreationSize.AutoSize = true;
            this.lblPartitionCreationSize.Location = new System.Drawing.Point(285, 29);
            this.lblPartitionCreationSize.Name = "lblPartitionCreationSize";
            this.lblPartitionCreationSize.Size = new System.Drawing.Size(71, 16);
            this.lblPartitionCreationSize.TabIndex = 12;
            this.lblPartitionCreationSize.Text = "Size (MB) :";
            // 
            // txtPartitionCreationName
            // 
            this.txtPartitionCreationName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPartitionCreationName.Location = new System.Drawing.Point(79, 26);
            this.txtPartitionCreationName.Name = "txtPartitionCreationName";
            this.txtPartitionCreationName.Size = new System.Drawing.Size(83, 22);
            this.txtPartitionCreationName.TabIndex = 12;
            // 
            // lblPartitionCreationName
            // 
            this.lblPartitionCreationName.AutoSize = true;
            this.lblPartitionCreationName.Location = new System.Drawing.Point(15, 29);
            this.lblPartitionCreationName.Name = "lblPartitionCreationName";
            this.lblPartitionCreationName.Size = new System.Drawing.Size(51, 16);
            this.lblPartitionCreationName.TabIndex = 12;
            this.lblPartitionCreationName.Text = "Name :";
            // 
            // btnDeletePartition
            // 
            this.btnDeletePartition.Enabled = false;
            this.btnDeletePartition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePartition.Location = new System.Drawing.Point(351, 286);
            this.btnDeletePartition.Name = "btnDeletePartition";
            this.btnDeletePartition.Size = new System.Drawing.Size(125, 33);
            this.btnDeletePartition.TabIndex = 6;
            this.btnDeletePartition.Text = "Delete Partition";
            this.btnDeletePartition.UseVisualStyleBackColor = true;
            this.btnDeletePartition.Click += new System.EventHandler(this.btnDeletePartition_Click);
            // 
            // btnCreatePartition
            // 
            this.btnCreatePartition.Enabled = false;
            this.btnCreatePartition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreatePartition.Location = new System.Drawing.Point(353, 466);
            this.btnCreatePartition.Name = "btnCreatePartition";
            this.btnCreatePartition.Size = new System.Drawing.Size(125, 33);
            this.btnCreatePartition.TabIndex = 7;
            this.btnCreatePartition.Text = "Create Partition";
            this.btnCreatePartition.UseVisualStyleBackColor = true;
            this.btnCreatePartition.Click += new System.EventHandler(this.btnCreatePartition_Click);
            // 
            // btnResizeDataPartition
            // 
            this.btnResizeDataPartition.Enabled = false;
            this.btnResizeDataPartition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResizeDataPartition.ForeColor = System.Drawing.Color.Black;
            this.btnResizeDataPartition.Location = new System.Drawing.Point(289, 31);
            this.btnResizeDataPartition.Name = "btnResizeDataPartition";
            this.btnResizeDataPartition.Size = new System.Drawing.Size(159, 33);
            this.btnResizeDataPartition.TabIndex = 8;
            this.btnResizeDataPartition.Text = "Resize Data Partition";
            this.btnResizeDataPartition.UseVisualStyleBackColor = true;
            this.btnResizeDataPartition.Click += new System.EventHandler(this.btnResizeDataPartition_Click);
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveSettings.Location = new System.Drawing.Point(353, 506);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(125, 33);
            this.btnSaveSettings.TabIndex = 9;
            this.btnSaveSettings.Text = "Save Settings";
            this.btnSaveSettings.UseVisualStyleBackColor = true;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // gbPartitionTablePreparation
            // 
            this.gbPartitionTablePreparation.BackColor = System.Drawing.Color.Black;
            this.gbPartitionTablePreparation.Controls.Add(this.txtNewDataPartitionSize);
            this.gbPartitionTablePreparation.Controls.Add(this.lblDataPartitionSize);
            this.gbPartitionTablePreparation.Controls.Add(this.btnResizeDataPartition);
            this.gbPartitionTablePreparation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPartitionTablePreparation.ForeColor = System.Drawing.Color.White;
            this.gbPartitionTablePreparation.Location = new System.Drawing.Point(12, 99);
            this.gbPartitionTablePreparation.Name = "gbPartitionTablePreparation";
            this.gbPartitionTablePreparation.Size = new System.Drawing.Size(463, 85);
            this.gbPartitionTablePreparation.TabIndex = 10;
            this.gbPartitionTablePreparation.TabStop = false;
            this.gbPartitionTablePreparation.Text = "Partition Table Preparation";
            // 
            // txtNewDataPartitionSize
            // 
            this.txtNewDataPartitionSize.Location = new System.Drawing.Point(174, 36);
            this.txtNewDataPartitionSize.Name = "txtNewDataPartitionSize";
            this.txtNewDataPartitionSize.Size = new System.Drawing.Size(60, 22);
            this.txtNewDataPartitionSize.TabIndex = 13;
            // 
            // lblDataPartitionSize
            // 
            this.lblDataPartitionSize.AutoSize = true;
            this.lblDataPartitionSize.Location = new System.Drawing.Point(15, 39);
            this.lblDataPartitionSize.Name = "lblDataPartitionSize";
            this.lblDataPartitionSize.Size = new System.Drawing.Size(154, 16);
            this.lblDataPartitionSize.TabIndex = 12;
            this.lblDataPartitionSize.Text = "Data Partition Size (MB) :";
            // 
            // frmPartitionManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(490, 551);
            this.Controls.Add(this.gbPartitionTablePreparation);
            this.Controls.Add(this.btnSaveSettings);
            this.Controls.Add(this.btnCreatePartition);
            this.Controls.Add(this.btnDeletePartition);
            this.Controls.Add(this.gbPartitionCreation);
            this.Controls.Add(this.gbPartitionInformation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbPartitionTable);
            this.Controls.Add(this.txtDeviceAvailableStorage);
            this.Controls.Add(this.lblDeviceAvailableStorage);
            this.Name = "frmPartitionManager";
            this.Text = "Partitions Manager";
            this.gbPartitionInformation.ResumeLayout(false);
            this.gbPartitionInformation.PerformLayout();
            this.gbPartitionCreation.ResumeLayout(false);
            this.gbPartitionCreation.PerformLayout();
            this.gbPartitionTablePreparation.ResumeLayout(false);
            this.gbPartitionTablePreparation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDeviceAvailableStorage;
        private System.Windows.Forms.TextBox txtDeviceAvailableStorage;
        private System.Windows.Forms.ListBox lbPartitionTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbPartitionInformation;
        private System.Windows.Forms.Label lblPartitionInformationSize;
        private System.Windows.Forms.TextBox txtPartitionInformationSize;
        private System.Windows.Forms.TextBox txtPartitionInformationNumber;
        private System.Windows.Forms.Label lblPartitionInformationNumber;
        private System.Windows.Forms.GroupBox gbPartitionCreation;
        private System.Windows.Forms.Button btnDeletePartition;
        private System.Windows.Forms.Button btnCreatePartition;
        private System.Windows.Forms.TextBox txtPartitionCreationSize;
        private System.Windows.Forms.Label lblPartitionCreationSize;
        private System.Windows.Forms.TextBox txtPartitionCreationName;
        private System.Windows.Forms.Label lblPartitionCreationName;
        private System.Windows.Forms.Button btnResizeDataPartition;
        private System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.GroupBox gbPartitionTablePreparation;
        private System.Windows.Forms.TextBox txtNewDataPartitionSize;
        private System.Windows.Forms.Label lblDataPartitionSize;
        private System.Windows.Forms.CheckBox cbJournaled;
        private System.Windows.Forms.CheckBox cbProtected;
    }
}