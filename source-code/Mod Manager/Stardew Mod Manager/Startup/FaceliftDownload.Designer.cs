namespace Stardew_Mod_Manager.Startup
{
    partial class FaceliftDownload
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FaceliftDownload));
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.PresentTimer = new System.Windows.Forms.Timer(this.components);
            this.InfoPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Upgrade = new System.Windows.Forms.Button();
            this.RemindLater = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.InfoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(-19, 0);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(697, 651);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            // 
            // PresentTimer
            // 
            this.PresentTimer.Interval = 52000;
            this.PresentTimer.Tick += new System.EventHandler(this.PresentTimer_Tick);
            // 
            // InfoPanel
            // 
            this.InfoPanel.BackColor = System.Drawing.Color.White;
            this.InfoPanel.Controls.Add(this.RemindLater);
            this.InfoPanel.Controls.Add(this.Upgrade);
            this.InfoPanel.Controls.Add(this.label2);
            this.InfoPanel.Controls.Add(this.label1);
            this.InfoPanel.Location = new System.Drawing.Point(-1, 0);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Size = new System.Drawing.Size(658, 589);
            this.InfoPanel.TabIndex = 1;
            this.InfoPanel.Visible = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 38.25F);
            this.label1.Location = new System.Drawing.Point(25, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(605, 141);
            this.label1.TabIndex = 0;
            this.label1.Text = "Experience the new Stardew Mod Manager";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18.25F);
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(31, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(577, 119);
            this.label2.TabIndex = 1;
            this.label2.Text = "With more features and a new modern design, we\'re sure you\'ll love the new Starde" +
    "w Mod Manager.";
            // 
            // Upgrade
            // 
            this.Upgrade.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.Upgrade.Location = new System.Drawing.Point(37, 358);
            this.Upgrade.Name = "Upgrade";
            this.Upgrade.Size = new System.Drawing.Size(206, 66);
            this.Upgrade.TabIndex = 2;
            this.Upgrade.Text = "Upgrade Now";
            this.Upgrade.UseVisualStyleBackColor = true;
            this.Upgrade.Click += new System.EventHandler(this.Upgrade_Click);
            // 
            // RemindLater
            // 
            this.RemindLater.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.RemindLater.Location = new System.Drawing.Point(37, 439);
            this.RemindLater.Name = "RemindLater";
            this.RemindLater.Size = new System.Drawing.Size(206, 66);
            this.RemindLater.TabIndex = 3;
            this.RemindLater.Text = "Remind Me Later";
            this.RemindLater.UseVisualStyleBackColor = true;
            this.RemindLater.Click += new System.EventHandler(this.RemindLater_Click);
            // 
            // FaceliftDownload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 585);
            this.Controls.Add(this.InfoPanel);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(671, 624);
            this.MinimumSize = new System.Drawing.Size(671, 624);
            this.Name = "FaceliftDownload";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Try the new Stardew Mod Manager";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FaceliftDownload_FormClosed);
            this.Load += new System.EventHandler(this.FaceliftDownload_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.InfoPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Timer PresentTimer;
        private System.Windows.Forms.Panel InfoPanel;
        private System.Windows.Forms.Button RemindLater;
        private System.Windows.Forms.Button Upgrade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}