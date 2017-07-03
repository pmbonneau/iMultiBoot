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
            this.SuspendLayout();
            // 
            // gbFirmwareSection
            // 
            this.gbFirmwareSection.ForeColor = System.Drawing.Color.White;
            this.gbFirmwareSection.Location = new System.Drawing.Point(12, 12);
            this.gbFirmwareSection.Name = "gbFirmwareSection";
            this.gbFirmwareSection.Size = new System.Drawing.Size(272, 269);
            this.gbFirmwareSection.TabIndex = 0;
            this.gbFirmwareSection.TabStop = false;
            this.gbFirmwareSection.Text = "Firmware Section";
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFirmwareSection;
    }
}