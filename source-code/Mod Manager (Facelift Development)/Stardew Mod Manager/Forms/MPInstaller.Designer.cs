﻿namespace Stardew_Mod_Manager.Forms
{
    partial class MPInstaller
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MPInstaller));
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ModsToDisable = new System.Windows.Forms.ListBox();
            this.ModsToInstall = new System.Windows.Forms.ListBox();
            this.OverwriteMods = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ExtractProgress = new System.Windows.Forms.ProgressBar();
            this.Cancel = new System.Windows.Forms.Button();
            this.Continue = new System.Windows.Forms.Button();
            this.DoModInstall = new System.ComponentModel.BackgroundWorker();
            this.PresetGenerator = new System.Windows.Forms.RichTextBox();
            this.DoMovementOperation = new System.Windows.Forms.Timer(this.components);
            this.DoModDelete = new System.ComponentModel.BackgroundWorker();
            this.ErrorLog = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label4.Location = new System.Drawing.Point(12, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "The following mods will be installed:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Stardew_Mod_Manager.Properties.Resources.SDVMPIcon;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // ModsToDisable
            // 
            this.ModsToDisable.FormattingEnabled = true;
            this.ModsToDisable.Location = new System.Drawing.Point(24, 39);
            this.ModsToDisable.Name = "ModsToDisable";
            this.ModsToDisable.Size = new System.Drawing.Size(48, 17);
            this.ModsToDisable.TabIndex = 34;
            // 
            // ModsToInstall
            // 
            this.ModsToInstall.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ModsToInstall.FormattingEnabled = true;
            this.ModsToInstall.Location = new System.Drawing.Point(11, 122);
            this.ModsToInstall.Name = "ModsToInstall";
            this.ModsToInstall.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.ModsToInstall.Size = new System.Drawing.Size(384, 95);
            this.ModsToInstall.TabIndex = 35;
            // 
            // OverwriteMods
            // 
            this.OverwriteMods.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.OverwriteMods.FormattingEnabled = true;
            this.OverwriteMods.Location = new System.Drawing.Point(11, 267);
            this.OverwriteMods.Name = "OverwriteMods";
            this.OverwriteMods.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.OverwriteMods.Size = new System.Drawing.Size(384, 95);
            this.OverwriteMods.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label2.Location = new System.Drawing.Point(12, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(381, 36);
            this.label2.TabIndex = 30;
            this.label2.Text = "The following mods that you already have installed will be overwritten by the ver" +
    "sion of the mod included in this modpack:";
            // 
            // ExtractProgress
            // 
            this.ExtractProgress.Location = new System.Drawing.Point(11, 381);
            this.ExtractProgress.Name = "ExtractProgress";
            this.ExtractProgress.Size = new System.Drawing.Size(384, 23);
            this.ExtractProgress.Step = 50;
            this.ExtractProgress.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.ExtractProgress.TabIndex = 39;
            this.ExtractProgress.Visible = false;
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(208, 381);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(73, 23);
            this.Cancel.TabIndex = 38;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Continue
            // 
            this.Continue.Location = new System.Drawing.Point(287, 381);
            this.Continue.Name = "Continue";
            this.Continue.Size = new System.Drawing.Size(108, 23);
            this.Continue.TabIndex = 37;
            this.Continue.Text = "Continue";
            this.Continue.UseVisualStyleBackColor = true;
            this.Continue.Click += new System.EventHandler(this.MPInstaller_Click);
            // 
            // DoModInstall
            // 
            this.DoModInstall.WorkerReportsProgress = true;
            this.DoModInstall.DoWork += new System.ComponentModel.DoWorkEventHandler(this.DoModInstall_DoWork);
            this.DoModInstall.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.DoModInstall_ProgressChanged);
            this.DoModInstall.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.DoModInstall_RunWorkerCompleted);
            // 
            // PresetGenerator
            // 
            this.PresetGenerator.Location = new System.Drawing.Point(24, 45);
            this.PresetGenerator.Name = "PresetGenerator";
            this.PresetGenerator.Size = new System.Drawing.Size(22, 11);
            this.PresetGenerator.TabIndex = 40;
            this.PresetGenerator.Text = "";
            // 
            // DoMovementOperation
            // 
            this.DoMovementOperation.Interval = 11000;
            this.DoMovementOperation.Tick += new System.EventHandler(this.DoMovementOperation_Tick);
            // 
            // DoModDelete
            // 
            this.DoModDelete.WorkerReportsProgress = true;
            this.DoModDelete.DoWork += new System.ComponentModel.DoWorkEventHandler(this.DoModDelete_DoWork);
            this.DoModDelete.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.DoModDelete_ProgressChanged);
            this.DoModDelete.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.DoModDelete_RunWorkerCompleted);
            // 
            // ErrorLog
            // 
            this.ErrorLog.Location = new System.Drawing.Point(12, 12);
            this.ErrorLog.Name = "ErrorLog";
            this.ErrorLog.Size = new System.Drawing.Size(71, 70);
            this.ErrorLog.TabIndex = 41;
            this.ErrorLog.Text = "";
            this.ErrorLog.Visible = false;
            // 
            // MPInstaller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(409, 428);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PresetGenerator);
            this.Controls.Add(this.ExtractProgress);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Continue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OverwriteMods);
            this.Controls.Add(this.ModsToInstall);
            this.Controls.Add(this.ModsToDisable);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ErrorLog);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(425, 467);
            this.MinimumSize = new System.Drawing.Size(425, 467);
            this.Name = "MPInstaller";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Install Modpack - Stardew Valley Mod Manager";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MPInstaller_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox ModsToDisable;
        private System.Windows.Forms.ListBox OverwriteMods;
        private System.Windows.Forms.ListBox ModsToInstall;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar ExtractProgress;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Continue;
        private System.ComponentModel.BackgroundWorker DoModInstall;
        private System.Windows.Forms.RichTextBox PresetGenerator;
        private System.Windows.Forms.Timer DoMovementOperation;
        private System.ComponentModel.BackgroundWorker DoModDelete;
        private System.Windows.Forms.RichTextBox ErrorLog;
    }
}