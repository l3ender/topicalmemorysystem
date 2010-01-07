using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Topical_Memory_System
{
	class ComparedString
	{
		public List<Selection> Selections;
		public string FinalString;

		public ComparedString(List<Selection> Selections, string FinalString)
		{
			this.Selections = Selections;
			this.FinalString = FinalString;
		}
	}
}
