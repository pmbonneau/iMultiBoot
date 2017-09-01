namespace iMultiBoot
{
    partial class frmMain
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlMain = new System.Windows.Forms.Panel();
            this.gbConnectionSSH = new System.Windows.Forms.GroupBox();
            this.txtUserPassword = new System.Windows.Forms.TextBox();
            this.lblUserPassword = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtDeviceHostName = new System.Windows.Forms.TextBox();
            this.lblDeviceHostName = new System.Windows.Forms.Label();
            this.btnManagePartitions = new System.Windows.Forms.Button();
            this.btnInstallOperatingSystems = new System.Windows.Forms.Button();
            this.btnConfigureSoftware = new System.Windows.Forms.Button();
            this.btnBuildFirmware = new System.Windows.Forms.Button();
            this.btnSelectOperatingSystems = new System.Windows.Forms.Button();
            this.btnSelectDevice = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnBegin = new System.Windows.Forms.Button();
            this.lblCopyrights = new System.Windows.Forms.Label();
            this.btnCredits = new System.Windows.Forms.Button();
            this.pnlMain.SuspendLayout();
            this.gbConnectionSSH.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.gbConnectionSSH);
            this.pnlMain.Controls.Add(this.btnManagePartitions);
            this.pnlMain.Controls.Add(this.btnInstallOperatingSystems);
            this.pnlMain.Controls.Add(this.btnConfigureSoftware);
            this.pnlMain.Controls.Add(this.btnBuildFirmware);
            this.pnlMain.Controls.Add(this.btnSelectOperatingSystems);
            this.pnlMain.Controls.Add(this.btnSelectDevice);
            this.pnlMain.Location = new System.Drawing.Point(2, 38);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(579, 272);
            this.pnlMain.TabIndex = 1;
            this.pnlMain.Visible = false;
            // 
            // gbConnectionSSH
            // 
            this.gbConnectionSSH.Controls.Add(this.txtUserPassword);
            this.gbConnectionSSH.Controls.Add(this.lblUserPassword);
            this.gbConnectionSSH.Controls.Add(this.txtUserName);
            this.gbConnectionSSH.Controls.Add(this.lblUserName);
            this.gbConnectionSSH.Controls.Add(this.txtDeviceHostName);
            this.gbConnectionSSH.Controls.Add(this.lblDeviceHostName);
            this.gbConnectionSSH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbConnectionSSH.ForeColor = System.Drawing.Color.White;
            this.gbConnectionSSH.Location = new System.Drawing.Point(359, 7);
            this.gbConnectionSSH.Name = "gbConnectionSSH";
            this.gbConnectionSSH.Size = new System.Drawing.Size(211, 201);
            this.gbConnectionSSH.TabIndex = 6;
            this.gbConnectionSSH.TabStop = false;
            this.gbConnectionSSH.Text = "SSH Connection";
            // 
            // txtUserPassword
            // 
            this.txtUserPassword.Enabled = false;
            this.txtUserPassword.Location = new System.Drawing.Point(9, 144);
            this.txtUserPassword.Name = "txtUserPassword";
            this.txtUserPassword.Size = new System.Drawing.Size(100, 22);
            this.txtUserPassword.TabIndex = 5;
            this.txtUserPassword.UseSystemPasswordChar = true;
            // 
            // lblUserPassword
            // 
            this.lblUserPassword.AutoSize = true;
            this.lblUserPassword.Location = new System.Drawing.Point(6, 125);
            this.lblUserPassword.Name = "lblUserPassword";
            this.lblUserPassword.Size = new System.Drawing.Size(106, 16);
            this.lblUserPassword.TabIndex = 4;
            this.lblUserPassword.Text = "User Password :";
            // 
            // txtUserName
            // 
            this.txtUserName.Enabled = false;
            this.txtUserName.Location = new System.Drawing.Point(9, 92);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(100, 22);
            this.txtUserName.TabIndex = 3;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(6, 73);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(83, 16);
            this.lblUserName.TabIndex = 2;
            this.lblUserName.Text = "User Name :";
            // 
            // txtDeviceHostName
            // 
            this.txtDeviceHostName.Enabled = false;
            this.txtDeviceHostName.Location = new System.Drawing.Point(9, 38);
            this.txtDeviceHostName.Name = "txtDeviceHostName";
            this.txtDeviceHostName.Size = new System.Drawing.Size(125, 22);
            this.txtDeviceHostName.TabIndex = 1;
            // 
            // lblDeviceHostName
            // 
            this.lblDeviceHostName.AutoSize = true;
            this.lblDeviceHostName.Location = new System.Drawing.Point(6, 19);
            this.lblDeviceHostName.Name = "lblDeviceHostName";
            this.lblDeviceHostName.Size = new System.Drawing.Size(128, 16);
            this.lblDeviceHostName.TabIndex = 0;
            this.lblDeviceHostName.Text = "Device Host Name :";
            // 
            // btnManagePartitions
            // 
            this.btnManagePartitions.Enabled = false;
            this.btnManagePartitions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManagePartitions.Location = new System.Drawing.Point(10, 119);
            this.btnManagePartitions.Name = "btnManagePartitions";
            this.btnManagePartitions.Size = new System.Drawing.Size(211, 35);
            this.btnManagePartitions.TabIndex = 5;
            this.btnManagePartitions.Text = "Manage Partitions";
            this.btnManagePartitions.UseVisualStyleBackColor = true;
            this.btnManagePartitions.Click += new System.EventHandler(this.btnManagePartitions_Click);
            // 
            // btnInstallOperatingSystems
            // 
            this.btnInstallOperatingSystems.Enabled = false;
            this.btnInstallOperatingSystems.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstallOperatingSystems.Location = new System.Drawing.Point(359, 226);
            this.btnInstallOperatingSystems.Name = "btnInstallOperatingSystems";
            this.btnInstallOperatingSystems.Size = new System.Drawing.Size(211, 35);
            this.btnInstallOperatingSystems.TabIndex = 4;
            this.btnInstallOperatingSystems.Text = "Install Operating Systems";
            this.btnInstallOperatingSystems.UseVisualStyleBackColor = true;
            this.btnInstallOperatingSystems.Click += new System.EventHandler(this.btnInstallOperatingSystems_Click);
            // 
            // btnConfigureSoftware
            // 
            this.btnConfigureSoftware.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfigureSoftware.Location = new System.Drawing.Point(10, 14);
            this.btnConfigureSoftware.Name = "btnConfigureSoftware";
            this.btnConfigureSoftware.Size = new System.Drawing.Size(211, 35);
            this.btnConfigureSoftware.TabIndex = 3;
            this.btnConfigureSoftware.Text = "Configure Software";
            this.btnConfigureSoftware.UseVisualStyleBackColor = true;
            this.btnConfigureSoftware.Click += new System.EventHandler(this.btnConfigureSoftware_Click);
            // 
            // btnBuildFirmware
            // 
            this.btnBuildFirmware.Enabled = false;
            this.btnBuildFirmware.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuildFirmware.Location = new System.Drawing.Point(10, 226);
            this.btnBuildFirmware.Name = "btnBuildFirmware";
            this.btnBuildFirmware.Size = new System.Drawing.Size(211, 35);
            this.btnBuildFirmware.TabIndex = 2;
            this.btnBuildFirmware.Text = "Build Firmware Package (IPSW)";
            this.btnBuildFirmware.UseVisualStyleBackColor = true;
            this.btnBuildFirmware.Click += new System.EventHandler(this.btnBuildFirmware_Click);
            // 
            // btnSelectOperatingSystems
            // 
            this.btnSelectOperatingSystems.Enabled = false;
            this.btnSelectOperatingSystems.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectOperatingSystems.Location = new System.Drawing.Point(10, 173);
            this.btnSelectOperatingSystems.Name = "btnSelectOperatingSystems";
            this.btnSelectOperatingSystems.Size = new System.Drawing.Size(211, 35);
            this.btnSelectOperatingSystems.TabIndex = 1;
            this.btnSelectOperatingSystems.Text = "Select Operating Systems";
            this.btnSelectOperatingSystems.UseVisualStyleBackColor = true;
            this.btnSelectOperatingSystems.Click += new System.EventHandler(this.btnSelectOperatingSystems_Click);
            // 
            // btnSelectDevice
            // 
            this.btnSelectDevice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectDevice.Location = new System.Drawing.Point(10, 66);
            this.btnSelectDevice.Name = "btnSelectDevice";
            this.btnSelectDevice.Size = new System.Drawing.Size(211, 35);
            this.btnSelectDevice.TabIndex = 0;
            this.btnSelectDevice.Text = "Select Device";
            this.btnSelectDevice.UseVisualStyleBackColor = true;
            this.btnSelectDevice.Click += new System.EventHandler(this.btnSelectDevice_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(230, 6);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(120, 29);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "iMultiBoot";
            // 
            // btnBegin
            // 
            this.btnBegin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBegin.Location = new System.Drawing.Point(305, 264);
            this.btnBegin.Name = "btnBegin";
            this.btnBegin.Size = new System.Drawing.Size(131, 36);
            this.btnBegin.TabIndex = 3;
            this.btnBegin.Text = "Click Here to Begin";
            this.btnBegin.UseVisualStyleBackColor = true;
            this.btnBegin.Click += new System.EventHandler(this.btnBegin_Click);
            // 
            // lblCopyrights
            // 
            this.lblCopyrights.AutoSize = true;
            this.lblCopyrights.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyrights.ForeColor = System.Drawing.Color.White;
            this.lblCopyrights.Location = new System.Drawing.Point(254, 313);
            this.lblCopyrights.Name = "lblCopyrights";
            this.lblCopyrights.Size = new System.Drawing.Size(323, 18);
            this.lblCopyrights.TabIndex = 4;
            this.lblCopyrights.Text = "©2017 Pierre-Marc Bonneau, all rights reserved.";
            // 
            // btnCredits
            // 
            this.btnCredits.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCredits.Location = new System.Drawing.Point(441, 264);
            this.btnCredits.Name = "btnCredits";
            this.btnCredits.Size = new System.Drawing.Size(131, 36);
            this.btnCredits.TabIndex = 5;
            this.btnCredits.Text = "Credits";
            this.btnCredits.UseVisualStyleBackColor = true;
            this.btnCredits.Click += new System.EventHandler(this.btnCredits_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(584, 340);
            this.Controls.Add(this.lblCopyrights);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.btnBegin);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnCredits);
            this.Name = "frmMain";
            this.Text = "iMultiBoot v0.6 (0F0917a)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.pnlMain.ResumeLayout(false);
            this.gbConnectionSSH.ResumeLayout(false);
            this.gbConnectionSSH.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnBegin;
        private System.Windows.Forms.Label lblCopyrights;
        private System.Windows.Forms.Button btnSelectOperatingSystems;
        private System.Windows.Forms.Button btnSelectDevice;
        private System.Windows.Forms.Button btnBuildFirmware;
        private System.Windows.Forms.Button btnConfigureSoftware;
        private System.Windows.Forms.Button btnInstallOperatingSystems;
        private System.Windows.Forms.Button btnManagePartitions;
        private System.Windows.Forms.GroupBox gbConnectionSSH;
        private System.Windows.Forms.TextBox txtUserPassword;
        private System.Windows.Forms.Label lblUserPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtDeviceHostName;
        private System.Windows.Forms.Label lblDeviceHostName;
        private System.Windows.Forms.Button btnCredits;
    }
}

