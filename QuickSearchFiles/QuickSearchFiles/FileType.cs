using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSearchFiles
{
	/// <summary>
	/// Enumeration to determine the file type being searched.
	/// </summary>
	public enum FileType
	{
		/// <summary>
		/// The file type is unknown
		/// </summary>
		Unknown,

		/// <summary>
		/// The file type is that of a excel
		/// </summary>
		Excel,

		/// <summary>
		/// The file type is that of word
		/// </summary>
		Word,

		/// <summary>
		/// A generic text file (.txt, .csv etc)
		/// </summary>
		GenericTextFile,

		/// <summary>
		/// Search all implemented file types
		/// </summary>
		All
	}
}
