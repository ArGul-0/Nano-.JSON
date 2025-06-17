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
            recentFilesText = new Label();
            openJSONFile = new Button();
            newJSONFile = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // recentFilesText
            // 
            recentFilesText.Anchor = AnchorStyles.Right;
            recentFilesText.AutoSize = true;
            recentFilesText.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            recentFilesText.ForeColor = Color.Silver;
            recentFilesText.Location = new Point(339, 20);
            recentFilesText.Margin = new Padding(0, 20, 25, 0);
            recentFilesText.Name = "recentFilesText";
            recentFilesText.Size = new Size(120, 30);
            recentFilesText.TabIndex = 2;
            recentFilesText.Text = "Recent files";
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
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(recentFilesText, 2, 0);
            tableLayoutPanel1.Controls.Add(newJSONFile, 1, 1);
            tableLayoutPanel1.Controls.Add(openJSONFile, 1, 5);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(484, 461);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // StartForm
            // 
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

        private Label recentFilesText;
        private Button openJSONFile;
        private Button newJSONFile;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
