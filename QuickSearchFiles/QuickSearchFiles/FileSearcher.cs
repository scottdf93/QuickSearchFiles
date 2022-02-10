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
using Spire.Doc.Documents;
using Spire.Pdf;
using Spire.Doc.Fields;

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

            string[] extensions = new[] { ".xls", ".xlsx", ".xlsm" };

            string[] files = Directory.GetFiles(searchOptions.SearchParameters.DirectoryToSearchIn).Where(file => extensions.Contains(Path.GetExtension(file))).ToArray();

            string[] wordsToFind = searchOptions.SearchParameters.StringToSearchFor.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string file in files)
            {
                Workbook workbook = new Workbook();
                workbook.LoadFromFile(file);

                for (int i = 0; i < workbook.Worksheets.Count; i++)
                {
                    for (int row = 1; row < workbook.Worksheets[i].Rows.Length + 1; row++)
                    {
                        bool[] foundWords = new bool[wordsToFind.Length];

                        for (int word = 0; word < wordsToFind.Length; word++)
                        {
                            for (int col = 1; col < workbook.Worksheets[i].Columns.Length + 1; col++)
                            {
                                if (workbook.Worksheets[i].Range[row, col].Value != null)
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
                                Row = row.ToString(),
                                File = file
                            });
                        }
                    }
                }

            }
        }

        private void SearchWord(SearchObject searchOptions)
        {
            string[] extensions = new[] { ".doc", ".docx" };

            string[] files = Directory.GetFiles(searchOptions.SearchParameters.DirectoryToSearchIn).Where(file => extensions.Contains(Path.GetExtension(file))).ToArray();

            string[] wordsToFind = searchOptions.SearchParameters.StringToSearchFor.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string file in files)
            {
                Document document = new Document();
                document.LoadFromFile(file);

                bool[] foundWords = new bool[wordsToFind.Length];

                for (int word = 0; word < wordsToFind.Length; word++)
                {
                    TextSelection[] text = document.FindAllString(wordsToFind[word], searchOptions.SearchOptions.IgnoreCase, searchOptions.SearchOptions.MatchWholeWord);

                    foreach (TextSelection selection in text)
                    {
                        results.Add(new SearchResults()
                        {
                            Row = "Text found but could not find location",
                            File = file
                        });
                    }
                }
            }
        }

        private void SearchGenericText(SearchObject searchOptions)
        {
            string[] extensions = new[] { ".txt", ".csv" };

            string[] files = Directory.GetFiles(searchOptions.SearchParameters.DirectoryToSearchIn).Where(file => extensions.Contains(Path.GetExtension(file))).ToArray();

            string[] wordsToFind = searchOptions.SearchParameters.StringToSearchFor.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string file in files)
            {
                bool[] foundWords = new bool[wordsToFind.Length];

                for (int word = 0; word < wordsToFind.Length; word++)
                {
                    string[] fileLines = File.ReadAllLines(file);

                    for (int line = 0; line < fileLines.Count(); line++)
                    {
                        if (!searchOptions.SearchOptions.MatchWholeWord && !searchOptions.SearchOptions.IgnoreCase)
                        {
                            if (fileLines[line].Contains(wordsToFind[word]))
                            {
                                foundWords[word] = true;
                            }
                        }
                        else if (!searchOptions.SearchOptions.MatchWholeWord && searchOptions.SearchOptions.IgnoreCase)
                        {
                            if (fileLines[line].ToLower().Contains(wordsToFind[word].ToLower()))
                            {
                                foundWords[word] = true;
                            }
                        }
                        else if (searchOptions.SearchOptions.MatchWholeWord && !searchOptions.SearchOptions.IgnoreCase)
                        {
                            if (fileLines[line].ToString() == wordsToFind[word])
                            {
                                foundWords[word] = true;
                            }
                        }
                        else if (searchOptions.SearchOptions.MatchWholeWord && searchOptions.SearchOptions.IgnoreCase)
                        {
                            if (fileLines[line].ToLower() == wordsToFind[word].ToLower())
                            {
                                foundWords[word] = true;
                            }
                        }
                    }
                }

                if (foundWords.All(x => x == true))
                {
                    results.Add(new SearchResults()
                    {
                        Row = line.ToString(),
                        File = file
                    });
                }
            }
        }
    }
}