using System;
using System.Collections.Generic;

namespace Topical_Memory_System
{
	public class VersePack
	{
		public string Name;
		public List<Verse> Verses;

		public VersePack()
		{
			Verses = new List<Verse>();
		}

		public void SetName(string Name)
		{
			this.Name = Name;
		}

		public void AddVerse(Verse v)
		{
			Verses.Add(v);
		}
	}
}
