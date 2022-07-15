
namespace Stardew_Mod_Manager.Forms
{
    partial class UpdateDownload
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateDownload));
            this.Progress = new System.Windows.Forms.ProgressBar();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PercentText = new System.Windows.Forms.Label();
            this.StartExecute = new System.Windows.Forms.Timer(this.components);
            this.CancelCleanup = new System.Windows.Forms.Timer(this.components);
            this.Cancel = new Syncfusion.WinForms.Controls.SfButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // Progress
            // 
            this.Progress.Location = new System.Drawing.Point(14, 142);
            this.Progress.Name = "Progress";
            this.Progress.Size = new System.Drawing.Size(278, 24);
            this.Progress.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(70, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(264, 23);
            this.label6.TabIndex = 32;
            this.label6.Text = "Stardew Valley Mod Manager";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(73, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(287, 16);
            this.label7.TabIndex = 34;
            this.label7.Text = "Downloading update...";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Stardew_Mod_Manager.Properties.Resources.sdvicon;
            this.pictureBox5.Location = new System.Drawing.Point(14, 28);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(50, 50);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox5.TabIndex = 33;
            this.pictureBox5.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(73, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 16);
            this.label1.TabIndex = 35;
            this.label1.Text = "labs.ryanwalpole.com";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PercentText
            // 
            this.PercentText.Location = new System.Drawing.Point(11, 119);
            this.PercentText.Name = "PercentText";
            this.PercentText.Size = new System.Drawing.Size(383, 14);
            this.PercentText.TabIndex = 36;
            this.PercentText.Text = "PercentText";
            // 
            // StartExecute
            // 
            this.StartExecute.Interval = 3000;
            this.StartExecute.Tick += new System.EventHandler(this.StartExecute_Tick);
            // 
            // CancelCleanup
            // 
            this.CancelCleanup.Interval = 4000;
            this.CancelCleanup.Tick += new System.EventHandler(this.CancelCleanup_Tick);
            // 
            // Cancel
            // 
            this.Cancel.AccessibleName = "Button";
            this.Cancel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.Cancel.Location = new System.Drawing.Point(302, 142);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(97, 24);
            this.Cancel.TabIndex = 37;
            this.Cancel.Text = "Cancel";
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // UpdateDownload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 193);
            this.CloseButtonVisible = false;
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.PercentText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.Progress);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UpdateDownload";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Style.MdiChild.IconHorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Style.MdiChild.IconVerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
            this.Text = "Update Software | RWE Labs";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UpdateDownload_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar Progress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label PercentText;
        private System.Windows.Forms.Timer StartExecute;
        private System.Windows.Forms.Timer CancelCleanup;
        private Syncfusion.WinForms.Controls.SfButton Cancel;
    }
}