using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Topical_Memory_System
{

	class Verse
	{
		private static string book;
		private static int chapter;
		private static string verseNumbers;	//can be multiple verses
		private static string packLetter;
		private static int packNumber;
		private static string verseData;

		public Verse(string book, int chapter, string verseNumbers, string packLetter, int packNumber, string verseData)
		{
			Verse.book = book;
			Verse.chapter = chapter;
			Verse.verseNumbers = verseNumbers;
			Verse.packLetter = packLetter;
			Verse.packNumber = packNumber;
			Verse.verseData = verseData;
		}

		public string getBook()
		{
			return book;
		}
		public int getChapter()
		{
			return chapter;
		}
		public string getVerseNumbers()
		{
			return verseNumbers;
		}
		public string getReference()
		{
			return getBook() + " " + getChapter().ToString() + ":" + getVerseNumbers().ToString();
		}
		public string getPackLetter()
		{
			return packLetter;
		}
		public int getPackNumber()
		{
			return packNumber;
		}
		public string getVerseData()
		{
			return verseData;
		}
	}


}
