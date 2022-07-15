namespace Stardew_Mod_Manager.Forms.Error_Log_Viewer
{
    partial class ELViewer
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
            this.ErrorLogContents = new System.Windows.Forms.RichTextBox();
            this.SubmitLogs = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // ErrorLogContents
            // 
            this.ErrorLogContents.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ErrorLogContents.BackColor = System.Drawing.Color.Black;
            this.ErrorLogContents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ErrorLogContents.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorLogContents.ForeColor = System.Drawing.Color.White;
            this.ErrorLogContents.Location = new System.Drawing.Point(12, 38);
            this.ErrorLogContents.Name = "ErrorLogContents";
            this.ErrorLogContents.Size = new System.Drawing.Size(594, 203);
            this.ErrorLogContents.TabIndex = 0;
            this.ErrorLogContents.Text = "";
            // 
            // SubmitLogs
            // 
            this.SubmitLogs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SubmitLogs.AutoSize = true;
            this.SubmitLogs.LinkColor = System.Drawing.SystemColors.AppWorkspace;
            this.SubmitLogs.Location = new System.Drawing.Point(500, 12);
            this.SubmitLogs.Name = "SubmitLogs";
            this.SubmitLogs.Size = new System.Drawing.Size(106, 13);
            this.SubmitLogs.TabIndex = 1;
            this.SubmitLogs.TabStop = true;
            this.SubmitLogs.Text = "Submit to RWE Labs";
            this.SubmitLogs.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SubmitLogs_LinkClicked);
            // 
            // ELViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(618, 253);
            this.Controls.Add(this.SubmitLogs);
            this.Controls.Add(this.ErrorLogContents);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "ELViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Error Log";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ELViewer_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox ErrorLogContents;
        private System.Windows.Forms.LinkLabel SubmitLogs;
    }
}