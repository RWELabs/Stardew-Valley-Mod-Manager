namespace Stardew_Mod_Manager.Forms
{
    partial class SMAPI_Updater
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SMAPI_Updater));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CurrentPublisher = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CurrentVersion = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CurrentName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.UpdateVersionLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.UpdateName = new System.Windows.Forms.Label();
            this.WarningLabel = new System.Windows.Forms.Label();
            this.WarningIcon = new System.Windows.Forms.PictureBox();
            this.DownloadButton = new Syncfusion.WinForms.Controls.SfButton();
            this.CancelButton = new Syncfusion.WinForms.Controls.SfButton();
            this.IsAppOpen = new System.Windows.Forms.Timer(this.components);
            this.ProgressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WarningIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.CurrentPublisher);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.CurrentVersion);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.CurrentName);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(22, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 99);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Current Installation";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Publisher";
            // 
            // CurrentPublisher
            // 
            this.CurrentPublisher.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.CurrentPublisher.Location = new System.Drawing.Point(82, 66);
            this.CurrentPublisher.Name = "CurrentPublisher";
            this.CurrentPublisher.Size = new System.Drawing.Size(242, 13);
            this.CurrentPublisher.TabIndex = 5;
            this.CurrentPublisher.Text = "Pathoschild";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Version";
            // 
            // CurrentVersion
            // 
            this.CurrentVersion.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.CurrentVersion.Location = new System.Drawing.Point(82, 48);
            this.CurrentVersion.Name = "CurrentVersion";
            this.CurrentVersion.Size = new System.Drawing.Size(242, 13);
            this.CurrentVersion.TabIndex = 3;
            this.CurrentVersion.Text = "label4";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // CurrentName
            // 
            this.CurrentName.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.CurrentName.Location = new System.Drawing.Point(82, 29);
            this.CurrentName.Name = "CurrentName";
            this.CurrentName.Size = new System.Drawing.Size(242, 13);
            this.CurrentName.TabIndex = 1;
            this.CurrentName.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Stardew_Mod_Manager.Properties.Resources.SMAPILogo1;
            this.pictureBox1.Location = new System.Drawing.Point(22, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.UpdateVersionLabel);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.UpdateName);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(22, 225);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(365, 78);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Available Update";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Version";
            // 
            // UpdateVersionLabel
            // 
            this.UpdateVersionLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.UpdateVersionLabel.Location = new System.Drawing.Point(82, 48);
            this.UpdateVersionLabel.Name = "UpdateVersionLabel";
            this.UpdateVersionLabel.Size = new System.Drawing.Size(242, 13);
            this.UpdateVersionLabel.TabIndex = 3;
            this.UpdateVersionLabel.Text = "label4";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Name";
            // 
            // UpdateName
            // 
            this.UpdateName.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.UpdateName.Location = new System.Drawing.Point(82, 29);
            this.UpdateName.Name = "UpdateName";
            this.UpdateName.Size = new System.Drawing.Size(242, 13);
            this.UpdateName.TabIndex = 1;
            this.UpdateName.Text = "label1";
            // 
            // WarningLabel
            // 
            this.WarningLabel.Location = new System.Drawing.Point(51, 317);
            this.WarningLabel.Name = "WarningLabel";
            this.WarningLabel.Size = new System.Drawing.Size(338, 29);
            this.WarningLabel.TabIndex = 8;
            this.WarningLabel.Text = "We\'ve detected that you\'re running Stardew Valley on your machine. To update SMAP" +
    "I, please close Stardew Valley to continue.";
            // 
            // WarningIcon
            // 
            this.WarningIcon.Image = global::Stardew_Mod_Manager.Properties.Resources.sdvError;
            this.WarningIcon.Location = new System.Drawing.Point(22, 317);
            this.WarningIcon.Name = "WarningIcon";
            this.WarningIcon.Size = new System.Drawing.Size(24, 29);
            this.WarningIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.WarningIcon.TabIndex = 9;
            this.WarningIcon.TabStop = false;
            // 
            // DownloadButton
            // 
            this.DownloadButton.AccessibleName = "Button";
            this.DownloadButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.DownloadButton.Location = new System.Drawing.Point(227, 360);
            this.DownloadButton.Name = "DownloadButton";
            this.DownloadButton.Size = new System.Drawing.Size(160, 28);
            this.DownloadButton.TabIndex = 10;
            this.DownloadButton.Text = "Download and Install";
            this.DownloadButton.Click += new System.EventHandler(this.DownloadButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.AccessibleName = "Button";
            this.CancelButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CancelButton.Location = new System.Drawing.Point(132, 360);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(89, 28);
            this.CancelButton.TabIndex = 11;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // IsAppOpen
            // 
            this.IsAppOpen.Interval = 1000;
            this.IsAppOpen.Tick += new System.EventHandler(this.IsAppOpen_Tick);
            // 
            // ProgressBar1
            // 
            this.ProgressBar1.Location = new System.Drawing.Point(22, 349);
            this.ProgressBar1.Name = "ProgressBar1";
            this.ProgressBar1.Size = new System.Drawing.Size(365, 28);
            this.ProgressBar1.TabIndex = 12;
            this.ProgressBar1.Visible = false;
            // 
            // SMAPI_Updater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(411, 406);
            this.Controls.Add(this.ProgressBar1);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.DownloadButton);
            this.Controls.Add(this.WarningIcon);
            this.Controls.Add(this.WarningLabel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SMAPI_Updater";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SMAPI Update Utility | Stardew Valley Mod Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SMAPI_Updater_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WarningIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label CurrentVersion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label CurrentName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label CurrentPublisher;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label UpdateVersionLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label UpdateName;
        private System.Windows.Forms.Label WarningLabel;
        private System.Windows.Forms.PictureBox WarningIcon;
        private Syncfusion.WinForms.Controls.SfButton DownloadButton;
        private Syncfusion.WinForms.Controls.SfButton CancelButton;
        private System.Windows.Forms.Timer IsAppOpen;
        private System.Windows.Forms.ProgressBar ProgressBar1;
    }
}