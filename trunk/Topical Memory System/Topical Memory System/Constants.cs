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
		public static string Version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString().Trim();

		public static List<string> BooksOfTheBible()
		{
			List<string> books = new List<string>(66);
			books.Add("Genesis");
			books.Add("Exodus");
			books.Add("Leviticus");
			books.Add("Numbers");
			books.Add("Deuteronomy");
			books.Add("Joshua");
			books.Add("Judges");
			books.Add("Ruth");
			books.Add("1 Samuel");
			books.Add("2 Samuel");
			books.Add("1 Kings");
			books.Add("2 Kings");
			books.Add("1 Chronicles");
			books.Add("2 Chronicles");
			books.Add("Ezra");
			books.Add("Nehemiah");
			books.Add("Esther");
			books.Add("Job");
			books.Add("Psalm");
			books.Add("Proverbs");
			books.Add("Ecclesiastes");
			books.Add("Song of Solomon");
			books.Add("Isaiah");
			books.Add("Jeremiah");
			books.Add("Lamentations");
			books.Add("Ezekiel");
			books.Add("Daniel");
			books.Add("Hosea");
			books.Add("Joel");
			books.Add("Amos");
			books.Add("Obadiah");
			books.Add("Jonah");
			books.Add("Micah");
			books.Add("Nahum");
			books.Add("Habakkuk");
			books.Add("Zephaniah");
			books.Add("Haggai");
			books.Add("Zechariah");
			books.Add("Malachi");
			books.Add("Matthew");
			books.Add("Mark");
			books.Add("Luke");
			books.Add("John");
			books.Add("Acts");
			books.Add("Romans");
			books.Add("1 Corinthians");
			books.Add("2 Corinthians");
			books.Add("Galatians");
			books.Add("Ephesians");
			books.Add("Philippians");
			books.Add("Colossians");
			books.Add("1 Thessalonians");
			books.Add("2 Thessalonians");
			books.Add("1 Timothy");
			books.Add("2 Timothy");
			books.Add("Titus");
			books.Add("Philemon");
			books.Add("Hebrews");
			books.Add("James");
			books.Add("1 Peter");
			books.Add("2 Peter");
			books.Add("1 John");
			books.Add("2 John");
			books.Add("3 John");
			books.Add("Jude");
			books.Add("Revelation");
			return books;
		}

		public static List<string> DutchBooksOfTheBible()
		{
			List<string> books = new List<string>(66);
			books.Add("Genesis");
			books.Add("Exodus");
			books.Add("Leviticus");
			books.Add("Numeri");
			books.Add("Deuteronomium");
			books.Add("Jozua");
			books.Add("Rechters");
			books.Add("Ruth");
			books.Add("1 Samuel");
			books.Add("2 Samuel");
			books.Add("1 Koningen");
			books.Add("2 Koningen");
			books.Add("1 Kronieken");
			books.Add("2 Kronieken");
			books.Add("Ezra");
			books.Add("Nehemia");
			books.Add("Ester");
			books.Add("Job");
			books.Add("Psalmen");
			books.Add("Spreuken");
			books.Add("Prediker");
			books.Add("Hooglied");
			books.Add("Jesaja");
			books.Add("Jeremia");
			books.Add("Klaagliederen");
			books.Add("Ezechiel");
			books.Add("Daniel");
			books.Add("Hosea");
			books.Add("Joel");
			books.Add("Amos");
			books.Add("Obadja");
			books.Add("Jona");
			books.Add("Micha");
			books.Add("Nahum");
			books.Add("Habakuk");
			books.Add("Sefanja");
			books.Add("Haggai");
			books.Add("Zacharia");
			books.Add("Maleachi");
			books.Add("Matteus");
			books.Add("Marcus");
			books.Add("Lucas");
			books.Add("Johannes");
			books.Add("Handelingen");
			books.Add("Romeinen");
			books.Add("1 Korintiers");
			books.Add("2 Korintiers");
			books.Add("Galaten");
			books.Add("Efeziers");
			books.Add("Filippenzen");
			books.Add("Kolossenzen");
			books.Add("1 Tessalonicenzen");
			books.Add("2 Tessalonicenzen");
			books.Add("1 Timoteus");
			books.Add("2 Timoteus");
			books.Add("Titus");
			books.Add("Filemon");
			books.Add("Hebreeen");
			books.Add("Jakobus");
			books.Add("1 Petrus");
			books.Add("2 Petrus");
			books.Add("1 Johannes");
			books.Add("2 Johannes");
			books.Add("3 Johannes");
			books.Add("Judas");
			books.Add("Openbaring");
			return books;
		}
	}
}
