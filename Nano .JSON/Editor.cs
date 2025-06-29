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
    }
}
