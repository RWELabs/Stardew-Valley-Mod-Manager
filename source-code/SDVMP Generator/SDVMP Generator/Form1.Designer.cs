
namespace SDVMP_Generator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SDVMPRaw = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ModpackName = new System.Windows.Forms.TextBox();
            this.SMAPIVer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ModsLink = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.PresetLink = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Create = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.LearnMoreLink = new System.Windows.Forms.LinkLabel();
            this.label11 = new System.Windows.Forms.Label();
            this.Cancelquit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create a Modpack";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.label2.Location = new System.Drawing.Point(14, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(390, 51);
            this.label2.TabIndex = 1;
            this.label2.Text = "Use this tool to generate a Stardew Valley Modpack that can be distributed and in" +
    "stalled with just a few clicks using the Stardew Valley Mod Manager";
            // 
            // SDVMPRaw
            // 
            this.SDVMPRaw.Location = new System.Drawing.Point(214, 165);
            this.SDVMPRaw.Name = "SDVMPRaw";
            this.SDVMPRaw.Size = new System.Drawing.Size(22, 10);
            this.SDVMPRaw.TabIndex = 2;
            this.SDVMPRaw.Text = "";
            this.SDVMPRaw.Visible = false;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label3.Location = new System.Drawing.Point(12, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Modpack Name";
            // 
            // ModpackName
            // 
            this.ModpackName.Location = new System.Drawing.Point(130, 159);
            this.ModpackName.Name = "ModpackName";
            this.ModpackName.Size = new System.Drawing.Size(273, 20);
            this.ModpackName.TabIndex = 1;
            // 
            // SMAPIVer
            // 
            this.SMAPIVer.Location = new System.Drawing.Point(130, 187);
            this.SMAPIVer.Name = "SMAPIVer";
            this.SMAPIVer.Size = new System.Drawing.Size(273, 20);
            this.SMAPIVer.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label4.Location = new System.Drawing.Point(12, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "SMAPI Version";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 7.25F, System.Drawing.FontStyle.Italic);
            this.label5.Location = new System.Drawing.Point(128, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(276, 27);
            this.label5.TabIndex = 7;
            this.label5.Text = "The minimum required version of SMAPI to support this modpack.";
            // 
            // ModsLink
            // 
            this.ModsLink.Location = new System.Drawing.Point(129, 250);
            this.ModsLink.Name = "ModsLink";
            this.ModsLink.Size = new System.Drawing.Size(273, 20);
            this.ModsLink.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label6.Location = new System.Drawing.Point(11, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 21);
            this.label6.TabIndex = 8;
            this.label6.Text = "Download Link";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI", 7.25F, System.Drawing.FontStyle.Italic);
            this.label7.Location = new System.Drawing.Point(128, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(276, 27);
            this.label7.TabIndex = 10;
            this.label7.Text = "A link that when clicked begins downloading the zip file containing your mods.";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Segoe UI", 7.25F, System.Drawing.FontStyle.Italic);
            this.label8.Location = new System.Drawing.Point(126, 331);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(276, 19);
            this.label8.TabIndex = 13;
            this.label8.Text = "Optional: A link to an online Presets.txt file for mod presets.";
            // 
            // PresetLink
            // 
            this.PresetLink.Location = new System.Drawing.Point(129, 308);
            this.PresetLink.Name = "PresetLink";
            this.PresetLink.Size = new System.Drawing.Size(273, 20);
            this.PresetLink.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label9.Location = new System.Drawing.Point(13, 305);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 21);
            this.label9.TabIndex = 11;
            this.label9.Text = "Preset Link";
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(291, 371);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(111, 30);
            this.Create.TabIndex = 6;
            this.Create.Text = "Create Modpack";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(13, 121);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 21);
            this.label10.TabIndex = 15;
            this.label10.Text = "Modpack Logic";
            // 
            // LearnMoreLink
            // 
            this.LearnMoreLink.ActiveLinkColor = System.Drawing.Color.Blue;
            this.LearnMoreLink.AutoSize = true;
            this.LearnMoreLink.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.LearnMoreLink.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.LearnMoreLink.Location = new System.Drawing.Point(96, 83);
            this.LearnMoreLink.Name = "LearnMoreLink";
            this.LearnMoreLink.Size = new System.Drawing.Size(67, 15);
            this.LearnMoreLink.TabIndex = 16;
            this.LearnMoreLink.TabStop = true;
            this.LearnMoreLink.Text = "Learn More";
            this.LearnMoreLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LearnMoreLink_LinkClicked);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.DarkGray;
            this.label11.Location = new System.Drawing.Point(14, 380);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Version 220401 (Beta)";
            // 
            // Cancelquit
            // 
            this.Cancelquit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancelquit.Location = new System.Drawing.Point(174, 371);
            this.Cancelquit.Name = "Cancelquit";
            this.Cancelquit.Size = new System.Drawing.Size(111, 30);
            this.Cancelquit.TabIndex = 5;
            this.Cancelquit.Text = "Cancel + Exit";
            this.Cancelquit.UseVisualStyleBackColor = true;
            this.Cancelquit.Click += new System.EventHandler(this.Cancelquit_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.Create;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.Cancelquit;
            this.ClientSize = new System.Drawing.Size(419, 416);
            this.ControlBox = false;
            this.Controls.Add(this.Cancelquit);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.LearnMoreLink);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.PresetLink);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ModsLink);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SMAPIVer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ModpackName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SDVMPRaw);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(435, 455);
            this.MinimumSize = new System.Drawing.Size(435, 455);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modpack Compiler | Stardew Valley Modded Framework";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox SDVMPRaw;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ModpackName;
        private System.Windows.Forms.TextBox SMAPIVer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ModsLink;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox PresetLink;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.LinkLabel LearnMoreLink;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button Cancelquit;
    }
}

