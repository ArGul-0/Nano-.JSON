namespace Nano_.JSON
{
    partial class StartForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            recentFilesText = new Label();
            newJSONFile = new Button();
            openJSONFile = new Button();
            RecentFile1 = new Button();
            RecentFile2 = new Button();
            RecentFile3 = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(recentFilesText, 2, 0);
            tableLayoutPanel1.Controls.Add(newJSONFile, 1, 1);
            tableLayoutPanel1.Controls.Add(openJSONFile, 1, 2);
            tableLayoutPanel1.Controls.Add(RecentFile1, 2, 1);
            tableLayoutPanel1.Controls.Add(RecentFile2, 2, 2);
            tableLayoutPanel1.Controls.Add(RecentFile3, 2, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(484, 461);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // recentFilesText
            // 
            recentFilesText.Anchor = AnchorStyles.Right;
            recentFilesText.AutoSize = true;
            recentFilesText.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            recentFilesText.ForeColor = Color.Gray;
            recentFilesText.Location = new Point(339, 20);
            recentFilesText.Margin = new Padding(0, 20, 25, 0);
            recentFilesText.Name = "recentFilesText";
            recentFilesText.Size = new Size(120, 30);
            recentFilesText.TabIndex = 2;
            recentFilesText.Text = "Recent files";
            // 
            // newJSONFile
            // 
            newJSONFile.Anchor = AnchorStyles.Top;
            newJSONFile.BackColor = Color.FromArgb(65, 65, 65);
            newJSONFile.FlatAppearance.BorderColor = Color.FromArgb(70, 70, 70);
            newJSONFile.FlatStyle = FlatStyle.Flat;
            newJSONFile.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            newJSONFile.ForeColor = Color.WhiteSmoke;
            newJSONFile.Location = new Point(181, 70);
            newJSONFile.Margin = new Padding(20);
            newJSONFile.Name = "newJSONFile";
            newJSONFile.Size = new Size(121, 75);
            newJSONFile.TabIndex = 0;
            newJSONFile.Text = "New .JSON file";
            newJSONFile.UseVisualStyleBackColor = false;
            newJSONFile.Click += newJSONFile_Click;
            // 
            // openJSONFile
            // 
            openJSONFile.Anchor = AnchorStyles.Top;
            openJSONFile.BackColor = Color.FromArgb(65, 65, 65);
            openJSONFile.FlatAppearance.BorderColor = Color.FromArgb(70, 70, 70);
            openJSONFile.FlatStyle = FlatStyle.Flat;
            openJSONFile.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            openJSONFile.ForeColor = Color.WhiteSmoke;
            openJSONFile.Location = new Point(181, 185);
            openJSONFile.Margin = new Padding(20);
            openJSONFile.Name = "openJSONFile";
            openJSONFile.Size = new Size(121, 75);
            openJSONFile.TabIndex = 1;
            openJSONFile.Text = "Open .JSON file";
            openJSONFile.UseVisualStyleBackColor = false;
            openJSONFile.Click += openJSONFile_Click;
            // 
            // RecentFile1
            // 
            RecentFile1.BackColor = Color.FromArgb(55, 55, 55);
            RecentFile1.FlatAppearance.BorderColor = Color.FromArgb(70, 70, 70);
            RecentFile1.FlatStyle = FlatStyle.Flat;
            RecentFile1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            RecentFile1.ForeColor = Color.WhiteSmoke;
            RecentFile1.Location = new Point(342, 70);
            RecentFile1.Margin = new Padding(20);
            RecentFile1.Name = "RecentFile1";
            RecentFile1.Size = new Size(121, 75);
            RecentFile1.TabIndex = 3;
            RecentFile1.Text = "Open ";
            RecentFile1.UseVisualStyleBackColor = false;
            RecentFile1.Visible = false;
            // 
            // RecentFile2
            // 
            RecentFile2.BackColor = Color.FromArgb(55, 55, 55);
            RecentFile2.FlatAppearance.BorderColor = Color.FromArgb(70, 70, 70);
            RecentFile2.FlatStyle = FlatStyle.Flat;
            RecentFile2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            RecentFile2.ForeColor = Color.WhiteSmoke;
            RecentFile2.Location = new Point(342, 185);
            RecentFile2.Margin = new Padding(20);
            RecentFile2.Name = "RecentFile2";
            RecentFile2.Size = new Size(121, 75);
            RecentFile2.TabIndex = 4;
            RecentFile2.Text = "Open ";
            RecentFile2.UseVisualStyleBackColor = false;
            RecentFile2.Visible = false;
            // 
            // RecentFile3
            // 
            RecentFile3.BackColor = Color.FromArgb(55, 55, 55);
            RecentFile3.FlatAppearance.BorderColor = Color.FromArgb(70, 70, 70);
            RecentFile3.FlatStyle = FlatStyle.Flat;
            RecentFile3.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            RecentFile3.ForeColor = Color.WhiteSmoke;
            RecentFile3.Location = new Point(342, 300);
            RecentFile3.Margin = new Padding(20);
            RecentFile3.Name = "RecentFile3";
            RecentFile3.Size = new Size(121, 75);
            RecentFile3.TabIndex = 5;
            RecentFile3.Text = "Open ";
            RecentFile3.UseVisualStyleBackColor = false;
            RecentFile3.Visible = false;
            // 
            // StartForm
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 50, 50);
            ClientSize = new Size(484, 461);
            Controls.Add(tableLayoutPanel1);
            Name = "StartForm";
            Text = "Nano .JSON";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private Label recentFilesText;
        private Button newJSONFile;
        private Button openJSONFile;
        private Button RecentFile1;
        private Button RecentFile2;
        private Button RecentFile3;
    }
}
