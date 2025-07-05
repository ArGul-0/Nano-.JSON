namespace Nano_.JSON
{
    public partial class StartForm : Form
    {
        private Storage storage;
        public StartForm()
        {
            InitializeComponent();
            storage = new Storage();
            LoadRecentFiles();
        }

        private void newJSONFile_Click(object sender, EventArgs e)
        {
            Form editor = new Editor();
            editor.Show();
            this.Hide();
        }

        private void openJSONFile_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog
                {
                    Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*",
                    Title = "Open JSON File",
                    InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
                };
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    Form editor = new Editor(true, filePath);
                    editor.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading the .JSON file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadRecentFiles()
        {
            List<string> lastFiles = storage.LoadRecentFiles();

            if (lastFiles != null && lastFiles.Count > 0)
            {
                if (lastFiles.Count > 0)
                {
                    RecentFile1.Visible = true;
                    RecentFile1.Text = lastFiles[0];
                }
                if (lastFiles.Count > 1)
                {
                    RecentFile2.Visible = true;
                    RecentFile2.Text = lastFiles[1];
                }
                if (lastFiles.Count > 2)
                {
                    RecentFile3.Visible = true;
                    RecentFile3.Text = lastFiles[2];
                }
            }
        }
    }
}
