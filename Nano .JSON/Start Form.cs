using System.Windows.Forms;

namespace Nano_.JSON
{
    public partial class StartForm : Form
    {
        public static StartForm Instance { get; private set; }
        public static string Version = "1.0";

        private Storage storage;
        public StartForm()
        {
            InitializeComponent();
            Instance = this;

            storage = new Storage();
            LoadRecentFiles();

            programVersion.Text = $"Version: {Version}";
        }

        public void newJSONFile_Click(object sender, EventArgs e)
        {
            Form editor = new Editor();
            editor.Show();
            this.Hide();
        }

        public void OpenJSONFile_Click(object sender, EventArgs e)
        {
            try
            {
                // OpenFileDialog to select a JSON file
                OpenFileDialog openFileDialog = new OpenFileDialog
                {
                    Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*",
                    Title = "Open JSON File",
                    InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
                };
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;

                    SaveFilePatchToRecentFiles(filePath);

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
        private void OpenRecentJSONFile(string filePath)
        {
            try
            {
                SaveFilePatchToRecentFiles(filePath);

                Form editor = new Editor(true, filePath);
                editor.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error open the .JSON file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void SaveFilePatchToRecentFiles(string filePath)
        {
            List<string> recentFiles = storage.LoadRecentFiles() ?? new List<string>();
            if (!recentFiles.Contains(filePath))
            {
                recentFiles.Insert(0, filePath); // Add the new file to the top of the list
            }
            else
            {
                uint index = (uint)recentFiles.IndexOf(filePath);
                recentFiles.RemoveAt((int)index);
                recentFiles.Insert(0, filePath); // Move the file to the top of the list
            }

            storage.SaveRecentFile(recentFiles);
        }
        private void LoadRecentFiles()
        {
            List<string> lastFiles = storage.LoadRecentFiles();

            if (lastFiles == null || lastFiles.Count == 0)
            {
                RecentFile1.Visible = false;
                RecentFile2.Visible = false;
                RecentFile3.Visible = false;
                return;
            }
            else if (lastFiles.Count > 3)
            {
                lastFiles.RemoveAt(3); // Limit to 3 recent files
            }

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

        private void RecentFile1_Click(object sender, EventArgs e)
        {
            OpenRecentJSONFile(RecentFile1.Text);
        }

        private void RecentFile2_Click(object sender, EventArgs e)
        {
            OpenRecentJSONFile(RecentFile2.Text);
        }

        private void RecentFile3_Click(object sender, EventArgs e)
        {
            OpenRecentJSONFile(RecentFile3.Text);
        }



        private void StartForm_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void StartForm_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                if (files.Length > 0)
                {
                    string filePath = files[0];
                    if (Path.GetExtension(filePath).Equals(".json", StringComparison.OrdinalIgnoreCase))
                    {
                        SaveFilePatchToRecentFiles(filePath);
                        Form editor = new Editor(true, filePath);
                        editor.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Please drop a valid .JSON file.", "Invalid File", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
    }
}
