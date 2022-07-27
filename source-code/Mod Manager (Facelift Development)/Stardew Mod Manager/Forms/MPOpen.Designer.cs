namespace Stardew_Mod_Manager.Forms
{
    partial class MPOpen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MPOpen));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DriveSpaceAvailable = new System.Windows.Forms.Label();
            this.DriveSpaceRequired = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.IsValidSpace = new System.Windows.Forms.PictureBox();
            this.IsValidSpaceText = new System.Windows.Forms.Label();
            this.DriveSpaceDestination = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.WarningText = new System.Windows.Forms.RichTextBox();
            this.Continue = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.Extract = new System.ComponentModel.BackgroundWorker();
            this.ExtractProgress = new System.Windows.Forms.ProgressBar();
            this.ErrorLog = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IsValidSpace)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Stardew_Mod_Manager.Properties.Resources.SDVMPIcon;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Available Install Space:";
            // 
            // DriveSpaceAvailable
            // 
            this.DriveSpaceAvailable.AutoSize = true;
            this.DriveSpaceAvailable.Location = new System.Drawing.Point(195, 117);
            this.DriveSpaceAvailable.Name = "DriveSpaceAvailable";
            this.DriveSpaceAvailable.Size = new System.Drawing.Size(106, 13);
            this.DriveSpaceAvailable.TabIndex = 2;
            this.DriveSpaceAvailable.Text = "DriveSpaceAvailable";
            // 
            // DriveSpaceRequired
            // 
            this.DriveSpaceRequired.AutoSize = true;
            this.DriveSpaceRequired.Location = new System.Drawing.Point(195, 135);
            this.DriveSpaceRequired.Name = "DriveSpaceRequired";
            this.DriveSpaceRequired.Size = new System.Drawing.Size(106, 13);
            this.DriveSpaceRequired.TabIndex = 4;
            this.DriveSpaceRequired.Text = "DriveSpaceRequired";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Required Unpack/Install Space:";
            // 
            // IsValidSpace
            // 
            this.IsValidSpace.Image = global::Stardew_Mod_Manager.Properties.Resources.sdvError;
            this.IsValidSpace.Location = new System.Drawing.Point(14, 157);
            this.IsValidSpace.Name = "IsValidSpace";
            this.IsValidSpace.Size = new System.Drawing.Size(21, 23);
            this.IsValidSpace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IsValidSpace.TabIndex = 26;
            this.IsValidSpace.TabStop = false;
            // 
            // IsValidSpaceText
            // 
            this.IsValidSpaceText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsValidSpaceText.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.IsValidSpaceText.Location = new System.Drawing.Point(37, 162);
            this.IsValidSpaceText.Name = "IsValidSpaceText";
            this.IsValidSpaceText.Size = new System.Drawing.Size(359, 40);
            this.IsValidSpaceText.TabIndex = 25;
            this.IsValidSpaceText.Text = "There is not enough disk space to install this modpack.";
            // 
            // DriveSpaceDestination
            // 
            this.DriveSpaceDestination.AutoSize = true;
            this.DriveSpaceDestination.Location = new System.Drawing.Point(195, 99);
            this.DriveSpaceDestination.Name = "DriveSpaceDestination";
            this.DriveSpaceDestination.Size = new System.Drawing.Size(116, 13);
            this.DriveSpaceDestination.TabIndex = 28;
            this.DriveSpaceDestination.Text = "DriveSpaceDestination";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Available Unpack Space:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.WarningText);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 209);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 155);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Warnings";
            // 
            // WarningText
            // 
            this.WarningText.BackColor = System.Drawing.Color.White;
            this.WarningText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WarningText.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.WarningText.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.WarningText.Location = new System.Drawing.Point(10, 21);
            this.WarningText.Name = "WarningText";
            this.WarningText.ReadOnly = true;
            this.WarningText.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.WarningText.Size = new System.Drawing.Size(368, 128);
            this.WarningText.TabIndex = 0;
            this.WarningText.Text = "By continuing to install this modpack, we will disable all currently enabled mods" +
    ". You will have to re-enable them later.";
            // 
            // Continue
            // 
            this.Continue.Location = new System.Drawing.Point(288, 384);
            this.Continue.Name = "Continue";
            this.Continue.Size = new System.Drawing.Size(108, 23);
            this.Continue.TabIndex = 30;
            this.Continue.Text = "Continue";
            this.Continue.UseVisualStyleBackColor = true;
            this.Continue.Click += new System.EventHandler(this.Continue_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(209, 384);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(73, 23);
            this.Cancel.TabIndex = 31;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Extract
            // 
            this.Extract.WorkerReportsProgress = true;
            this.Extract.WorkerSupportsCancellation = true;
            this.Extract.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Extract_DoWork);
            this.Extract.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.Extract_RunWorkerCompleted);
            // 
            // ExtractProgress
            // 
            this.ExtractProgress.Location = new System.Drawing.Point(12, 384);
            this.ExtractProgress.Name = "ExtractProgress";
            this.ExtractProgress.Size = new System.Drawing.Size(384, 23);
            this.ExtractProgress.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.ExtractProgress.TabIndex = 32;
            this.ExtractProgress.Value = 15;
            // 
            // ErrorLog
            // 
            this.ErrorLog.Location = new System.Drawing.Point(12, 12);
            this.ErrorLog.Name = "ErrorLog";
            this.ErrorLog.Size = new System.Drawing.Size(71, 70);
            this.ErrorLog.TabIndex = 33;
            this.ErrorLog.Text = "";
            this.ErrorLog.Visible = false;
            // 
            // MPOpen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(409, 428);
            this.Controls.Add(this.ExtractProgress);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Continue);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DriveSpaceDestination);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.IsValidSpace);
            this.Controls.Add(this.IsValidSpaceText);
            this.Controls.Add(this.DriveSpaceRequired);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DriveSpaceAvailable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ErrorLog);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(425, 467);
            this.MinimumSize = new System.Drawing.Size(425, 467);
            this.Name = "MPOpen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Install Modpack - Stardew Valley Mod Manager";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MPOpen_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IsValidSpace)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label DriveSpaceAvailable;
        private System.Windows.Forms.Label DriveSpaceRequired;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox IsValidSpace;
        private System.Windows.Forms.Label IsValidSpaceText;
        private System.Windows.Forms.Label DriveSpaceDestination;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Continue;
        private System.Windows.Forms.Button Cancel;
        private System.ComponentModel.BackgroundWorker Extract;
        private System.Windows.Forms.ProgressBar ExtractProgress;
        private System.Windows.Forms.RichTextBox WarningText;
        private System.Windows.Forms.RichTextBox ErrorLog;
    }
}