using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Topical_Memory_System
{

	public class Verse
	{
		private string book;
		private int chapter;
		private string verseNumbers;	//can be multiple verses
		private string packLetter;
		private int packNumber;
		private string verseData;

		public Verse(string book, int chapter, string verseNumbers, string packLetter, int packNumber, string verseData)
		{
			this.book = book;
			this.chapter = chapter;
			this.verseNumbers = verseNumbers;
			this.packLetter = packLetter;
			this.packNumber = packNumber;
			this.verseData = verseData;
		}

		public override int GetHashCode()
		{
			return Convert.ToInt32(book) * chapter * Convert.ToInt32(verseNumbers);
		}

		public override bool Equals(object obj)
		{
			return this.GetHashCode() == ((Verse)obj).GetHashCode();
		}

		public override string ToString()
		{
			return book + Convert.ToString(chapter) + verseNumbers;
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
