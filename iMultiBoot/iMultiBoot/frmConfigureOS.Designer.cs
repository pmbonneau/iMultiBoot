﻿namespace iMultiBoot
{
    partial class frmConfigureOS
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
            this.gbFirmwareSection = new System.Windows.Forms.GroupBox();
            this.btnRootFileSystem = new System.Windows.Forms.Button();
            this.txtRootFileSystem = new System.Windows.Forms.TextBox();
            this.lblRootFileSystem = new System.Windows.Forms.Label();
            this.btnBootLogo = new System.Windows.Forms.Button();
            this.txtBootLogo = new System.Windows.Forms.TextBox();
            this.lblBootLogo = new System.Windows.Forms.Label();
            this.btnSecondaryStageBootloader = new System.Windows.Forms.Button();
            this.btnFirstStageBootloader = new System.Windows.Forms.Button();
            this.txtSecondaryStageBootloader = new System.Windows.Forms.TextBox();
            this.txtFirstStageBootloader = new System.Windows.Forms.TextBox();
            this.lblSecondaryStageBootloader = new System.Windows.Forms.Label();
            this.lblFirstStageBootloader = new System.Windows.Forms.Label();
            this.btnDeviceTree = new System.Windows.Forms.Button();
            this.txtDeviceTree = new System.Windows.Forms.TextBox();
            this.lblDeviceTree = new System.Windows.Forms.Label();
            this.gbFileSystemSection = new System.Windows.Forms.GroupBox();
            this.btnSetData = new System.Windows.Forms.Button();
            this.btnSetSystem = new System.Windows.Forms.Button();
            this.txtDataPartition = new System.Windows.Forms.TextBox();
            this.txtSystemPartition = new System.Windows.Forms.TextBox();
            this.lblDataPartition = new System.Windows.Forms.Label();
            this.lblSystemPartition = new System.Windows.Forms.Label();
            this.lblCurrentPartitionTable = new System.Windows.Forms.Label();
            this.lbPartitionTable = new System.Windows.Forms.ListBox();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.gbFirmwareSection.SuspendLayout();
            this.gbFileSystemSection.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbFirmwareSection
            // 
            this.gbFirmwareSection.Controls.Add(this.btnRootFileSystem);
            this.gbFirmwareSection.Controls.Add(this.txtRootFileSystem);
            this.gbFirmwareSection.Controls.Add(this.lblRootFileSystem);
            this.gbFirmwareSection.Controls.Add(this.btnBootLogo);
            this.gbFirmwareSection.Controls.Add(this.txtBootLogo);
            this.gbFirmwareSection.Controls.Add(this.lblBootLogo);
            this.gbFirmwareSection.Controls.Add(this.btnSecondaryStageBootloader);
            this.gbFirmwareSection.Controls.Add(this.btnFirstStageBootloader);
            this.gbFirmwareSection.Controls.Add(this.txtSecondaryStageBootloader);
            this.gbFirmwareSection.Controls.Add(this.txtFirstStageBootloader);
            this.gbFirmwareSection.Controls.Add(this.lblSecondaryStageBootloader);
            this.gbFirmwareSection.Controls.Add(this.lblFirstStageBootloader);
            this.gbFirmwareSection.Controls.Add(this.btnDeviceTree);
            this.gbFirmwareSection.Controls.Add(this.txtDeviceTree);
            this.gbFirmwareSection.Controls.Add(this.lblDeviceTree);
            this.gbFirmwareSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFirmwareSection.ForeColor = System.Drawing.Color.White;
            this.gbFirmwareSection.Location = new System.Drawing.Point(12, 12);
            this.gbFirmwareSection.Name = "gbFirmwareSection";
            this.gbFirmwareSection.Size = new System.Drawing.Size(507, 273);
            this.gbFirmwareSection.TabIndex = 0;
            this.gbFirmwareSection.TabStop = false;
            this.gbFirmwareSection.Text = "Firmware Section";
            // 
            // btnRootFileSystem
            // 
            this.btnRootFileSystem.Enabled = false;
            this.btnRootFileSystem.ForeColor = System.Drawing.Color.Black;
            this.btnRootFileSystem.Location = new System.Drawing.Point(406, 229);
            this.btnRootFileSystem.Name = "btnRootFileSystem";
            this.btnRootFileSystem.Size = new System.Drawing.Size(75, 23);
            this.btnRootFileSystem.TabIndex = 15;
            this.btnRootFileSystem.Text = "Browse";
            this.btnRootFileSystem.UseVisualStyleBackColor = true;
            // 
            // txtRootFileSystem
            // 
            this.txtRootFileSystem.Enabled = false;
            this.txtRootFileSystem.Location = new System.Drawing.Point(141, 230);
            this.txtRootFileSystem.Name = "txtRootFileSystem";
            this.txtRootFileSystem.Size = new System.Drawing.Size(244, 22);
            this.txtRootFileSystem.TabIndex = 14;
            // 
            // lblRootFileSystem
            // 
            this.lblRootFileSystem.AutoSize = true;
            this.lblRootFileSystem.Location = new System.Drawing.Point(19, 233);
            this.lblRootFileSystem.Name = "lblRootFileSystem";
            this.lblRootFileSystem.Size = new System.Drawing.Size(116, 16);
            this.lblRootFileSystem.TabIndex = 13;
            this.lblRootFileSystem.Text = "Root File System :";
            // 
            // btnBootLogo
            // 
            this.btnBootLogo.ForeColor = System.Drawing.Color.Black;
            this.btnBootLogo.Location = new System.Drawing.Point(406, 184);
            this.btnBootLogo.Name = "btnBootLogo";
            this.btnBootLogo.Size = new System.Drawing.Size(75, 23);
            this.btnBootLogo.TabIndex = 12;
            this.btnBootLogo.Text = "Browse";
            this.btnBootLogo.UseVisualStyleBackColor = true;
            this.btnBootLogo.Click += new System.EventHandler(this.btnBootLogo_Click);
            // 
            // txtBootLogo
            // 
            this.txtBootLogo.Location = new System.Drawing.Point(108, 184);
            this.txtBootLogo.Name = "txtBootLogo";
            this.txtBootLogo.Size = new System.Drawing.Size(278, 22);
            this.txtBootLogo.TabIndex = 11;
            // 
            // lblBootLogo
            // 
            this.lblBootLogo.AutoSize = true;
            this.lblBootLogo.Location = new System.Drawing.Point(19, 187);
            this.lblBootLogo.Name = "lblBootLogo";
            this.lblBootLogo.Size = new System.Drawing.Size(76, 16);
            this.lblBootLogo.TabIndex = 10;
            this.lblBootLogo.Text = "Boot Logo :";
            // 
            // btnSecondaryStageBootloader
            // 
            this.btnSecondaryStageBootloader.ForeColor = System.Drawing.Color.Black;
            this.btnSecondaryStageBootloader.Location = new System.Drawing.Point(406, 83);
            this.btnSecondaryStageBootloader.Name = "btnSecondaryStageBootloader";
            this.btnSecondaryStageBootloader.Size = new System.Drawing.Size(75, 23);
            this.btnSecondaryStageBootloader.TabIndex = 9;
            this.btnSecondaryStageBootloader.Text = "Browse";
            this.btnSecondaryStageBootloader.UseVisualStyleBackColor = true;
            this.btnSecondaryStageBootloader.Click += new System.EventHandler(this.btnSecondaryStageBootloader_Click);
            // 
            // btnFirstStageBootloader
            // 
            this.btnFirstStageBootloader.ForeColor = System.Drawing.Color.Black;
            this.btnFirstStageBootloader.Location = new System.Drawing.Point(406, 31);
            this.btnFirstStageBootloader.Name = "btnFirstStageBootloader";
            this.btnFirstStageBootloader.Size = new System.Drawing.Size(75, 23);
            this.btnFirstStageBootloader.TabIndex = 8;
            this.btnFirstStageBootloader.Text = "Browse";
            this.btnFirstStageBootloader.UseVisualStyleBackColor = true;
            this.btnFirstStageBootloader.Click += new System.EventHandler(this.btnFirstStageBootloader_Click);
            // 
            // txtSecondaryStageBootloader
            // 
            this.txtSecondaryStageBootloader.Location = new System.Drawing.Point(214, 84);
            this.txtSecondaryStageBootloader.Name = "txtSecondaryStageBootloader";
            this.txtSecondaryStageBootloader.Size = new System.Drawing.Size(171, 22);
            this.txtSecondaryStageBootloader.TabIndex = 6;
            // 
            // txtFirstStageBootloader
            // 
            this.txtFirstStageBootloader.Location = new System.Drawing.Point(173, 32);
            this.txtFirstStageBootloader.Name = "txtFirstStageBootloader";
            this.txtFirstStageBootloader.Size = new System.Drawing.Size(212, 22);
            this.txtFirstStageBootloader.TabIndex = 5;
            // 
            // lblSecondaryStageBootloader
            // 
            this.lblSecondaryStageBootloader.AutoSize = true;
            this.lblSecondaryStageBootloader.Location = new System.Drawing.Point(19, 87);
            this.lblSecondaryStageBootloader.Name = "lblSecondaryStageBootloader";
            this.lblSecondaryStageBootloader.Size = new System.Drawing.Size(189, 16);
            this.lblSecondaryStageBootloader.TabIndex = 4;
            this.lblSecondaryStageBootloader.Text = "Secondary Stage Bootloader :";
            // 
            // lblFirstStageBootloader
            // 
            this.lblFirstStageBootloader.AutoSize = true;
            this.lblFirstStageBootloader.Location = new System.Drawing.Point(19, 35);
            this.lblFirstStageBootloader.Name = "lblFirstStageBootloader";
            this.lblFirstStageBootloader.Size = new System.Drawing.Size(145, 16);
            this.lblFirstStageBootloader.TabIndex = 3;
            this.lblFirstStageBootloader.Text = "Low-Level Bootloader :";
            // 
            // btnDeviceTree
            // 
            this.btnDeviceTree.ForeColor = System.Drawing.Color.Black;
            this.btnDeviceTree.Location = new System.Drawing.Point(406, 134);
            this.btnDeviceTree.Name = "btnDeviceTree";
            this.btnDeviceTree.Size = new System.Drawing.Size(75, 23);
            this.btnDeviceTree.TabIndex = 2;
            this.btnDeviceTree.Text = "Browse";
            this.btnDeviceTree.UseVisualStyleBackColor = true;
            this.btnDeviceTree.Click += new System.EventHandler(this.btnDeviceTree_Click);
            // 
            // txtDeviceTree
            // 
            this.txtDeviceTree.Location = new System.Drawing.Point(111, 135);
            this.txtDeviceTree.Name = "txtDeviceTree";
            this.txtDeviceTree.Size = new System.Drawing.Size(274, 22);
            this.txtDeviceTree.TabIndex = 1;
            // 
            // lblDeviceTree
            // 
            this.lblDeviceTree.AutoSize = true;
            this.lblDeviceTree.Location = new System.Drawing.Point(19, 138);
            this.lblDeviceTree.Name = "lblDeviceTree";
            this.lblDeviceTree.Size = new System.Drawing.Size(86, 16);
            this.lblDeviceTree.TabIndex = 0;
            this.lblDeviceTree.Text = "DeviceTree :";
            // 
            // gbFileSystemSection
            // 
            this.gbFileSystemSection.Controls.Add(this.btnSetData);
            this.gbFileSystemSection.Controls.Add(this.btnSetSystem);
            this.gbFileSystemSection.Controls.Add(this.txtDataPartition);
            this.gbFileSystemSection.Controls.Add(this.txtSystemPartition);
            this.gbFileSystemSection.Controls.Add(this.lblDataPartition);
            this.gbFileSystemSection.Controls.Add(this.lblSystemPartition);
            this.gbFileSystemSection.Controls.Add(this.lblCurrentPartitionTable);
            this.gbFileSystemSection.Controls.Add(this.lbPartitionTable);
            this.gbFileSystemSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFileSystemSection.ForeColor = System.Drawing.Color.White;
            this.gbFileSystemSection.Location = new System.Drawing.Point(13, 304);
            this.gbFileSystemSection.Name = "gbFileSystemSection";
            this.gbFileSystemSection.Size = new System.Drawing.Size(506, 131);
            this.gbFileSystemSection.TabIndex = 1;
            this.gbFileSystemSection.TabStop = false;
            this.gbFileSystemSection.Text = "FileSystem Section";
            // 
            // btnSetData
            // 
            this.btnSetData.ForeColor = System.Drawing.Color.Black;
            this.btnSetData.Location = new System.Drawing.Point(184, 81);
            this.btnSetData.Name = "btnSetData";
            this.btnSetData.Size = new System.Drawing.Size(75, 41);
            this.btnSetData.TabIndex = 10;
            this.btnSetData.Text = "Set as Data";
            this.btnSetData.UseVisualStyleBackColor = true;
            this.btnSetData.Click += new System.EventHandler(this.btnSetData_Click);
            // 
            // btnSetSystem
            // 
            this.btnSetSystem.ForeColor = System.Drawing.Color.Black;
            this.btnSetSystem.Location = new System.Drawing.Point(184, 34);
            this.btnSetSystem.Name = "btnSetSystem";
            this.btnSetSystem.Size = new System.Drawing.Size(75, 41);
            this.btnSetSystem.TabIndex = 9;
            this.btnSetSystem.Text = "Set as System";
            this.btnSetSystem.UseVisualStyleBackColor = true;
            this.btnSetSystem.Click += new System.EventHandler(this.btnSetSystem_Click);
            // 
            // txtDataPartition
            // 
            this.txtDataPartition.Enabled = false;
            this.txtDataPartition.Location = new System.Drawing.Point(391, 94);
            this.txtDataPartition.Name = "txtDataPartition";
            this.txtDataPartition.Size = new System.Drawing.Size(100, 22);
            this.txtDataPartition.TabIndex = 8;
            // 
            // txtSystemPartition
            // 
            this.txtSystemPartition.Enabled = false;
            this.txtSystemPartition.Location = new System.Drawing.Point(391, 43);
            this.txtSystemPartition.Name = "txtSystemPartition";
            this.txtSystemPartition.Size = new System.Drawing.Size(100, 22);
            this.txtSystemPartition.TabIndex = 7;
            // 
            // lblDataPartition
            // 
            this.lblDataPartition.AutoSize = true;
            this.lblDataPartition.Location = new System.Drawing.Point(290, 97);
            this.lblDataPartition.Name = "lblDataPartition";
            this.lblDataPartition.Size = new System.Drawing.Size(94, 16);
            this.lblDataPartition.TabIndex = 6;
            this.lblDataPartition.Text = "Data Partition :";
            // 
            // lblSystemPartition
            // 
            this.lblSystemPartition.AutoSize = true;
            this.lblSystemPartition.Location = new System.Drawing.Point(275, 46);
            this.lblSystemPartition.Name = "lblSystemPartition";
            this.lblSystemPartition.Size = new System.Drawing.Size(110, 16);
            this.lblSystemPartition.TabIndex = 5;
            this.lblSystemPartition.Text = "System Partition :";
            // 
            // lblCurrentPartitionTable
            // 
            this.lblCurrentPartitionTable.AutoSize = true;
            this.lblCurrentPartitionTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentPartitionTable.ForeColor = System.Drawing.Color.White;
            this.lblCurrentPartitionTable.Location = new System.Drawing.Point(10, 29);
            this.lblCurrentPartitionTable.Name = "lblCurrentPartitionTable";
            this.lblCurrentPartitionTable.Size = new System.Drawing.Size(146, 16);
            this.lblCurrentPartitionTable.TabIndex = 4;
            this.lblCurrentPartitionTable.Text = "Current Partition Table :";
            // 
            // lbPartitionTable
            // 
            this.lbPartitionTable.FormattingEnabled = true;
            this.lbPartitionTable.ItemHeight = 16;
            this.lbPartitionTable.Location = new System.Drawing.Point(13, 48);
            this.lbPartitionTable.Name = "lbPartitionTable";
            this.lbPartitionTable.Size = new System.Drawing.Size(150, 68);
            this.lbPartitionTable.TabIndex = 0;
            this.lbPartitionTable.SelectedIndexChanged += new System.EventHandler(this.lbPartitionTable_SelectedIndexChanged);
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveSettings.Location = new System.Drawing.Point(390, 441);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(129, 40);
            this.btnSaveSettings.TabIndex = 2;
            this.btnSaveSettings.Text = "Save Settings";
            this.btnSaveSettings.UseVisualStyleBackColor = true;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // frmConfigureOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(531, 493);
            this.Controls.Add(this.btnSaveSettings);
            this.Controls.Add(this.gbFileSystemSection);
            this.Controls.Add(this.gbFirmwareSection);
            this.Name = "frmConfigureOS";
            this.Text = "Configure Operating System";
            this.gbFirmwareSection.ResumeLayout(false);
            this.gbFirmwareSection.PerformLayout();
            this.gbFileSystemSection.ResumeLayout(false);
            this.gbFileSystemSection.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFirmwareSection;
        private System.Windows.Forms.Button btnDeviceTree;
        private System.Windows.Forms.TextBox txtDeviceTree;
        private System.Windows.Forms.Label lblDeviceTree;
        private System.Windows.Forms.Button btnSecondaryStageBootloader;
        private System.Windows.Forms.Button btnFirstStageBootloader;
        private System.Windows.Forms.TextBox txtSecondaryStageBootloader;
        private System.Windows.Forms.TextBox txtFirstStageBootloader;
        private System.Windows.Forms.Label lblFirstStageBootloader;
        private System.Windows.Forms.Label lblSecondaryStageBootloader;
        private System.Windows.Forms.GroupBox gbFileSystemSection;
        private System.Windows.Forms.ListBox lbPartitionTable;
        private System.Windows.Forms.Label lblCurrentPartitionTable;
        private System.Windows.Forms.Button btnSetData;
        private System.Windows.Forms.Button btnSetSystem;
        private System.Windows.Forms.TextBox txtDataPartition;
        private System.Windows.Forms.TextBox txtSystemPartition;
        private System.Windows.Forms.Label lblDataPartition;
        private System.Windows.Forms.Label lblSystemPartition;
        private System.Windows.Forms.Button btnRootFileSystem;
        private System.Windows.Forms.TextBox txtRootFileSystem;
        private System.Windows.Forms.Label lblRootFileSystem;
        private System.Windows.Forms.Button btnBootLogo;
        private System.Windows.Forms.TextBox txtBootLogo;
        private System.Windows.Forms.Label lblBootLogo;
        private System.Windows.Forms.Button btnSaveSettings;
    }
}