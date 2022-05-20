
namespace Stardew_Mod_Manager.Startup
{
    partial class Splash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.Version = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.StartupTimer = new System.Windows.Forms.Timer(this.components);
            this.CheckDirectory = new System.Windows.Forms.Timer(this.components);
            this.LaunchApplication = new System.Windows.Forms.Timer(this.components);
            this.Cleanup = new System.Windows.Forms.Timer(this.components);
            this.FileWrite = new System.Windows.Forms.RichTextBox();
            this.ModpackStarter = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Stardew_Mod_Manager.Properties.Resources.sdvicon;
            this.pictureBox2.Location = new System.Drawing.Point(10, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Stardew_Mod_Manager.Properties.Resources.RWE_Labs_White;
            this.pictureBox1.Location = new System.Drawing.Point(393, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::Stardew_Mod_Manager.Properties.Resources.RWE_Labs_BG;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.Version);
            this.panel1.Controls.Add(this.Status);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-1, 175);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(481, 73);
            this.panel1.TabIndex = 4;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Stardew_Mod_Manager.Properties.Resources.progress_white;
            this.pictureBox4.Location = new System.Drawing.Point(346, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(34, 73);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // Version
            // 
            this.Version.AutoSize = true;
            this.Version.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.Version.ForeColor = System.Drawing.Color.White;
            this.Version.Location = new System.Drawing.Point(12, 37);
            this.Version.Name = "Version";
            this.Version.Size = new System.Drawing.Size(41, 12);
            this.Version.TabIndex = 4;
            this.Version.Text = "v000000";
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.ForeColor = System.Drawing.Color.White;
            this.Status.Location = new System.Drawing.Point(10, 51);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(67, 13);
            this.Status.TabIndex = 3;
            this.Status.Text = "Starting up...";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Stardew_Mod_Manager.Properties.Resources.SDVMM_LogoNoImage;
            this.pictureBox3.Location = new System.Drawing.Point(12, 68);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(389, 91);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // StartupTimer
            // 
            this.StartupTimer.Interval = 1000;
            this.StartupTimer.Tick += new System.EventHandler(this.StartupTimer_Tick);
            // 
            // CheckDirectory
            // 
            this.CheckDirectory.Interval = 3000;
            this.CheckDirectory.Tick += new System.EventHandler(this.CheckDirectory_Tick);
            // 
            // LaunchApplication
            // 
            this.LaunchApplication.Interval = 2000;
            this.LaunchApplication.Tick += new System.EventHandler(this.LaunchApplication_Tick);
            // 
            // Cleanup
            // 
            this.Cleanup.Interval = 1000;
            this.Cleanup.Tick += new System.EventHandler(this.Cleanup_Tick);
            // 
            // FileWrite
            // 
            this.FileWrite.Location = new System.Drawing.Point(392, 12);
            this.FileWrite.Name = "FileWrite";
            this.FileWrite.Size = new System.Drawing.Size(60, 25);
            this.FileWrite.TabIndex = 6;
            this.FileWrite.Text = "";
            this.FileWrite.Visible = false;
            // 
            // ModpackStarter
            // 
            this.ModpackStarter.Interval = 2500;
            this.ModpackStarter.Tick += new System.EventHandler(this.ModpackStarter_Tick);
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(462, 248);
            this.ControlBox = false;
            this.Controls.Add(this.FileWrite);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(478, 287);
            this.MinimumSize = new System.Drawing.Size(478, 287);
            this.Name = "Splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stardew Valley Modded Framework";
            this.Load += new System.EventHandler(this.Splash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label Version;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.Timer StartupTimer;
        private System.Windows.Forms.Timer CheckDirectory;
        private System.Windows.Forms.Timer LaunchApplication;
        private System.Windows.Forms.Timer Cleanup;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.RichTextBox FileWrite;
        private System.Windows.Forms.Timer ModpackStarter;
    }
}