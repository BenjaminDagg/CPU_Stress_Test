using System.Windows.Forms;

namespace StressTest
{
    partial class CPUStressTest
    {

        private CPUStatManager cpuStats = new CPUStatManager();

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CPUStressTest));
            this.TabelLayout = new System.Windows.Forms.TableLayoutPanel();
            this.ToolBar = new System.Windows.Forms.ToolStrip();
            this.TestToolLabel = new System.Windows.Forms.ToolStripLabel();
            this.TestToolBtn = new System.Windows.Forms.ToolStripDropDownButton();
            this.StartMenuOption = new System.Windows.Forms.ToolStripMenuItem();
            this.StopMenuOption = new System.Windows.Forms.ToolStripMenuItem();
            this.OptionsToolLabel = new System.Windows.Forms.ToolStripLabel();
            this.OptionsToolBtn = new System.Windows.Forms.ToolStripDropDownButton();
            this.TimeUnitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.TimeUnitSecondBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.TimeUnitMinBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.TimeUnitHrBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolLabel = new System.Windows.Forms.ToolStripLabel();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.CpuLabel = new System.Windows.Forms.Label();
            this.UserCpuLabel = new System.Windows.Forms.Label();
            this.CoreLabel = new System.Windows.Forms.Label();
            this.UserCoreLabel = new System.Windows.Forms.Label();
            this.CoreTestLabel = new System.Windows.Forms.Label();
            this.UserCoreInput = new System.Windows.Forms.NumericUpDown();
            this.TimerLabel = new System.Windows.Forms.Label();
            this.TimerDurationInput = new System.Windows.Forms.NumericUpDown();
            this.StartTestBtn = new System.Windows.Forms.Button();
            this.TimerStatus = new System.Windows.Forms.Label();
            this.CPUFreqLabel = new System.Windows.Forms.Label();
            this.CPUFreqActual = new System.Windows.Forms.Label();
            this.AboutToolBtn = new System.Windows.Forms.ToolStripDropDownButton();
            this.AboutMenuOption = new System.Windows.Forms.ToolStripMenuItem();
            this.TestTimer = new System.Windows.Forms.Timer(this.components);
            this.TabelLayout.SuspendLayout();
            this.ToolBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserCoreInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimerDurationInput)).BeginInit();
            this.SuspendLayout();
            // 
            // TabelLayout
            // 
            this.TabelLayout.AllowDrop = true;
            this.TabelLayout.ColumnCount = 4;
            this.TabelLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TabelLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TabelLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TabelLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TabelLayout.Controls.Add(this.ToolBar, 0, 0);
            this.TabelLayout.Controls.Add(this.TitleLabel, 1, 0);
            this.TabelLayout.Controls.Add(this.CpuLabel, 1, 1);
            this.TabelLayout.Controls.Add(this.UserCpuLabel, 2, 1);
            this.TabelLayout.Controls.Add(this.CoreLabel, 0, 3);
            this.TabelLayout.Controls.Add(this.UserCoreLabel, 1, 3);
            this.TabelLayout.Controls.Add(this.CoreTestLabel, 0, 4);
            this.TabelLayout.Controls.Add(this.UserCoreInput, 1, 4);
            this.TabelLayout.Controls.Add(this.TimerLabel, 0, 5);
            this.TabelLayout.Controls.Add(this.TimerDurationInput, 1, 5);
            this.TabelLayout.Controls.Add(this.StartTestBtn, 1, 7);
            this.TabelLayout.Controls.Add(this.TimerStatus, 2, 7);
            this.TabelLayout.Controls.Add(this.CPUFreqLabel, 0, 6);
            this.TabelLayout.Controls.Add(this.CPUFreqActual, 1, 6);
            this.TabelLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabelLayout.Location = new System.Drawing.Point(0, 0);
            this.TabelLayout.Name = "TabelLayout";
            this.TabelLayout.RowCount = 8;
            this.TabelLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TabelLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.091134F));
            this.TabelLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.091134F));
            this.TabelLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.091134F));
            this.TabelLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090225F));
            this.TabelLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.TabelLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.18182F));
            this.TabelLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.36364F));
            this.TabelLayout.Size = new System.Drawing.Size(800, 450);
            this.TabelLayout.TabIndex = 0;
            this.TabelLayout.Paint += new System.Windows.Forms.PaintEventHandler(this.TabelLayout_Paint);
            // 
            // ToolBar
            // 
            this.ToolBar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TabelLayout.SetColumnSpan(this.ToolBar, 4);
            this.ToolBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ToolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TestToolLabel,
            this.TestToolBtn,
            this.OptionsToolLabel,
            this.OptionsToolBtn,
            this.AboutToolLabel});
            this.ToolBar.Location = new System.Drawing.Point(0, 0);
            this.ToolBar.Name = "ToolBar";
            this.ToolBar.Size = new System.Drawing.Size(800, 20);
            this.ToolBar.TabIndex = 0;
            this.ToolBar.Text = "toolStrip1";
            // 
            // TestToolLabel
            // 
            this.TestToolLabel.Name = "TestToolLabel";
            this.TestToolLabel.Size = new System.Drawing.Size(28, 17);
            this.TestToolLabel.Text = "Test";
            this.TestToolLabel.Click += new System.EventHandler(this.TestToolBtn_Click);
            // 
            // TestToolBtn
            // 
            this.TestToolBtn.BackColor = System.Drawing.Color.Transparent;
            this.TestToolBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TestToolBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StartMenuOption,
            this.StopMenuOption});
            this.TestToolBtn.Image = ((System.Drawing.Image)(resources.GetObject("TestToolBtn.Image")));
            this.TestToolBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TestToolBtn.Name = "TestToolBtn";
            this.TestToolBtn.Size = new System.Drawing.Size(29, 17);
            this.TestToolBtn.Text = "TestDropdown";
            // 
            // StartMenuOption
            // 
            this.StartMenuOption.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.StartMenuOption.Name = "StartMenuOption";
            this.StartMenuOption.Size = new System.Drawing.Size(98, 22);
            this.StartMenuOption.Text = "Start";
            this.StartMenuOption.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // StopMenuOption
            // 
            this.StopMenuOption.BackColor = System.Drawing.SystemColors.Control;
            this.StopMenuOption.Name = "StopMenuOption";
            this.StopMenuOption.Size = new System.Drawing.Size(98, 22);
            this.StopMenuOption.Text = "Stop";
            this.StopMenuOption.Click += new System.EventHandler(this.StopBtn_Click);
            // 
            // OptionsToolLabel
            // 
            this.OptionsToolLabel.Name = "OptionsToolLabel";
            this.OptionsToolLabel.Size = new System.Drawing.Size(49, 17);
            this.OptionsToolLabel.Text = "Options";
            // 
            // OptionsToolBtn
            // 
            this.OptionsToolBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OptionsToolBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TimeUnitMenu});
            this.OptionsToolBtn.Image = ((System.Drawing.Image)(resources.GetObject("OptionsToolBtn.Image")));
            this.OptionsToolBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OptionsToolBtn.Name = "OptionsToolBtn";
            this.OptionsToolBtn.Size = new System.Drawing.Size(29, 17);
            this.OptionsToolBtn.Text = "Options";
            // 
            // TimeUnitMenu
            // 
            this.TimeUnitMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TimeUnitSecondBtn,
            this.TimeUnitMinBtn,
            this.TimeUnitHrBtn});
            this.TimeUnitMenu.Name = "TimeUnitMenu";
            this.TimeUnitMenu.Size = new System.Drawing.Size(126, 22);
            this.TimeUnitMenu.Text = "Time Unit";
            // 
            // TimeUnitSecondBtn
            // 
            this.TimeUnitSecondBtn.Name = "TimeUnitSecondBtn";
            this.TimeUnitSecondBtn.Size = new System.Drawing.Size(112, 22);
            this.TimeUnitSecondBtn.Text = "second";
            this.TimeUnitSecondBtn.Click += new System.EventHandler((sender, e) => this.TimeUnitBtn_Click(sender, e, TimeUnit.SECOND));
            // 
            // TimeUnitMinBtn
            // 
            this.TimeUnitMinBtn.Name = "TimeUnitMinBtn";
            this.TimeUnitMinBtn.Size = new System.Drawing.Size(112, 22);
            this.TimeUnitMinBtn.Text = "minute";
            this.TimeUnitMinBtn.Click += new System.EventHandler((sender, e) => this.TimeUnitBtn_Click(sender, e, TimeUnit.MINUTE));
            // 
            // TimeUnitHrBtn
            // 
            this.TimeUnitHrBtn.Name = "TimeUnitHrBtn";
            this.TimeUnitHrBtn.Size = new System.Drawing.Size(112, 22);
            this.TimeUnitHrBtn.Text = "hour";
            this.TimeUnitMinBtn.Click += new System.EventHandler((sender, e) => this.TimeUnitBtn_Click(sender, e, TimeUnit.HOUR));
            // 
            // AboutToolLabel
            // 
            this.AboutToolLabel.Name = "AboutToolLabel";
            this.AboutToolLabel.Size = new System.Drawing.Size(40, 17);
            this.AboutToolLabel.Text = "About";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TabelLayout.SetColumnSpan(this.TitleLabel, 4);
            this.TitleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.TitleLabel.Location = new System.Drawing.Point(3, 20);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(794, 39);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "CPU Stress Test";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TitleLabel.Click += new System.EventHandler(this.TitleLabel_Click);
            // 
            // CpuLabel
            // 
            this.CpuLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CpuLabel.AutoSize = true;
            this.CpuLabel.Location = new System.Drawing.Point(84, 72);
            this.CpuLabel.Name = "CpuLabel";
            this.CpuLabel.Size = new System.Drawing.Size(32, 13);
            this.CpuLabel.TabIndex = 2;
            this.CpuLabel.Text = "CPU:";
            // 
            // UserCpuLabel
            // 
            this.UserCpuLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.UserCpuLabel.AutoSize = true;
            this.UserCpuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserCpuLabel.Location = new System.Drawing.Point(203, 72);
            this.UserCpuLabel.Name = "UserCpuLabel";
            this.UserCpuLabel.Size = new System.Drawing.Size(20, 12);
            this.UserCpuLabel.TabIndex = 3;
            this.UserCpuLabel.Text = "cpu";
            // 
            // CoreLabel
            // 
            this.CoreLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CoreLabel.AutoSize = true;
            this.CoreLabel.Location = new System.Drawing.Point(68, 111);
            this.CoreLabel.Name = "CoreLabel";
            this.CoreLabel.Size = new System.Drawing.Size(63, 13);
            this.CoreLabel.TabIndex = 4;
            this.CoreLabel.Text = "Core Count:";
            // 
            // UserCoreLabel
            // 
            this.UserCoreLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.UserCoreLabel.AutoSize = true;
            this.UserCoreLabel.Location = new System.Drawing.Point(203, 111);
            this.UserCoreLabel.Name = "UserCoreLabel";
            this.UserCoreLabel.Size = new System.Drawing.Size(35, 13);
            this.UserCoreLabel.TabIndex = 5;
            this.UserCoreLabel.Text = "label1";
            // 
            // CoreTestLabel
            // 
            this.CoreTestLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CoreTestLabel.AutoSize = true;
            this.CoreTestLabel.Location = new System.Drawing.Point(60, 150);
            this.CoreTestLabel.Name = "CoreTestLabel";
            this.CoreTestLabel.Size = new System.Drawing.Size(79, 13);
            this.CoreTestLabel.TabIndex = 6;
            this.CoreTestLabel.Text = "# Cores to test:";
            // 
            // UserCoreInput
            // 
            this.UserCoreInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.UserCoreInput.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.UserCoreInput.Location = new System.Drawing.Point(203, 146);
            this.UserCoreInput.Name = "UserCoreInput";
            this.UserCoreInput.Size = new System.Drawing.Size(40, 20);
            this.UserCoreInput.TabIndex = 7;
            this.UserCoreInput.ValueChanged += new System.EventHandler(this.UserCoreInput_ValueChanged);
            // 
            // TimerLabel
            // 
            this.TimerLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TimerLabel.AutoSize = true;
            this.TimerLabel.Location = new System.Drawing.Point(50, 189);
            this.TimerLabel.Name = "TimerLabel";
            this.TimerLabel.Size = new System.Drawing.Size(99, 13);
            this.TimerLabel.TabIndex = 8;
            this.TimerLabel.Text = "Test Duration (min):";
            // 
            // TimerDurationInput
            // 
            this.TimerDurationInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TimerDurationInput.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.TimerDurationInput.Location = new System.Drawing.Point(203, 185);
            this.TimerDurationInput.Name = "TimerDurationInput";
            this.TimerDurationInput.Size = new System.Drawing.Size(40, 20);
            this.TimerDurationInput.TabIndex = 9;
            this.TimerDurationInput.ValueChanged += new System.EventHandler(this.TimerDurationInput_ValueChanged);
            // 
            // StartTestBtn
            // 
            this.StartTestBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StartTestBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.StartTestBtn.Location = new System.Drawing.Point(262, 360);
            this.StartTestBtn.Name = "StartTestBtn";
            this.StartTestBtn.Size = new System.Drawing.Size(75, 23);
            this.StartTestBtn.TabIndex = 10;
            this.StartTestBtn.Text = "Start";
            this.StartTestBtn.UseVisualStyleBackColor = false;
            this.StartTestBtn.Click += new System.EventHandler(this.StartTestBtn_Click);
            // 
            // TimerStatus
            // 
            this.TimerStatus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TimerStatus.AutoSize = true;
            this.TimerStatus.Location = new System.Drawing.Point(403, 365);
            this.TimerStatus.Name = "TimerStatus";
            this.TimerStatus.Size = new System.Drawing.Size(35, 13);
            this.TimerStatus.TabIndex = 11;
            this.TimerStatus.Text = "label1";
            // 
            // CPUFreqLabel
            // 
            this.CPUFreqLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CPUFreqLabel.AutoSize = true;
            this.CPUFreqLabel.Location = new System.Drawing.Point(58, 247);
            this.CPUFreqLabel.Name = "CPUFreqLabel";
            this.CPUFreqLabel.Size = new System.Drawing.Size(84, 13);
            this.CPUFreqLabel.TabIndex = 14;
            this.CPUFreqLabel.Text = "CPU Freq (mhz):";
            // 
            // CPUFreqActual
            // 
            this.CPUFreqActual.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CPUFreqActual.AutoSize = true;
            this.CPUFreqActual.Location = new System.Drawing.Point(203, 247);
            this.CPUFreqActual.Name = "CPUFreqActual";
            this.CPUFreqActual.Size = new System.Drawing.Size(35, 13);
            this.CPUFreqActual.TabIndex = 15;
            this.CPUFreqActual.Text = "label1";
            // 
            // AboutToolBtn
            // 
            this.AboutToolBtn.BackColor = System.Drawing.Color.Transparent;
            this.AboutToolBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AboutToolBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutMenuOption});
            this.AboutToolBtn.Image = ((System.Drawing.Image)(resources.GetObject("AboutToolBtn.Image")));
            this.AboutToolBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AboutToolBtn.Name = "AboutToolBtn";
            this.AboutToolBtn.Size = new System.Drawing.Size(29, 17);
            this.AboutToolBtn.Text = "About";
            // 
            // AboutMenuOption
            // 
            this.AboutMenuOption.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.AboutMenuOption.Name = "AboutMenuOption";
            this.AboutMenuOption.Size = new System.Drawing.Size(107, 22);
            this.AboutMenuOption.Text = "About";
            // 
            // TestTimer
            // 
            this.TestTimer.Interval = 1000;
            this.TestTimer.Tick += new System.EventHandler(this.TestTimer_Tick);
            // 
            // CPUStressTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TabelLayout);
            this.Name = "CPUStressTest";
            this.Text = "CPU Stress Test";
            this.TabelLayout.ResumeLayout(false);
            this.TabelLayout.PerformLayout();
            this.ToolBar.ResumeLayout(false);
            this.ToolBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserCoreInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimerDurationInput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TabelLayout;
        private System.Windows.Forms.ToolStrip ToolBar;
        private System.Windows.Forms.ToolStripLabel TestToolLabel;
        private System.Windows.Forms.ToolStripDropDownButton TestToolBtn;
        private ToolStripLabel AboutToolLabel;
        private ToolStripDropDownButton AboutToolBtn;
        private System.Windows.Forms.ToolStripMenuItem StartMenuOption;
        private ToolStripMenuItem AboutMenuOption;
        private System.Windows.Forms.ToolStripMenuItem StopMenuOption;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label CpuLabel;
        private System.Windows.Forms.Label UserCpuLabel;
        private System.Windows.Forms.Label CoreLabel;
        private System.Windows.Forms.Label UserCoreLabel;
        private System.Windows.Forms.Label CoreTestLabel;
        private System.Windows.Forms.NumericUpDown UserCoreInput;
        private System.Windows.Forms.Timer TestTimer;
        private System.Windows.Forms.Label TimerLabel;
        private System.Windows.Forms.NumericUpDown TimerDurationInput;
        private System.Windows.Forms.Button StartTestBtn;
        private System.Windows.Forms.Label TimerStatus;
        private System.Windows.Forms.ToolStripLabel OptionsToolLabel;
        private System.Windows.Forms.ToolStripDropDownButton OptionsToolBtn;
        private System.Windows.Forms.ToolStripMenuItem TimeUnitMenu;
        private System.Windows.Forms.ToolStripMenuItem TimeUnitSecondBtn;
        private System.Windows.Forms.ToolStripMenuItem TimeUnitMinBtn;
        private System.Windows.Forms.ToolStripMenuItem TimeUnitHrBtn;
        private Label CPUFreqLabel;
        private Label CPUFreqActual;
    }
}

