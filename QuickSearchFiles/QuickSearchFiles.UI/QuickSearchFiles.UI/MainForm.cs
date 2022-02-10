using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickSearchFiles.UI
{
    /// <summary>
    /// Main form of the interface
    /// </summary>
    public partial class MainForm : Form
    {
        FileSearcher fileSearcher = new FileSearcher();

        FileType fileType = FileType.Unknown;

        /// <summary>
        /// Initalizer
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string fileContent = new WebClient().DownloadString(@"https://github.com/scottdf93/QuickSearchFiles/blob/master/Version");

            if (fileSearcher != null)
            {
                if (this.ValidateData())
                {
                    SearchingPictureBox.Show();

                    Application.DoEvents();

                    ResultListView.ClearObjects();

                    Thread thread = new Thread(this.Search);
                    thread.Start();
                }
            }
        }

        private void Search()
        {
            fileSearcher.OnSearchCompleted += FileSearcher_OnSearchCompleted;

            SearchOptions searchOptions = new SearchOptions()
            {
                FileType = fileType,
                IgnoreCase = this.IgnoreCase.Checked,
                MatchWholeWord = this.MatchWholeWord.Checked
            };

            SearchParameters searchParameters = new SearchParameters()
            {
                DirectoryToSearchIn = this.SearchDirectory.Text,
                StringToSearchFor = this.SearchForTextBox.Text
            };

            fileSearcher.Search(new SearchObject()
            {
                SearchOptions = searchOptions,
                SearchParameters = searchParameters
            });
        }

        private bool ValidateData()
        {
            if (string.IsNullOrEmpty(this.SearchDirectory.Text))
            {
                MessageBox.Show("I don't know where im searching! Select a folder using the browse (...) button!", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(this.SearchForTextBox.Text))
            {
                MessageBox.Show("I don't what im searching for! Enter any text in the Search for text box", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (fileType == FileType.Unknown)
            {
                MessageBox.Show("I don't what file type im searching! Select a file type!", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void FileSearcher_OnSearchCompleted(object sender, EventArgs e)
        {
            fileSearcher.OnSearchCompleted -= FileSearcher_OnSearchCompleted;

            SearchCompletedEventArgs searchCompletedEventArgs = (SearchCompletedEventArgs)e;

            if (searchCompletedEventArgs.SearchResults != null && searchCompletedEventArgs.SearchResults.Count > 0)
            {
                ResultListView.Invoke(new Action(() =>
                {
                    ResultListView.ClearObjects();
                    ResultListView.AddObjects(searchCompletedEventArgs.SearchResults);
                }));


                SearchingPictureBox.Invoke(new Action(() => { this.SearchingPictureBox.Hide(); }));
            }

            TotalHitsLabel.Invoke(new Action(() => { this.TotalHitsLabel.Text = "Total hits: " + ResultListView.GetItemCount(); }));
        }

        private void BrowseDirectory_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog()
            {
                ShowNewFolderButton = true
            };

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                this.SearchDirectory.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void ResultListView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenu contextMenu = new ContextMenu();
                MenuItem menuItem = new MenuItem("Open file");
                menuItem.Click += MenuItem_Click;
                contextMenu.MenuItems.Add(menuItem);

                contextMenu.Show(this, new Point(Cursor.Position.X, Cursor.Position.Y));
            }
        }

        private void MenuItem_Click(object sender, EventArgs e)
        {
            if (ResultListView.SelectedObject != null)
            {
                SearchResults searchResults = (SearchResults)ResultListView.SelectedObject;

                if (File.Exists(searchResults.File))
                {
                    Process.Start(searchResults.File);
                }
            }
        }

        private void IgnoreCase_CheckedChanged(object sender, EventArgs e)
        {
            if (!IgnoreCase.Checked)
            {
                MessageBox.Show("I highly suggest you leave this checked to avoid missing data!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void SearchExcelFiles_CheckedChanged(object sender, EventArgs e)
        {
            fileType = FileType.Excel;
        }

        private void WordRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            fileType = FileType.Word;
        }

        private void TextFileRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            fileType = FileType.GenericTextFile;
        }

        private void AllFilesRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            fileType = FileType.All;
        }
    }
}