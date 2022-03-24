
namespace Stardew_Mod_Manager
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.InstalledModsList = new System.Windows.Forms.ListBox();
            this.AvailableModsList = new System.Windows.Forms.ListBox();
            this.DisableMod = new System.Windows.Forms.Button();
            this.EnableMod = new System.Windows.Forms.Button();
            this.ModFolderPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SavePreset = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.LoadPreset = new System.Windows.Forms.Button();
            this.DeleteMod = new System.Windows.Forms.Button();
            this.SMAPIWarning = new System.Windows.Forms.Panel();
            this.SMAPIDownload = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.SMAPIVer = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.RefreshPanel = new System.Windows.Forms.Panel();
            this.CloseRefreshPanel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SoftVer = new System.Windows.Forms.Label();
            this.UpdateCheckLabel = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SettingsLink = new System.Windows.Forms.LinkLabel();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.Tab_ModManagement = new System.Windows.Forms.TabPage();
            this.ModManageToolstrip = new System.Windows.Forms.ToolStrip();
            this.InstallModToolstrip = new System.Windows.Forms.ToolStripDropDownButton();
            this.addNewModzipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.installModpackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CheckModUpdates = new System.Windows.Forms.ToolStripButton();
            this.Tab_SaveFileManagement = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.OpenSavesButton = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.DeleteFarmButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.GameSavesList = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ViewSMAPIBackups = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.ViewBackupsButton = new System.Windows.Forms.Button();
            this.MakeBackupButton = new System.Windows.Forms.Button();
            this.SMAPIWarning.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.RefreshPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.Tab_ModManagement.SuspendLayout();
            this.ModManageToolstrip.SuspendLayout();
            this.Tab_SaveFileManagement.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // InstalledModsList
            // 
            this.InstalledModsList.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.InstalledModsList.FormattingEnabled = true;
            this.InstalledModsList.ItemHeight = 15;
            this.InstalledModsList.Location = new System.Drawing.Point(18, 70);
            this.InstalledModsList.Name = "InstalledModsList";
            this.InstalledModsList.Size = new System.Drawing.Size(200, 274);
            this.InstalledModsList.TabIndex = 0;
            this.InstalledModsList.Click += new System.EventHandler(this.InstalledModsList_Click);
            // 
            // AvailableModsList
            // 
            this.AvailableModsList.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.AvailableModsList.FormattingEnabled = true;
            this.AvailableModsList.ItemHeight = 15;
            this.AvailableModsList.Location = new System.Drawing.Point(326, 70);
            this.AvailableModsList.Name = "AvailableModsList";
            this.AvailableModsList.Size = new System.Drawing.Size(200, 274);
            this.AvailableModsList.TabIndex = 1;
            this.AvailableModsList.Click += new System.EventHandler(this.AvailableModsList_Click);
            this.AvailableModsList.SelectedIndexChanged += new System.EventHandler(this.AvailableModsList_SelectedIndexChanged);
            // 
            // DisableMod
            // 
            this.DisableMod.Enabled = false;
            this.DisableMod.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.DisableMod.Location = new System.Drawing.Point(234, 183);
            this.DisableMod.Name = "DisableMod";
            this.DisableMod.Size = new System.Drawing.Size(75, 49);
            this.DisableMod.TabIndex = 2;
            this.DisableMod.Text = "->\r\nDisable";
            this.DisableMod.UseVisualStyleBackColor = true;
            this.DisableMod.Click += new System.EventHandler(this.DisableMod_Click);
            // 
            // EnableMod
            // 
            this.EnableMod.Enabled = false;
            this.EnableMod.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.EnableMod.Location = new System.Drawing.Point(234, 125);
            this.EnableMod.Name = "EnableMod";
            this.EnableMod.Size = new System.Drawing.Size(75, 49);
            this.EnableMod.TabIndex = 3;
            this.EnableMod.Text = "<-\r\nEnable";
            this.EnableMod.UseVisualStyleBackColor = true;
            this.EnableMod.Click += new System.EventHandler(this.EnableMod_Click);
            // 
            // ModFolderPath
            // 
            this.ModFolderPath.Location = new System.Drawing.Point(38, 12);
            this.ModFolderPath.Name = "ModFolderPath";
            this.ModFolderPath.Size = new System.Drawing.Size(455, 20);
            this.ModFolderPath.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(14, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enabled Mods";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(322, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Disabled Mods";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SavePreset
            // 
            this.SavePreset.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.SavePreset.Location = new System.Drawing.Point(234, 242);
            this.SavePreset.Name = "SavePreset";
            this.SavePreset.Size = new System.Drawing.Size(75, 47);
            this.SavePreset.TabIndex = 8;
            this.SavePreset.Text = "Save\r\nPreset";
            this.SavePreset.UseVisualStyleBackColor = true;
            this.SavePreset.Click += new System.EventHandler(this.SavePreset_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 85);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(85, 22);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // LoadPreset
            // 
            this.LoadPreset.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.LoadPreset.Location = new System.Drawing.Point(234, 70);
            this.LoadPreset.Name = "LoadPreset";
            this.LoadPreset.Size = new System.Drawing.Size(75, 47);
            this.LoadPreset.TabIndex = 10;
            this.LoadPreset.Text = "Load\r\nPreset";
            this.LoadPreset.UseVisualStyleBackColor = true;
            this.LoadPreset.Click += new System.EventHandler(this.LoadPreset_Click);
            // 
            // DeleteMod
            // 
            this.DeleteMod.Enabled = false;
            this.DeleteMod.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.DeleteMod.Location = new System.Drawing.Point(234, 298);
            this.DeleteMod.Name = "DeleteMod";
            this.DeleteMod.Size = new System.Drawing.Size(75, 46);
            this.DeleteMod.TabIndex = 13;
            this.DeleteMod.Text = "Delete\r\nMod";
            this.DeleteMod.UseVisualStyleBackColor = true;
            this.DeleteMod.Click += new System.EventHandler(this.DeleteMod_Click);
            // 
            // SMAPIWarning
            // 
            this.SMAPIWarning.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SMAPIWarning.Controls.Add(this.SMAPIDownload);
            this.SMAPIWarning.Controls.Add(this.label3);
            this.SMAPIWarning.Controls.Add(this.pictureBox2);
            this.SMAPIWarning.Location = new System.Drawing.Point(25, 54);
            this.SMAPIWarning.Name = "SMAPIWarning";
            this.SMAPIWarning.Size = new System.Drawing.Size(490, 52);
            this.SMAPIWarning.TabIndex = 14;
            this.SMAPIWarning.Visible = false;
            // 
            // SMAPIDownload
            // 
            this.SMAPIDownload.ActiveLinkColor = System.Drawing.Color.White;
            this.SMAPIDownload.AutoSize = true;
            this.SMAPIDownload.LinkColor = System.Drawing.Color.White;
            this.SMAPIDownload.Location = new System.Drawing.Point(326, 28);
            this.SMAPIDownload.Name = "SMAPIDownload";
            this.SMAPIDownload.Size = new System.Drawing.Size(142, 13);
            this.SMAPIDownload.TabIndex = 2;
            this.SMAPIDownload.TabStop = true;
            this.SMAPIDownload.Text = "Download and Install SMAPI";
            this.SMAPIDownload.VisitedLinkColor = System.Drawing.Color.White;
            this.SMAPIDownload.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SMAPIDownload_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(72, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(399, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "SMAPI was not found on your system. SMAPI is required in order to play with Mods." +
    "";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Stardew_Mod_Manager.Properties.Resources.icon_attention;
            this.pictureBox2.Location = new System.Drawing.Point(4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(62, 42);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // SMAPIVer
            // 
            this.SMAPIVer.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.SMAPIVer.Location = new System.Drawing.Point(333, 16);
            this.SMAPIVer.Name = "SMAPIVer";
            this.SMAPIVer.Size = new System.Drawing.Size(222, 13);
            this.SMAPIVer.TabIndex = 15;
            this.SMAPIVer.Text = "SMAPI 0.0.0";
            this.SMAPIVer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SMAPIVer.Click += new System.EventHandler(this.SMAPIVer_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::Stardew_Mod_Manager.Properties.Resources.sdvbg1;
            this.pictureBox1.Location = new System.Drawing.Point(-15, -82);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(570, 242);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // RefreshPanel
            // 
            this.RefreshPanel.AllowDrop = true;
            this.RefreshPanel.Controls.Add(this.CloseRefreshPanel);
            this.RefreshPanel.Controls.Add(this.label4);
            this.RefreshPanel.Enabled = false;
            this.RefreshPanel.Location = new System.Drawing.Point(3, 31);
            this.RefreshPanel.Name = "RefreshPanel";
            this.RefreshPanel.Size = new System.Drawing.Size(538, 327);
            this.RefreshPanel.TabIndex = 16;
            this.RefreshPanel.Visible = false;
            // 
            // CloseRefreshPanel
            // 
            this.CloseRefreshPanel.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.CloseRefreshPanel.Image = global::Stardew_Mod_Manager.Properties.Resources.sdvrefresh;
            this.CloseRefreshPanel.Location = new System.Drawing.Point(198, 119);
            this.CloseRefreshPanel.Name = "CloseRefreshPanel";
            this.CloseRefreshPanel.Size = new System.Drawing.Size(127, 103);
            this.CloseRefreshPanel.TabIndex = 18;
            this.CloseRefreshPanel.Text = "Refresh";
            this.CloseRefreshPanel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.CloseRefreshPanel.UseVisualStyleBackColor = true;
            this.CloseRefreshPanel.Click += new System.EventHandler(this.CloseRefreshPanel_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(38, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(448, 60);
            this.label4.TabIndex = 17;
            this.label4.Text = "Finished Installing Mods?";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SoftVer
            // 
            this.SoftVer.AutoSize = true;
            this.SoftVer.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.SoftVer.Location = new System.Drawing.Point(80, 16);
            this.SoftVer.Name = "SoftVer";
            this.SoftVer.Size = new System.Drawing.Size(49, 13);
            this.SoftVer.TabIndex = 17;
            this.SoftVer.Text = "v220909";
            // 
            // UpdateCheckLabel
            // 
            this.UpdateCheckLabel.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
            this.UpdateCheckLabel.AutoSize = true;
            this.UpdateCheckLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.UpdateCheckLabel.Location = new System.Drawing.Point(135, 16);
            this.UpdateCheckLabel.Name = "UpdateCheckLabel";
            this.UpdateCheckLabel.Size = new System.Drawing.Size(96, 13);
            this.UpdateCheckLabel.TabIndex = 18;
            this.UpdateCheckLabel.TabStop = true;
            this.UpdateCheckLabel.Text = "Check for Updates";
            this.UpdateCheckLabel.VisitedLinkColor = System.Drawing.Color.Blue;
            this.UpdateCheckLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.UpdateCheckLabel_LinkClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SettingsLink);
            this.groupBox1.Controls.Add(this.UpdateCheckLabel);
            this.groupBox1.Controls.Add(this.SMAPIVer);
            this.groupBox1.Controls.Add(this.SoftVer);
            this.groupBox1.Location = new System.Drawing.Point(-71, 546);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(626, 39);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // SettingsLink
            // 
            this.SettingsLink.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
            this.SettingsLink.AutoSize = true;
            this.SettingsLink.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.SettingsLink.Location = new System.Drawing.Point(560, 16);
            this.SettingsLink.Name = "SettingsLink";
            this.SettingsLink.Size = new System.Drawing.Size(45, 13);
            this.SettingsLink.TabIndex = 19;
            this.SettingsLink.TabStop = true;
            this.SettingsLink.Text = "Settings";
            this.SettingsLink.VisitedLinkColor = System.Drawing.Color.Blue;
            this.SettingsLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SettingsLink_LinkClicked);
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.Tab_ModManagement);
            this.TabControl.Controls.Add(this.Tab_SaveFileManagement);
            this.TabControl.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabControl.ItemSize = new System.Drawing.Size(149, 30);
            this.TabControl.Location = new System.Drawing.Point(-1, 157);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(555, 402);
            this.TabControl.TabIndex = 20;
            // 
            // Tab_ModManagement
            // 
            this.Tab_ModManagement.Controls.Add(this.ModManageToolstrip);
            this.Tab_ModManagement.Controls.Add(this.RefreshPanel);
            this.Tab_ModManagement.Controls.Add(this.AvailableModsList);
            this.Tab_ModManagement.Controls.Add(this.InstalledModsList);
            this.Tab_ModManagement.Controls.Add(this.DeleteMod);
            this.Tab_ModManagement.Controls.Add(this.DisableMod);
            this.Tab_ModManagement.Controls.Add(this.EnableMod);
            this.Tab_ModManagement.Controls.Add(this.label1);
            this.Tab_ModManagement.Controls.Add(this.LoadPreset);
            this.Tab_ModManagement.Controls.Add(this.label2);
            this.Tab_ModManagement.Controls.Add(this.SavePreset);
            this.Tab_ModManagement.Location = new System.Drawing.Point(4, 34);
            this.Tab_ModManagement.Name = "Tab_ModManagement";
            this.Tab_ModManagement.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_ModManagement.Size = new System.Drawing.Size(547, 364);
            this.Tab_ModManagement.TabIndex = 0;
            this.Tab_ModManagement.Text = "   Mod Management   ";
            this.Tab_ModManagement.UseVisualStyleBackColor = true;
            // 
            // ModManageToolstrip
            // 
            this.ModManageToolstrip.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.ModManageToolstrip.GripMargin = new System.Windows.Forms.Padding(15, 2, 2, 2);
            this.ModManageToolstrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ModManageToolstrip.ImageScalingSize = new System.Drawing.Size(14, 14);
            this.ModManageToolstrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InstallModToolstrip,
            this.CheckModUpdates});
            this.ModManageToolstrip.Location = new System.Drawing.Point(3, 3);
            this.ModManageToolstrip.Name = "ModManageToolstrip";
            this.ModManageToolstrip.Padding = new System.Windows.Forms.Padding(7, 0, 1, 0);
            this.ModManageToolstrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.ModManageToolstrip.Size = new System.Drawing.Size(541, 25);
            this.ModManageToolstrip.TabIndex = 18;
            this.ModManageToolstrip.Text = "toolStrip1";
            // 
            // InstallModToolstrip
            // 
            this.InstallModToolstrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewModzipToolStripMenuItem,
            this.installModpackToolStripMenuItem});
            this.InstallModToolstrip.Image = global::Stardew_Mod_Manager.Properties.Resources.sdv_add;
            this.InstallModToolstrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.InstallModToolstrip.Name = "InstallModToolstrip";
            this.InstallModToolstrip.Size = new System.Drawing.Size(97, 22);
            this.InstallModToolstrip.Text = "Install Mods";
            // 
            // addNewModzipToolStripMenuItem
            // 
            this.addNewModzipToolStripMenuItem.Name = "addNewModzipToolStripMenuItem";
            this.addNewModzipToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.addNewModzipToolStripMenuItem.Text = "Add New Mod (.zip)";
            this.addNewModzipToolStripMenuItem.Click += new System.EventHandler(this.ZipInstall_Click);
            // 
            // installModpackToolStripMenuItem
            // 
            this.installModpackToolStripMenuItem.Name = "installModpackToolStripMenuItem";
            this.installModpackToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.installModpackToolStripMenuItem.Text = "Install Modpack";
            this.installModpackToolStripMenuItem.Click += new System.EventHandler(this.PackInstall_Click);
            // 
            // CheckModUpdates
            // 
            this.CheckModUpdates.Image = global::Stardew_Mod_Manager.Properties.Resources.sdv_updatecheck;
            this.CheckModUpdates.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CheckModUpdates.Margin = new System.Windows.Forms.Padding(10, 1, 0, 2);
            this.CheckModUpdates.Name = "CheckModUpdates";
            this.CheckModUpdates.Size = new System.Drawing.Size(178, 22);
            this.CheckModUpdates.Text = "Check for Mod Updates [Beta]";
            this.CheckModUpdates.Click += new System.EventHandler(this.CheckModUpdates_Click);
            // 
            // Tab_SaveFileManagement
            // 
            this.Tab_SaveFileManagement.Controls.Add(this.groupBox3);
            this.Tab_SaveFileManagement.Controls.Add(this.label5);
            this.Tab_SaveFileManagement.Controls.Add(this.GameSavesList);
            this.Tab_SaveFileManagement.Controls.Add(this.groupBox2);
            this.Tab_SaveFileManagement.Location = new System.Drawing.Point(4, 34);
            this.Tab_SaveFileManagement.Name = "Tab_SaveFileManagement";
            this.Tab_SaveFileManagement.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_SaveFileManagement.Size = new System.Drawing.Size(547, 364);
            this.Tab_SaveFileManagement.TabIndex = 1;
            this.Tab_SaveFileManagement.Text = "   Game Save Management   ";
            this.Tab_SaveFileManagement.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.OpenSavesButton);
            this.groupBox3.Controls.Add(this.pictureBox4);
            this.groupBox3.Controls.Add(this.DeleteFarmButton);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(259, 215);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(265, 113);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Management";
            // 
            // OpenSavesButton
            // 
            this.OpenSavesButton.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.OpenSavesButton.Location = new System.Drawing.Point(14, 53);
            this.OpenSavesButton.Name = "OpenSavesButton";
            this.OpenSavesButton.Size = new System.Drawing.Size(146, 23);
            this.OpenSavesButton.TabIndex = 13;
            this.OpenSavesButton.Text = "Open Saves Folder";
            this.OpenSavesButton.UseVisualStyleBackColor = true;
            this.OpenSavesButton.Click += new System.EventHandler(this.OpenSavesButton_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Stardew_Mod_Manager.Properties.Resources.sdvEdit;
            this.pictureBox4.Location = new System.Drawing.Point(182, 14);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(69, 93);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            // 
            // DeleteFarmButton
            // 
            this.DeleteFarmButton.Enabled = false;
            this.DeleteFarmButton.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.DeleteFarmButton.Location = new System.Drawing.Point(14, 24);
            this.DeleteFarmButton.Name = "DeleteFarmButton";
            this.DeleteFarmButton.Size = new System.Drawing.Size(146, 23);
            this.DeleteFarmButton.TabIndex = 12;
            this.DeleteFarmButton.Text = "Delete Farm";
            this.DeleteFarmButton.UseVisualStyleBackColor = true;
            this.DeleteFarmButton.Click += new System.EventHandler(this.DeleteFarmButton_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(14, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "My Farms";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GameSavesList
            // 
            this.GameSavesList.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.GameSavesList.FormattingEnabled = true;
            this.GameSavesList.ItemHeight = 15;
            this.GameSavesList.Location = new System.Drawing.Point(18, 69);
            this.GameSavesList.Name = "GameSavesList";
            this.GameSavesList.Size = new System.Drawing.Size(223, 259);
            this.GameSavesList.TabIndex = 0;
            this.GameSavesList.SelectedValueChanged += new System.EventHandler(this.GameSavesList_SelectedValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ViewSMAPIBackups);
            this.groupBox2.Controls.Add(this.pictureBox3);
            this.groupBox2.Controls.Add(this.ViewBackupsButton);
            this.groupBox2.Controls.Add(this.MakeBackupButton);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(259, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(265, 132);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Backups";
            // 
            // ViewSMAPIBackups
            // 
            this.ViewSMAPIBackups.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.ViewSMAPIBackups.Location = new System.Drawing.Point(14, 87);
            this.ViewSMAPIBackups.Name = "ViewSMAPIBackups";
            this.ViewSMAPIBackups.Size = new System.Drawing.Size(146, 23);
            this.ViewSMAPIBackups.TabIndex = 12;
            this.ViewSMAPIBackups.Text = "View SMAPI Backups";
            this.ViewSMAPIBackups.UseVisualStyleBackColor = true;
            this.ViewSMAPIBackups.Click += new System.EventHandler(this.ViewSMAPIBackups_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Stardew_Mod_Manager.Properties.Resources.sdvBackups;
            this.pictureBox3.Location = new System.Drawing.Point(182, 29);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(69, 81);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // ViewBackupsButton
            // 
            this.ViewBackupsButton.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.ViewBackupsButton.Location = new System.Drawing.Point(14, 58);
            this.ViewBackupsButton.Name = "ViewBackupsButton";
            this.ViewBackupsButton.Size = new System.Drawing.Size(146, 23);
            this.ViewBackupsButton.TabIndex = 9;
            this.ViewBackupsButton.Text = "View Farm Backups";
            this.ViewBackupsButton.UseVisualStyleBackColor = true;
            this.ViewBackupsButton.Click += new System.EventHandler(this.ViewBackupsButton_Click);
            // 
            // MakeBackupButton
            // 
            this.MakeBackupButton.Enabled = false;
            this.MakeBackupButton.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.MakeBackupButton.Location = new System.Drawing.Point(14, 29);
            this.MakeBackupButton.Name = "MakeBackupButton";
            this.MakeBackupButton.Size = new System.Drawing.Size(146, 23);
            this.MakeBackupButton.TabIndex = 8;
            this.MakeBackupButton.Text = "Backup Selected Farm";
            this.MakeBackupButton.UseVisualStyleBackColor = true;
            this.MakeBackupButton.Click += new System.EventHandler(this.MakeBackupButton_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 581);
            this.Controls.Add(this.SMAPIWarning);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ModFolderPath);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(562, 1000);
            this.MinimumSize = new System.Drawing.Size(562, 100);
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mod Manager | Stardew Valley Modded Framework";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainPage_FormClosed);
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.SMAPIWarning.ResumeLayout(false);
            this.SMAPIWarning.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.RefreshPanel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.TabControl.ResumeLayout(false);
            this.Tab_ModManagement.ResumeLayout(false);
            this.Tab_ModManagement.PerformLayout();
            this.ModManageToolstrip.ResumeLayout(false);
            this.ModManageToolstrip.PerformLayout();
            this.Tab_SaveFileManagement.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox InstalledModsList;
        private System.Windows.Forms.ListBox AvailableModsList;
        private System.Windows.Forms.Button DisableMod;
        private System.Windows.Forms.Button EnableMod;
        private System.Windows.Forms.TextBox ModFolderPath;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SavePreset;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button LoadPreset;
        private System.Windows.Forms.Button DeleteMod;
        private System.Windows.Forms.Panel SMAPIWarning;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.LinkLabel SMAPIDownload;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label SMAPIVer;
        private System.Windows.Forms.Panel RefreshPanel;
        private System.Windows.Forms.Button CloseRefreshPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label SoftVer;
        private System.Windows.Forms.LinkLabel UpdateCheckLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel SettingsLink;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage Tab_ModManagement;
        private System.Windows.Forms.TabPage Tab_SaveFileManagement;
        private System.Windows.Forms.ListBox GameSavesList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button ViewBackupsButton;
        private System.Windows.Forms.Button MakeBackupButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button DeleteFarmButton;
        private System.Windows.Forms.Button OpenSavesButton;
        private System.Windows.Forms.Button ViewSMAPIBackups;
        private System.Windows.Forms.ToolStrip ModManageToolstrip;
        private System.Windows.Forms.ToolStripDropDownButton InstallModToolstrip;
        private System.Windows.Forms.ToolStripMenuItem addNewModzipToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem installModpackToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton CheckModUpdates;
    }
}