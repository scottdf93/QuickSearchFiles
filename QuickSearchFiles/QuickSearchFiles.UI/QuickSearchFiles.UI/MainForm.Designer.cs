
namespace QuickSearchFiles.UI
{
	partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AllFilesRadioButton = new System.Windows.Forms.RadioButton();
            this.TextFileRadioButton = new System.Windows.Forms.RadioButton();
            this.WordRadioButton = new System.Windows.Forms.RadioButton();
            this.SearchExcelFiles = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.IgnoreCase = new System.Windows.Forms.CheckBox();
            this.MatchWholeWord = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.TotalHitsLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BrowseDirectory = new System.Windows.Forms.Button();
            this.SearchDirectory = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SearchForTextBox = new System.Windows.Forms.TextBox();
            this.SearchingPictureBox = new System.Windows.Forms.PictureBox();
            this.ResultListView = new BrightIdeasSoftware.FastObjectListView();
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchingPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultListView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AllFilesRadioButton);
            this.groupBox1.Controls.Add(this.TextFileRadioButton);
            this.groupBox1.Controls.Add(this.WordRadioButton);
            this.groupBox1.Controls.Add(this.SearchExcelFiles);
            this.groupBox1.Location = new System.Drawing.Point(18, 113);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(165, 147);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File type";
            // 
            // AllFilesRadioButton
            // 
            this.AllFilesRadioButton.AutoSize = true;
            this.AllFilesRadioButton.Location = new System.Drawing.Point(8, 117);
            this.AllFilesRadioButton.Name = "AllFilesRadioButton";
            this.AllFilesRadioButton.Size = new System.Drawing.Size(44, 24);
            this.AllFilesRadioButton.TabIndex = 4;
            this.AllFilesRadioButton.Text = "All";
            this.AllFilesRadioButton.UseVisualStyleBackColor = true;
            this.AllFilesRadioButton.CheckedChanged += new System.EventHandler(this.AllFilesRadioButton_CheckedChanged);
            // 
            // TextFileRadioButton
            // 
            this.TextFileRadioButton.AutoSize = true;
            this.TextFileRadioButton.Location = new System.Drawing.Point(8, 87);
            this.TextFileRadioButton.Name = "TextFileRadioButton";
            this.TextFileRadioButton.Size = new System.Drawing.Size(148, 24);
            this.TextFileRadioButton.TabIndex = 3;
            this.TextFileRadioButton.Text = "Text file (txt | csv)";
            this.TextFileRadioButton.UseVisualStyleBackColor = true;
            this.TextFileRadioButton.CheckedChanged += new System.EventHandler(this.TextFileRadioButton_CheckedChanged);
            // 
            // WordRadioButton
            // 
            this.WordRadioButton.AutoSize = true;
            this.WordRadioButton.Location = new System.Drawing.Point(8, 57);
            this.WordRadioButton.Name = "WordRadioButton";
            this.WordRadioButton.Size = new System.Drawing.Size(65, 24);
            this.WordRadioButton.TabIndex = 2;
            this.WordRadioButton.Text = "Word";
            this.WordRadioButton.UseVisualStyleBackColor = true;
            this.WordRadioButton.CheckedChanged += new System.EventHandler(this.WordRadioButton_CheckedChanged);
            // 
            // SearchExcelFiles
            // 
            this.SearchExcelFiles.AutoSize = true;
            this.SearchExcelFiles.Location = new System.Drawing.Point(8, 27);
            this.SearchExcelFiles.Name = "SearchExcelFiles";
            this.SearchExcelFiles.Size = new System.Drawing.Size(65, 24);
            this.SearchExcelFiles.TabIndex = 0;
            this.SearchExcelFiles.Text = "Excel";
            this.SearchExcelFiles.UseVisualStyleBackColor = true;
            this.SearchExcelFiles.CheckedChanged += new System.EventHandler(this.SearchExcelFiles_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SearchButton);
            this.groupBox2.Location = new System.Drawing.Point(18, 14);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(165, 89);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // SearchButton
            // 
            this.SearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchButton.Location = new System.Drawing.Point(8, 29);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(149, 35);
            this.SearchButton.TabIndex = 0;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.IgnoreCase);
            this.groupBox3.Controls.Add(this.MatchWholeWord);
            this.groupBox3.Location = new System.Drawing.Point(18, 270);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(165, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Options";
            // 
            // IgnoreCase
            // 
            this.IgnoreCase.AutoSize = true;
            this.IgnoreCase.Location = new System.Drawing.Point(8, 57);
            this.IgnoreCase.Name = "IgnoreCase";
            this.IgnoreCase.Size = new System.Drawing.Size(112, 24);
            this.IgnoreCase.TabIndex = 1;
            this.IgnoreCase.Text = "Ignore case";
            this.IgnoreCase.UseVisualStyleBackColor = true;
            this.IgnoreCase.CheckedChanged += new System.EventHandler(this.IgnoreCase_CheckedChanged);
            // 
            // MatchWholeWord
            // 
            this.MatchWholeWord.AutoSize = true;
            this.MatchWholeWord.Location = new System.Drawing.Point(8, 27);
            this.MatchWholeWord.Name = "MatchWholeWord";
            this.MatchWholeWord.Size = new System.Drawing.Size(155, 24);
            this.MatchWholeWord.TabIndex = 0;
            this.MatchWholeWord.Text = "Match whole word";
            this.MatchWholeWord.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search for";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.TotalHitsLabel);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.BrowseDirectory);
            this.groupBox4.Controls.Add(this.SearchDirectory);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.SearchForTextBox);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.SearchingPictureBox);
            this.groupBox4.Controls.Add(this.ResultListView);
            this.groupBox4.Location = new System.Drawing.Point(191, 14);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Size = new System.Drawing.Size(1137, 600);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            // 
            // TotalHitsLabel
            // 
            this.TotalHitsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalHitsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalHitsLabel.Location = new System.Drawing.Point(1029, 112);
            this.TotalHitsLabel.Name = "TotalHitsLabel";
            this.TotalHitsLabel.Size = new System.Drawing.Size(101, 20);
            this.TotalHitsLabel.TabIndex = 39;
            this.TotalHitsLabel.Text = "Total hits: ";
            this.TotalHitsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Results";
            // 
            // BrowseDirectory
            // 
            this.BrowseDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BrowseDirectory.Location = new System.Drawing.Point(1077, 71);
            this.BrowseDirectory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BrowseDirectory.Name = "BrowseDirectory";
            this.BrowseDirectory.Size = new System.Drawing.Size(53, 26);
            this.BrowseDirectory.TabIndex = 1;
            this.BrowseDirectory.Text = "...";
            this.BrowseDirectory.UseVisualStyleBackColor = true;
            this.BrowseDirectory.Click += new System.EventHandler(this.BrowseDirectory_Click);
            // 
            // SearchDirectory
            // 
            this.SearchDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchDirectory.Location = new System.Drawing.Point(96, 71);
            this.SearchDirectory.Name = "SearchDirectory";
            this.SearchDirectory.ReadOnly = true;
            this.SearchDirectory.Size = new System.Drawing.Size(974, 26);
            this.SearchDirectory.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Search in";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(784, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(346, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Use a comma (,) to delimit multiple words to search on the same row/line";
            // 
            // SearchForTextBox
            // 
            this.SearchForTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchForTextBox.Location = new System.Drawing.Point(96, 21);
            this.SearchForTextBox.Name = "SearchForTextBox";
            this.SearchForTextBox.Size = new System.Drawing.Size(1034, 26);
            this.SearchForTextBox.TabIndex = 4;
            // 
            // SearchingPictureBox
            // 
            this.SearchingPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchingPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("SearchingPictureBox.Image")));
            this.SearchingPictureBox.Location = new System.Drawing.Point(14, 138);
            this.SearchingPictureBox.Name = "SearchingPictureBox";
            this.SearchingPictureBox.Size = new System.Drawing.Size(1114, 452);
            this.SearchingPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SearchingPictureBox.TabIndex = 40;
            this.SearchingPictureBox.TabStop = false;
            this.SearchingPictureBox.Visible = false;
            // 
            // ResultListView
            // 
            this.ResultListView.AllColumns.Add(this.olvColumn1);
            this.ResultListView.AllColumns.Add(this.olvColumn2);
            this.ResultListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultListView.CellEditUseWholeCell = false;
            this.ResultListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn1,
            this.olvColumn2});
            this.ResultListView.Cursor = System.Windows.Forms.Cursors.Default;
            this.ResultListView.FullRowSelect = true;
            this.ResultListView.HideSelection = false;
            this.ResultListView.Location = new System.Drawing.Point(11, 135);
            this.ResultListView.MultiSelect = false;
            this.ResultListView.Name = "ResultListView";
            this.ResultListView.ShowGroups = false;
            this.ResultListView.Size = new System.Drawing.Size(1119, 457);
            this.ResultListView.TabIndex = 8;
            this.ResultListView.UseAlternatingBackColors = true;
            this.ResultListView.UseCompatibleStateImageBehavior = false;
            this.ResultListView.UseExplorerTheme = true;
            this.ResultListView.UseFilterIndicator = true;
            this.ResultListView.UseFiltering = true;
            this.ResultListView.View = System.Windows.Forms.View.Details;
            this.ResultListView.VirtualMode = true;
            this.ResultListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ResultListView_MouseClick);
            // 
            // olvColumn1
            // 
            this.olvColumn1.AspectName = "Row";
            this.olvColumn1.Text = "Row/Line number";
            this.olvColumn1.Width = 146;
            // 
            // olvColumn2
            // 
            this.olvColumn2.AspectName = "File";
            this.olvColumn2.Text = "File";
            this.olvColumn2.Width = 961;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1341, 628);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File searcher";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchingPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultListView)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button SearchButton;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.CheckBox IgnoreCase;
		private System.Windows.Forms.CheckBox MatchWholeWord;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Button BrowseDirectory;
		private System.Windows.Forms.TextBox SearchDirectory;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox SearchForTextBox;
		private System.Windows.Forms.Label label4;
		private BrightIdeasSoftware.FastObjectListView ResultListView;
		private BrightIdeasSoftware.OLVColumn olvColumn1;
		private BrightIdeasSoftware.OLVColumn olvColumn2;
		private System.Windows.Forms.Label TotalHitsLabel;
        private System.Windows.Forms.RadioButton TextFileRadioButton;
        private System.Windows.Forms.RadioButton WordRadioButton;
        private System.Windows.Forms.RadioButton SearchExcelFiles;
        private System.Windows.Forms.RadioButton AllFilesRadioButton;
        private System.Windows.Forms.PictureBox SearchingPictureBox;
    }
}

