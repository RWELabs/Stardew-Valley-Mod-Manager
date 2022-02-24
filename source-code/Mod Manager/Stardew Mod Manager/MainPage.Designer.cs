
namespace Stardew_Mod_Manager
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.InstalledModsList = new System.Windows.Forms.ListBox();
            this.AvailableModsList = new System.Windows.Forms.ListBox();
            this.DisableMod = new System.Windows.Forms.Button();
            this.EnableMod = new System.Windows.Forms.Button();
            this.ModFolderPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SavePreset = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.LoadPreset = new System.Windows.Forms.Button();
            this.ZipInstall = new System.Windows.Forms.Button();
            this.PackInstall = new System.Windows.Forms.Button();
            this.DeleteMod = new System.Windows.Forms.Button();
            this.SMAPIWarning = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.SMAPIDownload = new System.Windows.Forms.LinkLabel();
            this.SMAPIVer = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SMAPIWarning.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // InstalledModsList
            // 
            this.InstalledModsList.FormattingEnabled = true;
            this.InstalledModsList.Location = new System.Drawing.Point(25, 241);
            this.InstalledModsList.Name = "InstalledModsList";
            this.InstalledModsList.Size = new System.Drawing.Size(200, 212);
            this.InstalledModsList.TabIndex = 0;
            this.InstalledModsList.Click += new System.EventHandler(this.InstalledModsList_Click);
            // 
            // AvailableModsList
            // 
            this.AvailableModsList.FormattingEnabled = true;
            this.AvailableModsList.Location = new System.Drawing.Point(315, 241);
            this.AvailableModsList.Name = "AvailableModsList";
            this.AvailableModsList.Size = new System.Drawing.Size(200, 212);
            this.AvailableModsList.TabIndex = 1;
            this.AvailableModsList.Click += new System.EventHandler(this.AvailableModsList_Click);
            // 
            // DisableMod
            // 
            this.DisableMod.Enabled = false;
            this.DisableMod.Location = new System.Drawing.Point(234, 351);
            this.DisableMod.Name = "DisableMod";
            this.DisableMod.Size = new System.Drawing.Size(75, 49);
            this.DisableMod.TabIndex = 2;
            this.DisableMod.Text = "->\r\nDisable";
            this.DisableMod.UseVisualStyleBackColor = true;
            this.DisableMod.Click += new System.EventHandler(this.DisableMod_Click);
            // 
            // EnableMod
            // 
            this.EnableMod.Enabled = false;
            this.EnableMod.Location = new System.Drawing.Point(234, 296);
            this.EnableMod.Name = "EnableMod";
            this.EnableMod.Size = new System.Drawing.Size(75, 49);
            this.EnableMod.TabIndex = 3;
            this.EnableMod.Text = "<-\r\nEnable";
            this.EnableMod.UseVisualStyleBackColor = true;
            this.EnableMod.Click += new System.EventHandler(this.EnableMod_Click);
            // 
            // ModFolderPath
            // 
            this.ModFolderPath.Location = new System.Drawing.Point(38, 12);
            this.ModFolderPath.Name = "ModFolderPath";
            this.ModFolderPath.Size = new System.Drawing.Size(455, 20);
            this.ModFolderPath.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(21, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enabled Mods";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(315, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Disabled Mods";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SavePreset
            // 
            this.SavePreset.Location = new System.Drawing.Point(234, 406);
            this.SavePreset.Name = "SavePreset";
            this.SavePreset.Size = new System.Drawing.Size(75, 47);
            this.SavePreset.TabIndex = 8;
            this.SavePreset.Text = "Save\r\nPreset";
            this.SavePreset.UseVisualStyleBackColor = true;
            this.SavePreset.Click += new System.EventHandler(this.SavePreset_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 85);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(85, 22);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // LoadPreset
            // 
            this.LoadPreset.Location = new System.Drawing.Point(234, 241);
            this.LoadPreset.Name = "LoadPreset";
            this.LoadPreset.Size = new System.Drawing.Size(75, 47);
            this.LoadPreset.TabIndex = 10;
            this.LoadPreset.Text = "Load\r\nPreset";
            this.LoadPreset.UseVisualStyleBackColor = true;
            this.LoadPreset.Click += new System.EventHandler(this.LoadPreset_Click);
            // 
            // ZipInstall
            // 
            this.ZipInstall.Location = new System.Drawing.Point(25, 464);
            this.ZipInstall.Name = "ZipInstall";
            this.ZipInstall.Size = new System.Drawing.Size(96, 23);
            this.ZipInstall.TabIndex = 11;
            this.ZipInstall.Text = "Add New Mod";
            this.ZipInstall.UseVisualStyleBackColor = true;
            this.ZipInstall.Click += new System.EventHandler(this.ZipInstall_Click);
            // 
            // PackInstall
            // 
            this.PackInstall.Location = new System.Drawing.Point(127, 464);
            this.PackInstall.Name = "PackInstall";
            this.PackInstall.Size = new System.Drawing.Size(98, 23);
            this.PackInstall.TabIndex = 12;
            this.PackInstall.Text = "Install Modpack";
            this.PackInstall.UseVisualStyleBackColor = true;
            this.PackInstall.Click += new System.EventHandler(this.PackInstall_Click);
            // 
            // DeleteMod
            // 
            this.DeleteMod.Enabled = false;
            this.DeleteMod.Location = new System.Drawing.Point(315, 464);
            this.DeleteMod.Name = "DeleteMod";
            this.DeleteMod.Size = new System.Drawing.Size(96, 23);
            this.DeleteMod.TabIndex = 13;
            this.DeleteMod.Text = "Delete Mod";
            this.DeleteMod.UseVisualStyleBackColor = true;
            this.DeleteMod.Click += new System.EventHandler(this.DeleteMod_Click);
            // 
            // SMAPIWarning
            // 
            this.SMAPIWarning.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SMAPIWarning.Controls.Add(this.SMAPIDownload);
            this.SMAPIWarning.Controls.Add(this.label3);
            this.SMAPIWarning.Controls.Add(this.pictureBox2);
            this.SMAPIWarning.Location = new System.Drawing.Point(25, 37);
            this.SMAPIWarning.Name = "SMAPIWarning";
            this.SMAPIWarning.Size = new System.Drawing.Size(490, 52);
            this.SMAPIWarning.TabIndex = 14;
            this.SMAPIWarning.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(72, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(399, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "SMAPI was not found on your system. SMAPI is required in order to play with Mods." +
    "";
            // 
            // SMAPIDownload
            // 
            this.SMAPIDownload.ActiveLinkColor = System.Drawing.Color.White;
            this.SMAPIDownload.AutoSize = true;
            this.SMAPIDownload.LinkColor = System.Drawing.Color.White;
            this.SMAPIDownload.Location = new System.Drawing.Point(326, 28);
            this.SMAPIDownload.Name = "SMAPIDownload";
            this.SMAPIDownload.Size = new System.Drawing.Size(142, 13);
            this.SMAPIDownload.TabIndex = 2;
            this.SMAPIDownload.TabStop = true;
            this.SMAPIDownload.Text = "Download and Install SMAPI";
            this.SMAPIDownload.VisitedLinkColor = System.Drawing.Color.White;
            this.SMAPIDownload.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SMAPIDownload_LinkClicked);
            // 
            // SMAPIVer
            // 
            this.SMAPIVer.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.SMAPIVer.Location = new System.Drawing.Point(320, 498);
            this.SMAPIVer.Name = "SMAPIVer";
            this.SMAPIVer.Size = new System.Drawing.Size(222, 23);
            this.SMAPIVer.TabIndex = 15;
            this.SMAPIVer.Text = "SMAPI 0.0.0";
            this.SMAPIVer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SMAPIVer.Click += new System.EventHandler(this.SMAPIVer_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Stardew_Mod_Manager.Properties.Resources.icon_attention;
            this.pictureBox2.Location = new System.Drawing.Point(4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(62, 42);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Stardew_Mod_Manager.Properties.Resources.sdvbg1;
            this.pictureBox1.Location = new System.Drawing.Point(-6, -63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(570, 242);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 522);
            this.Controls.Add(this.SMAPIVer);
            this.Controls.Add(this.SMAPIWarning);
            this.Controls.Add(this.DeleteMod);
            this.Controls.Add(this.PackInstall);
            this.Controls.Add(this.ZipInstall);
            this.Controls.Add(this.LoadPreset);
            this.Controls.Add(this.SavePreset);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ModFolderPath);
            this.Controls.Add(this.EnableMod);
            this.Controls.Add(this.DisableMod);
            this.Controls.Add(this.InstalledModsList);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.AvailableModsList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(562, 561);
            this.MinimumSize = new System.Drawing.Size(562, 561);
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mod Manager | Stardew Valley Modded Framework";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainPage_FormClosed);
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.SMAPIWarning.ResumeLayout(false);
            this.SMAPIWarning.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox InstalledModsList;
        private System.Windows.Forms.ListBox AvailableModsList;
        private System.Windows.Forms.Button DisableMod;
        private System.Windows.Forms.Button EnableMod;
        private System.Windows.Forms.TextBox ModFolderPath;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SavePreset;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button LoadPreset;
        private System.Windows.Forms.Button ZipInstall;
        private System.Windows.Forms.Button PackInstall;
        private System.Windows.Forms.Button DeleteMod;
        private System.Windows.Forms.Panel SMAPIWarning;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.LinkLabel SMAPIDownload;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label SMAPIVer;
    }
}