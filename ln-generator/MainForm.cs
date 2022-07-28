namespace ln_generator
{
    public partial class MainForm : Form
    {
        private Config config = Config.getInstance();

        public MainForm()
        {
            InitializeComponent();
            Console.WriteLine("test");
#if DEBUG
            leistungsnachweisOutputDirTextBox.Text = "C:\\Users\\k.ryakhovskiy\\Desktop\\LNTest";
#endif
        }

        private void toggleControls(bool enabled)
        {
            foreach (Control c in this.Controls)
                c.Enabled = enabled;
            mainProgressBar.Visible = !enabled;
            progressLabel.Visible = !enabled;
            mainBackgroundWorker.WorkerReportsProgress = !enabled;
            generateBackgroundWorker.WorkerReportsProgress = !enabled;
        }

        private void loadComponents()
        {
            String fileName = availabilityTrackerFileTextBox.Text;
            
            if (String.IsNullOrEmpty(fileName))
            {
                MessageBox.Show("Availability Tracker file name is empty.", "No availability tracker found",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            mainBackgroundWorker.ReportProgress(0, "Reading file: " + fileName);
            if (!File.Exists(fileName))
            {
                MessageBox.Show("Availability Tracker file not found on path: " + fileName, "No availability tracker found",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            config.Init(fileName, mainBackgroundWorker);
        }

        private void initControlsFromConfig()
        {
            projectPONumberTextBox.Text = config.PONumber;
            yearComboBox.Items.Clear();
            yearComboBox.SelectedIndex = yearComboBox.Items.Add(config.Year);

            List<MonthConfig> months = config.GetMonthConfigs();
            monthComboBox.Items.Clear();
            foreach (MonthConfig mc in months)
            {
                monthComboBox.Items.Add(mc.Month);
            }
            monthComboBox.SelectedIndex = monthComboBox.Items.Add("All");

            employeeSelectionListBox.Items.Clear();
            foreach (string e in config.GetEmployeesConfig().Keys)
            {
                employeeSelectionListBox.Items.Add(e);
            }
            employeeSelectionListBox.SelectionMode = SelectionMode.MultiExtended;
            employeeSelectionListBox.SelectedIndex = employeeSelectionListBox.Items.Add("All");
        }

        private void availabilityTrackerFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            DialogResult dResult = ofd.ShowDialog();

            if (DialogResult.OK == dResult)
            {
                availabilityTrackerFileTextBox.Text = ofd.FileName;
            }
            
            toggleControls(false);
            mainProgressBar.Style = ProgressBarStyle.Marquee;
            mainBackgroundWorker.RunWorkerAsync();
        }

        private void doAvailabilityTrackerLoad()
        {
            loadComponents();
        }

        private void employeeSelectionListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            string outputDir = leistungsnachweisOutputDirTextBox.Text;
            if (string.IsNullOrEmpty(outputDir))
            {
                DialogResult dr = MessageBox.Show("Output Directory is not specified. Do you want to generate Leistungsnachweis to the current working directory", "Warning",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr != DialogResult.Yes) return;
                outputDir = Directory.GetCurrentDirectory();
            }

            int year = (int)yearComboBox.SelectedItem;
            string selectedMonth = monthComboBox.SelectedItem.ToString();
            List<string> months = new List<string>();
            if (selectedMonth.ToLower().Equals("all"))
            {
                foreach (var monthVar in monthComboBox.Items) {
                    string month = monthVar.ToString();
                    if (month.Equals("All")) continue;
                    months.Add(month);
                }
            } else
            {
                months.Add(selectedMonth);
            }

            List<string> employees = new List<string>();
            foreach (var employeeVar in employeeSelectionListBox.SelectedItems)
            {
                employees.Add(employeeVar.ToString());
            }
            if (employees.Contains("All"))
            {
                employees.Clear();
                config.GetEmployeesConfig().Keys.ToList<string>().ForEach(e => employees.Add(e));
            }
            toggleControls(false);
            mainProgressBar.Style = ProgressBarStyle.Continuous;
            mainProgressBar.Maximum = 100;
            Generator generator = new Generator(generateBackgroundWorker, year, months, employees, config, outputDir);
            generateBackgroundWorker.RunWorkerAsync(generator);
        }

        private void lesitungsnachweisOutputDirButton_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    leistungsnachweisOutputDirTextBox.Text = fbd.SelectedPath;
                }
            }
        }

        private void mainBackgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            doAvailabilityTrackerLoad();
        }

        private void mainBackgroundWorker_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            if (null == e.UserState) return;
            progressLabel.Text = e.UserState.ToString();
        }

        private void mainBackgroundWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            initControlsFromConfig();
            toggleControls(true);
            MessageBox.Show("Availability Tracker Data has been successfully loaded", 
                "Availability Tracker Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void generateBackgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            Generator g = e.Argument as Generator;
            if (null == g) return;
            g.generate();
        }

        private void generateBackgroundWorker_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            if (null == e.UserState) return;
            progressLabel.Text = e.UserState.ToString();
            mainProgressBar.Value = e.ProgressPercentage;
        }

        private void generateBackgroundWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            toggleControls(true);
            MessageBox.Show("Leistungsnachweis Generated Successfully",
                 "Leistungsnachweis", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}