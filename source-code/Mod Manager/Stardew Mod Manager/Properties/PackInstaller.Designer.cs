
namespace Stardew_Mod_Manager.Properties
{
    partial class PackInstaller
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PackInstaller));
            this.Browse = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SDVMPFilePath = new System.Windows.Forms.TextBox();
            this.OuputConsole = new System.Windows.Forms.RichTextBox();
            this.Install = new System.Windows.Forms.Button();
            this.ConfigFile = new System.Windows.Forms.RichTextBox();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.ModsTimer = new System.Windows.Forms.Timer(this.components);
            this.ExtractTimer = new System.Windows.Forms.Timer(this.components);
            this.verSMAPI = new System.Windows.Forms.TextBox();
            this.verSMAPIReq = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Browse
            // 
            this.Browse.Location = new System.Drawing.Point(355, 197);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(75, 23);
            this.Browse.TabIndex = 0;
            this.Browse.Text = "Browse";
            this.Browse.UseVisualStyleBackColor = true;
            this.Browse.Click += new System.EventHandler(this.Browse_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.label2.Location = new System.Drawing.Point(14, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(348, 91);
            this.label2.TabIndex = 6;
            this.label2.Text = resources.GetString("label2.Text");
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 35);
            this.label1.TabIndex = 5;
            this.label1.Text = "Install Modpack";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(12, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(446, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Select a SDVMP File:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SDVMPFilePath
            // 
            this.SDVMPFilePath.Location = new System.Drawing.Point(15, 199);
            this.SDVMPFilePath.Name = "SDVMPFilePath";
            this.SDVMPFilePath.ReadOnly = true;
            this.SDVMPFilePath.Size = new System.Drawing.Size(334, 20);
            this.SDVMPFilePath.TabIndex = 8;
            // 
            // OuputConsole
            // 
            this.OuputConsole.BackColor = System.Drawing.Color.Black;
            this.OuputConsole.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OuputConsole.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OuputConsole.ForeColor = System.Drawing.Color.White;
            this.OuputConsole.Location = new System.Drawing.Point(15, 240);
            this.OuputConsole.Name = "OuputConsole";
            this.OuputConsole.ReadOnly = true;
            this.OuputConsole.Size = new System.Drawing.Size(492, 303);
            this.OuputConsole.TabIndex = 9;
            this.OuputConsole.Text = "Stardew Valley Modded Framework\n(C) Copyright 2022 - Ryan Walpole Enterprises, Cr" +
    "utionix Media Group\nModpack Installation Utility\n\n[INFO] Installer Ready.";
            // 
            // Install
            // 
            this.Install.Enabled = false;
            this.Install.Location = new System.Drawing.Point(432, 197);
            this.Install.Name = "Install";
            this.Install.Size = new System.Drawing.Size(75, 23);
            this.Install.TabIndex = 10;
            this.Install.Text = "Install";
            this.Install.UseVisualStyleBackColor = true;
            this.Install.Click += new System.EventHandler(this.Install_Click);
            // 
            // ConfigFile
            // 
            this.ConfigFile.Location = new System.Drawing.Point(279, 21);
            this.ConfigFile.Name = "ConfigFile";
            this.ConfigFile.Size = new System.Drawing.Size(156, 25);
            this.ConfigFile.TabIndex = 11;
            this.ConfigFile.Text = "";
            this.ConfigFile.Visible = false;
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(15, 558);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(492, 20);
            this.ProgressBar.TabIndex = 12;
            // 
            // ModsTimer
            // 
            this.ModsTimer.Interval = 3000;
            this.ModsTimer.Tick += new System.EventHandler(this.ModsTimer_Tick);
            // 
            // ExtractTimer
            // 
            this.ExtractTimer.Interval = 3000;
            this.ExtractTimer.Tick += new System.EventHandler(this.ExtractTimer_Tick);
            // 
            // verSMAPI
            // 
            this.verSMAPI.Location = new System.Drawing.Point(67, 21);
            this.verSMAPI.Name = "verSMAPI";
            this.verSMAPI.Size = new System.Drawing.Size(100, 20);
            this.verSMAPI.TabIndex = 13;
            this.verSMAPI.Visible = false;
            // 
            // verSMAPIReq
            // 
            this.verSMAPIReq.Location = new System.Drawing.Point(173, 21);
            this.verSMAPIReq.Name = "verSMAPIReq";
            this.verSMAPIReq.Size = new System.Drawing.Size(100, 20);
            this.verSMAPIReq.TabIndex = 14;
            this.verSMAPIReq.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Stardew_Mod_Manager.Properties.Resources.Stardew_Mod_Manager;
            this.pictureBox1.Location = new System.Drawing.Point(355, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 147);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // PackInstaller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 590);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.Install);
            this.Controls.Add(this.OuputConsole);
            this.Controls.Add(this.SDVMPFilePath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Browse);
            this.Controls.Add(this.verSMAPIReq);
            this.Controls.Add(this.verSMAPI);
            this.Controls.Add(this.ConfigFile);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(535, 629);
            this.MinimumSize = new System.Drawing.Size(535, 629);
            this.Name = "PackInstaller";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Install Modpack | Stardew Valley Modded Framework";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Browse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SDVMPFilePath;
        private System.Windows.Forms.RichTextBox OuputConsole;
        private System.Windows.Forms.Button Install;
        private System.Windows.Forms.RichTextBox ConfigFile;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.Timer ModsTimer;
        private System.Windows.Forms.Timer ExtractTimer;
        private System.Windows.Forms.TextBox verSMAPI;
        private System.Windows.Forms.TextBox verSMAPIReq;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}