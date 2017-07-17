namespace iMultiBoot
{
    partial class frmDeviceSelection
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
            this.cmbCapacitySelection = new System.Windows.Forms.ComboBox();
            this.cmbDeviceSelection = new System.Windows.Forms.ComboBox();
            this.btnValidate = new System.Windows.Forms.Button();
            this.lblCopyrights = new System.Windows.Forms.Label();
            this.lblSelectDevice = new System.Windows.Forms.Label();
            this.lblTotalCapacity = new System.Windows.Forms.Label();
            this.lblDataCapacity = new System.Windows.Forms.Label();
            this.txtDataCapacity = new System.Windows.Forms.TextBox();
            this.lblDataRemainingCapacity = new System.Windows.Forms.Label();
            this.txtDataRemainingCapacity = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmbCapacitySelection
            // 
            this.cmbCapacitySelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCapacitySelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCapacitySelection.FormattingEnabled = true;
            this.cmbCapacitySelection.Items.AddRange(new object[] {
            "8 GB",
            "16 GB",
            "32 GB"});
            this.cmbCapacitySelection.Location = new System.Drawing.Point(210, 25);
            this.cmbCapacitySelection.Name = "cmbCapacitySelection";
            this.cmbCapacitySelection.Size = new System.Drawing.Size(125, 24);
            this.cmbCapacitySelection.TabIndex = 1;
            // 
            // cmbDeviceSelection
            // 
            this.cmbDeviceSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDeviceSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDeviceSelection.FormattingEnabled = true;
            this.cmbDeviceSelection.Items.AddRange(new object[] {
            "iPod Touch 4th (N81AP)"});
            this.cmbDeviceSelection.Location = new System.Drawing.Point(12, 25);
            this.cmbDeviceSelection.Name = "cmbDeviceSelection";
            this.cmbDeviceSelection.Size = new System.Drawing.Size(179, 24);
            this.cmbDeviceSelection.TabIndex = 2;
            // 
            // btnValidate
            // 
            this.btnValidate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidate.Location = new System.Drawing.Point(357, 131);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(94, 38);
            this.btnValidate.TabIndex = 3;
            this.btnValidate.Text = "Validate";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // lblCopyrights
            // 
            this.lblCopyrights.AutoSize = true;
            this.lblCopyrights.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyrights.ForeColor = System.Drawing.Color.White;
            this.lblCopyrights.Location = new System.Drawing.Point(135, 172);
            this.lblCopyrights.Name = "lblCopyrights";
            this.lblCopyrights.Size = new System.Drawing.Size(323, 18);
            this.lblCopyrights.TabIndex = 5;
            this.lblCopyrights.Text = "©2017 Pierre-Marc Bonneau, all rights reserved.";
            // 
            // lblSelectDevice
            // 
            this.lblSelectDevice.AutoSize = true;
            this.lblSelectDevice.ForeColor = System.Drawing.Color.White;
            this.lblSelectDevice.Location = new System.Drawing.Point(9, 9);
            this.lblSelectDevice.Name = "lblSelectDevice";
            this.lblSelectDevice.Size = new System.Drawing.Size(80, 13);
            this.lblSelectDevice.TabIndex = 6;
            this.lblSelectDevice.Text = "Select Device :";
            // 
            // lblTotalCapacity
            // 
            this.lblTotalCapacity.AutoSize = true;
            this.lblTotalCapacity.ForeColor = System.Drawing.Color.White;
            this.lblTotalCapacity.Location = new System.Drawing.Point(207, 9);
            this.lblTotalCapacity.Name = "lblTotalCapacity";
            this.lblTotalCapacity.Size = new System.Drawing.Size(81, 13);
            this.lblTotalCapacity.TabIndex = 7;
            this.lblTotalCapacity.Text = "Total Capacity :";
            // 
            // lblDataCapacity
            // 
            this.lblDataCapacity.AutoSize = true;
            this.lblDataCapacity.ForeColor = System.Drawing.Color.White;
            this.lblDataCapacity.Location = new System.Drawing.Point(12, 70);
            this.lblDataCapacity.Name = "lblDataCapacity";
            this.lblDataCapacity.Size = new System.Drawing.Size(145, 13);
            this.lblDataCapacity.TabIndex = 10;
            this.lblDataCapacity.Text = "Data Partition Capacity (GB) :";
            // 
            // txtDataCapacity
            // 
            this.txtDataCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataCapacity.Location = new System.Drawing.Point(163, 65);
            this.txtDataCapacity.Name = "txtDataCapacity";
            this.txtDataCapacity.Size = new System.Drawing.Size(68, 22);
            this.txtDataCapacity.TabIndex = 11;
            // 
            // lblDataRemainingCapacity
            // 
            this.lblDataRemainingCapacity.AutoSize = true;
            this.lblDataRemainingCapacity.ForeColor = System.Drawing.Color.White;
            this.lblDataRemainingCapacity.Location = new System.Drawing.Point(12, 104);
            this.lblDataRemainingCapacity.Name = "lblDataRemainingCapacity";
            this.lblDataRemainingCapacity.Size = new System.Drawing.Size(198, 13);
            this.lblDataRemainingCapacity.TabIndex = 8;
            this.lblDataRemainingCapacity.Text = "Data Partition Remaining Capacity (GB) :";
            // 
            // txtDataRemainingCapacity
            // 
            this.txtDataRemainingCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataRemainingCapacity.Location = new System.Drawing.Point(210, 99);
            this.txtDataRemainingCapacity.Name = "txtDataRemainingCapacity";
            this.txtDataRemainingCapacity.Size = new System.Drawing.Size(68, 22);
            this.txtDataRemainingCapacity.TabIndex = 9;
            // 
            // frmDeviceSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(463, 199);
            this.Controls.Add(this.txtDataCapacity);
            this.Controls.Add(this.lblDataCapacity);
            this.Controls.Add(this.txtDataRemainingCapacity);
            this.Controls.Add(this.lblDataRemainingCapacity);
            this.Controls.Add(this.lblTotalCapacity);
            this.Controls.Add(this.lblSelectDevice);
            this.Controls.Add(this.lblCopyrights);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.cmbDeviceSelection);
            this.Controls.Add(this.cmbCapacitySelection);
            this.Name = "frmDeviceSelection";
            this.Text = "Device Selection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbCapacitySelection;
        private System.Windows.Forms.ComboBox cmbDeviceSelection;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.Label lblCopyrights;
        private System.Windows.Forms.Label lblSelectDevice;
        private System.Windows.Forms.Label lblTotalCapacity;
        private System.Windows.Forms.Label lblDataCapacity;
        private System.Windows.Forms.TextBox txtDataCapacity;
        private System.Windows.Forms.Label lblDataRemainingCapacity;
        private System.Windows.Forms.TextBox txtDataRemainingCapacity;
    }
}