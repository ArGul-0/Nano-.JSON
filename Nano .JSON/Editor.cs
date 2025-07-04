﻿namespace Nano_.JSON
{
    public partial class Editor : Form
    {
        private Storage storage;
        public Editor(bool isOpen = false, string JSONFilePath = null)
        {
            InitializeComponent();
            storage = new Storage();

            // Setting up a text field for editing .JSON files.
            textBoxJSONData.Multiline = true;
            textBoxJSONData.ScrollBars = ScrollBars.Vertical;
            textBoxJSONData.WordWrap = false;
            textBoxJSONData.AcceptsTab = true;
            textBoxJSONData.AcceptsReturn = true;

            textBoxJSONData.HandleCreated += (s, e) =>
            {
                ScrollBarHider.HideVertical(textBoxJSONData);

                // колёсико попадёт в текстбокс
                textBoxJSONData.MouseEnter += (s2, e2) =>
                    textBoxJSONData.Focus();
            };


            if (isOpen)
            {
                textBoxJSONData.Text = File.ReadAllText(JSONFilePath);
                // Save the recent file path in storage
            }
        }

        private void Editor_FormClosing(object sender, FormClosingEventArgs e)
        {
            // здесь можно показать диалог, а если нужно отменить закрытие:
            // e.Cancel = true;

            // а если всё ок — выходим
            Application.Exit();
        }
    }
}
