
namespace Stardew_Mod_Manager
{
    partial class FirstRunSetup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirstRunSetup));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SDVDirPath = new System.Windows.Forms.TextBox();
            this.IsStardewValidText = new System.Windows.Forms.Label();
            this.Continue = new System.Windows.Forms.Button();
            this.IsStardewValidIcon = new System.Windows.Forms.PictureBox();
            this.IsSMAPIValidIcon = new System.Windows.Forms.PictureBox();
            this.IsSMAPIValidText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IsStardewValidIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IsSMAPIValidIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Stardew_Mod_Manager.Properties.Resources.GameDirExample;
            this.pictureBox1.Location = new System.Drawing.Point(-3, -6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(588, 329);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 344);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Get Started";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.label2.Location = new System.Drawing.Point(15, 377);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(545, 110);
            this.label2.TabIndex = 2;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // SDVDirPath
            // 
            this.SDVDirPath.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SDVDirPath.Location = new System.Drawing.Point(17, 506);
            this.SDVDirPath.Name = "SDVDirPath";
            this.SDVDirPath.Size = new System.Drawing.Size(430, 23);
            this.SDVDirPath.TabIndex = 3;
            this.SDVDirPath.TextChanged += new System.EventHandler(this.SDVDirPath_TextChanged);
            // 
            // IsStardewValidText
            // 
            this.IsStardewValidText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsStardewValidText.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.IsStardewValidText.Location = new System.Drawing.Point(40, 540);
            this.IsStardewValidText.Name = "IsStardewValidText";
            this.IsStardewValidText.Size = new System.Drawing.Size(431, 21);
            this.IsStardewValidText.TabIndex = 4;
            this.IsStardewValidText.Text = "There is not a valid Stardew Valley installation at this directory.";
            // 
            // Continue
            // 
            this.Continue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Continue.Location = new System.Drawing.Point(453, 505);
            this.Continue.Name = "Continue";
            this.Continue.Size = new System.Drawing.Size(106, 25);
            this.Continue.TabIndex = 5;
            this.Continue.Text = "Continue";
            this.Continue.UseVisualStyleBackColor = true;
            this.Continue.Click += new System.EventHandler(this.Continue_Click);
            // 
            // IsStardewValidIcon
            // 
            this.IsStardewValidIcon.Image = global::Stardew_Mod_Manager.Properties.Resources.sdvError;
            this.IsStardewValidIcon.Location = new System.Drawing.Point(17, 535);
            this.IsStardewValidIcon.Name = "IsStardewValidIcon";
            this.IsStardewValidIcon.Size = new System.Drawing.Size(21, 23);
            this.IsStardewValidIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IsStardewValidIcon.TabIndex = 6;
            this.IsStardewValidIcon.TabStop = false;
            // 
            // IsSMAPIValidIcon
            // 
            this.IsSMAPIValidIcon.Image = global::Stardew_Mod_Manager.Properties.Resources.sdvError;
            this.IsSMAPIValidIcon.Location = new System.Drawing.Point(17, 556);
            this.IsSMAPIValidIcon.Name = "IsSMAPIValidIcon";
            this.IsSMAPIValidIcon.Size = new System.Drawing.Size(21, 23);
            this.IsSMAPIValidIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IsSMAPIValidIcon.TabIndex = 8;
            this.IsSMAPIValidIcon.TabStop = false;
            // 
            // IsSMAPIValidText
            // 
            this.IsSMAPIValidText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsSMAPIValidText.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.IsSMAPIValidText.Location = new System.Drawing.Point(40, 560);
            this.IsSMAPIValidText.Name = "IsSMAPIValidText";
            this.IsSMAPIValidText.Size = new System.Drawing.Size(431, 21);
            this.IsSMAPIValidText.TabIndex = 7;
            this.IsSMAPIValidText.Text = "There is not a valid SMAPI installation at this directory.";
            // 
            // FirstRunSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 600);
            this.Controls.Add(this.IsStardewValidIcon);
            this.Controls.Add(this.IsSMAPIValidIcon);
            this.Controls.Add(this.IsSMAPIValidText);
            this.Controls.Add(this.Continue);
            this.Controls.Add(this.IsStardewValidText);
            this.Controls.Add(this.SDVDirPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(598, 639);
            this.MinimumSize = new System.Drawing.Size(598, 639);
            this.Name = "FirstRunSetup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Get Started - Setup | Stardew Valley Modded Framework";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FirstRunSetup_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IsStardewValidIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IsSMAPIValidIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SDVDirPath;
        private System.Windows.Forms.Label IsStardewValidText;
        private System.Windows.Forms.Button Continue;
        private System.Windows.Forms.PictureBox IsStardewValidIcon;
        private System.Windows.Forms.PictureBox IsSMAPIValidIcon;
        private System.Windows.Forms.Label IsSMAPIValidText;
    }
}