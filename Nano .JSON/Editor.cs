using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nano_.JSON
{
    public partial class Editor : Form
    {
        public Editor(bool isOpen = false, string JSONFilePath = null)
        {
            InitializeComponent();

            if (isOpen)
            {
                textBoxJSONData.Text = File.ReadAllText(JSONFilePath);
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
