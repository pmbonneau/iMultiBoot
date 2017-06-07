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
            this.btnInstall = new System.Windows.Forms.Button();
            this.btnSelectOperatingSystems = new System.Windows.Forms.Button();
            this.btnSelectDevice = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnBegin = new System.Windows.Forms.Button();
            this.lblCopyrights = new System.Windows.Forms.Label();
            this.btnConfigureSoftware = new System.Windows.Forms.Button();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.btnConfigureSoftware);
            this.pnlMain.Controls.Add(this.btnInstall);
            this.pnlMain.Controls.Add(this.btnSelectOperatingSystems);
            this.pnlMain.Controls.Add(this.btnSelectDevice);
            this.pnlMain.Location = new System.Drawing.Point(2, 38);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(579, 295);
            this.pnlMain.TabIndex = 1;
            this.pnlMain.Visible = false;
            // 
            // btnInstall
            // 
            this.btnInstall.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstall.Location = new System.Drawing.Point(213, 257);
            this.btnInstall.Name = "btnInstall";
            this.btnInstall.Size = new System.Drawing.Size(171, 35);
            this.btnInstall.TabIndex = 2;
            this.btnInstall.Text = "Proceed to Install";
            this.btnInstall.UseVisualStyleBackColor = true;
            this.btnInstall.Click += new System.EventHandler(this.btnInstall_Click);
            // 
            // btnSelectOperatingSystems
            // 
            this.btnSelectOperatingSystems.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectOperatingSystems.Location = new System.Drawing.Point(10, 117);
            this.btnSelectOperatingSystems.Name = "btnSelectOperatingSystems";
            this.btnSelectOperatingSystems.Size = new System.Drawing.Size(171, 35);
            this.btnSelectOperatingSystems.TabIndex = 1;
            this.btnSelectOperatingSystems.Text = "Select Operating Systems";
            this.btnSelectOperatingSystems.UseVisualStyleBackColor = true;
            this.btnSelectOperatingSystems.Click += new System.EventHandler(this.btnSelectOperatingSystems_Click);
            // 
            // btnSelectDevice
            // 
            this.btnSelectDevice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectDevice.Location = new System.Drawing.Point(10, 67);
            this.btnSelectDevice.Name = "btnSelectDevice";
            this.btnSelectDevice.Size = new System.Drawing.Size(171, 35);
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
            this.btnBegin.Location = new System.Drawing.Point(444, 294);
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
            this.lblCopyrights.Location = new System.Drawing.Point(258, 336);
            this.lblCopyrights.Name = "lblCopyrights";
            this.lblCopyrights.Size = new System.Drawing.Size(323, 18);
            this.lblCopyrights.TabIndex = 4;
            this.lblCopyrights.Text = "©2017 Pierre-Marc Bonneau, all rights reserved.";
            // 
            // btnConfigureSoftware
            // 
            this.btnConfigureSoftware.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfigureSoftware.Location = new System.Drawing.Point(10, 13);
            this.btnConfigureSoftware.Name = "btnConfigureSoftware";
            this.btnConfigureSoftware.Size = new System.Drawing.Size(171, 35);
            this.btnConfigureSoftware.TabIndex = 3;
            this.btnConfigureSoftware.Text = "Configure Software";
            this.btnConfigureSoftware.UseVisualStyleBackColor = true;
            this.btnConfigureSoftware.Click += new System.EventHandler(this.btnConfigureSoftware_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.lblCopyrights);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.btnBegin);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmMain";
            this.Text = "iMultiBoot v0.1a (0A0617a)";
            this.pnlMain.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnInstall;
        private System.Windows.Forms.Button btnConfigureSoftware;
    }
}

