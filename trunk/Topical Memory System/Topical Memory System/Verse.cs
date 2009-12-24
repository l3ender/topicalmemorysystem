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
		private string nivVerseData;
		private string esvVerseData;
		private int translation;	//0 == niv, 1 == esv

		public Verse(string book, int chapter, string verseNumbers, string packLetter, int packNumber, string nivVerseData)
		{
			this.translation = 0;
			this.book = book;
			this.chapter = chapter;
			this.verseNumbers = verseNumbers;
			this.packLetter = packLetter;
			this.packNumber = packNumber;
			this.nivVerseData = nivVerseData;
		}

		public override int GetHashCode()
		{
			return book.GetHashCode() * chapter.GetHashCode() * verseNumbers.GetHashCode();
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
		public string getTranslation()
		{
			if (translation == 1)
			{
				return "ESV";
			}
			else
			{
				return "NIV";
			}
		}
		public void setTranslation(int translation)
		{
			this.translation = translation;
		}
		public string getVerseData()
		{
			if (translation == 1)
			{
				return getEsvVerseData();
			} else
			{
				return getNivVerseData();
			}
		}
		public string getNivVerseData()
		{
			return nivVerseData;
		}
		public void setEsvVerseData(string esvVerseData)
		{
			this.esvVerseData = esvVerseData;
		}
		public string getEsvVerseData()
		{
			return esvVerseData;
		}
	}


}
