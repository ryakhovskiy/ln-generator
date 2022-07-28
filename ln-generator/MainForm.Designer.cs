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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lnGroupBox = new System.Windows.Forms.GroupBox();
            this.progressLabel = new System.Windows.Forms.Label();
            this.mainProgressBar = new System.Windows.Forms.ProgressBar();
            this.lesitungsnachweisOutputDirButton = new System.Windows.Forms.Button();
            this.leistungsnachweisOutputDirTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.employeeSelectionListBox = new System.Windows.Forms.ListBox();
            this.employeeSelectLabel = new System.Windows.Forms.Label();
            this.generateButton = new System.Windows.Forms.Button();
            this.availabilityTrackerFileButton = new System.Windows.Forms.Button();
            this.availabilityTrackerFileTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.projectPONumberTextBox = new System.Windows.Forms.TextBox();
            this.yearComboBox = new System.Windows.Forms.ComboBox();
            this.projectPONumLabel = new System.Windows.Forms.Label();
            this.monthComboBox = new System.Windows.Forms.ComboBox();
            this.monthLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.mainBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.generateBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.mainTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.lnGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.tabPage1);
            this.mainTabControl.Controls.Add(this.tabPage2);
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.Location = new System.Drawing.Point(0, 0);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(935, 657);
            this.mainTabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(927, 624);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Simple";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lnGroupBox);
            this.splitContainer1.Size = new System.Drawing.Size(921, 618);
            this.splitContainer1.SplitterDistance = 892;
            this.splitContainer1.TabIndex = 10;
            // 
            // lnGroupBox
            // 
            this.lnGroupBox.Controls.Add(this.progressLabel);
            this.lnGroupBox.Controls.Add(this.mainProgressBar);
            this.lnGroupBox.Controls.Add(this.lesitungsnachweisOutputDirButton);
            this.lnGroupBox.Controls.Add(this.leistungsnachweisOutputDirTextBox);
            this.lnGroupBox.Controls.Add(this.label3);
            this.lnGroupBox.Controls.Add(this.employeeSelectionListBox);
            this.lnGroupBox.Controls.Add(this.employeeSelectLabel);
            this.lnGroupBox.Controls.Add(this.generateButton);
            this.lnGroupBox.Controls.Add(this.availabilityTrackerFileButton);
            this.lnGroupBox.Controls.Add(this.availabilityTrackerFileTextBox);
            this.lnGroupBox.Controls.Add(this.label1);
            this.lnGroupBox.Controls.Add(this.projectPONumberTextBox);
            this.lnGroupBox.Controls.Add(this.yearComboBox);
            this.lnGroupBox.Controls.Add(this.projectPONumLabel);
            this.lnGroupBox.Controls.Add(this.monthComboBox);
            this.lnGroupBox.Controls.Add(this.monthLabel);
            this.lnGroupBox.Controls.Add(this.yearLabel);
            this.lnGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lnGroupBox.Location = new System.Drawing.Point(0, 0);
            this.lnGroupBox.Name = "lnGroupBox";
            this.lnGroupBox.Size = new System.Drawing.Size(892, 618);
            this.lnGroupBox.TabIndex = 9;
            this.lnGroupBox.TabStop = false;
            this.lnGroupBox.Text = "Leistungsnachweis Data";
            // 
            // progressLabel
            // 
            this.progressLabel.AutoSize = true;
            this.progressLabel.Location = new System.Drawing.Point(10, 552);
            this.progressLabel.Name = "progressLabel";
            this.progressLabel.Size = new System.Drawing.Size(105, 20);
            this.progressLabel.TabIndex = 21;
            this.progressLabel.Text = "Progress Label";
            this.progressLabel.Visible = false;
            // 
            // mainProgressBar
            // 
            this.mainProgressBar.Location = new System.Drawing.Point(10, 575);
            this.mainProgressBar.Name = "mainProgressBar";
            this.mainProgressBar.Size = new System.Drawing.Size(654, 29);
            this.mainProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.mainProgressBar.TabIndex = 0;
            this.mainProgressBar.UseWaitCursor = true;
            this.mainProgressBar.Visible = false;
            // 
            // lesitungsnachweisOutputDirButton
            // 
            this.lesitungsnachweisOutputDirButton.Location = new System.Drawing.Point(855, 160);
            this.lesitungsnachweisOutputDirButton.Name = "lesitungsnachweisOutputDirButton";
            this.lesitungsnachweisOutputDirButton.Size = new System.Drawing.Size(26, 29);
            this.lesitungsnachweisOutputDirButton.TabIndex = 20;
            this.lesitungsnachweisOutputDirButton.Text = "...";
            this.lesitungsnachweisOutputDirButton.UseVisualStyleBackColor = true;
            this.lesitungsnachweisOutputDirButton.Click += new System.EventHandler(this.lesitungsnachweisOutputDirButton_Click);
            // 
            // leistungsnachweisOutputDirTextBox
            // 
            this.leistungsnachweisOutputDirTextBox.Location = new System.Drawing.Point(261, 160);
            this.leistungsnachweisOutputDirTextBox.Name = "leistungsnachweisOutputDirTextBox";
            this.leistungsnachweisOutputDirTextBox.Size = new System.Drawing.Size(589, 27);
            this.leistungsnachweisOutputDirTextBox.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Leistungsnachweis Output Directory";
            // 
            // employeeSelectionListBox
            // 
            this.employeeSelectionListBox.FormattingEnabled = true;
            this.employeeSelectionListBox.ItemHeight = 20;
            this.employeeSelectionListBox.Location = new System.Drawing.Point(261, 206);
            this.employeeSelectionListBox.Name = "employeeSelectionListBox";
            this.employeeSelectionListBox.Size = new System.Drawing.Size(621, 324);
            this.employeeSelectionListBox.TabIndex = 14;
            this.employeeSelectionListBox.SelectedIndexChanged += new System.EventHandler(this.employeeSelectionListBox_SelectedIndexChanged);
            // 
            // employeeSelectLabel
            // 
            this.employeeSelectLabel.AutoSize = true;
            this.employeeSelectLabel.Location = new System.Drawing.Point(115, 206);
            this.employeeSelectLabel.Name = "employeeSelectLabel";
            this.employeeSelectLabel.Size = new System.Drawing.Size(140, 20);
            this.employeeSelectLabel.TabIndex = 13;
            this.employeeSelectLabel.Text = "Employee Selection";
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(670, 575);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(212, 29);
            this.generateButton.TabIndex = 12;
            this.generateButton.Text = "Generate Leistungsnachweis";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // availabilityTrackerFileButton
            // 
            this.availabilityTrackerFileButton.Location = new System.Drawing.Point(856, 24);
            this.availabilityTrackerFileButton.Name = "availabilityTrackerFileButton";
            this.availabilityTrackerFileButton.Size = new System.Drawing.Size(26, 29);
            this.availabilityTrackerFileButton.TabIndex = 11;
            this.availabilityTrackerFileButton.Text = "...";
            this.availabilityTrackerFileButton.UseVisualStyleBackColor = true;
            this.availabilityTrackerFileButton.Click += new System.EventHandler(this.availabilityTrackerFileButton_Click);
            // 
            // availabilityTrackerFileTextBox
            // 
            this.availabilityTrackerFileTextBox.Location = new System.Drawing.Point(261, 26);
            this.availabilityTrackerFileTextBox.Name = "availabilityTrackerFileTextBox";
            this.availabilityTrackerFileTextBox.Size = new System.Drawing.Size(589, 27);
            this.availabilityTrackerFileTextBox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Availability Tracker Path";
            // 
            // projectPONumberTextBox
            // 
            this.projectPONumberTextBox.Location = new System.Drawing.Point(261, 60);
            this.projectPONumberTextBox.Name = "projectPONumberTextBox";
            this.projectPONumberTextBox.Size = new System.Drawing.Size(621, 27);
            this.projectPONumberTextBox.TabIndex = 1;
            // 
            // yearComboBox
            // 
            this.yearComboBox.FormattingEnabled = true;
            this.yearComboBox.Location = new System.Drawing.Point(261, 126);
            this.yearComboBox.Name = "yearComboBox";
            this.yearComboBox.Size = new System.Drawing.Size(621, 28);
            this.yearComboBox.TabIndex = 8;
            // 
            // projectPONumLabel
            // 
            this.projectPONumLabel.AutoSize = true;
            this.projectPONumLabel.Location = new System.Drawing.Point(168, 63);
            this.projectPONumLabel.Name = "projectPONumLabel";
            this.projectPONumLabel.Size = new System.Drawing.Size(87, 20);
            this.projectPONumLabel.TabIndex = 0;
            this.projectPONumLabel.Text = "Project PO#";
            // 
            // monthComboBox
            // 
            this.monthComboBox.FormattingEnabled = true;
            this.monthComboBox.Location = new System.Drawing.Point(261, 93);
            this.monthComboBox.Name = "monthComboBox";
            this.monthComboBox.Size = new System.Drawing.Size(621, 28);
            this.monthComboBox.TabIndex = 7;
            // 
            // monthLabel
            // 
            this.monthLabel.AutoSize = true;
            this.monthLabel.Location = new System.Drawing.Point(203, 96);
            this.monthLabel.Name = "monthLabel";
            this.monthLabel.Size = new System.Drawing.Size(52, 20);
            this.monthLabel.TabIndex = 3;
            this.monthLabel.Text = "Month";
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(218, 129);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(37, 20);
            this.yearLabel.TabIndex = 4;
            this.yearLabel.Text = "Year";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1224, 593);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 657);
            this.Controls.Add(this.mainTabControl);
            this.Name = "MainForm";
            this.Text = "Leistungsnachweis Generator";
            this.mainTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.lnGroupBox.ResumeLayout(false);
            this.lnGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl mainTabControl;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox projectPONumberTextBox;
        private Label projectPONumLabel;
        private ComboBox yearComboBox;
        private ComboBox monthComboBox;
        private Label yearLabel;
        private Label monthLabel;
        private GroupBox lnGroupBox;
        private SplitContainer splitContainer1;
        private Label label1;
        private Button availabilityTrackerFileButton;
        private TextBox availabilityTrackerFileTextBox;
        private ListBox employeeSelectionListBox;
        private Label employeeSelectLabel;
        private Button generateButton;
        private Button lesitungsnachweisOutputDirButton;
        private TextBox leistungsnachweisOutputDirTextBox;
        private Label label3;
        private ProgressBar mainProgressBar;
        private System.ComponentModel.BackgroundWorker mainBackgroundWorker;
        private Label progressLabel;
        private System.ComponentModel.BackgroundWorker generateBackgroundWorker;
    }
}