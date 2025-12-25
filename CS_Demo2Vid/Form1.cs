using CS_Demo2Vid.Model;
using CS_Demo2Vid.Services;

namespace CS_Demo2Vid
{
    public partial class Form1 : Form
    {
        private DemoExportData? _demoData;
        private Dictionary<string, (string KillerName, List<(int RoundNumber, int KillCount)>)>? _multikillData;
        private readonly JsonDemoLoader _loader = new JsonDemoLoader();
        private readonly MultiKillAnalyzer _analyzer = new MultiKillAnalyzer();
        private readonly CsdmCommandBuilder _commandBuilder = new CsdmCommandBuilder();

        public Form1()
        {
            InitializeComponent();
        }

        private void startAnalyze()
        {
            try
            {
                string path = textBox1.Text;
                _demoData = _loader.LoadDemoData(path);
                _multikillData = _analyzer.GetDetailedMultikillInfo(_demoData);

                if (_multikillData.Count == 0)
                {
                    MessageBox.Show("No multikill data found.");
                    return;
                }

                var players = _multikillData.Select(p =>
                    new PlayerInfo
                    {
                        KillerSteamId = p.Key,
                        KillerName = p.Value.KillerName
                    }).ToList();

                comboBox1.DataSource = players;
                comboBox1.DisplayMember = "DisplayName";
                comboBox1.ValueMember = "KillerSteamId";

                //MessageBox.Show("Demo loaded successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading demo: {ex.Message}");
            }
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            if (_multikillData == null || _demoData == null)
                return;

            if (comboBox1.SelectedValue is string selectedSteamId && _multikillData.ContainsKey(selectedSteamId))
            {
                foreach (var (round, kills) in _multikillData[selectedSteamId].Item2)
                {
                    listBox1.Items.Add($"Round {round} — {kills} kills");
                }
            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (_demoData == null || comboBox1.SelectedValue is not string steamId)
                return;

            if (listBox1.SelectedItem == null)
                return;

            string selectedText = listBox1.SelectedItem.ToString() ?? "";
            if (!selectedText.StartsWith("Round ")) return;

            int roundNumber = int.Parse(selectedText.Split(' ')[1]);

            string command = _commandBuilder.BuildCommand(_demoData.DemoFilePath, checkOutPathExist(), steamId, roundNumber);
            _commandBuilder.RunCsdmCommand(command);

            MessageBox.Show($"Using CS Demo Manager CLI - " +
                            $"Executing:\n{command}");
        }

        private string checkOutPathExist()
        {
            string basePath = textBox2.Text;

            string gameName = _demoData.DemoName;

            string steamId = comboBox1.SelectedValue.ToString();

            string selectedText = listBox1.SelectedItem.ToString() ?? "";

            int roundNumber = int.Parse(selectedText.Split(' ')[1]);

            string combinedPath = Path.Join(basePath, gameName, steamId, roundNumber.ToString());
            if (!Directory.Exists(combinedPath))
            {
                Directory.CreateDirectory(combinedPath);
            }
            return combinedPath;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Select file";
            dialog.InitialDirectory = ".\\";
            dialog.Filter = "JSON files (*.json)|*.json";
            
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var extension = Path.GetExtension(dialog.FileName);
                if (extension.Equals(".json"))
                {
                    textBox1.Text = dialog.FileName;
                    startAnalyze();
                }
                else
                {
                    MessageBox.Show("Invalid file type");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var folderBrowserDialog1 = new FolderBrowserDialog();
            DialogResult result = folderBrowserDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                string folderName = folderBrowserDialog1.SelectedPath;
                textBox2.Text = folderName;
            }
        }
    }
}
