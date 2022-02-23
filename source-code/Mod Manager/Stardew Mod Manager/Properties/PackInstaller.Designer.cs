
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PackInstaller));
            this.Browse = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SDVMPFilePath = new System.Windows.Forms.TextBox();
            this.OuputConsole = new System.Windows.Forms.RichTextBox();
            this.Install = new System.Windows.Forms.Button();
            this.ConfigFile = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Browse
            // 
            this.Browse.Location = new System.Drawing.Point(279, 190);
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
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(423, 82);
            this.label2.TabIndex = 6;
            this.label2.Text = resources.GetString("label2.Text");
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(446, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Install Modpack";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(12, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(446, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Select a SDVMP File:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SDVMPFilePath
            // 
            this.SDVMPFilePath.Location = new System.Drawing.Point(15, 192);
            this.SDVMPFilePath.Name = "SDVMPFilePath";
            this.SDVMPFilePath.ReadOnly = true;
            this.SDVMPFilePath.Size = new System.Drawing.Size(258, 20);
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
            this.OuputConsole.Size = new System.Drawing.Size(420, 302);
            this.OuputConsole.TabIndex = 9;
            this.OuputConsole.Text = "Installer Ready";
            // 
            // Install
            // 
            this.Install.Enabled = false;
            this.Install.Location = new System.Drawing.Point(360, 190);
            this.Install.Name = "Install";
            this.Install.Size = new System.Drawing.Size(75, 23);
            this.Install.TabIndex = 10;
            this.Install.Text = "Install";
            this.Install.UseVisualStyleBackColor = true;
            // 
            // ConfigFile
            // 
            this.ConfigFile.Location = new System.Drawing.Point(279, 21);
            this.ConfigFile.Name = "ConfigFile";
            this.ConfigFile.Size = new System.Drawing.Size(156, 150);
            this.ConfigFile.TabIndex = 11;
            this.ConfigFile.Text = "";
            // 
            // PackInstaller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 563);
            this.Controls.Add(this.ConfigFile);
            this.Controls.Add(this.Install);
            this.Controls.Add(this.OuputConsole);
            this.Controls.Add(this.SDVMPFilePath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Browse);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PackInstaller";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Install Modpack | Stardew Valley Modded Framework";
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
    }
}