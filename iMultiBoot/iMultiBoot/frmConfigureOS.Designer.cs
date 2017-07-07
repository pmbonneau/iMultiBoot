namespace iMultiBoot
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
            this.btnDeviceTree = new System.Windows.Forms.Button();
            this.txtDeviceTree = new System.Windows.Forms.TextBox();
            this.lblDeviceTree = new System.Windows.Forms.Label();
            this.lblFirstStageBootloader = new System.Windows.Forms.Label();
            this.txtFirstStageBootloader = new System.Windows.Forms.TextBox();
            this.txtSecondaryStageBootloader = new System.Windows.Forms.TextBox();
            this.btnFirstStageBootloader = new System.Windows.Forms.Button();
            this.btnSecondaryStageBootloader = new System.Windows.Forms.Button();
            this.lblSecondaryStageBootloader = new System.Windows.Forms.Label();
            this.gbFirmwareSection.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbFirmwareSection
            // 
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
            this.gbFirmwareSection.Size = new System.Drawing.Size(499, 269);
            this.gbFirmwareSection.TabIndex = 0;
            this.gbFirmwareSection.TabStop = false;
            this.gbFirmwareSection.Text = "Firmware Section";
            // 
            // btnDeviceTree
            // 
            this.btnDeviceTree.ForeColor = System.Drawing.Color.Black;
            this.btnDeviceTree.Location = new System.Drawing.Point(402, 134);
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
            // lblFirstStageBootloader
            // 
            this.lblFirstStageBootloader.AutoSize = true;
            this.lblFirstStageBootloader.Location = new System.Drawing.Point(19, 35);
            this.lblFirstStageBootloader.Name = "lblFirstStageBootloader";
            this.lblFirstStageBootloader.Size = new System.Drawing.Size(145, 16);
            this.lblFirstStageBootloader.TabIndex = 3;
            this.lblFirstStageBootloader.Text = "Low-Level Bootloader :";
            // 
            // txtFirstStageBootloader
            // 
            this.txtFirstStageBootloader.Location = new System.Drawing.Point(173, 32);
            this.txtFirstStageBootloader.Name = "txtFirstStageBootloader";
            this.txtFirstStageBootloader.Size = new System.Drawing.Size(212, 22);
            this.txtFirstStageBootloader.TabIndex = 5;
            // 
            // txtSecondaryStageBootloader
            // 
            this.txtSecondaryStageBootloader.Location = new System.Drawing.Point(214, 84);
            this.txtSecondaryStageBootloader.Name = "txtSecondaryStageBootloader";
            this.txtSecondaryStageBootloader.Size = new System.Drawing.Size(171, 22);
            this.txtSecondaryStageBootloader.TabIndex = 6;
            // 
            // btnFirstStageBootloader
            // 
            this.btnFirstStageBootloader.ForeColor = System.Drawing.Color.Black;
            this.btnFirstStageBootloader.Location = new System.Drawing.Point(402, 31);
            this.btnFirstStageBootloader.Name = "btnFirstStageBootloader";
            this.btnFirstStageBootloader.Size = new System.Drawing.Size(75, 23);
            this.btnFirstStageBootloader.TabIndex = 8;
            this.btnFirstStageBootloader.Text = "Browse";
            this.btnFirstStageBootloader.UseVisualStyleBackColor = true;
            this.btnFirstStageBootloader.Click += new System.EventHandler(this.btnFirstStageBootloader_Click);
            // 
            // btnSecondaryStageBootloader
            // 
            this.btnSecondaryStageBootloader.ForeColor = System.Drawing.Color.Black;
            this.btnSecondaryStageBootloader.Location = new System.Drawing.Point(402, 83);
            this.btnSecondaryStageBootloader.Name = "btnSecondaryStageBootloader";
            this.btnSecondaryStageBootloader.Size = new System.Drawing.Size(75, 23);
            this.btnSecondaryStageBootloader.TabIndex = 9;
            this.btnSecondaryStageBootloader.Text = "Browse";
            this.btnSecondaryStageBootloader.UseVisualStyleBackColor = true;
            this.btnSecondaryStageBootloader.Click += new System.EventHandler(this.btnSecondaryStageBootloader_Click);
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
            // frmConfigureOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(523, 293);
            this.Controls.Add(this.gbFirmwareSection);
            this.Name = "frmConfigureOS";
            this.Text = "Configure Operating System";
            this.gbFirmwareSection.ResumeLayout(false);
            this.gbFirmwareSection.PerformLayout();
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
    }
}