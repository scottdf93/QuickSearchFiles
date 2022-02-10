using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSearchFiles
{
    /// <summary>
    /// Class containing the options to be used during a search
    /// </summary>
    public class SearchOptions
    {
        /// <summary>
        /// Ignore the case when search
        /// </summary>
        public bool IgnoreCase;

        /// <summary>
        /// Mathc the whole word when searching
        /// </summary>
        public bool MatchWholeWord;

        /// <summary>
        /// The file type to search
        /// </summary>
        public FileType FileType;
    }
}
