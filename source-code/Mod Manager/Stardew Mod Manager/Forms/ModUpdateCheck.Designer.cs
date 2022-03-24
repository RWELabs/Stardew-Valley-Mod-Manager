
namespace Stardew_Mod_Manager.Forms
{
    partial class ModUpdateCheck
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModUpdateCheck));
            this.Mods = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Check = new System.Windows.Forms.Button();
            this.Manifest = new System.Windows.Forms.RichTextBox();
            this.UpdateKey = new System.Windows.Forms.TextBox();
            this.Ouput = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.WebData = new System.Windows.Forms.RichTextBox();
            this.WebDataParsed = new System.Windows.Forms.RichTextBox();
            this.CurrentVersion = new System.Windows.Forms.TextBox();
            this.UpdateVersion = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Mods
            // 
            this.Mods.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Mods.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Mods.FormattingEnabled = true;
            this.Mods.Location = new System.Drawing.Point(47, 15);
            this.Mods.Name = "Mods";
            this.Mods.Size = new System.Drawing.Size(299, 21);
            this.Mods.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mod";
            // 
            // Check
            // 
            this.Check.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Check.Location = new System.Drawing.Point(352, 14);
            this.Check.Name = "Check";
            this.Check.Size = new System.Drawing.Size(117, 21);
            this.Check.TabIndex = 2;
            this.Check.Text = "Check for Updates";
            this.Check.UseVisualStyleBackColor = true;
            this.Check.Click += new System.EventHandler(this.Check_Click);
            // 
            // Manifest
            // 
            this.Manifest.Location = new System.Drawing.Point(56, 15);
            this.Manifest.Name = "Manifest";
            this.Manifest.Size = new System.Drawing.Size(18, 10);
            this.Manifest.TabIndex = 3;
            this.Manifest.Text = "";
            this.Manifest.Visible = false;
            // 
            // UpdateKey
            // 
            this.UpdateKey.Location = new System.Drawing.Point(80, 16);
            this.UpdateKey.MaxLength = 4;
            this.UpdateKey.Name = "UpdateKey";
            this.UpdateKey.Size = new System.Drawing.Size(50, 20);
            this.UpdateKey.TabIndex = 4;
            this.UpdateKey.Visible = false;
            // 
            // Ouput
            // 
            this.Ouput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Ouput.BackColor = System.Drawing.Color.Black;
            this.Ouput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Ouput.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ouput.ForeColor = System.Drawing.Color.White;
            this.Ouput.Location = new System.Drawing.Point(16, 13);
            this.Ouput.Name = "Ouput";
            this.Ouput.ReadOnly = true;
            this.Ouput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.Ouput.Size = new System.Drawing.Size(470, 190);
            this.Ouput.TabIndex = 5;
            this.Ouput.Text = "Stardew Valley Modded Framework\n(C) Copyright 2022 - Ryan Walpole Enterprises, Cr" +
    "utionix Media Group\nMod Update Check Utility\n\n[INFO] Update Check Ready";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.WebData);
            this.panel1.Controls.Add(this.Ouput);
            this.panel1.Controls.Add(this.WebDataParsed);
            this.panel1.Controls.Add(this.CurrentVersion);
            this.panel1.Controls.Add(this.UpdateVersion);
            this.panel1.Location = new System.Drawing.Point(-4, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(486, 219);
            this.panel1.TabIndex = 6;
            // 
            // WebData
            // 
            this.WebData.Location = new System.Drawing.Point(250, -33);
            this.WebData.Name = "WebData";
            this.WebData.Size = new System.Drawing.Size(79, 13);
            this.WebData.TabIndex = 7;
            this.WebData.Text = "";
            this.WebData.Visible = false;
            // 
            // WebDataParsed
            // 
            this.WebDataParsed.Location = new System.Drawing.Point(199, 67);
            this.WebDataParsed.Name = "WebDataParsed";
            this.WebDataParsed.Size = new System.Drawing.Size(257, 125);
            this.WebDataParsed.TabIndex = 8;
            this.WebDataParsed.Text = "";
            this.WebDataParsed.Visible = false;
            // 
            // CurrentVersion
            // 
            this.CurrentVersion.Location = new System.Drawing.Point(325, 143);
            this.CurrentVersion.Name = "CurrentVersion";
            this.CurrentVersion.Size = new System.Drawing.Size(100, 20);
            this.CurrentVersion.TabIndex = 7;
            this.CurrentVersion.Visible = false;
            // 
            // UpdateVersion
            // 
            this.UpdateVersion.Location = new System.Drawing.Point(325, 117);
            this.UpdateVersion.Name = "UpdateVersion";
            this.UpdateVersion.Size = new System.Drawing.Size(100, 20);
            this.UpdateVersion.TabIndex = 9;
            this.UpdateVersion.Visible = false;
            // 
            // ModUpdateCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 266);
            this.Controls.Add(this.Check);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Mods);
            this.Controls.Add(this.UpdateKey);
            this.Controls.Add(this.Manifest);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(297, 115);
            this.Name = "ModUpdateCheck";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[Beta] Mod Update Check | Stardew Valley Modded Framework";
            this.Load += new System.EventHandler(this.ModUpdateCheck_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Mods;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Check;
        private System.Windows.Forms.RichTextBox Manifest;
        private System.Windows.Forms.TextBox UpdateKey;
        private System.Windows.Forms.RichTextBox Ouput;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox WebData;
        private System.Windows.Forms.RichTextBox WebDataParsed;
        private System.Windows.Forms.TextBox CurrentVersion;
        private System.Windows.Forms.TextBox UpdateVersion;
    }
}