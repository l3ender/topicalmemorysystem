using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Topical_Memory_System
{
	static class Constants
	{
		public static string TmsTopicsFileLocation = "tmsTopics.txt";
        public static string NivFileLocation = "tmsVerses-NIV.txt";
        public static string EsvFileLocation = "tmsVerses-ESV.txt";
		public static string NbvFileLocation = "tmsVerses-NBV.txt";
        public static string TAB = "\t";
        public static string[] CustomVerseLocations = {"customVerses1.txt", "customVerses2.txt", "customVerses3.txt",
                                                      "customVerses4.txt", "customVerses5.txt"};
        public static int MinimumAllowedForMatching = 12;
        public static int MaximumCharactersForCustomGroupName = 20;
        public static string FileDelimiter = "/";
		public static string[] VerseTopics = {"A - Live The New Life", "B - Proclaim Christ", "C - Rely On God's Resources",
                                                      "D - Be Christ's Disciple", "E - Grow In Christlikeness"};
	}
}
