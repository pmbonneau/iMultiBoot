namespace iMultiBoot
{
    partial class frmSoftwareConfiguration
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
            this.lblWorkingDirectory = new System.Windows.Forms.Label();
            this.txtWorkingDirectory = new System.Windows.Forms.TextBox();
            this.btnBrowseTempDir = new System.Windows.Forms.Button();
            this.lblDeviceWorkingDirectory = new System.Windows.Forms.Label();
            this.txtDeviceWorkingDirectory = new System.Windows.Forms.TextBox();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWorkingDirectory
            // 
            this.lblWorkingDirectory.AutoSize = true;
            this.lblWorkingDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkingDirectory.ForeColor = System.Drawing.Color.White;
            this.lblWorkingDirectory.Location = new System.Drawing.Point(12, 23);
            this.lblWorkingDirectory.Name = "lblWorkingDirectory";
            this.lblWorkingDirectory.Size = new System.Drawing.Size(121, 16);
            this.lblWorkingDirectory.TabIndex = 0;
            this.lblWorkingDirectory.Text = "Working Directory :";
            // 
            // txtWorkingDirectory
            // 
            this.txtWorkingDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWorkingDirectory.Location = new System.Drawing.Point(156, 20);
            this.txtWorkingDirectory.Name = "txtWorkingDirectory";
            this.txtWorkingDirectory.Size = new System.Drawing.Size(207, 22);
            this.txtWorkingDirectory.TabIndex = 1;
            // 
            // btnBrowseTempDir
            // 
            this.btnBrowseTempDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseTempDir.Location = new System.Drawing.Point(390, 15);
            this.btnBrowseTempDir.Name = "btnBrowseTempDir";
            this.btnBrowseTempDir.Size = new System.Drawing.Size(83, 32);
            this.btnBrowseTempDir.TabIndex = 2;
            this.btnBrowseTempDir.Text = "Browse";
            this.btnBrowseTempDir.UseVisualStyleBackColor = true;
            this.btnBrowseTempDir.Click += new System.EventHandler(this.btnBrowseTempDir_Click);
            // 
            // lblDeviceWorkingDirectory
            // 
            this.lblDeviceWorkingDirectory.AutoSize = true;
            this.lblDeviceWorkingDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeviceWorkingDirectory.ForeColor = System.Drawing.Color.White;
            this.lblDeviceWorkingDirectory.Location = new System.Drawing.Point(12, 83);
            this.lblDeviceWorkingDirectory.Name = "lblDeviceWorkingDirectory";
            this.lblDeviceWorkingDirectory.Size = new System.Drawing.Size(167, 16);
            this.lblDeviceWorkingDirectory.TabIndex = 3;
            this.lblDeviceWorkingDirectory.Text = "Device Working Directory :";
            // 
            // txtDeviceWorkingDirectory
            // 
            this.txtDeviceWorkingDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeviceWorkingDirectory.Location = new System.Drawing.Point(185, 80);
            this.txtDeviceWorkingDirectory.Name = "txtDeviceWorkingDirectory";
            this.txtDeviceWorkingDirectory.Size = new System.Drawing.Size(207, 22);
            this.txtDeviceWorkingDirectory.TabIndex = 4;
            this.txtDeviceWorkingDirectory.Text = "//var";
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveSettings.Location = new System.Drawing.Point(390, 233);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(105, 36);
            this.btnSaveSettings.TabIndex = 5;
            this.btnSaveSettings.Text = "Save Settings";
            this.btnSaveSettings.UseVisualStyleBackColor = true;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // frmSoftwareConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(510, 281);
            this.Controls.Add(this.btnSaveSettings);
            this.Controls.Add(this.txtDeviceWorkingDirectory);
            this.Controls.Add(this.lblDeviceWorkingDirectory);
            this.Controls.Add(this.btnBrowseTempDir);
            this.Controls.Add(this.txtWorkingDirectory);
            this.Controls.Add(this.lblWorkingDirectory);
            this.Name = "frmSoftwareConfiguration";
            this.Text = "Configure Software";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWorkingDirectory;
        private System.Windows.Forms.TextBox txtWorkingDirectory;
        private System.Windows.Forms.Button btnBrowseTempDir;
        private System.Windows.Forms.Label lblDeviceWorkingDirectory;
        private System.Windows.Forms.TextBox txtDeviceWorkingDirectory;
        private System.Windows.Forms.Button btnSaveSettings;
    }
}