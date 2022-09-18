namespace Stardew_Mod_Manager.Forms.Repair
{
    partial class RepairApplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RepairApplication));
            this.Tabs = new System.Windows.Forms.TabControl();
            this.Repair1 = new System.Windows.Forms.TabPage();
            this.StepOne_Cancel = new System.Windows.Forms.Button();
            this.StepOne_Continue = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Repair2 = new System.Windows.Forms.TabPage();
            this.SkipStepOneRepairs = new System.Windows.Forms.Button();
            this.StartStepOneRepairs = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Repair3 = new System.Windows.Forms.TabPage();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.StatusOutput1 = new System.Windows.Forms.RichTextBox();
            this.MoreThan2RepairFlags = new System.Windows.Forms.TabPage();
            this.FinishRepairFail1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.LessThan2RepairFlags = new System.Windows.Forms.TabPage();
            this.ContinueRepairs = new System.Windows.Forms.Button();
            this.FinishRepairs = new System.Windows.Forms.Button();
            this.LaunchApplication = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.FullRepair = new System.Windows.Forms.TabPage();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.StatusOutput2 = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Repair1Timer = new System.Windows.Forms.Timer(this.components);
            this.Repair2Timer = new System.Windows.Forms.Timer(this.components);
            this.Tabs.SuspendLayout();
            this.Repair1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Repair2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.Repair3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.MoreThan2RepairFlags.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.LessThan2RepairFlags.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.FullRepair.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Tabs
            // 
            this.Tabs.Controls.Add(this.Repair1);
            this.Tabs.Controls.Add(this.Repair2);
            this.Tabs.Controls.Add(this.Repair3);
            this.Tabs.Controls.Add(this.MoreThan2RepairFlags);
            this.Tabs.Controls.Add(this.LessThan2RepairFlags);
            this.Tabs.Controls.Add(this.FullRepair);
            this.Tabs.Location = new System.Drawing.Point(-6, -24);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(513, 352);
            this.Tabs.TabIndex = 0;
            // 
            // Repair1
            // 
            this.Repair1.Controls.Add(this.StepOne_Cancel);
            this.Repair1.Controls.Add(this.StepOne_Continue);
            this.Repair1.Controls.Add(this.label4);
            this.Repair1.Controls.Add(this.label3);
            this.Repair1.Controls.Add(this.label2);
            this.Repair1.Controls.Add(this.label1);
            this.Repair1.Controls.Add(this.pictureBox1);
            this.Repair1.Location = new System.Drawing.Point(4, 22);
            this.Repair1.Name = "Repair1";
            this.Repair1.Padding = new System.Windows.Forms.Padding(3);
            this.Repair1.Size = new System.Drawing.Size(505, 326);
            this.Repair1.TabIndex = 0;
            this.Repair1.Text = "Repair1";
            this.Repair1.UseVisualStyleBackColor = true;
            // 
            // StepOne_Cancel
            // 
            this.StepOne_Cancel.Location = new System.Drawing.Point(249, 258);
            this.StepOne_Cancel.Name = "StepOne_Cancel";
            this.StepOne_Cancel.Size = new System.Drawing.Size(110, 23);
            this.StepOne_Cancel.TabIndex = 11;
            this.StepOne_Cancel.Text = "Cancel";
            this.StepOne_Cancel.UseVisualStyleBackColor = true;
            this.StepOne_Cancel.Click += new System.EventHandler(this.StepOne_Cancel_Click);
            // 
            // StepOne_Continue
            // 
            this.StepOne_Continue.Location = new System.Drawing.Point(365, 258);
            this.StepOne_Continue.Name = "StepOne_Continue";
            this.StepOne_Continue.Size = new System.Drawing.Size(110, 23);
            this.StepOne_Continue.TabIndex = 10;
            this.StepOne_Continue.Text = "Start Repairs";
            this.StepOne_Continue.UseVisualStyleBackColor = true;
            this.StepOne_Continue.Click += new System.EventHandler(this.StepOne_Continue_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label4.Location = new System.Drawing.Point(98, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(377, 56);
            this.label4.TabIndex = 9;
            this.label4.Text = resources.GetString("label4.Text");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(97, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(281, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Repairing Stardew Valley Mod Manager";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(98, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(401, 66);
            this.label2.TabIndex = 7;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 30);
            this.label1.TabIndex = 6;
            this.label1.Text = "Repair Utility by RWE Labs";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Stardew_Mod_Manager.Properties.Resources.RWESoftwareRepair;
            this.pictureBox1.Location = new System.Drawing.Point(0, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Repair2
            // 
            this.Repair2.Controls.Add(this.SkipStepOneRepairs);
            this.Repair2.Controls.Add(this.StartStepOneRepairs);
            this.Repair2.Controls.Add(this.groupBox1);
            this.Repair2.Controls.Add(this.label6);
            this.Repair2.Controls.Add(this.pictureBox3);
            this.Repair2.Location = new System.Drawing.Point(4, 22);
            this.Repair2.Name = "Repair2";
            this.Repair2.Padding = new System.Windows.Forms.Padding(3);
            this.Repair2.Size = new System.Drawing.Size(505, 326);
            this.Repair2.TabIndex = 1;
            this.Repair2.Text = "Repair2";
            this.Repair2.UseVisualStyleBackColor = true;
            // 
            // SkipStepOneRepairs
            // 
            this.SkipStepOneRepairs.Location = new System.Drawing.Point(264, 255);
            this.SkipStepOneRepairs.Name = "SkipStepOneRepairs";
            this.SkipStepOneRepairs.Size = new System.Drawing.Size(87, 23);
            this.SkipStepOneRepairs.TabIndex = 12;
            this.SkipStepOneRepairs.Text = "Skip";
            this.SkipStepOneRepairs.UseVisualStyleBackColor = true;
            this.SkipStepOneRepairs.Click += new System.EventHandler(this.SkipStepOneRepairs_Click);
            // 
            // StartStepOneRepairs
            // 
            this.StartStepOneRepairs.Location = new System.Drawing.Point(357, 255);
            this.StartStepOneRepairs.Name = "StartStepOneRepairs";
            this.StartStepOneRepairs.Size = new System.Drawing.Size(117, 23);
            this.StartStepOneRepairs.TabIndex = 0;
            this.StartStepOneRepairs.Text = "Continue";
            this.StartStepOneRepairs.UseVisualStyleBackColor = true;
            this.StartStepOneRepairs.Click += new System.EventHandler(this.StartStepOneRepairs_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(101, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(379, 166);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Repair Stardew Valley Mod Manager";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label5.Location = new System.Drawing.Point(7, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(366, 119);
            this.label5.TabIndex = 10;
            this.label5.Text = resources.GetString("label5.Text");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(96, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 30);
            this.label6.TabIndex = 9;
            this.label6.Text = "Step One";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Stardew_Mod_Manager.Properties.Resources.RWESoftwareRepair;
            this.pictureBox3.Location = new System.Drawing.Point(0, 23);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(89, 86);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // Repair3
            // 
            this.Repair3.BackColor = System.Drawing.Color.White;
            this.Repair3.Controls.Add(this.pictureBox4);
            this.Repair3.Controls.Add(this.label7);
            this.Repair3.Controls.Add(this.StatusOutput1);
            this.Repair3.Location = new System.Drawing.Point(4, 22);
            this.Repair3.Name = "Repair3";
            this.Repair3.Padding = new System.Windows.Forms.Padding(3);
            this.Repair3.Size = new System.Drawing.Size(505, 326);
            this.Repair3.TabIndex = 2;
            this.Repair3.Text = "Repair3";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Stardew_Mod_Manager.Properties.Resources.progress_colour;
            this.pictureBox4.Location = new System.Drawing.Point(433, 17);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(59, 30);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 30);
            this.label7.TabIndex = 10;
            this.label7.Text = "Please wait...";
            // 
            // StatusOutput1
            // 
            this.StatusOutput1.BackColor = System.Drawing.Color.White;
            this.StatusOutput1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StatusOutput1.Location = new System.Drawing.Point(14, 67);
            this.StatusOutput1.Name = "StatusOutput1";
            this.StatusOutput1.Size = new System.Drawing.Size(478, 225);
            this.StatusOutput1.TabIndex = 0;
            this.StatusOutput1.Text = "";
            // 
            // MoreThan2RepairFlags
            // 
            this.MoreThan2RepairFlags.Controls.Add(this.FinishRepairFail1);
            this.MoreThan2RepairFlags.Controls.Add(this.label10);
            this.MoreThan2RepairFlags.Controls.Add(this.label11);
            this.MoreThan2RepairFlags.Controls.Add(this.pictureBox5);
            this.MoreThan2RepairFlags.Location = new System.Drawing.Point(4, 22);
            this.MoreThan2RepairFlags.Name = "MoreThan2RepairFlags";
            this.MoreThan2RepairFlags.Padding = new System.Windows.Forms.Padding(3);
            this.MoreThan2RepairFlags.Size = new System.Drawing.Size(505, 326);
            this.MoreThan2RepairFlags.TabIndex = 3;
            this.MoreThan2RepairFlags.Text = "MoreThan2RepairFlags";
            this.MoreThan2RepairFlags.UseVisualStyleBackColor = true;
            // 
            // FinishRepairFail1
            // 
            this.FinishRepairFail1.Location = new System.Drawing.Point(101, 236);
            this.FinishRepairFail1.Name = "FinishRepairFail1";
            this.FinishRepairFail1.Size = new System.Drawing.Size(140, 23);
            this.FinishRepairFail1.TabIndex = 13;
            this.FinishRepairFail1.Text = "Finish Repairs";
            this.FinishRepairFail1.UseVisualStyleBackColor = true;
            this.FinishRepairFail1.Click += new System.EventHandler(this.FinishRepairFail1_Click);
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label10.Location = new System.Drawing.Point(98, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(369, 163);
            this.label10.TabIndex = 12;
            this.label10.Text = resources.GetString("label10.Text");
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(96, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(145, 30);
            this.label11.TabIndex = 11;
            this.label11.Text = "Repair Results";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Stardew_Mod_Manager.Properties.Resources.RWESoftwareRepair;
            this.pictureBox5.Location = new System.Drawing.Point(0, 23);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(89, 86);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 10;
            this.pictureBox5.TabStop = false;
            // 
            // LessThan2RepairFlags
            // 
            this.LessThan2RepairFlags.Controls.Add(this.ContinueRepairs);
            this.LessThan2RepairFlags.Controls.Add(this.FinishRepairs);
            this.LessThan2RepairFlags.Controls.Add(this.LaunchApplication);
            this.LessThan2RepairFlags.Controls.Add(this.label8);
            this.LessThan2RepairFlags.Controls.Add(this.label9);
            this.LessThan2RepairFlags.Controls.Add(this.pictureBox6);
            this.LessThan2RepairFlags.Location = new System.Drawing.Point(4, 22);
            this.LessThan2RepairFlags.Name = "LessThan2RepairFlags";
            this.LessThan2RepairFlags.Padding = new System.Windows.Forms.Padding(3);
            this.LessThan2RepairFlags.Size = new System.Drawing.Size(505, 326);
            this.LessThan2RepairFlags.TabIndex = 4;
            this.LessThan2RepairFlags.Text = "LessThan2RepairFlags";
            this.LessThan2RepairFlags.UseVisualStyleBackColor = true;
            // 
            // ContinueRepairs
            // 
            this.ContinueRepairs.Enabled = false;
            this.ContinueRepairs.Location = new System.Drawing.Point(248, 237);
            this.ContinueRepairs.Name = "ContinueRepairs";
            this.ContinueRepairs.Size = new System.Drawing.Size(140, 23);
            this.ContinueRepairs.TabIndex = 19;
            this.ContinueRepairs.Text = "Continue Repairs";
            this.ContinueRepairs.UseVisualStyleBackColor = true;
            this.ContinueRepairs.Click += new System.EventHandler(this.ContinueRepairs_Click);
            // 
            // FinishRepairs
            // 
            this.FinishRepairs.Enabled = false;
            this.FinishRepairs.Location = new System.Drawing.Point(102, 237);
            this.FinishRepairs.Name = "FinishRepairs";
            this.FinishRepairs.Size = new System.Drawing.Size(140, 23);
            this.FinishRepairs.TabIndex = 18;
            this.FinishRepairs.Text = "Finish Repairs";
            this.FinishRepairs.UseVisualStyleBackColor = true;
            this.FinishRepairs.Click += new System.EventHandler(this.FinishRepairs_Click);
            // 
            // LaunchApplication
            // 
            this.LaunchApplication.Location = new System.Drawing.Point(102, 196);
            this.LaunchApplication.Name = "LaunchApplication";
            this.LaunchApplication.Size = new System.Drawing.Size(140, 23);
            this.LaunchApplication.TabIndex = 17;
            this.LaunchApplication.Text = "Test Repairs";
            this.LaunchApplication.UseVisualStyleBackColor = true;
            this.LaunchApplication.Click += new System.EventHandler(this.LaunchApplication_Click);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label8.Location = new System.Drawing.Point(98, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(369, 118);
            this.label8.TabIndex = 16;
            this.label8.Text = resources.GetString("label8.Text");
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(96, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 30);
            this.label9.TabIndex = 15;
            this.label9.Text = "Repair Results";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Stardew_Mod_Manager.Properties.Resources.RWESoftwareRepair;
            this.pictureBox6.Location = new System.Drawing.Point(0, 23);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(89, 86);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 14;
            this.pictureBox6.TabStop = false;
            // 
            // FullRepair
            // 
            this.FullRepair.BackColor = System.Drawing.Color.White;
            this.FullRepair.Controls.Add(this.pictureBox7);
            this.FullRepair.Controls.Add(this.label12);
            this.FullRepair.Controls.Add(this.StatusOutput2);
            this.FullRepair.Location = new System.Drawing.Point(4, 22);
            this.FullRepair.Name = "FullRepair";
            this.FullRepair.Padding = new System.Windows.Forms.Padding(3);
            this.FullRepair.Size = new System.Drawing.Size(505, 326);
            this.FullRepair.TabIndex = 5;
            this.FullRepair.Text = "FullRepair";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::Stardew_Mod_Manager.Properties.Resources.progress_colour;
            this.pictureBox7.Location = new System.Drawing.Point(432, 18);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(59, 30);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 14;
            this.pictureBox7.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(13, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(133, 30);
            this.label12.TabIndex = 13;
            this.label12.Text = "Please wait...";
            // 
            // StatusOutput2
            // 
            this.StatusOutput2.BackColor = System.Drawing.Color.White;
            this.StatusOutput2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StatusOutput2.Location = new System.Drawing.Point(13, 68);
            this.StatusOutput2.Name = "StatusOutput2";
            this.StatusOutput2.Size = new System.Drawing.Size(478, 225);
            this.StatusOutput2.TabIndex = 12;
            this.StatusOutput2.Text = "";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::Stardew_Mod_Manager.Properties.Resources.RWE_Labs_BG;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(-9, 311);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(543, 73);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Stardew_Mod_Manager.Properties.Resources.RWE_Labs_White;
            this.pictureBox2.Location = new System.Drawing.Point(429, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(70, 65);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // Repair1Timer
            // 
            this.Repair1Timer.Interval = 7500;
            this.Repair1Timer.Tick += new System.EventHandler(this.Repair1Timer_Tick);
            // 
            // Repair2Timer
            // 
            this.Repair2Timer.Interval = 5000;
            this.Repair2Timer.Tick += new System.EventHandler(this.Repair2Timer_Tick);
            // 
            // RepairApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 377);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Tabs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RepairApplication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Repair Software - RWE Labs";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RepairApplication_FormClosed);
            this.Load += new System.EventHandler(this.RepairApplication_Load);
            this.Tabs.ResumeLayout(false);
            this.Repair1.ResumeLayout(false);
            this.Repair1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Repair2.ResumeLayout(false);
            this.Repair2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.Repair3.ResumeLayout(false);
            this.Repair3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.MoreThan2RepairFlags.ResumeLayout(false);
            this.MoreThan2RepairFlags.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.LessThan2RepairFlags.ResumeLayout(false);
            this.LessThan2RepairFlags.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.FullRepair.ResumeLayout(false);
            this.FullRepair.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tabs;
        private System.Windows.Forms.TabPage Repair1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage Repair2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button StepOne_Cancel;
        private System.Windows.Forms.Button StepOne_Continue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button StartStepOneRepairs;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button SkipStepOneRepairs;
        private System.Windows.Forms.TabPage Repair3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox StatusOutput1;
        private System.Windows.Forms.TabPage MoreThan2RepairFlags;
        private System.Windows.Forms.Button FinishRepairFail1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.TabPage LessThan2RepairFlags;
        private System.Windows.Forms.Button LaunchApplication;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button FinishRepairs;
        private System.Windows.Forms.Button ContinueRepairs;
        private System.Windows.Forms.TabPage FullRepair;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RichTextBox StatusOutput2;
        private System.Windows.Forms.Timer Repair1Timer;
        private System.Windows.Forms.Timer Repair2Timer;
    }
}