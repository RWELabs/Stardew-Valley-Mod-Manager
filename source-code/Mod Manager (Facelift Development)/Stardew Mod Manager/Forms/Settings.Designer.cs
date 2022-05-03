
namespace Stardew_Mod_Manager
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ValidDirectory = new System.Windows.Forms.PictureBox();
            this.SDVDir = new System.Windows.Forms.TextBox();
            this.UpdateSDVDir = new System.Windows.Forms.Button();
            this.Tooltip = new System.Windows.Forms.Label();
            this.CopyPath = new System.Windows.Forms.Button();
            this.FileExplorerOpen = new System.Windows.Forms.Button();
            this.SettingsReset = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValidDirectory)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.55F);
            this.label1.Location = new System.Drawing.Point(16, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stardew Game Directory";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(75, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(318, 23);
            this.label4.TabIndex = 18;
            this.label4.Text = "Settings (Deprecated)";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Stardew_Mod_Manager.Properties.Resources.sdvsettings;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.label2.Location = new System.Drawing.Point(76, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(303, 54);
            this.label2.TabIndex = 20;
            this.label2.Text = "This settings window is no longer updated as of v220401. This window may not have" +
    " all settings available, as they have been moved to the Settings tab.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ValidDirectory
            // 
            this.ValidDirectory.Image = global::Stardew_Mod_Manager.Properties.Resources.sdvvalidated;
            this.ValidDirectory.Location = new System.Drawing.Point(343, 45);
            this.ValidDirectory.Name = "ValidDirectory";
            this.ValidDirectory.Size = new System.Drawing.Size(24, 20);
            this.ValidDirectory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ValidDirectory.TabIndex = 21;
            this.ValidDirectory.TabStop = false;
            // 
            // SDVDir
            // 
            this.SDVDir.Location = new System.Drawing.Point(18, 45);
            this.SDVDir.Name = "SDVDir";
            this.SDVDir.Size = new System.Drawing.Size(319, 20);
            this.SDVDir.TabIndex = 22;
            this.SDVDir.TextChanged += new System.EventHandler(this.SDVDir_TextChanged);
            // 
            // UpdateSDVDir
            // 
            this.UpdateSDVDir.Enabled = false;
            this.UpdateSDVDir.Location = new System.Drawing.Point(18, 96);
            this.UpdateSDVDir.Name = "UpdateSDVDir";
            this.UpdateSDVDir.Size = new System.Drawing.Size(111, 24);
            this.UpdateSDVDir.TabIndex = 1;
            this.UpdateSDVDir.Text = "Update";
            this.UpdateSDVDir.UseVisualStyleBackColor = true;
            this.UpdateSDVDir.Click += new System.EventHandler(this.UpdateSDVDir_Click);
            // 
            // Tooltip
            // 
            this.Tooltip.AutoSize = true;
            this.Tooltip.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Italic);
            this.Tooltip.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Tooltip.Location = new System.Drawing.Point(16, 68);
            this.Tooltip.Name = "Tooltip";
            this.Tooltip.Size = new System.Drawing.Size(241, 13);
            this.Tooltip.TabIndex = 24;
            this.Tooltip.Text = "This directory contains a valid Stardew Installation.";
            // 
            // CopyPath
            // 
            this.CopyPath.Location = new System.Drawing.Point(133, 96);
            this.CopyPath.Name = "CopyPath";
            this.CopyPath.Size = new System.Drawing.Size(111, 24);
            this.CopyPath.TabIndex = 25;
            this.CopyPath.Text = "Copy to Clipboard";
            this.CopyPath.UseVisualStyleBackColor = true;
            this.CopyPath.Click += new System.EventHandler(this.CopyPath_Click);
            // 
            // FileExplorerOpen
            // 
            this.FileExplorerOpen.Location = new System.Drawing.Point(248, 96);
            this.FileExplorerOpen.Name = "FileExplorerOpen";
            this.FileExplorerOpen.Size = new System.Drawing.Size(119, 24);
            this.FileExplorerOpen.TabIndex = 26;
            this.FileExplorerOpen.Text = "Open in File Explorer";
            this.FileExplorerOpen.UseVisualStyleBackColor = true;
            this.FileExplorerOpen.Click += new System.EventHandler(this.FileExplorerOpen_Click);
            // 
            // SettingsReset
            // 
            this.SettingsReset.Location = new System.Drawing.Point(273, 274);
            this.SettingsReset.Name = "SettingsReset";
            this.SettingsReset.Size = new System.Drawing.Size(120, 23);
            this.SettingsReset.TabIndex = 27;
            this.SettingsReset.Text = "Reset Settings";
            this.SettingsReset.UseVisualStyleBackColor = true;
            this.SettingsReset.Click += new System.EventHandler(this.SettingsReset_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SDVDir);
            this.groupBox1.Controls.Add(this.FileExplorerOpen);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CopyPath);
            this.groupBox1.Controls.Add(this.ValidDirectory);
            this.groupBox1.Controls.Add(this.Tooltip);
            this.groupBox1.Controls.Add(this.UpdateSDVDir);
            this.groupBox1.Location = new System.Drawing.Point(12, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(381, 143);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(414, 317);
            this.Controls.Add(this.SettingsReset);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(430, 1000);
            this.MinimumSize = new System.Drawing.Size(430, 266);
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings | Stardew Valley Modded Framework";
            this.Load += new System.EventHandler(this.Settings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValidDirectory)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox ValidDirectory;
        private System.Windows.Forms.TextBox SDVDir;
        private System.Windows.Forms.Button UpdateSDVDir;
        private System.Windows.Forms.Label Tooltip;
        private System.Windows.Forms.Button CopyPath;
        private System.Windows.Forms.Button FileExplorerOpen;
        private System.Windows.Forms.Button SettingsReset;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}