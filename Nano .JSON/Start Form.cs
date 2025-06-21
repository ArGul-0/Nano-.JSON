namespace Nano_.JSON
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void newJSONFile_Click(object sender, EventArgs e)
        {
            Form editor = new Editor();
            editor.Show();
            this.Hide();
        }

        private void openJSONFile_Click(object sender, EventArgs e)
        {
            
        }
    }
}
