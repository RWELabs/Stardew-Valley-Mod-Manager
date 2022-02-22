
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SavePreset = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // InstalledModsList
            // 
            this.InstalledModsList.FormattingEnabled = true;
            this.InstalledModsList.Location = new System.Drawing.Point(25, 278);
            this.InstalledModsList.Name = "InstalledModsList";
            this.InstalledModsList.Size = new System.Drawing.Size(165, 212);
            this.InstalledModsList.TabIndex = 0;
            this.InstalledModsList.Click += new System.EventHandler(this.InstalledModsList_Click);
            // 
            // AvailableModsList
            // 
            this.AvailableModsList.FormattingEnabled = true;
            this.AvailableModsList.Location = new System.Drawing.Point(315, 278);
            this.AvailableModsList.Name = "AvailableModsList";
            this.AvailableModsList.Size = new System.Drawing.Size(165, 212);
            this.AvailableModsList.TabIndex = 1;
            this.AvailableModsList.Click += new System.EventHandler(this.AvailableModsList_Click);
            // 
            // DisableMod
            // 
            this.DisableMod.Location = new System.Drawing.Point(216, 388);
            this.DisableMod.Name = "DisableMod";
            this.DisableMod.Size = new System.Drawing.Size(75, 49);
            this.DisableMod.TabIndex = 2;
            this.DisableMod.Text = "->\r\nDisable";
            this.DisableMod.UseVisualStyleBackColor = true;
            this.DisableMod.Click += new System.EventHandler(this.DisableMod_Click);
            // 
            // EnableMod
            // 
            this.EnableMod.Location = new System.Drawing.Point(216, 333);
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
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Stardew_Mod_Manager.Properties.Resources.sdvbg1;
            this.pictureBox1.Location = new System.Drawing.Point(-6, -63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(529, 225);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(25, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enabled Mods";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(315, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Disabled Mods";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SavePreset
            // 
            this.SavePreset.Location = new System.Drawing.Point(216, 278);
            this.SavePreset.Name = "SavePreset";
            this.SavePreset.Size = new System.Drawing.Size(75, 49);
            this.SavePreset.TabIndex = 8;
            this.SavePreset.Text = "Save\r\nPreset";
            this.SavePreset.UseVisualStyleBackColor = true;
            this.SavePreset.Click += new System.EventHandler(this.SavePreset_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(90, 22);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(317, 200);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 528);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.SavePreset);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ModFolderPath);
            this.Controls.Add(this.EnableMod);
            this.Controls.Add(this.DisableMod);
            this.Controls.Add(this.AvailableModsList);
            this.Controls.Add(this.InstalledModsList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainPage";
            this.Text = "Mod Manager | Stardew Valley Modded Framework";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainPage_FormClosed);
            this.Load += new System.EventHandler(this.MainPage_Load);
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
    }
}