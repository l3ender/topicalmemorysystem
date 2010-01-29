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
	}
}
