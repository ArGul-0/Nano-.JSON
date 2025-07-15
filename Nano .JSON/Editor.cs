namespace Nano_.JSON
{
    public partial class Editor : Form
    {
        private Storage storage;

        private string JSONFilePath = null;
        public Editor(bool isOpen = false, string JSONFilePath = null)
        {
            InitializeComponent();
            storage = new Storage();

            this.JSONFilePath = JSONFilePath;

            // Setting up a text field for editing .JSON files.
            textBoxJSONData.Multiline = true;
            textBoxJSONData.ScrollBars = ScrollBars.Vertical;
            textBoxJSONData.WordWrap = false;
            textBoxJSONData.AcceptsTab = true;
            textBoxJSONData.AcceptsReturn = true;

            textBoxJSONData.HandleCreated += (s, e) =>
            {
                ScrollBarHider.HideVertical(textBoxJSONData);

                // the wheel will end up in the textbox
                textBoxJSONData.MouseEnter += (s2, e2) =>
                    textBoxJSONData.Focus();
            };


            if (isOpen)
            {
                textBoxJSONData.Text = File.ReadAllText(JSONFilePath);
            }
        }

        //ToolStrip menu items
        private void fileNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartForm.Instance.newJSONFile_Click(sender, e);
            this.Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartForm.Instance.OpenJSONFile_Click(sender, e);
            //NEED ADD CORRECTED CLOSE
            this.Close();
        }

        private void fileSaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists(JSONFilePath))
            {
                File.WriteAllText(JSONFilePath, textBoxJSONData.Text);
            }
            else
            {
                fileSaveAsToolStripMenuItem_Click(this, e);
            }
        }

        private void fileSaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*",
                Title = "Save JSON File",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                JSONFilePath = saveFileDialog.FileName;
                File.WriteAllText(JSONFilePath, textBoxJSONData.Text);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void Editor_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (File.ReadAllText(JSONFilePath) != textBoxJSONData.Text)
                {
                    if (textBoxJSONData.Text.Length > 0)
                    {

                        DialogResult result = MessageBox.Show("Do you want to save changes?", "Confirm",
                            MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            fileSaveToolStripMenuItem_Click(sender, e);
                        }
                        else if (result == DialogResult.Cancel)
                        {
                            e.Cancel = true;
                            return;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                if (textBoxJSONData.Text.Length > 0)
                {

                    DialogResult result = MessageBox.Show("Do you want to save changes?", "Confirm",
                        MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        fileSaveToolStripMenuItem_Click(sender, e);
                    }
                    else if (result == DialogResult.Cancel)
                    {
                        e.Cancel = true;
                        return;
                    }
                }
            }
            if (File.Exists(JSONFilePath))
            {
                storage.SaveRecentFile(new List<string> { JSONFilePath });
            }

            if (Editor.CheckForIllegalCrossThreadCalls)
            {
                return;
            }

            Application.Exit();
        }
    }
}
