using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSearchFiles
{
	/// <summary>
	/// Event arguments for the completed search call back
	/// </summary>
	public class SearchCompletedEventArgs : EventArgs
	{
		/// <summary>
		/// A list of found results
		/// </summary>
		public List<SearchResults> SearchResults;
	}
}
