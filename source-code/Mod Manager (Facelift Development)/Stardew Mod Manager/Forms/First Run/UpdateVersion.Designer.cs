namespace Stardew_Mod_Manager.Forms.First_Run
{
    partial class UpdateVersion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateVersion));
            this.FileRead = new System.Windows.Forms.RichTextBox();
            this.ResetManually = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Heading = new System.Windows.Forms.Label();
            this.SubHeading = new System.Windows.Forms.Label();
            this.DoDecision = new System.Windows.Forms.Timer(this.components);
            this.DoMigration = new System.Windows.Forms.Timer(this.components);
            this.DoCleanup = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // FileRead
            // 
            this.FileRead.Location = new System.Drawing.Point(17, 21);
            this.FileRead.Name = "FileRead";
            this.FileRead.Size = new System.Drawing.Size(26, 30);
            this.FileRead.TabIndex = 0;
            this.FileRead.Text = "";
            this.FileRead.Visible = false;
            // 
            // ResetManually
            // 
            this.ResetManually.Location = new System.Drawing.Point(17, 42);
            this.ResetManually.Name = "ResetManually";
            this.ResetManually.Size = new System.Drawing.Size(37, 20);
            this.ResetManually.TabIndex = 2;
            this.ResetManually.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Stardew_Mod_Manager.Properties.Resources.progress_colour;
            this.pictureBox1.Location = new System.Drawing.Point(-7, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(603, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Heading
            // 
            this.Heading.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F);
            this.Heading.Location = new System.Drawing.Point(-7, 198);
            this.Heading.Name = "Heading";
            this.Heading.Size = new System.Drawing.Size(603, 43);
            this.Heading.TabIndex = 4;
            this.Heading.Text = "Please Wait...";
            this.Heading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SubHeading
            // 
            this.SubHeading.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F);
            this.SubHeading.Location = new System.Drawing.Point(-7, 246);
            this.SubHeading.Name = "SubHeading";
            this.SubHeading.Size = new System.Drawing.Size(603, 25);
            this.SubHeading.TabIndex = 5;
            this.SubHeading.Text = "Applying updates. This may take a minute.";
            this.SubHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DoDecision
            // 
            this.DoDecision.Interval = 7000;
            this.DoDecision.Tick += new System.EventHandler(this.DoDecision_Tick);
            // 
            // DoMigration
            // 
            this.DoMigration.Interval = 10000;
            this.DoMigration.Tick += new System.EventHandler(this.DoMigration_Tick);
            // 
            // DoCleanup
            // 
            this.DoCleanup.Interval = 4000;
            this.DoCleanup.Tick += new System.EventHandler(this.DoCleanup_Tick);
            // 
            // UpdateVersion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 335);
            this.ControlBox = false;
            this.Controls.Add(this.FileRead);
            this.Controls.Add(this.SubHeading);
            this.Controls.Add(this.Heading);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ResetManually);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(604, 374);
            this.MinimumSize = new System.Drawing.Size(604, 374);
            this.Name = "UpdateVersion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Style.MdiChild.IconHorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Style.MdiChild.IconVerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
            this.Style.TitleBar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Text = "Applying Update... | Stardew Valley Modded Framework";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox FileRead;
        private System.Windows.Forms.TextBox ResetManually;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Heading;
        private System.Windows.Forms.Label SubHeading;
        private System.Windows.Forms.Timer DoDecision;
        private System.Windows.Forms.Timer DoMigration;
        private System.Windows.Forms.Timer DoCleanup;
    }
}