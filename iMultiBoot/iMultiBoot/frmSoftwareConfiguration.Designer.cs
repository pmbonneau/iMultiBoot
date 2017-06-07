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
            this.lblTemporaryDirectory = new System.Windows.Forms.Label();
            this.txtTemporaryDirectory = new System.Windows.Forms.TextBox();
            this.btnBrowseTempDir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTemporaryDirectory
            // 
            this.lblTemporaryDirectory.AutoSize = true;
            this.lblTemporaryDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemporaryDirectory.ForeColor = System.Drawing.Color.White;
            this.lblTemporaryDirectory.Location = new System.Drawing.Point(12, 23);
            this.lblTemporaryDirectory.Name = "lblTemporaryDirectory";
            this.lblTemporaryDirectory.Size = new System.Drawing.Size(138, 16);
            this.lblTemporaryDirectory.TabIndex = 0;
            this.lblTemporaryDirectory.Text = "Temporary Directory :";
            // 
            // txtTemporaryDirectory
            // 
            this.txtTemporaryDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTemporaryDirectory.Location = new System.Drawing.Point(156, 20);
            this.txtTemporaryDirectory.Name = "txtTemporaryDirectory";
            this.txtTemporaryDirectory.Size = new System.Drawing.Size(207, 22);
            this.txtTemporaryDirectory.TabIndex = 1;
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
            // frmSoftwareConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(510, 281);
            this.Controls.Add(this.btnBrowseTempDir);
            this.Controls.Add(this.txtTemporaryDirectory);
            this.Controls.Add(this.lblTemporaryDirectory);
            this.Name = "frmSoftwareConfiguration";
            this.Text = "Configure Software";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTemporaryDirectory;
        private System.Windows.Forms.TextBox txtTemporaryDirectory;
        private System.Windows.Forms.Button btnBrowseTempDir;
    }
}