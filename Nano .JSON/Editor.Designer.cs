﻿namespace Nano_.JSON
{
    partial class Editor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editor));
            tableLayoutJSONData = new TableLayoutPanel();
            textBoxJSONData = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            fileNewToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            fileSaveToolStripMenuItem = new ToolStripMenuItem();
            fileSaveAsToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            tableLayoutJSONData.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutJSONData
            // 
            tableLayoutJSONData.ColumnCount = 1;
            tableLayoutJSONData.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutJSONData.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutJSONData.Controls.Add(textBoxJSONData, 1, 0);
            tableLayoutJSONData.Dock = DockStyle.Right;
            tableLayoutJSONData.Location = new Point(284, 0);
            tableLayoutJSONData.Margin = new Padding(0);
            tableLayoutJSONData.Name = "tableLayoutJSONData";
            tableLayoutJSONData.RowCount = 1;
            tableLayoutJSONData.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutJSONData.Size = new Size(500, 461);
            tableLayoutJSONData.TabIndex = 0;
            // 
            // textBoxJSONData
            // 
            textBoxJSONData.AcceptsTab = true;
            textBoxJSONData.BackColor = Color.FromArgb(65, 65, 65);
            textBoxJSONData.BorderStyle = BorderStyle.FixedSingle;
            textBoxJSONData.Cursor = Cursors.IBeam;
            textBoxJSONData.Dock = DockStyle.Fill;
            textBoxJSONData.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            textBoxJSONData.ForeColor = Color.WhiteSmoke;
            textBoxJSONData.Location = new Point(10, 10);
            textBoxJSONData.Margin = new Padding(10);
            textBoxJSONData.Multiline = true;
            textBoxJSONData.Name = "textBoxJSONData";
            textBoxJSONData.ScrollBars = ScrollBars.Vertical;
            textBoxJSONData.Size = new Size(480, 441);
            textBoxJSONData.TabIndex = 1;
            textBoxJSONData.WordWrap = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(menuStrip1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Left;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 92F));
            tableLayoutPanel1.Size = new Size(280, 461);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(65, 65, 65);
            menuStrip1.Font = new Font("Segoe UI Symbol", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.GripMargin = new Padding(2);
            menuStrip1.GripStyle = ToolStripGripStyle.Visible;
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(5, 10);
            menuStrip1.Margin = new Padding(5, 10, 0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(275, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fileNewToolStripMenuItem, openToolStripMenuItem, fileSaveToolStripMenuItem, fileSaveAsToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.ForeColor = Color.WhiteSmoke;
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // fileNewToolStripMenuItem
            // 
            fileNewToolStripMenuItem.Name = "fileNewToolStripMenuItem";
            fileNewToolStripMenuItem.Size = new Size(205, 22);
            fileNewToolStripMenuItem.Text = "New (Ctrl + N)";
            fileNewToolStripMenuItem.Click += fileNewToolStripMenuItem_Click;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(205, 22);
            openToolStripMenuItem.Text = "Open (Ctrl + O)";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // fileSaveToolStripMenuItem
            // 
            fileSaveToolStripMenuItem.Name = "fileSaveToolStripMenuItem";
            fileSaveToolStripMenuItem.Size = new Size(205, 22);
            fileSaveToolStripMenuItem.Text = "Save (Ctrl + S)";
            fileSaveToolStripMenuItem.Click += fileSaveToolStripMenuItem_Click;
            // 
            // fileSaveAsToolStripMenuItem
            // 
            fileSaveAsToolStripMenuItem.Name = "fileSaveAsToolStripMenuItem";
            fileSaveAsToolStripMenuItem.Size = new Size(205, 22);
            fileSaveAsToolStripMenuItem.Text = "Save as... (Ctrl + Shift + S)";
            fileSaveAsToolStripMenuItem.Click += fileSaveAsToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(205, 22);
            exitToolStripMenuItem.Text = "Exit (Alt + F4)";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.ForeColor = Color.WhiteSmoke;
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(96, 20);
            helpToolStripMenuItem.Text = "Help (Ctrl + F1)";
            helpToolStripMenuItem.Click += helpToolStripMenuItem_Click;
            // 
            // Editor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 50, 50);
            ClientSize = new Size(784, 461);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(tableLayoutJSONData);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            MainMenuStrip = menuStrip1;
            Name = "Editor";
            Text = ".JSON Editor";
            FormClosing += Editor_FormClosing;
            KeyDown += Editor_KeyDown;
            tableLayoutJSONData.ResumeLayout(false);
            tableLayoutJSONData.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutJSONData;
        private TextBox textBoxJSONData;
        private TableLayoutPanel tableLayoutPanel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem fileNewToolStripMenuItem;
        private ToolStripMenuItem fileSaveToolStripMenuItem;
        private ToolStripMenuItem fileSaveAsToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
    }
}