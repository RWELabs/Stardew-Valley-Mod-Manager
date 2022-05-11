
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SDVMPFilePath = new System.Windows.Forms.TextBox();
            this.OuputConsole = new System.Windows.Forms.RichTextBox();
            this.ConfigFile = new System.Windows.Forms.RichTextBox();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.ModsTimer = new System.Windows.Forms.Timer(this.components);
            this.ExtractTimer = new System.Windows.Forms.Timer(this.components);
            this.verSMAPI = new System.Windows.Forms.TextBox();
            this.verSMAPIReq = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Browse = new Syncfusion.WinForms.Controls.SfButton();
            this.Install = new Syncfusion.WinForms.Controls.SfButton();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.label2.Location = new System.Drawing.Point(84, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(401, 77);
            this.label2.TabIndex = 6;
            this.label2.Text = resources.GetString("label2.Text");
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 35);
            this.label1.TabIndex = 5;
            this.label1.Text = "Modpack Installer";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(12, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(446, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Select a SDVMP File:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SDVMPFilePath
            // 
            this.SDVMPFilePath.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SDVMPFilePath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SDVMPFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.SDVMPFilePath.Location = new System.Drawing.Point(5, 6);
            this.SDVMPFilePath.Name = "SDVMPFilePath";
            this.SDVMPFilePath.ReadOnly = true;
            this.SDVMPFilePath.Size = new System.Drawing.Size(286, 14);
            this.SDVMPFilePath.TabIndex = 8;
            // 
            // OuputConsole
            // 
            this.OuputConsole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.OuputConsole.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OuputConsole.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OuputConsole.ForeColor = System.Drawing.Color.White;
            this.OuputConsole.Location = new System.Drawing.Point(15, 220);
            this.OuputConsole.Name = "OuputConsole";
            this.OuputConsole.ReadOnly = true;
            this.OuputConsole.Size = new System.Drawing.Size(492, 323);
            this.OuputConsole.TabIndex = 9;
            this.OuputConsole.Text = "Stardew Valley Modded Framework\n(C) Copyright 2022 - Ryan Walpole Enterprises, Cr" +
    "utionix Media Group\nModpack Installation Utility\n\n[INFO] Installer Ready.";
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
            this.ProgressBar.Location = new System.Drawing.Point(15, 550);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(492, 13);
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
            this.pictureBox1.Image = global::Stardew_Mod_Manager.Properties.Resources.ModpackInstall;
            this.pictureBox1.Location = new System.Drawing.Point(15, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // Browse
            // 
            this.Browse.AccessibleName = "Button";
            this.Browse.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.Browse.Location = new System.Drawing.Point(315, 175);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(96, 26);
            this.Browse.TabIndex = 16;
            this.Browse.Text = "Browse";
            this.Browse.Click += new System.EventHandler(this.Browse_Click);
            // 
            // Install
            // 
            this.Install.AccessibleName = "Button";
            this.Install.Enabled = false;
            this.Install.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.Install.Location = new System.Drawing.Point(413, 175);
            this.Install.Name = "Install";
            this.Install.Size = new System.Drawing.Size(94, 26);
            this.Install.TabIndex = 17;
            this.Install.Text = "Install";
            this.Install.Click += new System.EventHandler(this.Install_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.SDVMPFilePath);
            this.panel1.Location = new System.Drawing.Point(15, 175);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(296, 26);
            this.panel1.TabIndex = 18;
            // 
            // PackInstaller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 590);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Install);
            this.Controls.Add(this.Browse);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.OuputConsole);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.verSMAPIReq);
            this.Controls.Add(this.verSMAPI);
            this.Controls.Add(this.ConfigFile);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(535, 629);
            this.MinimumSize = new System.Drawing.Size(535, 629);
            this.Name = "PackInstaller";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Style.MdiChild.IconHorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Style.MdiChild.IconVerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
            this.Style.TitleBar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Text = "Install Modpack | Stardew Valley Modded Framework";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SDVMPFilePath;
        private System.Windows.Forms.RichTextBox OuputConsole;
        private System.Windows.Forms.RichTextBox ConfigFile;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.Timer ModsTimer;
        private System.Windows.Forms.Timer ExtractTimer;
        private System.Windows.Forms.TextBox verSMAPI;
        private System.Windows.Forms.TextBox verSMAPIReq;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Syncfusion.WinForms.Controls.SfButton Browse;
        private Syncfusion.WinForms.Controls.SfButton Install;
        private System.Windows.Forms.Panel panel1;
    }
}