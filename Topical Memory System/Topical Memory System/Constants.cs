using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Topical_Memory_System
{
	static class Constants
	{
        public static string TAB = "\t";
        public static string[] CustomVerseLocations = {"customVerses1.txt", "customVerses2.txt", "customVerses3.txt",
                                                      "customVerses4.txt", "customVerses5.txt"};
        public static int MinimumAllowedForMatching = 12;
        public static int MaximumCharactersForCustomGroupName = 20;
        public static string FileDelimiter = "/";
		public static string DatabaseConnectionString = "data source=" +
			Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\TMS\\" + "CustomVerses.db;";

		public static string Version = "4.1.0";
	}
}
