﻿
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirstRunSetup));
            this.Step = new System.Windows.Forms.TabControl();
            this.StepOne = new System.Windows.Forms.TabPage();
            this.StepOneContinue = new Syncfusion.WinForms.Controls.SfButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SubHeading = new System.Windows.Forms.Label();
            this.Heading = new System.Windows.Forms.Label();
            this.StepTwo = new System.Windows.Forms.TabPage();
            this.StepTwoContinue = new Syncfusion.WinForms.Controls.SfButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.IsStardewValidIcon = new System.Windows.Forms.PictureBox();
            this.IsStardewValidText = new System.Windows.Forms.Label();
            this.SDVDirPath = new System.Windows.Forms.TextBox();
            this.IsSMAPIValidIcon = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IsSMAPIValidText = new System.Windows.Forms.Label();
            this.StepThree = new System.Windows.Forms.TabPage();
            this.WhatsNew = new Syncfusion.WinForms.Controls.SfButton();
            this.FinishSetup = new Syncfusion.WinForms.Controls.SfButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.StepSmapi = new System.Windows.Forms.TabPage();
            this.ContinueSMAPI = new Syncfusion.WinForms.Controls.SfButton();
            this.SMAPIToDownload = new System.Windows.Forms.TextBox();
            this.WebDataParsed = new System.Windows.Forms.RichTextBox();
            this.WebData = new System.Windows.Forms.RichTextBox();
            this.SMAPIOpenInstall = new Syncfusion.WinForms.Controls.SfButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.LoadingStep = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.SetupEstablishTimer = new System.Windows.Forms.Timer(this.components);
            this.Step.SuspendLayout();
            this.StepOne.SuspendLayout();
            this.StepTwo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IsStardewValidIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IsSMAPIValidIcon)).BeginInit();
            this.StepThree.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.StepSmapi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.LoadingStep.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // Step
            // 
            this.Step.Controls.Add(this.StepOne);
            this.Step.Controls.Add(this.StepTwo);
            this.Step.Controls.Add(this.StepThree);
            this.Step.Controls.Add(this.StepSmapi);
            this.Step.Controls.Add(this.LoadingStep);
            this.Step.Location = new System.Drawing.Point(-9, -25);
            this.Step.Name = "Step";
            this.Step.SelectedIndex = 0;
            this.Step.Size = new System.Drawing.Size(612, 634);
            this.Step.TabIndex = 9;
            this.Step.SelectedIndexChanged += new System.EventHandler(this.Step_SelectedIndexChanged);
            // 
            // StepOne
            // 
            this.StepOne.BackColor = System.Drawing.Color.White;
            this.StepOne.Controls.Add(this.StepOneContinue);
            this.StepOne.Controls.Add(this.panel1);
            this.StepOne.Controls.Add(this.SubHeading);
            this.StepOne.Controls.Add(this.Heading);
            this.StepOne.Location = new System.Drawing.Point(4, 22);
            this.StepOne.Name = "StepOne";
            this.StepOne.Padding = new System.Windows.Forms.Padding(3);
            this.StepOne.Size = new System.Drawing.Size(604, 608);
            this.StepOne.TabIndex = 0;
            this.StepOne.Text = "StepOne";
            // 
            // StepOneContinue
            // 
            this.StepOneContinue.AccessibleName = "Button";
            this.StepOneContinue.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.StepOneContinue.Location = new System.Drawing.Point(222, 546);
            this.StepOneContinue.Name = "StepOneContinue";
            this.StepOneContinue.Size = new System.Drawing.Size(147, 28);
            this.StepOneContinue.TabIndex = 9;
            this.StepOneContinue.Text = "Continue";
            this.StepOneContinue.Click += new System.EventHandler(this.StepOneContinue_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackgroundImage = global::Stardew_Mod_Manager.Properties.Resources.sdvbg11;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(-5, -12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(603, 351);
            this.panel1.TabIndex = 8;
            // 
            // SubHeading
            // 
            this.SubHeading.Font = new System.Drawing.Font("Segoe UI Semilight", 9.25F);
            this.SubHeading.Location = new System.Drawing.Point(14, 398);
            this.SubHeading.Name = "SubHeading";
            this.SubHeading.Size = new System.Drawing.Size(568, 128);
            this.SubHeading.TabIndex = 7;
            this.SubHeading.Text = resources.GetString("SubHeading.Text");
            this.SubHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Heading
            // 
            this.Heading.Font = new System.Drawing.Font("Segoe UI Semibold", 16.25F);
            this.Heading.Location = new System.Drawing.Point(3, 353);
            this.Heading.Name = "Heading";
            this.Heading.Size = new System.Drawing.Size(590, 43);
            this.Heading.TabIndex = 6;
            this.Heading.Text = "Welcome. Let\'s Get Started";
            this.Heading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StepTwo
            // 
            this.StepTwo.BackColor = System.Drawing.Color.White;
            this.StepTwo.Controls.Add(this.StepTwoContinue);
            this.StepTwo.Controls.Add(this.pictureBox1);
            this.StepTwo.Controls.Add(this.IsStardewValidIcon);
            this.StepTwo.Controls.Add(this.IsStardewValidText);
            this.StepTwo.Controls.Add(this.SDVDirPath);
            this.StepTwo.Controls.Add(this.IsSMAPIValidIcon);
            this.StepTwo.Controls.Add(this.label1);
            this.StepTwo.Controls.Add(this.label2);
            this.StepTwo.Controls.Add(this.IsSMAPIValidText);
            this.StepTwo.Location = new System.Drawing.Point(4, 22);
            this.StepTwo.Name = "StepTwo";
            this.StepTwo.Padding = new System.Windows.Forms.Padding(3);
            this.StepTwo.Size = new System.Drawing.Size(604, 608);
            this.StepTwo.TabIndex = 1;
            this.StepTwo.Text = "StepTwo";
            // 
            // StepTwoContinue
            // 
            this.StepTwoContinue.AccessibleName = "Button";
            this.StepTwoContinue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.StepTwoContinue.FocusRectangleVisible = true;
            this.StepTwoContinue.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.StepTwoContinue.ForeColor = System.Drawing.Color.Black;
            this.StepTwoContinue.Location = new System.Drawing.Point(439, 544);
            this.StepTwoContinue.Name = "StepTwoContinue";
            this.StepTwoContinue.Size = new System.Drawing.Size(130, 28);
            this.StepTwoContinue.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.StepTwoContinue.Style.ForeColor = System.Drawing.Color.Black;
            this.StepTwoContinue.TabIndex = 27;
            this.StepTwoContinue.Text = "Continue";
            this.StepTwoContinue.UseVisualStyleBackColor = false;
            this.StepTwoContinue.Click += new System.EventHandler(this.Continue_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Stardew_Mod_Manager.Properties.Resources.GameDirExample;
            this.pictureBox1.Location = new System.Drawing.Point(-4, -26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(604, 329);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // IsStardewValidIcon
            // 
            this.IsStardewValidIcon.Image = global::Stardew_Mod_Manager.Properties.Resources.sdvError;
            this.IsStardewValidIcon.Location = new System.Drawing.Point(26, 535);
            this.IsStardewValidIcon.Name = "IsStardewValidIcon";
            this.IsStardewValidIcon.Size = new System.Drawing.Size(21, 23);
            this.IsStardewValidIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IsStardewValidIcon.TabIndex = 24;
            this.IsStardewValidIcon.TabStop = false;
            // 
            // IsStardewValidText
            // 
            this.IsStardewValidText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsStardewValidText.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.IsStardewValidText.Location = new System.Drawing.Point(49, 540);
            this.IsStardewValidText.Name = "IsStardewValidText";
            this.IsStardewValidText.Size = new System.Drawing.Size(431, 21);
            this.IsStardewValidText.TabIndex = 22;
            this.IsStardewValidText.Text = "There is not a valid Stardew Valley installation at this directory.";
            // 
            // SDVDirPath
            // 
            this.SDVDirPath.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SDVDirPath.Location = new System.Drawing.Point(26, 495);
            this.SDVDirPath.Name = "SDVDirPath";
            this.SDVDirPath.Size = new System.Drawing.Size(542, 23);
            this.SDVDirPath.TabIndex = 21;
            this.SDVDirPath.TextChanged += new System.EventHandler(this.SDVDirPath_TextChanged);
            // 
            // IsSMAPIValidIcon
            // 
            this.IsSMAPIValidIcon.Image = global::Stardew_Mod_Manager.Properties.Resources.sdvError;
            this.IsSMAPIValidIcon.Location = new System.Drawing.Point(26, 556);
            this.IsSMAPIValidIcon.Name = "IsSMAPIValidIcon";
            this.IsSMAPIValidIcon.Size = new System.Drawing.Size(21, 23);
            this.IsSMAPIValidIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IsSMAPIValidIcon.TabIndex = 26;
            this.IsSMAPIValidIcon.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(21, 323);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(547, 35);
            this.label1.TabIndex = 19;
            this.label1.Text = "Where is your Stardew Valley Installed?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 9.25F);
            this.label2.Location = new System.Drawing.Point(24, 365);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(545, 116);
            this.label2.TabIndex = 20;
            this.label2.Text = resources.GetString("label2.Text");
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IsSMAPIValidText
            // 
            this.IsSMAPIValidText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsSMAPIValidText.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.IsSMAPIValidText.Location = new System.Drawing.Point(49, 560);
            this.IsSMAPIValidText.Name = "IsSMAPIValidText";
            this.IsSMAPIValidText.Size = new System.Drawing.Size(431, 21);
            this.IsSMAPIValidText.TabIndex = 25;
            this.IsSMAPIValidText.Text = "There is not a valid SMAPI installation at this directory.";
            // 
            // StepThree
            // 
            this.StepThree.BackColor = System.Drawing.Color.White;
            this.StepThree.Controls.Add(this.WhatsNew);
            this.StepThree.Controls.Add(this.FinishSetup);
            this.StepThree.Controls.Add(this.label5);
            this.StepThree.Controls.Add(this.label6);
            this.StepThree.Controls.Add(this.pictureBox2);
            this.StepThree.Location = new System.Drawing.Point(4, 22);
            this.StepThree.Name = "StepThree";
            this.StepThree.Padding = new System.Windows.Forms.Padding(3);
            this.StepThree.Size = new System.Drawing.Size(604, 608);
            this.StepThree.TabIndex = 2;
            this.StepThree.Text = "StepThree";
            // 
            // WhatsNew
            // 
            this.WhatsNew.AccessibleName = "Button";
            this.WhatsNew.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.WhatsNew.Location = new System.Drawing.Point(95, 515);
            this.WhatsNew.Name = "WhatsNew";
            this.WhatsNew.Size = new System.Drawing.Size(194, 28);
            this.WhatsNew.TabIndex = 11;
            this.WhatsNew.Text = "What\'s New In This Update";
            this.WhatsNew.Click += new System.EventHandler(this.WhatsNew_Click);
            // 
            // FinishSetup
            // 
            this.FinishSetup.AccessibleName = "Button";
            this.FinishSetup.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.FinishSetup.Location = new System.Drawing.Point(295, 515);
            this.FinishSetup.Name = "FinishSetup";
            this.FinishSetup.Size = new System.Drawing.Size(204, 28);
            this.FinishSetup.TabIndex = 10;
            this.FinishSetup.Text = "Complete Setup";
            this.FinishSetup.Click += new System.EventHandler(this.FinishSetup_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI Semilight", 9.25F);
            this.label5.Location = new System.Drawing.Point(25, 372);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(545, 107);
            this.label5.TabIndex = 9;
            this.label5.Text = resources.GetString("label5.Text");
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 16.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(3, 320);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(585, 35);
            this.label6.TabIndex = 8;
            this.label6.Text = "Ready To Mod?";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Stardew_Mod_Manager.Properties.Resources.sdvbg1;
            this.pictureBox2.Location = new System.Drawing.Point(-129, -33);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(783, 329);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // StepSmapi
            // 
            this.StepSmapi.BackColor = System.Drawing.Color.White;
            this.StepSmapi.Controls.Add(this.ContinueSMAPI);
            this.StepSmapi.Controls.Add(this.SMAPIToDownload);
            this.StepSmapi.Controls.Add(this.WebDataParsed);
            this.StepSmapi.Controls.Add(this.WebData);
            this.StepSmapi.Controls.Add(this.SMAPIOpenInstall);
            this.StepSmapi.Controls.Add(this.label3);
            this.StepSmapi.Controls.Add(this.label4);
            this.StepSmapi.Controls.Add(this.pictureBox3);
            this.StepSmapi.Location = new System.Drawing.Point(4, 22);
            this.StepSmapi.Name = "StepSmapi";
            this.StepSmapi.Size = new System.Drawing.Size(604, 608);
            this.StepSmapi.TabIndex = 3;
            this.StepSmapi.Text = "SMAPI";
            // 
            // ContinueSMAPI
            // 
            this.ContinueSMAPI.AccessibleName = "Button";
            this.ContinueSMAPI.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.ContinueSMAPI.Location = new System.Drawing.Point(164, 494);
            this.ContinueSMAPI.Name = "ContinueSMAPI";
            this.ContinueSMAPI.Size = new System.Drawing.Size(253, 36);
            this.ContinueSMAPI.TabIndex = 16;
            this.ContinueSMAPI.Text = "I\'ve Installed SMAPI";
            this.ContinueSMAPI.Visible = false;
            this.ContinueSMAPI.Click += new System.EventHandler(this.ContinueSMAPI_Click);
            // 
            // SMAPIToDownload
            // 
            this.SMAPIToDownload.Location = new System.Drawing.Point(35, 19);
            this.SMAPIToDownload.Name = "SMAPIToDownload";
            this.SMAPIToDownload.Size = new System.Drawing.Size(100, 20);
            this.SMAPIToDownload.TabIndex = 15;
            this.SMAPIToDownload.Visible = false;
            // 
            // WebDataParsed
            // 
            this.WebDataParsed.Location = new System.Drawing.Point(10, 32);
            this.WebDataParsed.Name = "WebDataParsed";
            this.WebDataParsed.Size = new System.Drawing.Size(19, 16);
            this.WebDataParsed.TabIndex = 14;
            this.WebDataParsed.Text = "";
            this.WebDataParsed.Visible = false;
            // 
            // WebData
            // 
            this.WebData.Location = new System.Drawing.Point(10, 10);
            this.WebData.Name = "WebData";
            this.WebData.Size = new System.Drawing.Size(19, 16);
            this.WebData.TabIndex = 13;
            this.WebData.Text = "";
            this.WebData.Visible = false;
            this.WebData.TextChanged += new System.EventHandler(this.WebData_TextChanged);
            // 
            // SMAPIOpenInstall
            // 
            this.SMAPIOpenInstall.AccessibleName = "Button";
            this.SMAPIOpenInstall.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.SMAPIOpenInstall.Location = new System.Drawing.Point(164, 447);
            this.SMAPIOpenInstall.Name = "SMAPIOpenInstall";
            this.SMAPIOpenInstall.Size = new System.Drawing.Size(253, 36);
            this.SMAPIOpenInstall.Style.DisabledForeColor = System.Drawing.Color.Gray;
            this.SMAPIOpenInstall.TabIndex = 12;
            this.SMAPIOpenInstall.Text = "Install SMAPI";
            this.SMAPIOpenInstall.Click += new System.EventHandler(this.SMAPIOpenInstall_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI Semilight", 9.25F);
            this.label3.Location = new System.Drawing.Point(31, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(535, 143);
            this.label3.TabIndex = 11;
            this.label3.Text = resources.GetString("label3.Text");
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 16.25F);
            this.label4.Location = new System.Drawing.Point(29, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(525, 43);
            this.label4.TabIndex = 10;
            this.label4.Text = "Welcome. Let\'s Get Started";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Stardew_Mod_Manager.Properties.Resources.SMAPILogo1;
            this.pictureBox3.Location = new System.Drawing.Point(-4, 79);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(601, 73);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // LoadingStep
            // 
            this.LoadingStep.BackColor = System.Drawing.Color.White;
            this.LoadingStep.Controls.Add(this.label7);
            this.LoadingStep.Controls.Add(this.label8);
            this.LoadingStep.Controls.Add(this.pictureBox4);
            this.LoadingStep.Location = new System.Drawing.Point(4, 22);
            this.LoadingStep.Name = "LoadingStep";
            this.LoadingStep.Size = new System.Drawing.Size(604, 608);
            this.LoadingStep.TabIndex = 4;
            this.LoadingStep.Text = "tabPage1";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F);
            this.label7.Location = new System.Drawing.Point(26, 371);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(534, 45);
            this.label7.TabIndex = 8;
            this.label7.Text = "We\'re going to do as much as we can for you.\r\nThis may take a minute.\r\n";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F);
            this.label8.Location = new System.Drawing.Point(26, 323);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(534, 43);
            this.label8.TabIndex = 7;
            this.label8.Text = "Please Wait...";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Stardew_Mod_Manager.Properties.Resources.progress_colour;
            this.pictureBox4.Location = new System.Drawing.Point(26, 211);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(534, 85);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // SetupEstablishTimer
            // 
            this.SetupEstablishTimer.Interval = 6000;
            this.SetupEstablishTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FirstRunSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 600);
            this.Controls.Add(this.Step);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(598, 639);
            this.MinimumSize = new System.Drawing.Size(598, 639);
            this.Name = "FirstRunSetup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Style.MdiChild.IconHorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Style.MdiChild.IconVerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
            this.Style.TitleBar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Text = "Get Started - Setup | Stardew Valley Modded Framework";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FirstRunSetup_FormClosed);
            this.Step.ResumeLayout(false);
            this.StepOne.ResumeLayout(false);
            this.StepTwo.ResumeLayout(false);
            this.StepTwo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IsStardewValidIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IsSMAPIValidIcon)).EndInit();
            this.StepThree.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.StepSmapi.ResumeLayout(false);
            this.StepSmapi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.LoadingStep.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Step;
        private System.Windows.Forms.TabPage StepTwo;
        private System.Windows.Forms.TabPage StepThree;
        private System.Windows.Forms.TabPage StepOne;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label SubHeading;
        private System.Windows.Forms.Label Heading;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox IsStardewValidIcon;
        private System.Windows.Forms.Label IsStardewValidText;
        private System.Windows.Forms.TextBox SDVDirPath;
        private System.Windows.Forms.PictureBox IsSMAPIValidIcon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label IsSMAPIValidText;
        private Syncfusion.WinForms.Controls.SfButton StepOneContinue;
        private Syncfusion.WinForms.Controls.SfButton StepTwoContinue;
        private Syncfusion.WinForms.Controls.SfButton FinishSetup;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Syncfusion.WinForms.Controls.SfButton WhatsNew;
        private System.Windows.Forms.TabPage StepSmapi;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Syncfusion.WinForms.Controls.SfButton SMAPIOpenInstall;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox WebData;
        private System.Windows.Forms.RichTextBox WebDataParsed;
        private System.Windows.Forms.TextBox SMAPIToDownload;
        private Syncfusion.WinForms.Controls.SfButton ContinueSMAPI;
        private System.Windows.Forms.TabPage LoadingStep;
        private System.Windows.Forms.Timer SetupEstablishTimer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}