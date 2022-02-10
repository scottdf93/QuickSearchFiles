using OfficeOpenXml;
using Spire.Xls;
using Spire.Doc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickSearchFiles
{
    /// <summary>
    /// Recursivley searchs files in a directory for specific text
    /// </summary>
    public class FileSearcher
    {
        /// <summary>
        /// Event handler for the search completed
        /// </summary>
        public event EventHandler OnSearchCompleted;

        /// <summary>
        /// A list of the search results
        /// </summary>
        public List<SearchResults> results = new List<SearchResults>();

        /// <summary>
        /// Initiates the search
        /// </summary>
        /// <param name="searchOptions"></param>
        public void Search(SearchObject searchOptions)
        {
            results = new List<SearchResults>();

            if (searchOptions.SearchOptions.FileType == FileType.Excel || searchOptions.SearchOptions.FileType == FileType.All)
            {
                SearchExcel(searchOptions);
            }

            if (searchOptions.SearchOptions.FileType == FileType.Word || searchOptions.SearchOptions.FileType == FileType.All)
            {
                SearchWord(searchOptions);
            }

            if (searchOptions.SearchOptions.FileType == FileType.GenericTextFile || searchOptions.SearchOptions.FileType == FileType.All)
            {
                SearchGenericText(searchOptions);
            }

            this.OnSearchCompleted?.Invoke(this, new SearchCompletedEventArgs() { SearchResults = results });
        }

        private void SearchExcel(SearchObject searchOptions)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            string[] extensions = new[] { ".xls", ".xlsx" };

            string[] files = Directory.GetFiles(searchOptions.SearchParameters.DirectoryToSearchIn).Where(file => extensions.Contains(Path.GetExtension(file))).ToArray();

            string[] wordsToFind = searchOptions.SearchParameters.StringToSearchFor.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string file in files)
            {
                if (Path.GetExtension(file) == ".xlsx")
                {
                    using (ExcelPackage package = new ExcelPackage(file))
                    {
                        for (int i = 0; i < package.Workbook.Worksheets.Count; i++)
                        {
                            int colCount = package.Workbook.Worksheets[i].Dimension.End.Column;
                            int rowCount = package.Workbook.Worksheets[i].Dimension.End.Row;

                            for (int row = 1; row < rowCount + 1; row++)
                            {
                                bool[] foundWords = new bool[wordsToFind.Length];

                                for (int word = 0; word < wordsToFind.Length; word++)
                                {
                                    for (int col = 1; col < colCount + 1; col++)
                                    {
                                        if (package.Workbook.Worksheets[i].Cells[row, col].Value != null)
                                        {
                                            if (!searchOptions.SearchOptions.MatchWholeWord && !searchOptions.SearchOptions.IgnoreCase)
                                            {
                                                if (package.Workbook.Worksheets[i].Cells[row, col].Value.ToString().Contains(wordsToFind[word]))
                                                {
                                                    foundWords[word] = true;
                                                }
                                            }
                                            else if (!searchOptions.SearchOptions.MatchWholeWord && searchOptions.SearchOptions.IgnoreCase)
                                            {
                                                if (package.Workbook.Worksheets[i].Cells[row, col].Value.ToString().ToLower().Contains(wordsToFind[word].ToLower()))
                                                {
                                                    foundWords[word] = true;
                                                }
                                            }
                                            else if (searchOptions.SearchOptions.MatchWholeWord && !searchOptions.SearchOptions.IgnoreCase)
                                            {
                                                if (package.Workbook.Worksheets[i].Cells[row, col].Value.ToString() == wordsToFind[word])
                                                {
                                                    foundWords[word] = true;
                                                }
                                            }
                                            else if (searchOptions.SearchOptions.MatchWholeWord && searchOptions.SearchOptions.IgnoreCase)
                                            {
                                                if (package.Workbook.Worksheets[i].Cells[row, col].Value.ToString().ToLower() == wordsToFind[word].ToLower())
                                                {
                                                    foundWords[word] = true;
                                                }
                                            }
                                        }
                                    }
                                }

                                if (foundWords.All(x => x == true))
                                {
                                    results.Add(new SearchResults()
                                    {
                                        Row = row,
                                        File = file
                                    });
                                }
                            }
                        }
                    }
                }
                else if (Path.GetExtension(file) == ".xls")
                {
                    Workbook workbook = new Workbook();
                    workbook.LoadFromFile(file);

                    for (int i = 0; i < workbook.Worksheets.Count; i++)
                    {
                        for (int row = 1; row < workbook.Worksheets[i].Rows.Length+1; row++)
                        {
                            bool[] foundWords = new bool[wordsToFind.Length];

                            for (int word = 0; word < wordsToFind.Length; word++)
                            {
                                for (int col = 1; col < workbook.Worksheets[i].Columns.Length+1; col++)
                                {
                                    if (workbook.Worksheets[i].Range[row,col].Value != null)
                                    {
                                        if (!searchOptions.SearchOptions.MatchWholeWord && !searchOptions.SearchOptions.IgnoreCase)
                                        {
                                            if (workbook.Worksheets[i].Range[row, col].Value.ToString().Contains(wordsToFind[word]))
                                            {
                                                foundWords[word] = true;
                                            }
                                        }
                                        else if (!searchOptions.SearchOptions.MatchWholeWord && searchOptions.SearchOptions.IgnoreCase)
                                        {
                                            if (workbook.Worksheets[i].Range[row, col].Value.ToString().ToLower().Contains(wordsToFind[word].ToLower()))
                                            {
                                                foundWords[word] = true;
                                            }
                                        }
                                        else if (searchOptions.SearchOptions.MatchWholeWord && !searchOptions.SearchOptions.IgnoreCase)
                                        {
                                            if (workbook.Worksheets[i].Range[row, col].Value.ToString() == wordsToFind[word])
                                            {
                                                foundWords[word] = true;
                                            }
                                        }
                                        else if (searchOptions.SearchOptions.MatchWholeWord && searchOptions.SearchOptions.IgnoreCase)
                                        {
                                            if (workbook.Worksheets[i].Range[row, col].Value.ToString().ToLower() == wordsToFind[word].ToLower())
                                            {
                                                foundWords[word] = true;
                                            }
                                        }
                                    }
                                }
                            }

                            if (foundWords.All(x => x == true))
                            {
                                results.Add(new SearchResults()
                                {
                                    Row = row,
                                    File = file
                                });
                            }
                        }
                    }
                }
            }
        }

        private void SearchWord(SearchObject searchOptions)
        {
            throw new NotImplementedException("This function has not yet been implemented");
        }

        private void SearchGenericText(SearchObject searchOptions)
        {
            throw new NotImplementedException("This function has not yet been implemented");
        }
    }
}