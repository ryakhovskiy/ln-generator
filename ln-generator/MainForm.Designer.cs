namespace ln_generator
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.leistungsnachweisGeneratorTab = new System.Windows.Forms.TabPage();
            this.lnGroupBox = new System.Windows.Forms.GroupBox();
            this.progressLabel = new System.Windows.Forms.Label();
            this.mainProgressBar = new System.Windows.Forms.ProgressBar();
            this.leistungsnachweisOutputDirButton = new System.Windows.Forms.Button();
            this.leistungsnachweisOutputDirTextBox = new System.Windows.Forms.TextBox();
            this.leistungsnachweisOutputDirLabel = new System.Windows.Forms.Label();
            this.employeeSelectionListBox = new System.Windows.Forms.ListBox();
            this.employeeSelectLabel = new System.Windows.Forms.Label();
            this.generateButton = new System.Windows.Forms.Button();
            this.projectPONumberTextBox = new System.Windows.Forms.TextBox();
            this.projectPONumLabel = new System.Windows.Forms.Label();
            this.availabilityTrackerFileButton = new System.Windows.Forms.Button();
            this.availabilityTrackerFileTextBox = new System.Windows.Forms.TextBox();
            this.avaiabilityTrackerPathLabel = new System.Windows.Forms.Label();
            this.yearComboBox = new System.Windows.Forms.ComboBox();
            this.monthComboBox = new System.Windows.Forms.ComboBox();
            this.monthLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.mainBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.generateBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.mainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.myteValidationBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.mainTabControl.SuspendLayout();
            this.leistungsnachweisGeneratorTab.SuspendLayout();
            this.lnGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).BeginInit();
            this.mainSplitContainer.Panel1.SuspendLayout();
            this.mainSplitContainer.Panel2.SuspendLayout();
            this.mainSplitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.leistungsnachweisGeneratorTab);
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.Location = new System.Drawing.Point(0, 0);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(985, 578);
            this.mainTabControl.TabIndex = 0;
            // 
            // leistungsnachweisGeneratorTab
            // 
            this.leistungsnachweisGeneratorTab.Controls.Add(this.lnGroupBox);
            this.leistungsnachweisGeneratorTab.Location = new System.Drawing.Point(4, 29);
            this.leistungsnachweisGeneratorTab.Name = "leistungsnachweisGeneratorTab";
            this.leistungsnachweisGeneratorTab.Padding = new System.Windows.Forms.Padding(3);
            this.leistungsnachweisGeneratorTab.Size = new System.Drawing.Size(977, 545);
            this.leistungsnachweisGeneratorTab.TabIndex = 0;
            this.leistungsnachweisGeneratorTab.Text = "Leistungsnachweis Generator";
            this.leistungsnachweisGeneratorTab.UseVisualStyleBackColor = true;
            // 
            // lnGroupBox
            // 
            this.lnGroupBox.Controls.Add(this.progressLabel);
            this.lnGroupBox.Controls.Add(this.mainProgressBar);
            this.lnGroupBox.Controls.Add(this.leistungsnachweisOutputDirButton);
            this.lnGroupBox.Controls.Add(this.leistungsnachweisOutputDirTextBox);
            this.lnGroupBox.Controls.Add(this.leistungsnachweisOutputDirLabel);
            this.lnGroupBox.Controls.Add(this.employeeSelectionListBox);
            this.lnGroupBox.Controls.Add(this.employeeSelectLabel);
            this.lnGroupBox.Controls.Add(this.generateButton);
            this.lnGroupBox.Controls.Add(this.projectPONumberTextBox);
            this.lnGroupBox.Controls.Add(this.projectPONumLabel);
            this.lnGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lnGroupBox.Location = new System.Drawing.Point(3, 3);
            this.lnGroupBox.Name = "lnGroupBox";
            this.lnGroupBox.Size = new System.Drawing.Size(971, 539);
            this.lnGroupBox.TabIndex = 9;
            this.lnGroupBox.TabStop = false;
            this.lnGroupBox.Text = "Leistungsnachweis Data";
            // 
            // progressLabel
            // 
            this.progressLabel.AutoSize = true;
            this.progressLabel.Location = new System.Drawing.Point(6, 467);
            this.progressLabel.Name = "progressLabel";
            this.progressLabel.Size = new System.Drawing.Size(105, 20);
            this.progressLabel.TabIndex = 21;
            this.progressLabel.Text = "Progress Label";
            this.progressLabel.Visible = false;
            // 
            // mainProgressBar
            // 
            this.mainProgressBar.Location = new System.Drawing.Point(6, 490);
            this.mainProgressBar.Name = "mainProgressBar";
            this.mainProgressBar.Size = new System.Drawing.Size(741, 29);
            this.mainProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.mainProgressBar.TabIndex = 0;
            this.mainProgressBar.UseWaitCursor = true;
            this.mainProgressBar.Visible = false;
            // 
            // leistungsnachweisOutputDirButton
            // 
            this.leistungsnachweisOutputDirButton.Location = new System.Drawing.Point(939, 52);
            this.leistungsnachweisOutputDirButton.Name = "leistungsnachweisOutputDirButton";
            this.leistungsnachweisOutputDirButton.Size = new System.Drawing.Size(27, 29);
            this.leistungsnachweisOutputDirButton.TabIndex = 20;
            this.leistungsnachweisOutputDirButton.Text = "...";
            this.leistungsnachweisOutputDirButton.UseVisualStyleBackColor = true;
            this.leistungsnachweisOutputDirButton.Click += new System.EventHandler(this.lesitungsnachweisOutputDirButton_Click);
            // 
            // leistungsnachweisOutputDirTextBox
            // 
            this.leistungsnachweisOutputDirTextBox.Location = new System.Drawing.Point(261, 53);
            this.leistungsnachweisOutputDirTextBox.Name = "leistungsnachweisOutputDirTextBox";
            this.leistungsnachweisOutputDirTextBox.Size = new System.Drawing.Size(672, 27);
            this.leistungsnachweisOutputDirTextBox.TabIndex = 19;
            // 
            // leistungsnachweisOutputDirLabel
            // 
            this.leistungsnachweisOutputDirLabel.AutoSize = true;
            this.leistungsnachweisOutputDirLabel.Location = new System.Drawing.Point(10, 56);
            this.leistungsnachweisOutputDirLabel.Name = "leistungsnachweisOutputDirLabel";
            this.leistungsnachweisOutputDirLabel.Size = new System.Drawing.Size(245, 20);
            this.leistungsnachweisOutputDirLabel.TabIndex = 18;
            this.leistungsnachweisOutputDirLabel.Text = "Leistungsnachweis Output Directory";
            // 
            // employeeSelectionListBox
            // 
            this.employeeSelectionListBox.FormattingEnabled = true;
            this.employeeSelectionListBox.ItemHeight = 20;
            this.employeeSelectionListBox.Location = new System.Drawing.Point(262, 86);
            this.employeeSelectionListBox.Name = "employeeSelectionListBox";
            this.employeeSelectionListBox.Size = new System.Drawing.Size(704, 384);
            this.employeeSelectionListBox.TabIndex = 14;
            // 
            // employeeSelectLabel
            // 
            this.employeeSelectLabel.AutoSize = true;
            this.employeeSelectLabel.Location = new System.Drawing.Point(116, 86);
            this.employeeSelectLabel.Name = "employeeSelectLabel";
            this.employeeSelectLabel.Size = new System.Drawing.Size(140, 20);
            this.employeeSelectLabel.TabIndex = 13;
            this.employeeSelectLabel.Text = "Employee Selection";
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(753, 490);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(212, 29);
            this.generateButton.TabIndex = 12;
            this.generateButton.Text = "Generate Leistungsnachweis";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // projectPONumberTextBox
            // 
            this.projectPONumberTextBox.Location = new System.Drawing.Point(261, 20);
            this.projectPONumberTextBox.Name = "projectPONumberTextBox";
            this.projectPONumberTextBox.Size = new System.Drawing.Size(705, 27);
            this.projectPONumberTextBox.TabIndex = 1;
            // 
            // projectPONumLabel
            // 
            this.projectPONumLabel.AutoSize = true;
            this.projectPONumLabel.Location = new System.Drawing.Point(168, 23);
            this.projectPONumLabel.Name = "projectPONumLabel";
            this.projectPONumLabel.Size = new System.Drawing.Size(87, 20);
            this.projectPONumLabel.TabIndex = 0;
            this.projectPONumLabel.Text = "Project PO#";
            // 
            // availabilityTrackerFileButton
            // 
            this.availabilityTrackerFileButton.Location = new System.Drawing.Point(946, 5);
            this.availabilityTrackerFileButton.Name = "availabilityTrackerFileButton";
            this.availabilityTrackerFileButton.Size = new System.Drawing.Size(27, 29);
            this.availabilityTrackerFileButton.TabIndex = 11;
            this.availabilityTrackerFileButton.Text = "...";
            this.availabilityTrackerFileButton.UseVisualStyleBackColor = true;
            this.availabilityTrackerFileButton.Click += new System.EventHandler(this.availabilityTrackerFileButton_Click);
            // 
            // availabilityTrackerFileTextBox
            // 
            this.availabilityTrackerFileTextBox.Location = new System.Drawing.Point(268, 5);
            this.availabilityTrackerFileTextBox.Name = "availabilityTrackerFileTextBox";
            this.availabilityTrackerFileTextBox.Size = new System.Drawing.Size(672, 27);
            this.availabilityTrackerFileTextBox.TabIndex = 10;
            // 
            // avaiabilityTrackerPathLabel
            // 
            this.avaiabilityTrackerPathLabel.AutoSize = true;
            this.avaiabilityTrackerPathLabel.Location = new System.Drawing.Point(96, 8);
            this.avaiabilityTrackerPathLabel.Name = "avaiabilityTrackerPathLabel";
            this.avaiabilityTrackerPathLabel.Size = new System.Drawing.Size(166, 20);
            this.avaiabilityTrackerPathLabel.TabIndex = 9;
            this.avaiabilityTrackerPathLabel.Text = "Availability Tracker Path";
            // 
            // yearComboBox
            // 
            this.yearComboBox.FormattingEnabled = true;
            this.yearComboBox.Location = new System.Drawing.Point(268, 74);
            this.yearComboBox.Name = "yearComboBox";
            this.yearComboBox.Size = new System.Drawing.Size(705, 28);
            this.yearComboBox.TabIndex = 8;
            // 
            // monthComboBox
            // 
            this.monthComboBox.FormattingEnabled = true;
            this.monthComboBox.Location = new System.Drawing.Point(268, 40);
            this.monthComboBox.Name = "monthComboBox";
            this.monthComboBox.Size = new System.Drawing.Size(705, 28);
            this.monthComboBox.TabIndex = 7;
            // 
            // monthLabel
            // 
            this.monthLabel.AutoSize = true;
            this.monthLabel.Location = new System.Drawing.Point(210, 43);
            this.monthLabel.Name = "monthLabel";
            this.monthLabel.Size = new System.Drawing.Size(52, 20);
            this.monthLabel.TabIndex = 3;
            this.monthLabel.Text = "Month";
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(225, 77);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(37, 20);
            this.yearLabel.TabIndex = 4;
            this.yearLabel.Text = "Year";
            // 
            // mainBackgroundWorker
            // 
            this.mainBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.mainBackgroundWorker_DoWork);
            this.mainBackgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.mainBackgroundWorker_ProgressChanged);
            this.mainBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.mainBackgroundWorker_RunWorkerCompleted);
            // 
            // generateBackgroundWorker
            // 
            this.generateBackgroundWorker.WorkerReportsProgress = true;
            this.generateBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.generateBackgroundWorker_DoWork);
            this.generateBackgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.generateBackgroundWorker_ProgressChanged);
            this.generateBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.generateBackgroundWorker_RunWorkerCompleted);
            // 
            // mainSplitContainer
            // 
            this.mainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.mainSplitContainer.Name = "mainSplitContainer";
            this.mainSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // mainSplitContainer.Panel1
            // 
            this.mainSplitContainer.Panel1.Controls.Add(this.avaiabilityTrackerPathLabel);
            this.mainSplitContainer.Panel1.Controls.Add(this.availabilityTrackerFileTextBox);
            this.mainSplitContainer.Panel1.Controls.Add(this.availabilityTrackerFileButton);
            this.mainSplitContainer.Panel1.Controls.Add(this.monthComboBox);
            this.mainSplitContainer.Panel1.Controls.Add(this.monthLabel);
            this.mainSplitContainer.Panel1.Controls.Add(this.yearComboBox);
            this.mainSplitContainer.Panel1.Controls.Add(this.yearLabel);
            // 
            // mainSplitContainer.Panel2
            // 
            this.mainSplitContainer.Panel2.Controls.Add(this.mainTabControl);
            this.mainSplitContainer.Size = new System.Drawing.Size(985, 692);
            this.mainSplitContainer.SplitterDistance = 110;
            this.mainSplitContainer.TabIndex = 22;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 692);
            this.Controls.Add(this.mainSplitContainer);
            this.Name = "MainForm";
            this.Text = "Leistungsnachweis Generator";
            this.mainTabControl.ResumeLayout(false);
            this.leistungsnachweisGeneratorTab.ResumeLayout(false);
            this.lnGroupBox.ResumeLayout(false);
            this.lnGroupBox.PerformLayout();
            this.mainSplitContainer.Panel1.ResumeLayout(false);
            this.mainSplitContainer.Panel1.PerformLayout();
            this.mainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).EndInit();
            this.mainSplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl mainTabControl;
        private TabPage leistungsnachweisGeneratorTab;
        private TextBox projectPONumberTextBox;
        private Label projectPONumLabel;
        private ComboBox yearComboBox;
        private ComboBox monthComboBox;
        private Label yearLabel;
        private Label monthLabel;
        private GroupBox lnGroupBox;
        private Label avaiabilityTrackerPathLabel;
        private Button availabilityTrackerFileButton;
        private TextBox availabilityTrackerFileTextBox;
        private ListBox employeeSelectionListBox;
        private Label employeeSelectLabel;
        private Button generateButton;
        private Button leistungsnachweisOutputDirButton;
        private TextBox leistungsnachweisOutputDirTextBox;
        private Label leistungsnachweisOutputDirLabel;
        private ProgressBar mainProgressBar;
        private System.ComponentModel.BackgroundWorker mainBackgroundWorker;
        private Label progressLabel;
        private System.ComponentModel.BackgroundWorker generateBackgroundWorker;
        private SplitContainer mainSplitContainer;
        private System.ComponentModel.BackgroundWorker myteValidationBackgroundWorker;
    }
}