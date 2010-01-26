using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Topical_Memory_System
{
	static class Constants
	{
        public static string Tab = "\t";
        public static int MinimumAllowedForMatching = 12;
        public static int MaximumCharactersForCustomGroupName = 20;
        public static string FileDelimiter = "/";
		public static string NewLine = "\r\n";
		public static string DatabaseConnectionString = "data source=" +
			Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\TMS\\" + "CustomVerses.db;";

		public static string Version = "4.5.0";
	}
}
