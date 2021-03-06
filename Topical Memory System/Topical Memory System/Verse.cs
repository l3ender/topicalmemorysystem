﻿using System;
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
        private string packInformation; //like "A-1" or "Meditation Verses"
		private string tmsMainTopic;		//like "Live The New Life"
		private string tmsSubTopic;			//like "Christ the Center"
		private string nivVerseData;
		private string esvVerseData;
		private string nbvVerseData;
		private string nbvBook;
		private string nkjvVerseData;
		private string translation;     //ESV, NIV, etc
        private bool isTMSVerse;        //only TMS verses have pack numbers, etc

		public Verse(string book, int chapter, string verseNumbers, string packInformation, string tmsMainTopic, string tmsSubTopic,
			string nivVerseData, string esvVerseData, string nbvBook, string nbvVerseData, string nkjvVerseData, bool isTMS)
		{
			this.translation = "NIV";
			this.book = book;
			this.chapter = chapter;
			this.verseNumbers = verseNumbers;
            this.packInformation = packInformation;
			this.tmsMainTopic = tmsMainTopic;
			this.tmsSubTopic = tmsSubTopic;
			this.nivVerseData = nivVerseData;
			this.esvVerseData = esvVerseData;
			this.nbvBook = nbvBook;
			this.nbvVerseData = nbvVerseData;
			this.nkjvVerseData = nkjvVerseData;
            this.isTMSVerse = isTMS;
		}

		public override int GetHashCode()
		{
			return book.GetHashCode() * chapter.GetHashCode() * verseNumbers.GetHashCode();
		}

		public override string ToString()
		{
			return getReference();
		}

		public string getBook()
		{
			if (translation.Equals("NBV") && isTMSVerse)
			{
				return nbvBook;
			}
			else
			{
				return book;
			}
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
			if (translation.Equals("NBV") && isTMSVerse)
			{
				return nbvBook + " " + getChapter().ToString() + ":" + getVerseNumbers().ToString();
			}
			else
			{
				return getBook() + " " + getChapter().ToString() + ":" + getVerseNumbers().ToString();
			}
		}
		public string getPackInformation()
		{
            return packInformation;
		}
		public string getTmsMainTopic()
		{
			return tmsMainTopic;
		}
		public string getTmsSubTopic()
		{
			return tmsSubTopic;
		}
		public string getTranslation()
		{
            return translation;
		}
		public void setTranslation(string translation)
		{
			this.translation = translation;
		}
		public string getVerseData()
		{
            if (isTMSVerse)
            {
                if (translation.Equals("ESV"))
                {
                    return getEsvVerseData();
                }
				else if (translation.Equals("NBV"))
				{
					return getNbvVerseData();
				}
				else if (translation.Equals("NKJV"))
				{
					return getNkjvVerseData();
				}
				else
				{
					return getNivVerseData();
				}
            }
            else
            {
                return getNivVerseData();
            }
		}
		public string getNivVerseData()
		{
			return nivVerseData;
		}
		public string getEsvVerseData()
		{
			return esvVerseData;
		}
		public string getNbvVerseData()
		{
			return nbvVerseData;
		}
		public string getNbvBook()
		{
			return nbvBook;
		}
		public string getNkjvVerseData()
		{
			return nkjvVerseData;
		}
        public bool isTmsVerse()
        {
            return isTMSVerse;
        }
	}
}
